Console.WriteLine("Input num amount");
int am = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < am; i++)
{
    Console.WriteLine("Input num " + (i + 1));
    int num = int.Parse(Console.ReadLine());

    if (num > 0) count++;
}


 Console.WriteLine("Amount numbers above zero = " + count);