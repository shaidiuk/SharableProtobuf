//DecimalProto is generate from the nuget package
//Current project does not have direct reference to SharedProtobufs project
var testDecimalProto = new DecimalProto(5,10);
//demonstration of the extension method is accessible from current project
testDecimalProto.DescribeObject();
Console.ReadLine();
