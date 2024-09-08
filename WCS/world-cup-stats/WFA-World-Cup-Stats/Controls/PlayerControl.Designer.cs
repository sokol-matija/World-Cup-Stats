namespace WFA_World_Cup_Stats.Controls
{
	partial class PlayerControl
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
			lblNumber = new Label();
			lblPosition = new Label();
			cbCaptain = new CheckBox();
			picFavorite = new PictureBox();
			picPlayer = new PictureBox();
			((System.ComponentModel.ISupportInitialize)picFavorite).BeginInit();
			((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
			SuspendLayout();
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(16, 29);
			lblName.Name = "lblName";
			lblName.Size = new Size(68, 30);
			lblName.TabIndex = 0;
			lblName.Text = "label1";
			// 
			// lblNumber
			// 
			lblNumber.AutoSize = true;
			lblNumber.Location = new Point(16, 59);
			lblNumber.Name = "lblNumber";
			lblNumber.Size = new Size(68, 30);
			lblNumber.TabIndex = 1;
			lblNumber.Text = "label2";
			// 
			// lblPosition
			// 
			lblPosition.AutoSize = true;
			lblPosition.Location = new Point(16, 89);
			lblPosition.Name = "lblPosition";
			lblPosition.Size = new Size(68, 30);
			lblPosition.TabIndex = 2;
			lblPosition.Text = "label3";
			// 
			// cbCaptain
			// 
			cbCaptain.AutoSize = true;
			cbCaptain.Location = new Point(16, 122);
			cbCaptain.Name = "cbCaptain";
			cbCaptain.Size = new Size(110, 34);
			cbCaptain.TabIndex = 3;
			cbCaptain.Text = "Captain";
			cbCaptain.UseVisualStyleBackColor = true;
			// 
			// picFavorite
			// 
			picFavorite.Location = new Point(147, 111);
			picFavorite.Name = "picFavorite";
			picFavorite.Size = new Size(55, 45);
			picFavorite.TabIndex = 4;
			picFavorite.TabStop = false;
			// 
			// picPlayer
			// 
			picPlayer.Location = new Point(208, 18);
			picPlayer.Name = "picPlayer";
			picPlayer.Size = new Size(138, 136);
			picPlayer.TabIndex = 5;
			picPlayer.TabStop = false;
			// 
			// PlayerControl
			// 
			AutoScaleDimensions = new SizeF(12F, 30F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(picPlayer);
			Controls.Add(picFavorite);
			Controls.Add(cbCaptain);
			Controls.Add(lblPosition);
			Controls.Add(lblNumber);
			Controls.Add(lblName);
			Name = "PlayerControl";
			Size = new Size(356, 166);
			((System.ComponentModel.ISupportInitialize)picFavorite).EndInit();
			((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblName;
		private Label lblNumber;
		private Label lblPosition;
		private CheckBox cbCaptain;
		private PictureBox picFavorite;
		private PictureBox picPlayer;
	}
}
