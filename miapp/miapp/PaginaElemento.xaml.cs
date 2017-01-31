using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace miapp
{
	public partial class PaginaElemento : ContentPage
	{
		public PaginaElemento(Elemento elemento)
		{
			InitializeComponent();
			BackgroundColor = Color.FromRgb(240,255,255);
			BindingContext = elemento;
		}
	}
}
