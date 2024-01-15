class Program
{
    static void Main()
    {
        Console.WriteLine("Minimum and Maximum Values:");
        Console.WriteLine($"sbyte:  {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"byte:   {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"short:  {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"int:    {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"uint:   {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"long:   {long.MinValue} to {long.MaxValue}");
        Console.WriteLine($"ulong:  {ulong.MinValue} to {ulong.MaxValue}");
        Console.WriteLine($"float:  {float.MinValue} to {float.MaxValue}");
        Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
        Console.WriteLine($"decimal:{decimal.MinValue} to {decimal.MaxValue}");
        Console.WriteLine($"char:   {char.MinValue} to {char.MaxValue}");
        Console.WriteLine($"bool:   {bool.FalseString} to {bool.TrueString}");
    }
}