using Soenneker.Tests.HostedUnit;

namespace Soenneker.Context7.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class Context7OpenApiClientRunnerTests : HostedUnitTest
{
    public Context7OpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
