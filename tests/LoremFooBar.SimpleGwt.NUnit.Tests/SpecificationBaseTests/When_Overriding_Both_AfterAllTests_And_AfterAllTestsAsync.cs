using NUnit.Framework;

// ReSharper disable RedundantOverriddenMember
// ReSharper disable InconsistentNaming

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

[TestFixture]
public class When_Overriding_Both_AfterAllTests_And_AfterAllTestsAsync : ExceptionHandlingSpecificationBase
{
    protected override void AfterAllTests()
    {
        base.AfterAllTests();
    }

    protected override Task AfterAllTestsAsync() => base.AfterAllTestsAsync();

    [Then]
    public void It_Should_Throw_An_Exception()
    {
        Assert.AreEqual("Overriding both AfterAllTests and AfterAllTestsAsync is not allowed.", Exception.Message);
    }
}
