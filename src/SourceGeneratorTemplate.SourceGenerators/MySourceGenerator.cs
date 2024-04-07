using Microsoft.CodeAnalysis;

#nullable enable annotations

namespace SourceGeneratorTemplate.SourceGenerators;

[Generator(LanguageNames.CSharp)]
public sealed class MySourceGenerator : IIncrementalGenerator
{
    void IIncrementalGenerator.Initialize(IncrementalGeneratorInitializationContext context)
    {
    }
}
