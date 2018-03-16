namespace ShieldTest
{
	partial class HelpMe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpMe));
			this.btnReturn = new System.Windows.Forms.Button();
			this.lblInformation = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnReturn
			// 
			this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
			this.btnReturn.Location = new System.Drawing.Point(472, 459);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(108, 63);
			this.btnReturn.TabIndex = 0;
			this.btnReturn.Text = "Return to game";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// lblInformation
			// 
			this.lblInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblInformation.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInformation.Location = new System.Drawing.Point(71, 110);
			this.lblInformation.Name = "lblInformation";
			this.lblInformation.Size = new System.Drawing.Size(461, 295);
			this.lblInformation.TabIndex = 1;
			this.lblInformation.Text = resources.GetString("lblInformation.Text");
			// 
			// HelpMe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(592, 534);
			this.Controls.Add(this.lblInformation);
			this.Controls.Add(this.btnReturn);
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "HelpMe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HelpMe";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HelpMe_FormClosing);
			this.Load += new System.EventHandler(this.HelpMe_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Label lblInformation;
	}
}