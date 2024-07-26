using System;

namespace sevDesk.Api
{
	public class SevDeskServiceOptions
	{
		public string Token { get; set; }
		public string SourceCountry { get; set; } = "de";

		public Type TokenProviderType { get; set; }
	}
}
