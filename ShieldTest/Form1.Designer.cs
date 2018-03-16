namespace ShieldTest
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.GameTimer = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelPaused = new System.Windows.Forms.Label();
			this.labelHelp = new System.Windows.Forms.Label();
			this.Missile = new System.Windows.Forms.PictureBox();
			this.tank = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Missile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tank)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// GameTimer
			// 
			this.GameTimer.Enabled = true;
			this.GameTimer.Interval = 20;
			this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(762, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = " ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 514);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(802, 512);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Diffic: ";
			// 
			// labelPaused
			// 
			this.labelPaused.AutoSize = true;
			this.labelPaused.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPaused.Location = new System.Drawing.Point(309, 241);
			this.labelPaused.Name = "labelPaused";
			this.labelPaused.Size = new System.Drawing.Size(236, 33);
			this.labelPaused.TabIndex = 20;
			this.labelPaused.Text = "Hit \'P\' to resume ";
			// 
			// labelHelp
			// 
			this.labelHelp.AutoSize = true;
			this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHelp.Location = new System.Drawing.Point(300, 287);
			this.labelHelp.Name = "labelHelp";
			this.labelHelp.Size = new System.Drawing.Size(235, 33);
			this.labelHelp.TabIndex = 21;
			this.labelHelp.Text = "Hit \'H\' to get help";
			// 
			// Missile
			// 
			this.Missile.Image = global::ShieldTest.Properties.Resources.Bullet;
			this.Missile.Location = new System.Drawing.Point(875, 530);
			this.Missile.Name = "Missile";
			this.Missile.Size = new System.Drawing.Size(50, 50);
			this.Missile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Missile.TabIndex = 17;
			this.Missile.TabStop = false;
			this.Missile.Tag = "Missile";
			this.Missile.Visible = false;
			// 
			// tank
			// 
			this.tank.Image = global::ShieldTest.Properties.Resources.Tank;
			this.tank.Location = new System.Drawing.Point(375, 475);
			this.tank.Name = "tank";
			this.tank.Size = new System.Drawing.Size(50, 50);
			this.tank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tank.TabIndex = 16;
			this.tank.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = global::ShieldTest.Properties.Resources.Invader_2;
			this.pictureBox12.Location = new System.Drawing.Point(623, 43);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(52, 40);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox12.TabIndex = 14;
			this.pictureBox12.TabStop = false;
			this.pictureBox12.Tag = "Invader";
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(565, 43);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(52, 40);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 13;
			this.pictureBox9.TabStop = false;
			this.pictureBox9.Tag = "Invader";
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = global::ShieldTest.Properties.Resources.Invader_2;
			this.pictureBox10.Location = new System.Drawing.Point(507, 43);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(52, 40);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox10.TabIndex = 12;
			this.pictureBox10.TabStop = false;
			this.pictureBox10.Tag = "Invader";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = global::ShieldTest.Properties.Resources.Invader_2;
			this.pictureBox7.Location = new System.Drawing.Point(449, 43);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(52, 40);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 11;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Tag = "Invader";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(391, 43);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(52, 40);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 10;
			this.pictureBox8.TabStop = false;
			this.pictureBox8.Tag = "Invader";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(333, 43);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(52, 40);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 9;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Tag = "Invader";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::ShieldTest.Properties.Resources.Invader_2;
			this.pictureBox6.Location = new System.Drawing.Point(275, 43);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(52, 40);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 8;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Tag = "Invader";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::ShieldTest.Properties.Resources.Invader_2;
			this.pictureBox3.Location = new System.Drawing.Point(217, 43);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(52, 40);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "Invader";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(159, 43);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(52, 40);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Tag = "Invader";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::ShieldTest.Properties.Resources.Invader_2;
			this.pictureBox2.Location = new System.Drawing.Point(101, 43);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(52, 40);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "Invader";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(884, 536);
			this.Controls.Add(this.labelHelp);
			this.Controls.Add(this.labelPaused);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Missile);
			this.Controls.Add(this.tank);
			this.Controls.Add(this.pictureBox12);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alex\'s Space Invaders ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
			((System.ComponentModel.ISupportInitialize)(this.Missile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tank)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox tank;
		private System.Windows.Forms.PictureBox Missile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelPaused;
		private System.Windows.Forms.Label labelHelp;
	}
}

