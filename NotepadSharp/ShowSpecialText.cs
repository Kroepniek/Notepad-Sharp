using System;
using System.Windows.Forms;

namespace NotepadSharp
{
	public partial class frmShowSpecialTextDmon : Form
	{
		int indexToRemoveDmon = 0;

		public frmShowSpecialTextDmon()
		{
			InitializeComponent();
			btnShowSpecialTextForm_RemoveDmon.Focus();
		}

		public void LoadSpecialTextsDmon()
		{
			cbbShowSpecialTextForm_SpecialTextsDmon.Items.Clear();

			for (int i = 0; i < frmMainDmon.specialTextsDmon.Count; i++)
			{
				cbbShowSpecialTextForm_SpecialTextsDmon.Items.Add(frmMainDmon.specialTextsDmon[i].Item1);
			}

			if (cbbShowSpecialTextForm_SpecialTextsDmon.Items.Count > 0)
			{
				cbbShowSpecialTextForm_SpecialTextsDmon.Update();
			}
		}

		private void btnShowSpecialTextForm_AbortDmon_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void btnShowSpecialTextForm_RemoveDmon_Click(object sender, EventArgs e)
		{
			frmMainDmon.specialTextsDmon.RemoveAt(indexToRemoveDmon);
			LoadSpecialTextsDmon();
		}

		private void cbbShowSpecialTextForm_SpecialTextsDmon_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnShowSpecialTextForm_RemoveDmon.Focus();
			indexToRemoveDmon = cbbShowSpecialTextForm_SpecialTextsDmon.SelectedIndex;
		}

		private void frmShowSpecialTextDmon_Load(object sender, EventArgs e)
		{
			LoadSpecialTextsDmon();
		}

		private void cbbShowSpecialTextForm_SpecialTextsDmon_DropDownClosed(object sender, EventArgs e)
		{
			btnShowSpecialTextForm_RemoveDmon.Focus();
		}
	}
}
