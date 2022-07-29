using NUnit.Framework;

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

public class When_Overriding_Only_Given : SpecificationBase
{
    // ReSharper disable once RedundantOverriddenMember
    protected override void Given()
    {
        base.Given();
    }

    [Then]
    public void It_Should_Run_Test()
    {
        Assert.Pass();
    }
}
