
int[,,] array = new int[2,2,2] { { { 22, 33}, { 44, 52 } } , { { 71, 82}, { 10, 11 } } };

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            Console.Write(array[i,k,j] + "(" + i + "," + k + "," + j + ")");
        }
        Console.WriteLine();
    }
}

