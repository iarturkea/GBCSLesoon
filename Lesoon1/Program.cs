//Part1
Console.WriteLine("Input a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input b");
int b = int.Parse(Console.ReadLine());
        if (a > b) 
            Console.WriteLine("max = " + a);
        else 
            Console.WriteLine("max = " + b);
//Part2

Console.WriteLine("Input x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Input y");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Input z");
int z = int.Parse(Console.ReadLine());
int max;

if (x > y)
    if (z > x)
        max = z;
    else
        max = x;
else
    if (y > z)
        max = y;
    else
        max = z;
Console.WriteLine("max = " + max);

//Part3
Console.WriteLine("Input num");
int num = int.Parse(Console.ReadLine());
if( num % 2 == 0)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

//Part4

Console.WriteLine("Input length");
int length = int.Parse(Console.ReadLine());

for (int i = 1; i < length; i++)
{
    if(i % 2 == 0)
    Console.Write(i + ", ");
}