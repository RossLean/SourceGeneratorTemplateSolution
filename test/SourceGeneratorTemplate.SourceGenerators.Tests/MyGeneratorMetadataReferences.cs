using Microsoft.CodeAnalysis;
using RoseLynn;
using System.Collections.Immutable;

namespace SourceGeneratorTemplate.SourceGenerators.Tests;

public static class MyGeneratorMetadataReferences
{
    public static readonly ImmutableArray<MetadataReference> BaseReferences;

    static MyGeneratorMetadataReferences()
    {
        BaseReferences = [
            MetadataReferenceFactory.CreateFromType<MyTriggerAttribute>(),
        ];
    }
}
