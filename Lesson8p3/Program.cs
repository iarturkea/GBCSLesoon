
void FillArray (int[,] array){


    int rows = array.GetUpperBound(0) + 1;
    int colums = array.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        
        for (int j = 0; j < colums; j++)

        {
            array[i, j] = new Random().Next(0,3);
            
        }
        
    }


}

Console.WriteLine("Input array A length");
Console.WriteLine("Input m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Input n");
int n = int.Parse(Console.ReadLine());

int[,] arrayA = new int[m, n];

Console.WriteLine("Input array B length");
Console.WriteLine("Input m");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Input n");
n = int.Parse(Console.ReadLine());

int[,] arrayB = new int[m, n];

FillArray(arrayA);
int rowsA = arrayA.GetUpperBound(0) + 1;
int columsA = arrayB.Length / rowsA;
for (int i = 0; i < rowsA; i++)
    {
        
        for (int j = 0; j < columsA; j++)

        {
            Console.Write(arrayA[i,j] + " ");
        }
        Console.WriteLine();
        
    }
FillArray(arrayB);
Console.WriteLine();
int rowsB = arrayB.GetUpperBound(0) + 1;
int columsB = arrayB.Length / rowsB;
for (int i = 0; i < rowsB; i++)
    {
        
        for (int j = 0; j < columsB; j++)

        {
            Console.Write(arrayB[i,j] + " ");
        }
        Console.WriteLine();
        
    }
Console.WriteLine();




if(columsA!=rowsB)Console.WriteLine("Cant be calculated");

else{
    int[,]arrayAB = new int[rowsA,rowsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int k = 0; k < columsB; k++){
            int sum = 0;
            for (int j = 0; j < rowsB; j++)
            {
                sum = sum + arrayA[i,j]*arrayB[j,k];
            }
            arrayAB[i,k] = sum;
        }
        
    }

    for (int i = 0; i < rowsA; i++)
    {
        
        for (int j = 0; j < columsB; j++)

        {
            Console.Write(arrayAB[i,j] + " ");
        }
        Console.WriteLine();
        
    }

    

}
