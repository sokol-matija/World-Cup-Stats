namespace WFA_World_Cup_Stats.Controls
{
	partial class RankingPlayerControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblName = new Label();
			lblCount = new Label();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(19, 7);
			lblName.Name = "lblName";
			lblName.Size = new Size(68, 30);
			lblName.TabIndex = 0;
			lblName.Text = "label1";
			// 
			// lblCount
			// 
			lblCount.AutoSize = true;
			lblCount.Location = new Point(19, 54);
			lblCount.Name = "lblCount";
			lblCount.Size = new Size(68, 30);
			lblCount.TabIndex = 1;
			lblCount.Text = "label2";
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(172, 7);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(96, 88);
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// RankingPlayerControl
			// 
			AutoScaleDimensions = new SizeF(12F, 30F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(pictureBox1);
			Controls.Add(lblCount);
			Controls.Add(lblName);
			Name = "RankingPlayerControl";
			Size = new Size(271, 98);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblName;
		private Label lblCount;
		private PictureBox pictureBox1;
	}
}
