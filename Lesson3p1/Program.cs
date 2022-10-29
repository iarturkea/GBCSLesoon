

Console.WriteLine("Input num");
int num = int.Parse(Console.ReadLine());
if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10) Console.WriteLine("Yes");
else Console.WriteLine("No");