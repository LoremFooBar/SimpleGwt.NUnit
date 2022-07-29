using Microsoft.CodeAnalysis;

namespace LoremFooBar.SimpleGwt.NUnit.SourceGenerator;

/// <inheritdoc />
/// <summary>
/// Generate a `[Then]` attribute
/// </summary>
/// <remarks>
/// ThenAttribute is being source-generated because we prefer to alias TestAttribute with `global using` on net6.0,
/// but global usings apply only to the unit it is defined in (i.e. it is not transitive).
/// </remarks>
[Generator]
public class ThenGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
        // no initialization required
    }

    public void Execute(GeneratorExecutionContext context)
    {
        // language=c#
        const string source = @"#if NET6_0_OR_GREATER
global using ThenAttribute = NUnit.Framework.TestAttribute;
#else
using NUnit.Framework;

namespace LoremFooBar.SimpleGwt.NUnit;

public class ThenAttribute : TestAttribute { }
#endif";
        context.AddSource("ThenAttribute.g.cs", source);
    }
}
