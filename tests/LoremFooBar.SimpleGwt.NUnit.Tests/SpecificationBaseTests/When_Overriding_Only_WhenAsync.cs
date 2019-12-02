using NUnit.Framework;

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

[TestFixture]
public class When_Overriding_Only_When : SpecificationBase
{
    // ReSharper disable once RedundantOverriddenMember
    protected override void When()
    {
        base.When();
    }

    [Then]
    public void It_Should_Run_Test()
    {
        Assert.Pass();
    }
}
