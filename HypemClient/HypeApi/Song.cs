using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Hype.HypeApi
{
	[DataContract]
	public class Song
	{
		[DataMember(Name="itemid")]
		public string ItemID { get; internal set; }

		[DataMember(Name="artist")]
		public string Artist { get; internal set; }

		[DataMember(Name="title")]
		public string Title { get; internal set; }
	}
}

