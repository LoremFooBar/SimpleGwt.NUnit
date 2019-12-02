using NUnit.Framework;

// ReSharper disable RedundantOverriddenMember
// ReSharper disable InconsistentNaming

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

[TestFixture]
public class When_Overriding_Both_BeforeAllTests_And_BeforeAllTestsAsync : ExceptionHandlingSpecificationBase
{
    protected override void BeforeAllTests()
    {
        base.BeforeAllTests();
    }

    protected override Task BeforeAllTestsAsync() => base.BeforeAllTestsAsync();

    [Then]
    public void It_Should_Throw_An_Exception()
    {
        Assert.AreEqual("Overriding both BeforeAllTests and BeforeAllTestsAsync is not allowed.",
            Exception.Message);
    }
}
