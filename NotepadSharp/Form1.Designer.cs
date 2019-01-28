namespace NotepadSharp
{
	partial class frmMainDmon
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainDmon));
			this.rtbMainNotepadDmon = new System.Windows.Forms.RichTextBox();
			this.mnsMenuDmon = new System.Windows.Forms.MenuStrip();
			this.tsmFileDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmEditDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmFormatDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmViewDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlLineCountsDmon = new System.Windows.Forms.Panel();
			this.pnlColorRedDmon = new System.Windows.Forms.Panel();
			this.pnlColorOrangeDmon = new System.Windows.Forms.Panel();
			this.pnlColorYellowDmon = new System.Windows.Forms.Panel();
			this.pnlColorGreenDmon = new System.Windows.Forms.Panel();
			this.pnlColorAquaDmon = new System.Windows.Forms.Panel();
			this.pnlColorBlueDmon = new System.Windows.Forms.Panel();
			this.pnlColorVioletDmon = new System.Windows.Forms.Panel();
			this.pcbCheckDmon = new System.Windows.Forms.PictureBox();
			this.pnlColorNoneDmon = new System.Windows.Forms.Panel();
			this.mnsMenuDmon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbCheckDmon)).BeginInit();
			this.pnlColorNoneDmon.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtbMainNotepadDmon
			// 
			this.rtbMainNotepadDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.rtbMainNotepadDmon.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbMainNotepadDmon.Font = new System.Drawing.Font("Trebuchet MS", 12F);
			this.rtbMainNotepadDmon.ForeColor = System.Drawing.Color.White;
			this.rtbMainNotepadDmon.Location = new System.Drawing.Point(33, 30);
			this.rtbMainNotepadDmon.Name = "rtbMainNotepadDmon";
			this.rtbMainNotepadDmon.Size = new System.Drawing.Size(762, 414);
			this.rtbMainNotepadDmon.TabIndex = 0;
			this.rtbMainNotepadDmon.Text = "";
			this.rtbMainNotepadDmon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text_Writing);
			// 
			// mnsMenuDmon
			// 
			this.mnsMenuDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.mnsMenuDmon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFileDmon,
            this.tsmEditDmon,
            this.tsmFormatDmon,
            this.tsmViewDmon});
			this.mnsMenuDmon.Location = new System.Drawing.Point(0, 0);
			this.mnsMenuDmon.Name = "mnsMenuDmon";
			this.mnsMenuDmon.Size = new System.Drawing.Size(800, 26);
			this.mnsMenuDmon.TabIndex = 1;
			this.mnsMenuDmon.Text = "menuStrip1";
			// 
			// tsmFileDmon
			// 
			this.tsmFileDmon.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmFileDmon.ForeColor = System.Drawing.Color.White;
			this.tsmFileDmon.Name = "tsmFileDmon";
			this.tsmFileDmon.Size = new System.Drawing.Size(42, 22);
			this.tsmFileDmon.Text = "File";
			// 
			// tsmEditDmon
			// 
			this.tsmEditDmon.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
			this.tsmEditDmon.ForeColor = System.Drawing.Color.White;
			this.tsmEditDmon.Name = "tsmEditDmon";
			this.tsmEditDmon.Size = new System.Drawing.Size(43, 22);
			this.tsmEditDmon.Text = "Edit";
			// 
			// tsmFormatDmon
			// 
			this.tsmFormatDmon.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
			this.tsmFormatDmon.ForeColor = System.Drawing.Color.White;
			this.tsmFormatDmon.Name = "tsmFormatDmon";
			this.tsmFormatDmon.Size = new System.Drawing.Size(59, 22);
			this.tsmFormatDmon.Text = "Format";
			// 
			// tsmViewDmon
			// 
			this.tsmViewDmon.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
			this.tsmViewDmon.ForeColor = System.Drawing.Color.White;
			this.tsmViewDmon.Name = "tsmViewDmon";
			this.tsmViewDmon.Size = new System.Drawing.Size(49, 22);
			this.tsmViewDmon.Text = "View";
			// 
			// pnlLineCountsDmon
			// 
			this.pnlLineCountsDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.pnlLineCountsDmon.Location = new System.Drawing.Point(0, 26);
			this.pnlLineCountsDmon.Name = "pnlLineCountsDmon";
			this.pnlLineCountsDmon.Size = new System.Drawing.Size(30, 428);
			this.pnlLineCountsDmon.TabIndex = 2;
			// 
			// pnlColorRedDmon
			// 
			this.pnlColorRedDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.pnlColorRedDmon.Location = new System.Drawing.Point(313, 2);
			this.pnlColorRedDmon.Name = "pnlColorRedDmon";
			this.pnlColorRedDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorRedDmon.TabIndex = 3;
			this.pnlColorRedDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			// 
			// pnlColorOrangeDmon
			// 
			this.pnlColorOrangeDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(87)))), ((int)(((byte)(23)))));
			this.pnlColorOrangeDmon.Location = new System.Drawing.Point(351, 2);
			this.pnlColorOrangeDmon.Name = "pnlColorOrangeDmon";
			this.pnlColorOrangeDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorOrangeDmon.TabIndex = 3;
			this.pnlColorOrangeDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			// 
			// pnlColorYellowDmon
			// 
			this.pnlColorYellowDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(23)))));
			this.pnlColorYellowDmon.Location = new System.Drawing.Point(389, 2);
			this.pnlColorYellowDmon.Name = "pnlColorYellowDmon";
			this.pnlColorYellowDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorYellowDmon.TabIndex = 3;
			this.pnlColorYellowDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			// 
			// pnlColorGreenDmon
			// 
			this.pnlColorGreenDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(151)))), ((int)(((byte)(23)))));
			this.pnlColorGreenDmon.Location = new System.Drawing.Point(427, 2);
			this.pnlColorGreenDmon.Name = "pnlColorGreenDmon";
			this.pnlColorGreenDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorGreenDmon.TabIndex = 3;
			this.pnlColorGreenDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			// 
			// pnlColorAquaDmon
			// 
			this.pnlColorAquaDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
			this.pnlColorAquaDmon.Location = new System.Drawing.Point(465, 2);
			this.pnlColorAquaDmon.Name = "pnlColorAquaDmon";
			this.pnlColorAquaDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorAquaDmon.TabIndex = 3;
			this.pnlColorAquaDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			// 
			// pnlColorBlueDmon
			// 
			this.pnlColorBlueDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(151)))));
			this.pnlColorBlueDmon.Location = new System.Drawing.Point(503, 2);
			this.pnlColorBlueDmon.Name = "pnlColorBlueDmon";
			this.pnlColorBlueDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorBlueDmon.TabIndex = 3;
			this.pnlColorBlueDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			// 
			// pnlColorVioletDmon
			// 
			this.pnlColorVioletDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(23)))), ((int)(((byte)(151)))));
			this.pnlColorVioletDmon.Location = new System.Drawing.Point(541, 2);
			this.pnlColorVioletDmon.Name = "pnlColorVioletDmon";
			this.pnlColorVioletDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorVioletDmon.TabIndex = 3;
			this.pnlColorVioletDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			// 
			// pcbCheckDmon
			// 
			this.pcbCheckDmon.Image = global::NotepadSharp.Properties.Resources.check;
			this.pcbCheckDmon.Location = new System.Drawing.Point(2, 2);
			this.pcbCheckDmon.Name = "pcbCheckDmon";
			this.pcbCheckDmon.Size = new System.Drawing.Size(28, 18);
			this.pcbCheckDmon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbCheckDmon.TabIndex = 4;
			this.pcbCheckDmon.TabStop = false;
			// 
			// pnlColorNoneDmon
			// 
			this.pnlColorNoneDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.pnlColorNoneDmon.Controls.Add(this.pcbCheckDmon);
			this.pnlColorNoneDmon.Location = new System.Drawing.Point(579, 2);
			this.pnlColorNoneDmon.Name = "pnlColorNoneDmon";
			this.pnlColorNoneDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorNoneDmon.TabIndex = 3;
			this.pnlColorNoneDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			// 
			// frmMainDmon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlColorNoneDmon);
			this.Controls.Add(this.pnlColorVioletDmon);
			this.Controls.Add(this.pnlColorBlueDmon);
			this.Controls.Add(this.pnlColorAquaDmon);
			this.Controls.Add(this.pnlColorGreenDmon);
			this.Controls.Add(this.pnlColorYellowDmon);
			this.Controls.Add(this.pnlColorOrangeDmon);
			this.Controls.Add(this.pnlColorRedDmon);
			this.Controls.Add(this.pnlLineCountsDmon);
			this.Controls.Add(this.rtbMainNotepadDmon);
			this.Controls.Add(this.mnsMenuDmon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mnsMenuDmon;
			this.Name = "frmMainDmon";
			this.Text = "Notepad#";
			this.mnsMenuDmon.ResumeLayout(false);
			this.mnsMenuDmon.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbCheckDmon)).EndInit();
			this.pnlColorNoneDmon.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbMainNotepadDmon;
		private System.Windows.Forms.MenuStrip mnsMenuDmon;
		private System.Windows.Forms.ToolStripMenuItem tsmFileDmon;
		private System.Windows.Forms.ToolStripMenuItem tsmEditDmon;
		private System.Windows.Forms.ToolStripMenuItem tsmFormatDmon;
		private System.Windows.Forms.ToolStripMenuItem tsmViewDmon;
		private System.Windows.Forms.Panel pnlLineCountsDmon;
		private System.Windows.Forms.Panel pnlColorRedDmon;
		private System.Windows.Forms.Panel pnlColorOrangeDmon;
		private System.Windows.Forms.Panel pnlColorYellowDmon;
		private System.Windows.Forms.Panel pnlColorGreenDmon;
		private System.Windows.Forms.Panel pnlColorAquaDmon;
		private System.Windows.Forms.Panel pnlColorBlueDmon;
		private System.Windows.Forms.Panel pnlColorVioletDmon;
		private System.Windows.Forms.PictureBox pcbCheckDmon;
		private System.Windows.Forms.Panel pnlColorNoneDmon;
	}
}

