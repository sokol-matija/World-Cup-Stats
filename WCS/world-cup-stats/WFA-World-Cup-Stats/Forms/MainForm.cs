using DataLayer.Factory;
using DataLayer.Interfaces;
using DataLayer.Managers;
using DataLayer.Models;
using DataLayer.Services;
using System.Globalization;
using WFA_World_Cup_Stats.Forms;

namespace WFA_World_Cup_Stats
{
	public partial class MainForm : Form
	{
		private  IDataProvider _dataProvider;
		private  ISettingsManager _settingsManager;
		private IFavoritesManager _favoritesManager;
		private IImageManager _imageManager;
		private DataLoader _dataLoader;
		private readonly LocalizationManager _localizationManager;
		private UIManager _uiManager;
		private ExceptionHandler _exceptionHandler;
		private Settings _settings;
		private bool _isInitialized = false;
		private SemaphoreSlim _initializationSemaphore = new SemaphoreSlim(1, 1);

		public MainForm()
		{
			InitializeComponent();
			LoggingService.Log("Application Starting");
			this.Enabled = false;
			Task.Run(() => InitializeAsync());
		}

		private async Task InitializeAsync()
		{
			await _initializationSemaphore.WaitAsync();
			try
			{
				if (_isInitialized) return;
				LoggingService.Log("Initialization started");

				_uiManager = new UIManager(this);
				await _uiManager.ShowLogFormAsync();

				_settingsManager = new SettingsManager();
				_settings = await _settingsManager.GetSettingsAsync();
				//TODO : Move this to UIManager
				//ApplyLocalization(_settings.Language);
				
				LoggingService.Log(_settings.Language);

				if (_settingsManager.IsFirstRun)
				{
					LoggingService.Log("First run detected");
					await _uiManager.ShowSettingsFormAsync(_settings);
					_settings = await _settingsManager.GetSettingsAsync();
				}

				_dataProvider = DataProviderFactory.CreateDataProvider(_settingsManager);
				_favoritesManager = new FavoritesManager(_settingsManager);
				_imageManager = new ImageManager();
				_dataLoader = new DataLoader(_dataProvider, _settingsManager, _favoritesManager,_uiManager);
				_exceptionHandler = new ExceptionHandler();

				await _dataLoader.LoadInitialDataAsync();

				_isInitialized = true;
				LoggingService.Log("MainForm initialized");

				await _uiManager.EnableUIAsync();
			}
			catch (Exception ex)
			{
				LoggingService.Log($"Initialization error: {ex.Message}");
				if (_uiManager != null)
				{
					await _uiManager.InvokeAsync(() => _exceptionHandler.HandleException("Initialization error", ex));
				}
				else
				{
					MessageBox.Show($"Critical initialization error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			finally
			{
				_initializationSemaphore.Release();
			}
		}

		private void ApplyLocalization(string language)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

			lblChooseTeam.Text = Strings.ChooseTeam;
			lblAllPlayers.Text = Strings.AllPlayers;
			lblFavoritePlayers.Text = Strings.FavoritePlayers;
			lblTopScorers.Text = Strings.TopScorers;
			lblYellowCards.Text = Strings.YellowCards;
			lblMatches.Text = Strings.Matches;
			btnMoveToFavorites.Text = Strings.MoveToFavorites;
			mnuSettings.Text = Strings.Settings;
			mnuPrint.Text = Strings.Print;
			mnuPrintStatistics.Text = Strings.PrintStatistics;

			LoggingService.Log($"Current UI Culture: {Thread.CurrentThread.CurrentUICulture.Name}");
		}

		private async void cmbTeams_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbTeams.SelectedItem is Team selectedTeam)
			{
				var settings = await _settingsManager.GetSettingsAsync();
				await _dataLoader.LoadPlayerDetailsAsync(selectedTeam.FifaCode, settings.Championship);
			}
		}

		private async void btnMoveToFavorites_Click(object sender, EventArgs e)
		{
			// Implement move to favorites logic
			await _uiManager.MoveToFavoritesAsync();
		}

		private async void mnuSettings_Click(object sender, EventArgs e)
		{
			if (await _uiManager.ShowSettingsFormAsync(_settings))
			{
				await _dataLoader.ApplySettingsAsync();
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = !_uiManager.ConfirmApplicationClose();
			}
			base.OnFormClosing(e);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				Close();
				return true;
			}
			else if (keyData == Keys.Escape)
			{
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}

}
