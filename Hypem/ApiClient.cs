using System;
using System.Net;

namespace Hype
{
	public static class ApiClient
	{
		const string api = "https://api.hypem.com/v2";

		public static string Token { get; set; }

		public async static HttpWebResponse MakeRequest(string endpoint)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api + endpoint);
			request.Method = "GET";

			return await request.BeginGetResponse();
		}
	}
}

