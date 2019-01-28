using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadSharp
{
	public partial class frmMainDmon : Form
	{
		Color currentColorDmon = Color.FromArgb(46, 46, 46);
		bool isTextSelectedDmon = false;

		public frmMainDmon()
		{
			InitializeComponent();
		}

		private void Color_Change(object sender, MouseEventArgs e)
		{
			Panel selectedColorDmon = sender as Panel;
			currentColorDmon = selectedColorDmon.BackColor;
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
			if (rtbMainNotepadDmon.TextLength >= 0)
			{
				rtbMainNotepadDmon.SelectionStart = rtbMainNotepadDmon.TextLength;
				rtbMainNotepadDmon.SelectionLength = 1;
				rtbMainNotepadDmon.SelectionBackColor = currentColorDmon;
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
	}
}
