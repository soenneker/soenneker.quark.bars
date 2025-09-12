using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Bars.Tests;

[Collection("Collection")]
public sealed class BarTests : FixturedUnitTest
{
    public BarTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}