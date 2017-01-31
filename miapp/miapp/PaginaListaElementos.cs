using System;
using System.Linq;
using Xamarin.Forms;

namespace miapp
{
	public class PaginaListaElementos : MasterDetailPage
	{
		public PaginaListaElementos()
		{
			var lista = new ListView();
			lista.ItemsSource = GeneradorDeMensajes.creaElementos();

			Master = new ContentPage
			{
				Title = "Categorias",
				Content = lista
			};

			Detail = new PaginaElemento(GeneradorDeMensajes.creaElementos().First());

		}
	}
}

