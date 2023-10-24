using System.Text;

Console.WriteLine("Enter lenght of FIbonacci sequence");
var length = GetFibonacciLength();
Console.WriteLine("Great");
var sequence = CreateFibonacciSequence(length);
Console.WriteLine(sequence);

static uint GetFibonacciLength()
{
    var n = Console.ReadLine();
    uint length;
    while (!uint.TryParse(n, out length) || length <= 1)
    {
        Console.WriteLine("Wrong input");
        n = Console.ReadLine();
    }
    return length;
}

static string CreateFibonacciSequence(uint length)
{
    var x = 0UL;
    var y = 1UL;
    var sb = new StringBuilder($"{x} {y} ");
    for (var i = 2; i < length; i++)
    {
        var z = x + y;
        sb.Append($"{z} ");
        x = y;
        y = z;
    };
    return sb.ToString();
}