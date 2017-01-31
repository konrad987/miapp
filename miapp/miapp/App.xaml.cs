using System;
using Xamarin.Forms;

namespace miapp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new HomePage())
			{
				
				//titulo = "Titulo 1",
				//mensaje = "Estamos en estado de catastrofe",
				//fecha = "2017, 02, 16, 21, 00, 00",
				//tipo = "Alarma"
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
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
