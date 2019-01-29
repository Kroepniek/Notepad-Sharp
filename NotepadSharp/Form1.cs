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
		frmAddSpecialTextDmon frmAddSpecialTextDmon = new frmAddSpecialTextDmon();
		frmShowSpecialTextDmon frmShowSpecialTextDmon = new frmShowSpecialTextDmon();

		public frmMainDmon()
		{
			InitializeComponent();
			pcbCheckDmon.Parent = pnlColorNoneDmon;
			mnsMenuDmon.Renderer = new Arrow();
			LoadSpecialText();
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

		public void FindSpecialText(string txt, Color clr)
		{
			if (rtbMainNotepadDmon.Text.Contains(txt) || rtbMainNotepadDmon.Text.LastIndexOf(txt) > rtbMainNotepadDmon.Text.IndexOf(txt))
			{
				rtbMainNotepadDmon.SelectionStart = rtbMainNotepadDmon.Text.LastIndexOf(txt);
				rtbMainNotepadDmon.SelectionLength = txt.Length;
				rtbMainNotepadDmon.SelectionColor = clr;
				rtbMainNotepadDmon.SelectionStart = rtbMainNotepadDmon.TextLength;
				rtbMainNotepadDmon.SelectionLength = 0;
				rtbMainNotepadDmon.SelectionColor = Color.White;
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
		}

		private void Selection_Changed(object sender, EventArgs e)
		{
			if (rtbMainNotepadDmon.SelectionLength > 0)
			{
				isTextSelectedDmon = true;
			}
			else
			{
				isTextSelectedDmon = false;
			}
		}

		private void Form_Resize(object sender, EventArgs e)
		{
			rtbMainNotepadDmon.Size = new Size(this.Width - 54, this.Height - 75);
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
	}
}
