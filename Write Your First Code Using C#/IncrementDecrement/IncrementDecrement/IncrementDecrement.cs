int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.
Console.WriteLine(value);

Console.WriteLine();

int value3 = 0;     // value is now 0.
value3 = value3 + 1; // value is now 1.
value3++;           // value is now 2.
Console.WriteLine(value3);

Console.WriteLine();

int value4 = 1;

value4 = value4 + 1;
Console.WriteLine("First increment: " + value4);

value4 += 1;
Console.WriteLine("Second increment: " + value4);

value4++;
Console.WriteLine("Third increment: " + value4);

value4 = value4 - 1;
Console.WriteLine("First decrement: " + value4);

value4 -= 1;
Console.WriteLine("Second decrement: " + value4);

value4--;
Console.WriteLine("Third decrement: " + value4);

Console.WriteLine();

int value5 = 1;
value5++;
Console.WriteLine("First: " + value5);
Console.WriteLine($"Second: {value5++}");
Console.WriteLine("Third: " + value5);
Console.WriteLine("Fourth: " + (++value5));