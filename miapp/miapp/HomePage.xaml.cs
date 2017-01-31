using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace miapp
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
			verAvisos.Clicked += (sender, e) =>
			{
				Navigation.PushAsync(new PaginaListaElementos());
			};
		}
	}
}
