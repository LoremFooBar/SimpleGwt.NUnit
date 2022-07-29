using NUnit.Framework;

// ReSharper disable RedundantOverriddenMember
// ReSharper disable InconsistentNaming

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

public class When_Overriding_Only_BeforeAllTestsAsync : SpecificationBase
{
    protected override Task BeforeAllTestsAsync() => base.BeforeAllTestsAsync();

    [Then]
    public void It_Should_Run_Test()
    {
        Assert.Pass();
    }
}
