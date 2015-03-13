using System;
using Xamarin.Forms;

namespace Actividad4
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			//Se crea un inicializador de objeto
			return new ContentPage { 
				Content = new Label {
					//Se modifican sus propiedades
					//Texto
					Text = "Cámbiame",
					//Alineación vertical (VerticalOptions). Para la alineación horizontal, usar HorizontalOptions
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.StartAndExpand,
					//Color de Fondo
					BackgroundColor = Color.Black,
					//Color de Texto
					TextColor = Color.Blue
				},
			};
		}
	}
}
