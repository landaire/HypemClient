using System;
using System.Net;

namespace Hype
{
	public class User
	{
		public User(string username)
		{
			Name = username;
		}

		public string Name { get; private set; }

		public Song[] Favorites(int page, int count)
		{
			HttpWebResponse response = ApiClient.MakeRequest(String.Format("/users/{0}/favorites?page={1}&count={2}&key=swagger", Name, page, count));

			using (var stream = response.GetResponseStream) {

			}
		}
	}
}

