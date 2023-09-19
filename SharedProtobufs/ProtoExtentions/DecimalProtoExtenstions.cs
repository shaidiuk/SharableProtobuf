public static class DecimalProtoExtenstions
{
    public static void DescribeObject(this DecimalProto decimalProto)
    {
        Console.WriteLine($"Proto decimal having units part: {decimalProto.Units}, and nano part is {decimalProto.Nanos}");
    }
}
