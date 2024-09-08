namespace WFA_World_Cup_Stats
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			menuStrip = new MenuStrip();
			mnuSettings = new ToolStripMenuItem();
			mnuPrint = new ToolStripMenuItem();
			mnuPrintStatistics = new ToolStripMenuItem();
			lblChooseTeam = new Label();
			cmbTeams = new ComboBox();
			lblAllPlayers = new Label();
			lblFavoritePlayers = new Label();
			lblTopScorers = new Label();
			lblYellowCards = new Label();
			lblMatches = new Label();
			pnlAllPlayers = new Panel();
			pnlFavoritePlayers = new Panel();
			pnlTopScorers = new Panel();
			pnlYellowCards = new Panel();
			pnlMatches = new Panel();
			printDialog = new PrintDialog();
			printDocument = new System.Drawing.Printing.PrintDocument();
			printPreviewDialog = new PrintPreviewDialog();
			btnMoveToFavorites = new Button();
			statusStrip = new StatusStrip();
			menuStrip.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip
			// 
			menuStrip.ImageScalingSize = new Size(28, 28);
			menuStrip.Items.AddRange(new ToolStripItem[] { mnuSettings, mnuPrint });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(1340, 38);
			menuStrip.TabIndex = 0;
			menuStrip.Text = "menuStrip1";
			// 
			// mnuSettings
			// 
			mnuSettings.Name = "mnuSettings";
			mnuSettings.Size = new Size(105, 34);
			mnuSettings.Text = "Settings";
			mnuSettings.Click += mnuSettings_Click;
			// 
			// mnuPrint
			// 
			mnuPrint.DropDownItems.AddRange(new ToolStripItem[] { mnuPrintStatistics });
			mnuPrint.Name = "mnuPrint";
			mnuPrint.Size = new Size(74, 34);
			mnuPrint.Text = "Print";
			// 
			// mnuPrintStatistics
			// 
			mnuPrintStatistics.Name = "mnuPrintStatistics";
			mnuPrintStatistics.Size = new Size(260, 40);
			mnuPrintStatistics.Text = "Print Statistics";
			// 
			// lblChooseTeam
			// 
			lblChooseTeam.AutoSize = true;
			lblChooseTeam.Location = new Point(27, 56);
			lblChooseTeam.Name = "lblChooseTeam";
			lblChooseTeam.Size = new Size(137, 30);
			lblChooseTeam.TabIndex = 1;
			lblChooseTeam.Text = "Choose Team";
			// 
			// cmbTeams
			// 
			cmbTeams.FormattingEnabled = true;
			cmbTeams.Location = new Point(27, 89);
			cmbTeams.Name = "cmbTeams";
			cmbTeams.Size = new Size(212, 38);
			cmbTeams.TabIndex = 2;
			// 
			// lblAllPlayers
			// 
			lblAllPlayers.AutoSize = true;
			lblAllPlayers.Location = new Point(27, 149);
			lblAllPlayers.Name = "lblAllPlayers";
			lblAllPlayers.Size = new Size(108, 30);
			lblAllPlayers.TabIndex = 3;
			lblAllPlayers.Text = "All Players";
			// 
			// lblFavoritePlayers
			// 
			lblFavoritePlayers.AutoSize = true;
			lblFavoritePlayers.Location = new Point(33, 448);
			lblFavoritePlayers.Name = "lblFavoritePlayers";
			lblFavoritePlayers.Size = new Size(156, 30);
			lblFavoritePlayers.TabIndex = 4;
			lblFavoritePlayers.Text = "Favorite Players";
			// 
			// lblTopScorers
			// 
			lblTopScorers.AutoSize = true;
			lblTopScorers.Location = new Point(406, 158);
			lblTopScorers.Name = "lblTopScorers";
			lblTopScorers.Size = new Size(119, 30);
			lblTopScorers.TabIndex = 5;
			lblTopScorers.Text = "Top Scorers";
			// 
			// lblYellowCards
			// 
			lblYellowCards.AutoSize = true;
			lblYellowCards.Location = new Point(406, 448);
			lblYellowCards.Name = "lblYellowCards";
			lblYellowCards.Size = new Size(129, 30);
			lblYellowCards.TabIndex = 6;
			lblYellowCards.Text = "Yellow Cards";
			// 
			// lblMatches
			// 
			lblMatches.AutoSize = true;
			lblMatches.Location = new Point(778, 149);
			lblMatches.Name = "lblMatches";
			lblMatches.Size = new Size(92, 30);
			lblMatches.TabIndex = 7;
			lblMatches.Text = "Matches";
			// 
			// pnlAllPlayers
			// 
			pnlAllPlayers.Location = new Point(33, 188);
			pnlAllPlayers.Name = "pnlAllPlayers";
			pnlAllPlayers.Size = new Size(343, 257);
			pnlAllPlayers.TabIndex = 8;
			// 
			// pnlFavoritePlayers
			// 
			pnlFavoritePlayers.Location = new Point(33, 481);
			pnlFavoritePlayers.Name = "pnlFavoritePlayers";
			pnlFavoritePlayers.Size = new Size(343, 257);
			pnlFavoritePlayers.TabIndex = 9;
			// 
			// pnlTopScorers
			// 
			pnlTopScorers.Location = new Point(406, 191);
			pnlTopScorers.Name = "pnlTopScorers";
			pnlTopScorers.Size = new Size(343, 257);
			pnlTopScorers.TabIndex = 9;
			// 
			// pnlYellowCards
			// 
			pnlYellowCards.Location = new Point(406, 481);
			pnlYellowCards.Name = "pnlYellowCards";
			pnlYellowCards.Size = new Size(343, 257);
			pnlYellowCards.TabIndex = 10;
			// 
			// pnlMatches
			// 
			pnlMatches.Location = new Point(778, 191);
			pnlMatches.Name = "pnlMatches";
			pnlMatches.Size = new Size(343, 547);
			pnlMatches.TabIndex = 11;
			// 
			// printDialog
			// 
			printDialog.UseEXDialog = true;
			// 
			// printPreviewDialog
			// 
			printPreviewDialog.AutoScrollMargin = new Size(0, 0);
			printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
			printPreviewDialog.ClientSize = new Size(400, 300);
			printPreviewDialog.Document = printDocument;
			printPreviewDialog.Enabled = true;
			printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
			printPreviewDialog.Name = "printPreviewDialog";
			printPreviewDialog.Visible = false;
			// 
			// btnMoveToFavorites
			// 
			btnMoveToFavorites.Location = new Point(155, 142);
			btnMoveToFavorites.Name = "btnMoveToFavorites";
			btnMoveToFavorites.Size = new Size(221, 40);
			btnMoveToFavorites.TabIndex = 12;
			btnMoveToFavorites.Text = "Move To Favorites";
			btnMoveToFavorites.UseVisualStyleBackColor = true;
			// 
			// statusStrip
			// 
			statusStrip.ImageScalingSize = new Size(28, 28);
			statusStrip.Location = new Point(0, 764);
			statusStrip.Name = "statusStrip";
			statusStrip.Size = new Size(1340, 22);
			statusStrip.TabIndex = 13;
			statusStrip.Text = "statusStrip1";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(12F, 30F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1340, 786);
			Controls.Add(statusStrip);
			Controls.Add(btnMoveToFavorites);
			Controls.Add(pnlMatches);
			Controls.Add(pnlYellowCards);
			Controls.Add(pnlTopScorers);
			Controls.Add(pnlFavoritePlayers);
			Controls.Add(pnlAllPlayers);
			Controls.Add(lblMatches);
			Controls.Add(lblYellowCards);
			Controls.Add(lblTopScorers);
			Controls.Add(lblFavoritePlayers);
			Controls.Add(lblAllPlayers);
			Controls.Add(cmbTeams);
			Controls.Add(lblChooseTeam);
			Controls.Add(menuStrip);
			MainMenuStrip = menuStrip;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "World Cup Statistics";
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public MenuStrip menuStrip;
		public ToolStripMenuItem mnuSettings;
		public ToolStripMenuItem mnuPrint;
		public ToolStripMenuItem mnuPrintStatistics;
		public Label lblChooseTeam;
		public ComboBox cmbTeams;
		public Label lblAllPlayers;
		public Label lblFavoritePlayers;
		public Label lblTopScorers;
		public Label lblYellowCards;
		public Label lblMatches;
		public Panel pnlAllPlayers;
		public Panel pnlFavoritePlayers;
		public Panel pnlTopScorers;
		public Panel pnlYellowCards;
		public Panel pnlMatches;
		public PrintDialog printDialog;
		public System.Drawing.Printing.PrintDocument printDocument;
		public PrintPreviewDialog printPreviewDialog;
		public Button btnMoveToFavorites;
		private StatusStrip statusStrip;
	}
}
