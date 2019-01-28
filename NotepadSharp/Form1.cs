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
		List<Label> lblLineCountDmon = new List<Label>();
		Color currentColorDmon = Color.FromArgb(46, 46, 46);

		public frmMainDmon()
		{
			InitializeComponent();

			for (int i = 1; i < 31; i++)
			{
				Label lblCreatingDmon = new Label();
				lblCreatingDmon.Parent = pnlLineCountsDmon;
				lblCreatingDmon.Name = "lblLineCount_" + i.ToString() + "_Dmon";
				lblCreatingDmon.Font = new Font("Trebuchet MS", 12);
				lblCreatingDmon.ForeColor = Color.FromArgb(184, 184, 184);
				lblCreatingDmon.AutoSize = false;
				lblCreatingDmon.Size = new Size(30, 20);
				lblCreatingDmon.Text = i.ToString();
				lblCreatingDmon.TextAlign = ContentAlignment.MiddleRight;
				lblCreatingDmon.Location = new Point(0, -18 + i*22);

				lblLineCountDmon.Add(lblCreatingDmon);
			}
		}

		private void Color_Change(object sender, MouseEventArgs e)
		{
			Panel selectedColorDmon = sender as Panel;
			currentColorDmon = selectedColorDmon.BackColor;
			pcbCheckDmon.Parent = selectedColorDmon;
		}

		private void Text_Writing(object sender, KeyEventArgs e)
		{
			if (rtbMainNotepadDmon.TextLength > 0)
			{
				rtbMainNotepadDmon.SelectionStart = rtbMainNotepadDmon.TextLength;
				rtbMainNotepadDmon.SelectionLength = 1;
				rtbMainNotepadDmon.SelectionBackColor = currentColorDmon;
			}
		}
	}
}
