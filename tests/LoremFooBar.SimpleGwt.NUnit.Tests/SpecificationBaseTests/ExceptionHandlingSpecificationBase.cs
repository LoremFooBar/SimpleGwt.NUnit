namespace LoremFooBar.SimpleGwt.NUnit.Tests.SpecificationBaseTests;

public abstract class ExceptionHandlingSpecificationBase : SpecificationBase
{
    protected Exception Exception;

    public override async Task TestFixtureSetUp()
    {
        try {
            await base.TestFixtureSetUp();
        }
        catch (Exception ex) {
            Exception = ex;
        }
    }
}
