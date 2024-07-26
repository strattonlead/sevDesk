# sevDesk API V2.0.0

Provided by createIF Labs GmbH.
https://createif-labs.de

# Usage with Dependency Injection

## Add services to your service provider. Usually you do this in your Program.cs
```
var services = new ServiceCollection();
services.AddSevDeskClient(options => options
    .UseApiKey("your api key"));
var serviceProvider = services.BuildServiceProvider();

# Generate or update your own client

kiota generate -l CSharp -c SevDeskClient -n sevDesk.Api.V2 -d ./sevDesk.Api.V2/openapi.yaml -o ./sevDesk.Api.V2