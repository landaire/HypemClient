using System;
using Xamarin.Forms;
using Hype.HypeApi;
using System.Linq;

namespace HypemClient
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			User lander = new User("landaire");
			Song[] favorites = lander.Favorites (1, 20);

			favorites = favorites.Where((favorite) => { return favorite.Title.StartsWith("S"); }).ToArray();

			var listView = new ListView {
				ItemsSource = favorites,
				ItemTemplate = new DataTemplate(typeof(TextCell)),
			};

			listView.ItemTemplate.SetBinding (TextCell.TextProperty, "Title");
				
			return new ContentPage { 
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.FillAndExpand,
					Children = { listView },
				},
			};
		}
	}
}

