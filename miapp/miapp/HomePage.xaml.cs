﻿using System;
using System.Collections.Generic;

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
