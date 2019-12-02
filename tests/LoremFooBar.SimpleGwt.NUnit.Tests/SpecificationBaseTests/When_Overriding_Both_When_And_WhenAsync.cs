using NUnit.Framework;

// ReSharper disable RedundantOverriddenMember
// ReSharper disable InconsistentNaming

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

[TestFixture]
public class When_Overriding_Both_When_And_WhenAsync : ExceptionHandlingSpecificationBase
{
    protected override void When()
    {
        base.When();
    }

    protected override Task WhenAsync() => base.WhenAsync();

    [Then]
    public void It_Should_Throw_An_Exception()
    {
        Assert.AreEqual("Overriding both When and WhenAsync is not allowed.", Exception.Message);
    }
}
