using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace miapp
{
	public class Elemento 
	{
		public string titulo { get; set;}
		public string mensaje { get; set;}
		public DateTime fecha { get; set;}
		public string tipo { get; set;}

		public override string ToString()
		{
			return string.Format(tipo);
		}
 	}
}

