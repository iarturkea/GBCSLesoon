
int[] numArr = new int[8];
Console.WriteLine("Input Array");
for (int i = 0; i < numArr.Length; i++)
{
    Console.WriteLine("Input num " + (i+1));
    numArr[i] = int.Parse(Console.ReadLine());
    
}
Console.Write("[");

for (int i = 0; i < 4; i++)
{
    Console.Write(numArr[i] + ", ");
}
Console.WriteLine(numArr[4] + "]");
Console.WriteLine("["+ numArr[5] + ", " + numArr[6] + ", " + numArr[7] + "]" );

