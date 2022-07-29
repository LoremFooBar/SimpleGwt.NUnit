using NUnit.Framework;

// ReSharper disable RedundantOverriddenMember
// ReSharper disable InconsistentNaming

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

public class When_Overriding_Only_WhenAsync : SpecificationBase
{
    protected override Task WhenAsync() => base.WhenAsync();

    [Then]
    public void It_Should_Run_Test()
    {
        Assert.Pass();
    }
}
