
void FillArray (double[,] array){


    int rows = array.GetUpperBound(0) + 1;
    int colums = array.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        
        for (int j = 0; j < colums; j++)

        {
            array[i, j] = new Random().Next(-100,100)/10.0;
            
        }
        
    }


}

Console.WriteLine("Input array length");
Console.WriteLine("Input m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Input n");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

FillArray(array);



