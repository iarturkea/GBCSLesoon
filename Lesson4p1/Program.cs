Console.WriteLine("Input num");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Input Exp");
int exp = int.Parse(Console.ReadLine());
int res = 1;
for (int i = 0; i < exp; i++)
{
    res = res * num;
}
Console.WriteLine(num+ " in exp " +  exp + ": " + res);