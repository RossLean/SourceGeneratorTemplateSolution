using NUnit.Framework;
using RoseLynn.Generators;
using System.Threading.Tasks;

namespace SourceGeneratorTemplate.SourceGenerators.Tests;

public sealed class MySourceGeneratorTests
    : BaseIncrementalGeneratorTestContainer<MySourceGenerator>
{
    [Theory]
    [TestCase(TypeDeclarationKinds.Class, TypeDeclarationKinds.Class)]
    public async Task BaseTheoryExampleTest(
        string sourceTypeKind,
        string generatedTypeKind)
    {
        const string @namespace = "SourceGeneratorTemplate.SourceGenerators.Tests.Input";
        const string @class = "ExampleClassName";

        var source = $$"""
            using SourceGeneratorTemplate;
            using System;

            namespace {{@namespace}};

            public sealed partial {{sourceTypeKind}} {{@class}}
            {
            }
            """;

        var expected = $$"""
            using SourceGeneratorTemplate;
            using System;
            using System.Data;

            namespace {{@namespace}}
            {
                partial {{generatedTypeKind}} {{@class}}
                {
                }
            }

            """;

        var mappings = new GeneratedSourceMappings
        {
            { $"{@namespace}.{@class}.Boilerplate.g.cs", expected }
        };

        await VerifyAsync(source, mappings);
    }
}
