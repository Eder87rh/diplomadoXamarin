using Xamarin.Forms;

namespace PruebaXamarinForms
{
	public partial class App : Application
	{
		//private MainPage _mainPage;
		//private ControlsPage _controlPage;
		private ContactsPage _contacsPage;

		public App()
		{
			//_mainPage = new MainPage();
			_contacsPage = new ContactsPage();

			InitializeComponent();

			MainPage = _contacsPage ;
		}

		protected override /*async*/ void OnStart()
		{
			//var client = new ResClient();
			//	var json = client.Serialize();

			//await MainPage.DisplayAlert("JSON: ", json, "Cancel");
			_contacsPage.Load();


		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
