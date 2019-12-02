using NUnit.Framework;

namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

[TestFixture]
public abstract class ExceptionHandlingSpecificationBase : SpecificationBase
{
    public override async Task TestFixtureSetUp()
    {
        try {
            await base.TestFixtureSetUp();
        }
        catch (Exception ex) {
            Exception = ex;
        }
    }

    protected Exception Exception;
}
