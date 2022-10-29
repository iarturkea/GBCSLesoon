Console.WriteLine("Input num");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i < num; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}
Console.Write(Math.Pow(num, 3) + ". ");