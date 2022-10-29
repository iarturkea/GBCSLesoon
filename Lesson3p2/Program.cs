Console.WriteLine("Input dot A coordinates");
Console.WriteLine("dot A x");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("dot A y");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("dot A z");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input dot B coordinates");
Console.WriteLine("dot B x");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("dot B y");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("dot B z");
int z2 = int.Parse(Console.ReadLine());

double res;

res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));

Console.WriteLine("Dist A to B = " + res);