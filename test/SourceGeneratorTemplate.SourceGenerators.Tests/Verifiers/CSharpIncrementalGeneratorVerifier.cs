using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Testing;
using Microsoft.CodeAnalysis.Testing.Verifiers;
using RoseLynn.Testing;
using System.Collections.Generic;

namespace SourceGeneratorTemplate.SourceGenerators.Tests.Verifiers;

public static class CSharpIncrementalGeneratorVerifier<TSourceGenerator>
    where TSourceGenerator : IIncrementalGenerator, new()
{
    public class Test : CSharpIncrementalGeneratorTestEx<TSourceGenerator, NUnitVerifier>
    {
        public override IEnumerable<MetadataReference> AdditionalReferences => MyGeneratorMetadataReferences.BaseReferences;

        public Test()
        {
            ReferenceAssemblies = ReferenceAssemblies.Net.Net60;
        }
    }
}
