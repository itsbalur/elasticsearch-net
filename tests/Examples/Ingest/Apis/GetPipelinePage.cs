using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Ingest.Apis
{
	public class GetPipelinePage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("ingest/apis/get-pipeline.asciidoc:30")]
		public void Line30()
		{
			// tag::6a3a86ff58e5f20950d429cf2832c229[]
			var response0 = new SearchResponse<object>();
			// end::6a3a86ff58e5f20950d429cf2832c229[]

			response0.MatchesExample(@"GET /_ingest/pipeline/my-pipeline-id");
		}

		[U(Skip = "Example not implemented")]
		[Description("ingest/apis/get-pipeline.asciidoc:107")]
		public void Line107()
		{
			// tag::9f549bb400b6cc1523b00d60bc8fd8e1[]
			var response0 = new SearchResponse<object>();
			// end::9f549bb400b6cc1523b00d60bc8fd8e1[]

			response0.MatchesExample(@"GET /_ingest/pipeline/my-pipeline-id?filter_path=*.version");
		}
	}
}