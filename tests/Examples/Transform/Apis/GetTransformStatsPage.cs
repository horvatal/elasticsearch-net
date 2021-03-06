using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Transform.Apis
{
	public class GetTransformStatsPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line104()
		{
			// tag::53c6256295111524d5ff2885bdcb99a9[]
			var response0 = new SearchResponse<object>();
			// end::53c6256295111524d5ff2885bdcb99a9[]

			response0.MatchesExample(@"GET _transform/_stats?from=5&size=10");
		}

		[U(Skip = "Example not implemented")]
		public void Line113()
		{
			// tag::5db14291fd57c9cd780c969ae26dfaba[]
			var response0 = new SearchResponse<object>();
			// end::5db14291fd57c9cd780c969ae26dfaba[]

			response0.MatchesExample(@"GET _transform/ecommerce_transform/_stats");
		}
	}
}