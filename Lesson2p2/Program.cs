Console.WriteLine("Input num");
int num = int.Parse(Console.ReadLine());
int numLenght = 1;
int numTemp = num;
while (true)
{
    if (numTemp / 10 == 0) break;
    numTemp = numTemp / 10;
    numLenght++;
}
if (numLenght < 3)
    Console.WriteLine("No third number");
else
{
    for (int i = 0; i < numLenght - 3; i++)
    {
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}