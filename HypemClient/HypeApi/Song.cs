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

		[DataMember(Name="thumb_url")]
		public string ThumbnailUrlSmall { get; internal set; }

		[DataMember(Name="thumb_url_medium")]
		public string ThumbnailUrlMedium { get; internal set;}

		[DataMember(Name="thumb_url_large")]
		public string ThumbnailUrlLarge { get; internal set; }

		public 
	}
}

