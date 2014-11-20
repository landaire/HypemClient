using System;
using System.Net;
using System.Threading.Tasks;

namespace Hype.HypeApi
{
	public static class ApiClient
	{
		const string api = "https://api.hypem.com/v2";

		public static string Token { get; set; }

		public static HttpWebResponse MakeRequest(string endpoint)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api + endpoint);
			request.Method = "GET";

			return (HttpWebResponse)request.GetResponse();
		}
	}
}

