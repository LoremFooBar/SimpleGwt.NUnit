using NUnit.Framework;

// ReSharper disable RedundantOverriddenMember
// ReSharper disable InconsistentNaming

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

public class When_Overriding_Both_CleanUp_And_CleanUpAsync : ExceptionHandlingSpecificationBase
{
    protected override void CleanUp()
    {
        base.CleanUp();
    }

    protected override Task CleanUpAsync() => base.CleanUpAsync();

    [Then]
    public void It_Should_Throw_An_Exception()
    {
        Assert.AreEqual("Overriding both CleanUp and CleanUpAsync is not allowed.", Exception.Message);
    }
}
