using System;
using Xamarin.Forms;

namespace Actividad8
{
	public class Contenido: ContentPage
	{
		public Contenido ()
		{
			Label texto = new Label {
				Text = "Contenido",
				TextColor = Color.Green
			};

			Button boton = new Button
			{
				Text = "Click para navegar al Login"
			};

			boton.Clicked += (sender, e) => {
				this.Navigation.PushAsync(new Login());
			};

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					texto,
					boton
				}
				};


			//Como esta clase hereda de ContentPage, podemos usar estas propiedades directamente
			this.Content = stackLayout;
			this.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);
		}
	}
}
