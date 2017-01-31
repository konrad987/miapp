using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace miapp
{
	class GeneradorDeMensajes
	{
		private static List<string> ListaTitulos = new List<string>
		{
			"Ana Tijoux", "Coco Legrand", "Cueca Nacional", "Teatro a $1000"
		};

		private static List<string> ListaMensajes = new List<string>
		{
			"Esta semana en San Clemente, a disfrutar del mejor espetaculo del 2017, invita a Usted la Ilustre Municipalidad de San Clemente",
			"Durante el mes de Abril se presentarán en la plaza de San Clemente uno de los mejores exponentes de su genero, ven a disfrutar",
		};

		private static List<DateTime> ListaFechas = new List<DateTime>
		{
			new DateTime(2017, 02, 14, 20, 00, 00),
			new DateTime(2017, 02, 15, 19, 00, 00),
			new DateTime(2017, 02, 16, 21, 00, 00)
		};

		private static List<string> ListaTipos = new List<string>
		{
			"Música", "Bailes", "Teatro"
		};

		public static ObservableCollection<Elemento> creaElementos()
		{
			var random = new Random();
			var avisos = new ObservableCollection<Elemento>();
			for (int i = 0; i < 10; i++)
			{
				var tituloAviso = ListaTitulos[random.Next(ListaTitulos.Count - 1)];
				var mensajeAviso = ListaMensajes[random.Next(ListaMensajes.Count - 1)];
				var fechaAviso = ListaFechas[random.Next(ListaFechas.Count - 1)];
				var tipoAviso = ListaTipos[random.Next(ListaTipos.Count - 1)];

				var elemento = new Elemento
				{
					titulo = tituloAviso + " :" + mensajeAviso,
					fecha = fechaAviso,
					tipo = "Categoría: " + tipoAviso
				};

				avisos.Add(elemento);
			}
			return avisos;
		}

	}
}

