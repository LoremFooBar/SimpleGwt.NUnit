using NUnit.Framework;

// ReSharper disable RedundantOverriddenMember
// ReSharper disable InconsistentNaming

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

[TestFixture]
public class When_Overriding_Only_AfterAllTestsAsync : SpecificationBase
{
    protected override Task AfterAllTestsAsync() => base.AfterAllTestsAsync();

    [Then]
    public void It_Should_Run_Test()
    {
        Assert.Pass();
    }
}
