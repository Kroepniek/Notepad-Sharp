using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotepadSharp
{
	public partial class frmAddSpecialTextDmon : Form
	{
		string specialTextDmon = "";
		Color specialTextColorDmon = Color.White;
		bool selectedDmon = false;

		public frmAddSpecialTextDmon()
		{
			InitializeComponent();
		}

		private void btnSpecialTextForm_BrowseColorsDmon_Click(object sender, EventArgs e)
		{
			if (cldSpecialTextForm_ColorDialogDmon.ShowDialog() == DialogResult.OK)
			{
				specialTextColorDmon = cldSpecialTextForm_ColorDialogDmon.Color;
				selectedDmon = true;
			}
		}

		private void txbSpecialTextDmon_TextChanged(object sender, EventArgs e)
		{
			specialTextDmon = txbSpecialTextDmon.Text;
		}

		private void btnSpecialTextForm_SendDmon_Click(object sender, EventArgs e)
		{
			if (specialTextDmon.Length > 0 && specialTextColorDmon != Color.White && selectedDmon)
			{
				frmMainDmon.AddSpecialText(specialTextDmon, specialTextColorDmon);
				txbSpecialTextDmon.Text = "";
				selectedDmon = false;
				specialTextColorDmon = Color.White;
				this.Hide();
			}
			else
			{
				MessageBox.Show("Choose right color or/and fill in the input.", "Nope.");
			}
		}

		private void btnSpecialTextForm_AbortDmon_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
