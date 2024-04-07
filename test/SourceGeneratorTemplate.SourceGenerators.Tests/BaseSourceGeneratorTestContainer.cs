using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Testing.Verifiers;
using RoseLynn.Testing;
using SourceGeneratorTemplate.SourceGenerators.Tests.Verifiers;
using System.Collections.Generic;

namespace SourceGeneratorTemplate.SourceGenerators.Tests;

public abstract class BaseSourceGeneratorTestContainer<TSourceGenerator>
    : BaseSourceGeneratorTestContainer<TSourceGenerator, NUnitVerifier, CSharpSourceGeneratorVerifier<TSourceGenerator>.Test>

    where TSourceGenerator : ISourceGenerator, new()
{
    protected override IEnumerable<MetadataReference> DefaultMetadataReferences => MyGeneratorMetadataReferences.BaseReferences;

    protected override LanguageVersion LanguageVersion => LanguageVersion.CSharp12;
}
