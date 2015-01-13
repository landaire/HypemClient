using System;
using Xamarin.Forms;

namespace HypemClient 
{
	public class SongCell : ViewCell
	{
		public SongCell ()
		{
			var image = new Image {
				HorizontalOptions = LayoutOptions.Start,
			};
			image.SetBinding (Image.SourceProperty, new Binding ("ImageUri"));
		}
	}
}

