using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetBrowser.Engine;
using DotNetBrowser.Browser;

namespace ESRI.ArcGIS.Mapping.OfficeIntegration.Core
{
	public partial class Form1 : Form
	{
		const string defaultPort = "4500";
		static string AppDataFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
		IEngine Engine;
		IBrowser browser;

		public Form1()
		{
			InitializeDotNetBrowser(defaultPort);
			InitializeComponent();
			textBoxPort.Text = defaultPort;
			textBoxPort.SelectionStart = 0;
		}

		public bool InitializeDotNetBrowser(string port)
		{
			Engine = createEngine(string.Format("{0}\\{1}", AppDataFolder, @"DotNetBrowserDebugger\cache"));
			Task.Run(() =>
				Engine.CreateBrowser()
			).ContinueWith(t =>
			{
				browser = t.Result;
				browserView1.InitializeFrom(browser);
				browser.Navigation.LoadUrl(string.Format("{0}:{1}", @"http://localhost", port));
			}, TaskScheduler.FromCurrentSynchronizationContext());

			return true;
		}

		public static IEngine createEngine(string userdatadir)
		{
			IEngine engine = EngineFactory.Create(new EngineOptions.Builder
			{
				RenderingMode = RenderingMode.HardwareAccelerated,
				ChromiumDirectory = string.Format("{0}\\{1}", AppDataFolder, @"DotNetBrowserDebugger\binaries"),
				UserDataDirectory = userdatadir
			}
			.Build());
			return engine;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Engine?.Dispose();
			browser?.Dispose();
		}

		private void buttonStart_Click(object sender, System.EventArgs e)
		{
			if (textBoxPort.Text.Equals("")) return;
			int x = 0;
			if (int.TryParse(textBoxPort.Text, out x))
			{
				buttonStart.Visible = false;
				textBoxPort.Visible = false;
				labelPort.Visible = false;
				Form1_FormClosing(null, null);
				InitializeDotNetBrowser(textBoxPort.Text);
			}
		}
	}
}
