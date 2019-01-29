namespace NotepadSharp
{
	partial class frmAddSpecialTextDmon
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSpecialTextDmon));
			this.txbSpecialTextDmon = new System.Windows.Forms.TextBox();
			this.lblSpecialTextFormInfo_1_Dmon = new System.Windows.Forms.Label();
			this.lblSpecialTextFormInfo_2_Dmon = new System.Windows.Forms.Label();
			this.btnSpecialTextForm_BrowseColorsDmon = new System.Windows.Forms.Button();
			this.btnSpecialTextForm_SendDmon = new System.Windows.Forms.Button();
			this.cldSpecialTextForm_ColorDialogDmon = new System.Windows.Forms.ColorDialog();
			this.btnSpecialTextForm_AbortDmon = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txbSpecialTextDmon
			// 
			this.txbSpecialTextDmon.Font = new System.Drawing.Font("Trebuchet MS", 12F);
			this.txbSpecialTextDmon.ForeColor = System.Drawing.Color.Black;
			this.txbSpecialTextDmon.Location = new System.Drawing.Point(26, 52);
			this.txbSpecialTextDmon.Name = "txbSpecialTextDmon";
			this.txbSpecialTextDmon.Size = new System.Drawing.Size(230, 26);
			this.txbSpecialTextDmon.TabIndex = 0;
			this.txbSpecialTextDmon.TextChanged += new System.EventHandler(this.txbSpecialTextDmon_TextChanged);
			// 
			// lblSpecialTextFormInfo_1_Dmon
			// 
			this.lblSpecialTextFormInfo_1_Dmon.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lblSpecialTextFormInfo_1_Dmon.Location = new System.Drawing.Point(23, 26);
			this.lblSpecialTextFormInfo_1_Dmon.Name = "lblSpecialTextFormInfo_1_Dmon";
			this.lblSpecialTextFormInfo_1_Dmon.Size = new System.Drawing.Size(204, 23);
			this.lblSpecialTextFormInfo_1_Dmon.TabIndex = 1;
			this.lblSpecialTextFormInfo_1_Dmon.Text = "Write your special text:";
			// 
			// lblSpecialTextFormInfo_2_Dmon
			// 
			this.lblSpecialTextFormInfo_2_Dmon.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lblSpecialTextFormInfo_2_Dmon.Location = new System.Drawing.Point(23, 100);
			this.lblSpecialTextFormInfo_2_Dmon.Name = "lblSpecialTextFormInfo_2_Dmon";
			this.lblSpecialTextFormInfo_2_Dmon.Size = new System.Drawing.Size(233, 26);
			this.lblSpecialTextFormInfo_2_Dmon.TabIndex = 1;
			this.lblSpecialTextFormInfo_2_Dmon.Text = "Choose color for highlight:";
			// 
			// btnSpecialTextForm_BrowseColorsDmon
			// 
			this.btnSpecialTextForm_BrowseColorsDmon.AutoSize = true;
			this.btnSpecialTextForm_BrowseColorsDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnSpecialTextForm_BrowseColorsDmon.FlatAppearance.BorderSize = 0;
			this.btnSpecialTextForm_BrowseColorsDmon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnSpecialTextForm_BrowseColorsDmon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.btnSpecialTextForm_BrowseColorsDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpecialTextForm_BrowseColorsDmon.Font = new System.Drawing.Font("Trebuchet MS", 12F);
			this.btnSpecialTextForm_BrowseColorsDmon.Location = new System.Drawing.Point(27, 129);
			this.btnSpecialTextForm_BrowseColorsDmon.Name = "btnSpecialTextForm_BrowseColorsDmon";
			this.btnSpecialTextForm_BrowseColorsDmon.Size = new System.Drawing.Size(229, 32);
			this.btnSpecialTextForm_BrowseColorsDmon.TabIndex = 2;
			this.btnSpecialTextForm_BrowseColorsDmon.Text = "Browse color...";
			this.btnSpecialTextForm_BrowseColorsDmon.UseVisualStyleBackColor = false;
			this.btnSpecialTextForm_BrowseColorsDmon.Click += new System.EventHandler(this.btnSpecialTextForm_BrowseColorsDmon_Click);
			// 
			// btnSpecialTextForm_SendDmon
			// 
			this.btnSpecialTextForm_SendDmon.AutoSize = true;
			this.btnSpecialTextForm_SendDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnSpecialTextForm_SendDmon.FlatAppearance.BorderSize = 0;
			this.btnSpecialTextForm_SendDmon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnSpecialTextForm_SendDmon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.btnSpecialTextForm_SendDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpecialTextForm_SendDmon.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.btnSpecialTextForm_SendDmon.Location = new System.Drawing.Point(146, 177);
			this.btnSpecialTextForm_SendDmon.Name = "btnSpecialTextForm_SendDmon";
			this.btnSpecialTextForm_SendDmon.Size = new System.Drawing.Size(110, 32);
			this.btnSpecialTextForm_SendDmon.TabIndex = 2;
			this.btnSpecialTextForm_SendDmon.Text = "Ok";
			this.btnSpecialTextForm_SendDmon.UseVisualStyleBackColor = false;
			this.btnSpecialTextForm_SendDmon.Click += new System.EventHandler(this.btnSpecialTextForm_SendDmon_Click);
			// 
			// cldSpecialTextForm_ColorDialogDmon
			// 
			this.cldSpecialTextForm_ColorDialogDmon.AnyColor = true;
			this.cldSpecialTextForm_ColorDialogDmon.Color = System.Drawing.Color.DeepSkyBlue;
			// 
			// btnSpecialTextForm_AbortDmon
			// 
			this.btnSpecialTextForm_AbortDmon.AutoSize = true;
			this.btnSpecialTextForm_AbortDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.btnSpecialTextForm_AbortDmon.FlatAppearance.BorderSize = 0;
			this.btnSpecialTextForm_AbortDmon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnSpecialTextForm_AbortDmon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
			this.btnSpecialTextForm_AbortDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpecialTextForm_AbortDmon.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.btnSpecialTextForm_AbortDmon.Location = new System.Drawing.Point(26, 177);
			this.btnSpecialTextForm_AbortDmon.Name = "btnSpecialTextForm_AbortDmon";
			this.btnSpecialTextForm_AbortDmon.Size = new System.Drawing.Size(110, 32);
			this.btnSpecialTextForm_AbortDmon.TabIndex = 2;
			this.btnSpecialTextForm_AbortDmon.Text = "Cancel";
			this.btnSpecialTextForm_AbortDmon.UseVisualStyleBackColor = false;
			this.btnSpecialTextForm_AbortDmon.Click += new System.EventHandler(this.btnSpecialTextForm_AbortDmon_Click);
			// 
			// frmAddSpecialTextDmon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.ClientSize = new System.Drawing.Size(284, 231);
			this.Controls.Add(this.btnSpecialTextForm_AbortDmon);
			this.Controls.Add(this.btnSpecialTextForm_SendDmon);
			this.Controls.Add(this.btnSpecialTextForm_BrowseColorsDmon);
			this.Controls.Add(this.lblSpecialTextFormInfo_2_Dmon);
			this.Controls.Add(this.lblSpecialTextFormInfo_1_Dmon);
			this.Controls.Add(this.txbSpecialTextDmon);
			this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmAddSpecialTextDmon";
			this.Text = "Adding New Special Text";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txbSpecialTextDmon;
		private System.Windows.Forms.Label lblSpecialTextFormInfo_1_Dmon;
		private System.Windows.Forms.Label lblSpecialTextFormInfo_2_Dmon;
		private System.Windows.Forms.Button btnSpecialTextForm_BrowseColorsDmon;
		private System.Windows.Forms.Button btnSpecialTextForm_SendDmon;
		private System.Windows.Forms.ColorDialog cldSpecialTextForm_ColorDialogDmon;
		private System.Windows.Forms.Button btnSpecialTextForm_AbortDmon;
	}
}