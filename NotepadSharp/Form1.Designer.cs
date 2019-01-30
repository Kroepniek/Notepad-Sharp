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
			this.mnsMenuDmon = new System.Windows.Forms.MenuStrip();
			this.tsmFileDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmEditDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmFormatDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsiZoomDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.xZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xZoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.xZoomToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.xZoomToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmViewDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.specialTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAddNewSpecialTextDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiShowAllSpecialTextDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.pcbCheckDmon = new System.Windows.Forms.PictureBox();
			this.rtbMainNotepadDmon = new System.Windows.Forms.RichTextBox();
			this.pnlColorAquaDmon = new System.Windows.Forms.Panel();
			this.pnlColorBlueDmon = new System.Windows.Forms.Panel();
			this.pnlColorGreenDmon = new System.Windows.Forms.Panel();
			this.pnlColorNoneDmon = new System.Windows.Forms.Panel();
			this.pnlColorOrangeDmon = new System.Windows.Forms.Panel();
			this.pnlColorRedDmon = new System.Windows.Forms.Panel();
			this.pnlColorVioletDmon = new System.Windows.Forms.Panel();
			this.pnlColorYellowDmon = new System.Windows.Forms.Panel();
			this.tsmiDigitsSpecialTextDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiVariablesSpecialTextDmon = new System.Windows.Forms.ToolStripMenuItem();
			this.mnsMenuDmon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbCheckDmon)).BeginInit();
			this.SuspendLayout();
			// 
			// mnsMenuDmon
			// 
			this.mnsMenuDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.mnsMenuDmon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.mnsMenuDmon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFileDmon,
            this.tsmEditDmon,
            this.tsmFormatDmon,
            this.tsmViewDmon});
			this.mnsMenuDmon.Location = new System.Drawing.Point(0, 0);
			this.mnsMenuDmon.Name = "mnsMenuDmon";
			this.mnsMenuDmon.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnsMenuDmon.Size = new System.Drawing.Size(800, 26);
			this.mnsMenuDmon.TabIndex = 1;
			// 
			// tsmFileDmon
			// 
			this.tsmFileDmon.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsmFileDmon.ForeColor = System.Drawing.Color.White;
			this.tsmFileDmon.Name = "tsmFileDmon";
			this.tsmFileDmon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
			this.tsmFileDmon.Size = new System.Drawing.Size(42, 22);
			this.tsmFileDmon.Text = "File";
			// 
			// tsmEditDmon
			// 
			this.tsmEditDmon.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
			this.tsmEditDmon.ForeColor = System.Drawing.Color.White;
			this.tsmEditDmon.Name = "tsmEditDmon";
			this.tsmEditDmon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
			this.tsmEditDmon.Size = new System.Drawing.Size(43, 22);
			this.tsmEditDmon.Text = "Edit";
			// 
			// tsmFormatDmon
			// 
			this.tsmFormatDmon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsmFormatDmon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiZoomDmon});
			this.tsmFormatDmon.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
			this.tsmFormatDmon.ForeColor = System.Drawing.Color.White;
			this.tsmFormatDmon.Name = "tsmFormatDmon";
			this.tsmFormatDmon.ShortcutKeyDisplayString = "";
			this.tsmFormatDmon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
			this.tsmFormatDmon.Size = new System.Drawing.Size(59, 22);
			this.tsmFormatDmon.Text = "Format";
			// 
			// tsiZoomDmon
			// 
			this.tsiZoomDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.tsiZoomDmon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xZoomToolStripMenuItem,
            this.xZoomToolStripMenuItem1,
            this.xZoomToolStripMenuItem2,
            this.xZoomToolStripMenuItem3});
			this.tsiZoomDmon.ForeColor = System.Drawing.Color.White;
			this.tsiZoomDmon.Name = "tsiZoomDmon";
			this.tsiZoomDmon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
			this.tsiZoomDmon.Size = new System.Drawing.Size(180, 22);
			this.tsiZoomDmon.Text = "Zoom";
			// 
			// xZoomToolStripMenuItem
			// 
			this.xZoomToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xZoomToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.xZoomToolStripMenuItem.Name = "xZoomToolStripMenuItem";
			this.xZoomToolStripMenuItem.ShowShortcutKeys = false;
			this.xZoomToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.xZoomToolStripMenuItem.Tag = "1";
			this.xZoomToolStripMenuItem.Text = "1x zoom";
			this.xZoomToolStripMenuItem.Click += new System.EventHandler(this.Zoom_Changed);
			// 
			// xZoomToolStripMenuItem1
			// 
			this.xZoomToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xZoomToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.xZoomToolStripMenuItem1.Name = "xZoomToolStripMenuItem1";
			this.xZoomToolStripMenuItem1.ShowShortcutKeys = false;
			this.xZoomToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
			this.xZoomToolStripMenuItem1.Tag = "1,5";
			this.xZoomToolStripMenuItem1.Text = "1.5x zoom";
			this.xZoomToolStripMenuItem1.Click += new System.EventHandler(this.Zoom_Changed);
			// 
			// xZoomToolStripMenuItem2
			// 
			this.xZoomToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xZoomToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
			this.xZoomToolStripMenuItem2.Name = "xZoomToolStripMenuItem2";
			this.xZoomToolStripMenuItem2.ShowShortcutKeys = false;
			this.xZoomToolStripMenuItem2.Size = new System.Drawing.Size(127, 22);
			this.xZoomToolStripMenuItem2.Tag = "2";
			this.xZoomToolStripMenuItem2.Text = "2x zoom";
			this.xZoomToolStripMenuItem2.Click += new System.EventHandler(this.Zoom_Changed);
			// 
			// xZoomToolStripMenuItem3
			// 
			this.xZoomToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.xZoomToolStripMenuItem3.ForeColor = System.Drawing.Color.White;
			this.xZoomToolStripMenuItem3.Name = "xZoomToolStripMenuItem3";
			this.xZoomToolStripMenuItem3.ShowShortcutKeys = false;
			this.xZoomToolStripMenuItem3.Size = new System.Drawing.Size(127, 22);
			this.xZoomToolStripMenuItem3.Tag = "3";
			this.xZoomToolStripMenuItem3.Text = "3x zoom";
			this.xZoomToolStripMenuItem3.Click += new System.EventHandler(this.Zoom_Changed);
			// 
			// tsmViewDmon
			// 
			this.tsmViewDmon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specialTextToolStripMenuItem});
			this.tsmViewDmon.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
			this.tsmViewDmon.ForeColor = System.Drawing.Color.White;
			this.tsmViewDmon.Name = "tsmViewDmon";
			this.tsmViewDmon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
			this.tsmViewDmon.Size = new System.Drawing.Size(49, 22);
			this.tsmViewDmon.Text = "View";
			// 
			// specialTextToolStripMenuItem
			// 
			this.specialTextToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.specialTextToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddNewSpecialTextDmon,
            this.tsmiShowAllSpecialTextDmon,
            this.tsmiDigitsSpecialTextDmon,
            this.tsmiVariablesSpecialTextDmon});
			this.specialTextToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.specialTextToolStripMenuItem.Name = "specialTextToolStripMenuItem";
			this.specialTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.specialTextToolStripMenuItem.Text = "Special Text";
			// 
			// tsmiAddNewSpecialTextDmon
			// 
			this.tsmiAddNewSpecialTextDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.tsmiAddNewSpecialTextDmon.ForeColor = System.Drawing.Color.White;
			this.tsmiAddNewSpecialTextDmon.Name = "tsmiAddNewSpecialTextDmon";
			this.tsmiAddNewSpecialTextDmon.Size = new System.Drawing.Size(200, 22);
			this.tsmiAddNewSpecialTextDmon.Text = "Add...";
			this.tsmiAddNewSpecialTextDmon.Click += new System.EventHandler(this.AddNewSpecialText_Click);
			// 
			// tsmiShowAllSpecialTextDmon
			// 
			this.tsmiShowAllSpecialTextDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.tsmiShowAllSpecialTextDmon.ForeColor = System.Drawing.Color.White;
			this.tsmiShowAllSpecialTextDmon.Name = "tsmiShowAllSpecialTextDmon";
			this.tsmiShowAllSpecialTextDmon.Size = new System.Drawing.Size(200, 22);
			this.tsmiShowAllSpecialTextDmon.Text = "Show my Special Text";
			this.tsmiShowAllSpecialTextDmon.Click += new System.EventHandler(this.ShowMySpecialTextDmon_Click);
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
			this.pcbCheckDmon.MouseEnter += new System.EventHandler(this.ColorCheck_Hover);
			this.pcbCheckDmon.MouseLeave += new System.EventHandler(this.ColorCheck_NoMoreHover);
			// 
			// rtbMainNotepadDmon
			// 
			this.rtbMainNotepadDmon.AcceptsTab = true;
			this.rtbMainNotepadDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.rtbMainNotepadDmon.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbMainNotepadDmon.Font = new System.Drawing.Font("Trebuchet MS", 12F);
			this.rtbMainNotepadDmon.ForeColor = System.Drawing.Color.White;
			this.rtbMainNotepadDmon.Location = new System.Drawing.Point(5, 30);
			this.rtbMainNotepadDmon.Name = "rtbMainNotepadDmon";
			this.rtbMainNotepadDmon.Size = new System.Drawing.Size(795, 418);
			this.rtbMainNotepadDmon.TabIndex = 2;
			this.rtbMainNotepadDmon.Tag = "None";
			this.rtbMainNotepadDmon.Text = "";
			this.rtbMainNotepadDmon.SelectionChanged += new System.EventHandler(this.Selection_Changed);
			this.rtbMainNotepadDmon.TextChanged += new System.EventHandler(this.Text_Written);
			this.rtbMainNotepadDmon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShortCut_Down);
			this.rtbMainNotepadDmon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Writing);
			// 
			// pnlColorAquaDmon
			// 
			this.pnlColorAquaDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
			this.pnlColorAquaDmon.Location = new System.Drawing.Point(465, 2);
			this.pnlColorAquaDmon.Name = "pnlColorAquaDmon";
			this.pnlColorAquaDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorAquaDmon.TabIndex = 3;
			this.pnlColorAquaDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			this.pnlColorAquaDmon.MouseEnter += new System.EventHandler(this.Color_Hover);
			this.pnlColorAquaDmon.MouseLeave += new System.EventHandler(this.Color_NoMoreHover);
			// 
			// pnlColorBlueDmon
			// 
			this.pnlColorBlueDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(151)))));
			this.pnlColorBlueDmon.Location = new System.Drawing.Point(503, 2);
			this.pnlColorBlueDmon.Name = "pnlColorBlueDmon";
			this.pnlColorBlueDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorBlueDmon.TabIndex = 3;
			this.pnlColorBlueDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			this.pnlColorBlueDmon.MouseEnter += new System.EventHandler(this.Color_Hover);
			this.pnlColorBlueDmon.MouseLeave += new System.EventHandler(this.Color_NoMoreHover);
			// 
			// pnlColorGreenDmon
			// 
			this.pnlColorGreenDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(151)))), ((int)(((byte)(23)))));
			this.pnlColorGreenDmon.Location = new System.Drawing.Point(427, 2);
			this.pnlColorGreenDmon.Name = "pnlColorGreenDmon";
			this.pnlColorGreenDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorGreenDmon.TabIndex = 3;
			this.pnlColorGreenDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			this.pnlColorGreenDmon.MouseEnter += new System.EventHandler(this.Color_Hover);
			this.pnlColorGreenDmon.MouseLeave += new System.EventHandler(this.Color_NoMoreHover);
			// 
			// pnlColorNoneDmon
			// 
			this.pnlColorNoneDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.pnlColorNoneDmon.Location = new System.Drawing.Point(579, 2);
			this.pnlColorNoneDmon.Name = "pnlColorNoneDmon";
			this.pnlColorNoneDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorNoneDmon.TabIndex = 3;
			this.pnlColorNoneDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			this.pnlColorNoneDmon.MouseEnter += new System.EventHandler(this.Color_Hover);
			this.pnlColorNoneDmon.MouseLeave += new System.EventHandler(this.Color_NoMoreHover);
			// 
			// pnlColorOrangeDmon
			// 
			this.pnlColorOrangeDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(87)))), ((int)(((byte)(23)))));
			this.pnlColorOrangeDmon.Location = new System.Drawing.Point(351, 2);
			this.pnlColorOrangeDmon.Name = "pnlColorOrangeDmon";
			this.pnlColorOrangeDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorOrangeDmon.TabIndex = 3;
			this.pnlColorOrangeDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			this.pnlColorOrangeDmon.MouseEnter += new System.EventHandler(this.Color_Hover);
			this.pnlColorOrangeDmon.MouseLeave += new System.EventHandler(this.Color_NoMoreHover);
			// 
			// pnlColorRedDmon
			// 
			this.pnlColorRedDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.pnlColorRedDmon.Location = new System.Drawing.Point(313, 2);
			this.pnlColorRedDmon.Name = "pnlColorRedDmon";
			this.pnlColorRedDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorRedDmon.TabIndex = 3;
			this.pnlColorRedDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			this.pnlColorRedDmon.MouseEnter += new System.EventHandler(this.Color_Hover);
			this.pnlColorRedDmon.MouseLeave += new System.EventHandler(this.Color_NoMoreHover);
			// 
			// pnlColorVioletDmon
			// 
			this.pnlColorVioletDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(23)))), ((int)(((byte)(151)))));
			this.pnlColorVioletDmon.Location = new System.Drawing.Point(541, 2);
			this.pnlColorVioletDmon.Name = "pnlColorVioletDmon";
			this.pnlColorVioletDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorVioletDmon.TabIndex = 3;
			this.pnlColorVioletDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			this.pnlColorVioletDmon.MouseEnter += new System.EventHandler(this.Color_Hover);
			this.pnlColorVioletDmon.MouseLeave += new System.EventHandler(this.Color_NoMoreHover);
			// 
			// pnlColorYellowDmon
			// 
			this.pnlColorYellowDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(23)))));
			this.pnlColorYellowDmon.Location = new System.Drawing.Point(389, 2);
			this.pnlColorYellowDmon.Name = "pnlColorYellowDmon";
			this.pnlColorYellowDmon.Size = new System.Drawing.Size(32, 22);
			this.pnlColorYellowDmon.TabIndex = 3;
			this.pnlColorYellowDmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Color_Change);
			this.pnlColorYellowDmon.MouseEnter += new System.EventHandler(this.Color_Hover);
			this.pnlColorYellowDmon.MouseLeave += new System.EventHandler(this.Color_NoMoreHover);
			// 
			// tsmiDigitsSpecialTextDmon
			// 
			this.tsmiDigitsSpecialTextDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.tsmiDigitsSpecialTextDmon.Checked = true;
			this.tsmiDigitsSpecialTextDmon.CheckOnClick = true;
			this.tsmiDigitsSpecialTextDmon.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsmiDigitsSpecialTextDmon.ForeColor = System.Drawing.Color.White;
			this.tsmiDigitsSpecialTextDmon.Name = "tsmiDigitsSpecialTextDmon";
			this.tsmiDigitsSpecialTextDmon.Size = new System.Drawing.Size(200, 22);
			this.tsmiDigitsSpecialTextDmon.Tag = "0";
			this.tsmiDigitsSpecialTextDmon.Text = "Digits";
			this.tsmiDigitsSpecialTextDmon.CheckedChanged += new System.EventHandler(this.TurningSpecialText_CheckedChanged);
			// 
			// tsmiVariablesSpecialTextDmon
			// 
			this.tsmiVariablesSpecialTextDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.tsmiVariablesSpecialTextDmon.Checked = true;
			this.tsmiVariablesSpecialTextDmon.CheckOnClick = true;
			this.tsmiVariablesSpecialTextDmon.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsmiVariablesSpecialTextDmon.ForeColor = System.Drawing.Color.White;
			this.tsmiVariablesSpecialTextDmon.Name = "tsmiVariablesSpecialTextDmon";
			this.tsmiVariablesSpecialTextDmon.Size = new System.Drawing.Size(200, 22);
			this.tsmiVariablesSpecialTextDmon.Tag = "1";
			this.tsmiVariablesSpecialTextDmon.Text = "Variables";
			this.tsmiVariablesSpecialTextDmon.CheckedChanged += new System.EventHandler(this.TurningSpecialText_CheckedChanged);
			// 
			// frmMainDmon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlColorYellowDmon);
			this.Controls.Add(this.pnlColorVioletDmon);
			this.Controls.Add(this.pnlColorRedDmon);
			this.Controls.Add(this.pnlColorOrangeDmon);
			this.Controls.Add(this.pnlColorNoneDmon);
			this.Controls.Add(this.pnlColorGreenDmon);
			this.Controls.Add(this.pnlColorBlueDmon);
			this.Controls.Add(this.pnlColorAquaDmon);
			this.Controls.Add(this.rtbMainNotepadDmon);
			this.Controls.Add(this.mnsMenuDmon);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.mnsMenuDmon;
			this.Name = "frmMainDmon";
			this.Text = "Notepad#";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainDmon_FormClosing);
			this.Resize += new System.EventHandler(this.Form_Resize);
			this.mnsMenuDmon.ResumeLayout(false);
			this.mnsMenuDmon.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbCheckDmon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnsMenuDmon;
		private System.Windows.Forms.ToolStripMenuItem tsmFileDmon;
		private System.Windows.Forms.ToolStripMenuItem tsmEditDmon;
		private System.Windows.Forms.ToolStripMenuItem tsmFormatDmon;
		private System.Windows.Forms.ToolStripMenuItem tsmViewDmon;
		private System.Windows.Forms.ToolStripMenuItem tsiZoomDmon;
		private System.Windows.Forms.ToolStripMenuItem xZoomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xZoomToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem xZoomToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem xZoomToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem specialTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiAddNewSpecialTextDmon;
		private System.Windows.Forms.ToolStripMenuItem tsmiShowAllSpecialTextDmon;
		private System.Windows.Forms.PictureBox pcbCheckDmon;
		private System.Windows.Forms.RichTextBox rtbMainNotepadDmon;
		private System.Windows.Forms.Panel pnlColorAquaDmon;
		private System.Windows.Forms.Panel pnlColorBlueDmon;
		private System.Windows.Forms.Panel pnlColorGreenDmon;
		private System.Windows.Forms.Panel pnlColorNoneDmon;
		private System.Windows.Forms.Panel pnlColorOrangeDmon;
		private System.Windows.Forms.Panel pnlColorRedDmon;
		private System.Windows.Forms.Panel pnlColorVioletDmon;
		private System.Windows.Forms.Panel pnlColorYellowDmon;
		private System.Windows.Forms.ToolStripMenuItem tsmiDigitsSpecialTextDmon;
		private System.Windows.Forms.ToolStripMenuItem tsmiVariablesSpecialTextDmon;
	}
}

