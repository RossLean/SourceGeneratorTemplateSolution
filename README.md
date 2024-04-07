# Source Generator Template Solution

This solution provides a template for building a Roslyn source generator that targets .NET Standard 2.0. It follows practices followed during the development of other source generators, and mainly targeting support for incremental source gnerators.

## Structure

The solution consists of 4 projects:
- **SourceGeneratorTemplate.Package** - The project responsible for packing the source generator into a NuGet package.
- **SourceGeneratorTemplate.Core** - The project containing core elements for the source generator, like attributes, intended to be published as a separate NuGet package.
- **SourceGeneratorTemplate.SourceGenerators** - The project containing the source generators that are part of the package.
- **SourceGeneratorTemplate.SourceGenerators.Tests** - The project responsible for testing the source generator. It is not part of any published package.

## Guidelines

`WellKnownNames.cs` in **SourceGeneratorTemplate.SourceGenerators** may be used for declaring names that are not available by `nameof` references, due to depending on assemblies using a newer .NET version that cannot be directly consumed in the source generator project.

**SourceGeneratorTemplate.Core** contains some sample attributes and extensions.

`MyGeneratorMetadataReferences.cs` in **SourceGeneratorTemplate.SourceGenerators.Tests** contains helpers for adding metadata references to the Core assembly, and other assemblies that the source generator might make use of.

`CSharpSourceGeneratorVerifier.cs` and `CSharpIncrementalGeneratorVerifier.cs` define helper methods for verifying execution of a standard or incremental source generator respectively. They also define the .NET version that the tests will depend on, which must be compatible with the .NET version of the test project.

## Dependencies

By default the projects contain references to these helper libraries:
- [RoseLynn](https://github.com/Rekkonnect/RoseLynn)
- [Garyon](https://github.com/Rekkonnect/Garyon)
- [Dentextist](https://github.com/Rekkonnect/Dentextist)

Additionally, the test project uses the NUnit test framework.
