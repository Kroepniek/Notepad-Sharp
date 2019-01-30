using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace NotepadSharp
{
	public partial class frmMainDmon : Form
	{
		Color currentColorDmon = Color.FromArgb(46, 46, 46);
		bool isTextSelectedDmon = false;
		public static List<Tuple<string, int, int, int>> specialTextsDmon = new List<Tuple<string, int, int, int>>();

		public static List<Tuple<string, Color, bool>> defaultSpecialTexts = new List<Tuple<string, Color, bool>>();
		static string[] varNamesDmon = new string[] { "var", "string", "int", "bool", "long", "unsigned", "signed", "decimal", "double", "float", "new" };

		frmAddSpecialTextDmon frmAddSpecialTextDmon = new frmAddSpecialTextDmon();
		frmShowSpecialTextDmon frmShowSpecialTextDmon = new frmShowSpecialTextDmon();
		frmSearchDmon frmSearchDmon = new frmSearchDmon();

		static RichTextBox rtbCurrentDmon = new RichTextBox();

		public frmMainDmon()
		{
			InitializeComponent();
			pcbCheckDmon.Parent = pnlColorNoneDmon;
			mnsMenuDmon.Renderer = new Arrow();
			defaultSpecialTexts.Add(new Tuple<string, Color, bool>("digits", Color.Crimson, true));
			defaultSpecialTexts.Add(new Tuple<string, Color, bool>("variables", Color.RoyalBlue, true));
			LoadSpecialText();
			rtbMainNotepadDmon.MouseWheel += new MouseEventHandler(Scroll_Move);
			rtbCurrentDmon = rtbMainNotepadDmon;
		}

		public class RootObject
		{
			public string Item1 { get; set; }
			public int Item2 { get; set; }
			public int Item3 { get; set; }
			public int Item4 { get; set; }
		}

		#region MenuStrip Rendering

		public class BrowserColors : ProfessionalColorTable
		{
			public override Color MenuItemSelected
			{
				get { return Color.FromArgb(32, 32, 32); }
			}
			public override Color MenuItemBorder
			{
				get { return Color.FromArgb(23, 23, 23); }
			}
			public override Color MenuBorder
			{
				get { return Color.FromArgb(23, 23, 23); }
			}
			public override Color ToolStripDropDownBackground
			{
				get { return Color.FromArgb(23, 23, 23); }
			}
			public override Color MenuItemPressedGradientBegin
			{
				get { return Color.FromArgb(32, 32, 32); }
			}
			public override Color MenuItemPressedGradientEnd
			{
				get { return Color.FromArgb(32, 32, 32); }
			}
			public override Color CheckSelectedBackground
			{
				get { return Color.FromArgb(32, 32, 32); }
			}
			public override Color MenuItemSelectedGradientBegin
			{
				get { return Color.FromArgb(23, 23, 23); }
			}
			public override Color MenuItemSelectedGradientEnd
			{
				get { return Color.FromArgb(23, 23, 23); }
			}
		}

		public class Arrow : ToolStripProfessionalRenderer
		{
			public Arrow() : base(new BrowserColors())
			{

			}

			protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
			{
				var tsMenuItem = e.Item as ToolStripMenuItem;
				if (tsMenuItem != null)
					e.ArrowColor = Color.White;
				base.OnRenderArrow(e);
			}
		}

		#endregion

		public void DefaultSpecialText()
		{
			if (rtbCurrentDmon.Text.Length > 0)
			{
				foreach (Tuple<string, Color, bool> item in defaultSpecialTexts)
				{
					if (item.Item3)
					{
						switch (item.Item1)
						{
							case "digits":
								int res = 0;
								bool ok = int.TryParse(rtbCurrentDmon.Text[rtbCurrentDmon.Text.Length - 1].ToString(), out res);
								if (ok)
								{
									rtbCurrentDmon.SelectionStart = rtbCurrentDmon.Text.LastIndexOf(res.ToString());
									rtbCurrentDmon.SelectionLength = res.ToString().Length;
									rtbCurrentDmon.SelectionColor = item.Item2;
									rtbCurrentDmon.SelectionStart = rtbCurrentDmon.TextLength;
									rtbCurrentDmon.SelectionLength = 0;
									rtbCurrentDmon.SelectionColor = Color.White;
								}
								break;
							case "variables":
								foreach (string varName in varNamesDmon)
								{
									if (rtbCurrentDmon.Text.Contains(varName) || rtbCurrentDmon.Text.LastIndexOf(varName) > rtbCurrentDmon.Text.IndexOf(varName))
									{
										rtbCurrentDmon.SelectionStart = rtbCurrentDmon.Text.LastIndexOf(varName);
										rtbCurrentDmon.SelectionLength = varName.Length;
										rtbCurrentDmon.SelectionColor = item.Item2;
										rtbCurrentDmon.SelectionStart = rtbCurrentDmon.TextLength;
										rtbCurrentDmon.SelectionLength = 0;
										rtbCurrentDmon.SelectionColor = Color.White;
									}
								}
								break;
						}
					}
				}
			}
		}

		public static void DefaultSpecialTextTurning(int index, bool turnState)
		{
			switch (defaultSpecialTexts[index].Item1)
			{
				case "digits":
					for (int i = 0; i < rtbCurrentDmon.Text.Length; i++)
					{
						int res = 0;
						bool ok = int.TryParse(rtbCurrentDmon.Text[i].ToString(), out res);
						if (ok)
						{
							rtbCurrentDmon.SelectionStart = i;
							rtbCurrentDmon.SelectionLength = res.ToString().Length;
							rtbCurrentDmon.SelectionColor = (turnState ? defaultSpecialTexts[index].Item2 : Color.White);
							rtbCurrentDmon.SelectionStart = rtbCurrentDmon.TextLength;
							rtbCurrentDmon.SelectionLength = 0;
							rtbCurrentDmon.SelectionColor = Color.White;
						}
					}
					break;
				case "variables":
					foreach (string varName in varNamesDmon)
					{
						for (int i = rtbCurrentDmon.Text.IndexOf(varName); i > -1; i = rtbCurrentDmon.Text.IndexOf(varName, i + 1))
						{
							rtbCurrentDmon.SelectionStart = i;
							rtbCurrentDmon.SelectionLength = varName.Length;
							rtbCurrentDmon.SelectionColor = (turnState ? defaultSpecialTexts[index].Item2 : Color.White);
							rtbCurrentDmon.SelectionStart = rtbCurrentDmon.TextLength;
							rtbCurrentDmon.SelectionLength = 0;
							rtbCurrentDmon.SelectionColor = Color.White;
						}
					}
					break;
			}
		}

		public static void FindSpecialText(string txt, Color clr)
		{
			if (rtbCurrentDmon.Text.Contains(txt) || rtbCurrentDmon.Text.LastIndexOf(txt) > rtbCurrentDmon.Text.IndexOf(txt))
			{
				rtbCurrentDmon.SelectionStart = rtbCurrentDmon.Text.LastIndexOf(txt);
				rtbCurrentDmon.SelectionLength = txt.Length;
				rtbCurrentDmon.SelectionColor = clr;
				rtbCurrentDmon.SelectionStart = rtbCurrentDmon.TextLength;
				rtbCurrentDmon.SelectionLength = 0;
				rtbCurrentDmon.SelectionColor = Color.White;
			}
		}

		public static void AddSpecialText(string txt, Color clr)
		{
			Tuple<string, int, int, int> newItem = new Tuple<string, int, int, int>(txt, clr.R, clr.G, clr.B);

			specialTextsDmon.Add(newItem);
			SaveSpecialText();
		}

		public static void SaveSpecialText()
		{
			var json = JsonConvert.SerializeObject(specialTextsDmon);

			File.WriteAllText(Application.StartupPath + "\\..\\..\\specialtext\\specialtexts.json", json);
		}

		public static void LoadSpecialText()
		{
			try
			{
				var json = File.ReadAllText(Application.StartupPath + "\\..\\..\\specialtext\\specialtexts.json");
				var model = JsonConvert.DeserializeObject<List<RootObject>>(json);

				for (int i = 0; i < model.Count; i++)
				{
					Tuple<string, int, int, int> newItem = new Tuple<string, int, int, int>(model[i].Item1, model[i].Item2, model[i].Item3, model[i].Item4);

					specialTextsDmon.Add(newItem);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Loading of Special Text failed.", "Error");
			}
		}

		private void Color_Change(object sender, MouseEventArgs e)
		{
			Panel selectedColorDmon = sender as Panel;
			currentColorDmon = selectedColorDmon.BackColor;
			currentColorDmon = Color.FromArgb(currentColorDmon.R - 23, currentColorDmon.G - 23, currentColorDmon.B - 23);
			pcbCheckDmon.Parent = selectedColorDmon;

			if (isTextSelectedDmon)
			{
				rtbMainNotepadDmon.SelectionBackColor = currentColorDmon;
			}
		}

		private void Color_Hover(object sender, EventArgs e)
		{
			Panel mouseOnColorDmon = sender as Panel;
			Color tempBgColor = mouseOnColorDmon.BackColor;
			mouseOnColorDmon.BackColor = Color.FromArgb(tempBgColor.R + 23, tempBgColor.G + 23, tempBgColor.B + 23);
		}

		private void Color_NoMoreHover(object sender, EventArgs e)
		{
			Panel mouseOnColorDmon = sender as Panel;
			Color tempBgColor = mouseOnColorDmon.BackColor;
			mouseOnColorDmon.BackColor = Color.FromArgb(tempBgColor.R - 23, tempBgColor.G - 23, tempBgColor.B - 23);
		}

		private void ColorCheck_Hover(object sender, EventArgs e)
		{
			PictureBox mouseOnColorDmon = sender as PictureBox;
			Panel parentPanel = mouseOnColorDmon.Parent as Panel;
			Color tempBgColor = mouseOnColorDmon.BackColor;
			parentPanel.BackColor = Color.FromArgb(tempBgColor.R + 23, tempBgColor.G + 23, tempBgColor.B + 23);
		}

		private void ColorCheck_NoMoreHover(object sender, EventArgs e)
		{
			PictureBox mouseOnColorDmon = sender as PictureBox;
			Panel parentPanel = mouseOnColorDmon.Parent as Panel;
			Color tempBgColor = mouseOnColorDmon.BackColor;
			parentPanel.BackColor = Color.FromArgb(tempBgColor.R - 23, tempBgColor.G - 23, tempBgColor.B - 23);
		}

		private void Text_Writing(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 8)
			{
				rtbMainNotepadDmon.SelectionStart = rtbMainNotepadDmon.TextLength;
				rtbMainNotepadDmon.SelectionLength = 0;
				rtbMainNotepadDmon.SelectionColor = Color.White;
			}

			if (rtbMainNotepadDmon.TextLength >= 0)
			{
				rtbMainNotepadDmon.SelectionStart = rtbMainNotepadDmon.TextLength;
				rtbMainNotepadDmon.SelectionLength = 0;
				rtbMainNotepadDmon.SelectionBackColor = currentColorDmon;
			}
		}

		private void Text_Written(object sender, EventArgs e)
		{
			foreach (Tuple<string, int, int, int> item in specialTextsDmon)
			{
				FindSpecialText(item.Item1, Color.FromArgb(item.Item2, item.Item3, item.Item4));
			}

			DefaultSpecialText();
			frmSearchDmon.rtbCurrentDmon = rtbMainNotepadDmon;
		}

		private void Selection_Changed(object sender, EventArgs e)
		{
			isTextSelectedDmon = (rtbMainNotepadDmon.SelectionLength > 0 ? true : false);
		}

		private void Form_Resize(object sender, EventArgs e)
		{

		}

		private void AddNewSpecialText_Click(object sender, EventArgs e)
		{
			try
			{
				frmAddSpecialTextDmon.Show();
			}
			catch (Exception)
			{
				frmAddSpecialTextDmon = new frmAddSpecialTextDmon();
				frmAddSpecialTextDmon.Show();
			}
		}

		private void ShowMySpecialTextDmon_Click(object sender, EventArgs e)
		{
			try
			{
				frmShowSpecialTextDmon.Show();
			}
			catch (Exception)
			{
				frmShowSpecialTextDmon = new frmShowSpecialTextDmon();
				frmShowSpecialTextDmon.Show();
			}
		}

		private void frmMainDmon_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				frmAddSpecialTextDmon.Close();
				frmShowSpecialTextDmon.Close();
			}
			catch (Exception)
			{
				
			}

			SaveSpecialText();
		}

		private void Zoom_Changed(object sender, EventArgs e)
		{
			ToolStripItem currentItem = sender as ToolStripItem;
			float zoom = float.Parse(currentItem.Tag.ToString());

			rtbMainNotepadDmon.ZoomFactor = zoom;
		}

		private void TurningSpecialText_CheckedChanged(object sender, EventArgs e)
		{
			ToolStripMenuItem currentItemDmon = sender as ToolStripMenuItem;
			int indexInList = int.Parse(currentItemDmon.Tag.ToString());
			bool newBoolState = (currentItemDmon.Checked ? true : false);

			defaultSpecialTexts[indexInList] = new Tuple<string, Color, bool>(defaultSpecialTexts[indexInList].Item1, defaultSpecialTexts[indexInList].Item2, newBoolState);
			DefaultSpecialTextTurning(indexInList, newBoolState);
		}

		private void Scroll_Move(object sender, MouseEventArgs e)
		{
			//Add numbers on left side..
		}

		private void ShortCut_Down(object sender, KeyEventArgs e)
		{
			if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.A)
			{
				rtbMainNotepadDmon.SelectAll();
				e.SuppressKeyPress = true;
			}
			else if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.D)
			{
				int firstCharDmon = rtbMainNotepadDmon.GetFirstCharIndexOfCurrentLine();
				int currentLineDmon = rtbMainNotepadDmon.GetLineFromCharIndex(firstCharDmon);
				string currentLineTextDmon = rtbMainNotepadDmon.Lines[currentLineDmon];
				rtbMainNotepadDmon.Select(firstCharDmon, currentLineTextDmon.Length);
			
				rtbMainNotepadDmon.Copy();
				rtbMainNotepadDmon.SelectionStart = currentLineTextDmon.Length;
				rtbMainNotepadDmon.AppendText(Environment.NewLine);
				rtbMainNotepadDmon.Paste();
				e.SuppressKeyPress = true;
			}
			else if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.F)
			{
				try
				{
					frmSearchDmon.Show();
				}
				catch (Exception)
				{
					frmSearchDmon = new frmSearchDmon();
					frmSearchDmon.Show();
				}
			}
		}
	}
}