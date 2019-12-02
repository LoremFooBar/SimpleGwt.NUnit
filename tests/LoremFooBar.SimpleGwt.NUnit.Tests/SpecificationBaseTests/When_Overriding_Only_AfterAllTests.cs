using NUnit.Framework;

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

[TestFixture]
public class When_Overriding_Only_AfterAllTests : SpecificationBase
{
    // ReSharper disable once RedundantOverriddenMember
    protected override void AfterAllTests()
    {
        base.AfterAllTests();
    }

    [Then]
    public void It_Should_Run_Test()
    {
        Assert.Pass();
    }
}
