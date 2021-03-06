using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	[DataContract]
	public class BulkIndexByScrollFailure
	{
		[DataMember(Name = "cause")]
		public Error Cause { get; set; }

		[DataMember(Name = "id")]
		public string Id { get; internal set; }

		[DataMember(Name = "index")]
		public string Index { get; set; }

		[DataMember(Name = "status")]
		public int Status { get; set; }

		[DataMember(Name = "type")]
		public string Type { get; internal set; }
	}
}
