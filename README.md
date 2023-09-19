## Projects:

- **SharedProtobufs** - contains protobufs shared as a NuGet package with other projects.
- **GrpcService** -  a consumer of the sharable NuGet package.

## Details:
### SharedProtobufs

The project file (*.csproj) must include the following configuration:
```
<ItemGroup>
  <Content Include="<FolderForExport>\*.proto">
    <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
  </Content>
</ItemGroup>
```
### GrpcService

The project file (*.csproj) must contain the following configurations:

1. Imported NuGet packages should have the 'GeneratePathProperty' attribute set to true:
```
 <PackageReference Include="SharedProtobufs" Version="1.0.0" GeneratePathProperty="true"/>
```
2. The Protobuf include should contain the AdditionalImportDirs attribute with the path to the imported protobufs:
```
<ItemGroup>
  <Protobuf Include="Protos\**" GrpcServices="Server" AdditionalImportDirs="$(PkgSharedProtobufs)\content"/>
</ItemGroup>
```
