using System;
using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Hype.HypeApi
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

			using (var stream = new System.IO.StreamReader(response.GetResponseStream())) {
				string json = stream.ReadToEnd ();
				Console.WriteLine (json);
//				var songs = JObject.Parse (json);
				return JsonConvert.DeserializeObject<Song[]> (json);
			}
		}
	}
}

