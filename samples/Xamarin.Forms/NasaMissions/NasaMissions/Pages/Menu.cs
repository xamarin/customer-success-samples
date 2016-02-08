using System;
using Xamarin.Forms;

namespace NasaMissions
{
	public class Menu : ContentPage
	{
		public Menu ()
		{

			Content = new TableView () {
				BackgroundColor = Color.Black,

				Intent = TableIntent.Form,
				Root = new TableRoot () {
					new TableSection ("") 
					{						
						new KeyValueCell ("Xamarin.Forms", "Nasa Planet Sample"),
					},				
					new TableSection ("Deep Space") 
					{						
						
						new ImageCell () 
						{
							Text = "Voyager",
							TextColor = Color.White,
							DetailColor = Color.Blue,
							Detail = "Launched 10/24/2005",
							ImageSource = new FileImageSource () { File = "Location.png"  },
						},
						new ImageCell () 
						{
							Text = "New Horizons",
							TextColor = Color.White,
							Detail = "Launched 10/24/2005",
							DetailColor = Color.Gray,
							ImageSource = new FileImageSource () { File = "Location.png"  },
						},
							
					},
					new TableSection("Planets")
					{
						
						new ImageCell() 
						{
							Text = "Mercury",
							Detail = "Detail",
							TextColor = Color.White,

							ImageSource = new FileImageSource () { File = @"Planet100.png"}, 

						},
						new ImageCell() 
						{
							Text = "Venus",
							Detail = "Detail",
							TextColor = Color.White,
							ImageSource = new FileImageSource () { File = "Planet100.png"}, 

						},
						new ImageCell() 
						{
							Text = "Earth",
							Detail = "Detail",
							TextColor = Color.White,
							ImageSource = new FileImageSource () { File = "Planet100.png"}, 

						},
						new ImageCell() 
						{
							Text = "Mars",
							Detail = "Detail",
							TextColor = Color.White,
							ImageSource = new FileImageSource () { File = "Planet100.png"}, 

						},
						new ImageCell() 
						{
							Text = "Jupiter",
							Detail = "Detail",
							TextColor = Color.White,
							ImageSource = new FileImageSource () { File = "Planet100.png"}, 

						},
						new ImageCell() 
						{
							Text = "Saturn",
							Detail = "Detail",
							TextColor = Color.White,
							ImageSource = new FileImageSource () { File = "Planet100.png"}, 

						},
						new ImageCell() 
						{
							Text = "Uranus",
							Detail = "Detail",
							TextColor = Color.White,
							ImageSource = new FileImageSource () { File = "Planet100.png"}, 

						},
						new ImageCell() 
						{
							Text = "Neptune",
							Detail = "Detail",
							TextColor = Color.White,
							ImageSource = new FileImageSource () { File = "Planet100.png"}, 

						},
							
					}




				}


			};
					

		}
	}
}