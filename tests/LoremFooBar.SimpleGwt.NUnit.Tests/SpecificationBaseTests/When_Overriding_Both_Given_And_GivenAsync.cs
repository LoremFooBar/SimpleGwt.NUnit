using NUnit.Framework;

// ReSharper disable RedundantOverriddenMember
// ReSharper disable InconsistentNaming

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

[TestFixture]
public class When_Overriding_Both_Given_And_GivenAsync : ExceptionHandlingSpecificationBase
{
    protected override void Given()
    {
        base.Given();
    }

    protected override Task GivenAsync() => base.GivenAsync();

    [Then]
    public void It_Should_Throw_An_Exception()
    {
        Assert.AreEqual("Overriding both Given and GivenAsync is not allowed.", Exception.Message);
    }
}
