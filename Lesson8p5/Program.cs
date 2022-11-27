
int[,] array = new int[4,4];
int n = 0;
for (int i = 0; i < 4; i++)
{
    array[0,i] = n;
    n++;
 
}

for (int i = 1; i < 4; i++)
{
    array[i,3] = n;
    n++;
 
}

for (int i = 2; i >=0; i--)
{
    array[3,i] = n;
    n++;
}

for (int i = 2; i >0; i--)
{
    array[i,0] = n;
    n++;
}
for (int i = 1; i < 3; i++)
{
    array[1,i] = n;
    n++;
}
array[2,2] = n;
n++;
array[2,1] = n;
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(array[i,j]+" ");

    }
    Console.WriteLine();
}
