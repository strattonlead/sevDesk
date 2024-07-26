using System.Collections.Generic;

namespace SevDesk.Api.V2.Security
{
	public class AccessTokenProviderOptions
	{
		public List<string> AllowedHosts { get; set; } = new List<string>();
		public string ApiKey { get; set; }
		public string BaseUrl { get; set; }
	}
}
