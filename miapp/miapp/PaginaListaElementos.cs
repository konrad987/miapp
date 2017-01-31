using System;
using System.Linq;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace miapp
{
	public class PaginaListaElementos : MasterDetailPage
	{
		public PaginaListaElementos()
		{
			var lista = new ListView();
			lista.ItemsSource = GeneradorDeMensajes.creaElementos();

			lista.ItemSelected += (sender, e) =>
			{
				if (e.SelectedItem != null)
				{
					Detail = new PaginaElemento(e.SelectedItem as Elemento);
					IsPresented = false;
				}
			};

			Master = new ContentPage
			{
				Title = "Categorias",
				Content = lista
			};

			Detail = new PaginaElemento(GeneradorDeMensajes.creaElementos().First());

		}
	}
}

