using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadSharp
{
	public partial class frmSearchDmon : Form
	{
		string textToFind = "";
		int i = 0;
		List<WordDmon> indexPos = new List<WordDmon>();
		public RichTextBox rtbCurrentDmon = new RichTextBox();

		public frmSearchDmon()
		{
			InitializeComponent();
		}

		class WordDmon
		{
			public int indexInText { get; set; }
			public int textLength { get; set; }

			public WordDmon(int p_indexInText, int p_textLength)
			{
				indexInText = p_indexInText;
				textLength = p_textLength;
			}
		}

		private void FindText()
		{
			for (int i = rtbCurrentDmon.Text.IndexOf(textToFind); i > -1; i = rtbCurrentDmon.Text.IndexOf(textToFind, i + 1))
			{
				indexPos.Add(new WordDmon(i, textToFind.Length));
			}
		}

		private void HighlightText(Color clr)
		{
			rtbCurrentDmon.SelectionStart = indexPos[i].indexInText;
			rtbCurrentDmon.SelectionLength = indexPos[i].textLength;
			rtbCurrentDmon.SelectionBackColor = clr;
			rtbCurrentDmon.SelectionStart = rtbCurrentDmon.Text.Length;
			rtbCurrentDmon.SelectionLength = 0;
			rtbCurrentDmon.SelectionColor = Color.White;
		}

		private void btnSearchingForm_AbortDmon_Click(object sender, EventArgs e)
		{
			btnSearchingForm_NextDmon.Enabled = false;
			btnSearchingForm_PrevDmon.Enabled = false;
			btnSearchingForm_ReplaceDmon.Enabled = false;
			btnSearchingForm_ReplaceAllDmon.Enabled = false;
			this.Hide();
		}

		private void btnSearchingForm_SearchDmon_Click(object sender, EventArgs e)
		{
			if (txbSearchingDmon.Text.Length > 0)
			{
				textToFind = txbSearchingDmon.Text;
				lblSearchingFormFoundsDmon.Text = "Found: " + Regex.Matches(rtbCurrentDmon.Text, textToFind).Count.ToString();
				FindText();
				lblSearchingFormCountDmon.Text = (i + 1).ToString() + " of " + indexPos.Count.ToString();
				HighlightText(Color.SkyBlue);
				btnSearchingForm_NextDmon.Enabled = true;
				btnSearchingForm_PrevDmon.Enabled = true;
				btnSearchingForm_ReplaceDmon.Enabled = true;
				btnSearchingForm_ReplaceAllDmon.Enabled = true;
			}
			else
			{
				MessageBox.Show("I can't search for nothing.\nWrite some text to find.", "Alert");
			}
		}

		private void btnSearchingForm_NextDmon_Click(object sender, EventArgs e)
		{
			HighlightText(Color.FromArgb(46, 46, 46));

			i += (i < indexPos.Count-1 ? 1 : 0);

			HighlightText(Color.SkyBlue);
			lblSearchingFormCountDmon.Text = (i + 1).ToString() + " of " + indexPos.Count.ToString();
		}

		private void btnSearchingForm_PrevDmon_Click(object sender, EventArgs e)
		{
			HighlightText(Color.FromArgb(46, 46, 46));

			i -= (i > 0 ? 1 : 0);

			HighlightText(Color.SkyBlue);
			lblSearchingFormCountDmon.Text = (i + 1).ToString() + " of " + indexPos.Count.ToString();
		}

		private void btnSearchingForm_ReplaceDmon_Click(object sender, EventArgs e)
		{
			if (txbReplaceDmon.Text.Length > 0)
			{
				if (indexPos.Count > 0)
				{
					string tempText = "";
					int lengthDif = txbReplaceDmon.Text.Length - indexPos[i].textLength;

					tempText = rtbCurrentDmon.Text.Substring(0, indexPos[i].indexInText) + txbReplaceDmon.Text + rtbCurrentDmon.Text.Substring(indexPos[i].indexInText + indexPos[i].textLength);
					rtbCurrentDmon.Text = tempText;

					for (int j = i + 1; j < indexPos.Count; j++)
					{
						indexPos[j].indexInText += lengthDif;
					}

					indexPos[i].textLength = txbReplaceDmon.Text.Length;
					HighlightText(Color.SkyBlue);
				}
			}
			else
			{
				MessageBox.Show("I can't replace it to nothing.\nWrite some text for replacing.", "Alert");
			}
		}

		private void btnSearchingForm_ReplaceAllDmon_Click(object sender, EventArgs e)
		{
			if (txbReplaceDmon.Text.Length > 0)
			{
				foreach (WordDmon item in indexPos)
				{
					//string tempText = "";
					int lengthDif = txbReplaceDmon.Text.Length - item.textLength;

					//tempText = rtbCurrentDmon.Text.Substring(0, item.indexInText) + txbReplaceDmon.Text + rtbCurrentDmon.Text.Substring(item.indexInText + item.textLength);
					//rtbCurrentDmon.Text = tempText;
					
					rtbCurrentDmon.Text = rtbCurrentDmon.Text.Replace(textToFind, txbReplaceDmon.Text);

					for (int j = i + 1; j < indexPos.Count; j++)
					{
						indexPos[j].indexInText += lengthDif;
					}

					item.textLength = txbReplaceDmon.Text.Length;
					HighlightText(Color.FromArgb(46, 46, 46));

					for (int i = 0; i < frmMainDmon.defaultSpecialTexts.Count; i++)
					{
						frmMainDmon.DefaultSpecialTextTurning(i, true);
					}
				}

				foreach (Tuple<string, int, int, int> item in frmMainDmon.specialTextsDmon)
				{
					frmMainDmon.FindSpecialText(item.Item1, Color.FromArgb(item.Item2, item.Item3, item.Item4));
				}
			}
			else
			{
				MessageBox.Show("I can't replace it to nothing.\nWrite some text for replacing.", "Alert");
			}
		}
	}
}
