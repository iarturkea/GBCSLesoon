Console.WriteLine("Input num");
int num = int.Parse(Console.ReadLine());
int res = 0;
while(true)
{
 res = res + num % 10;
 num = num / 10;

 if (num == 0)break;
}

 Console.WriteLine("Summ = " + res);