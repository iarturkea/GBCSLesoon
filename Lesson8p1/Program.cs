void FillArray (int[,] array){


    int rows = array.GetUpperBound(0) + 1;
    int colums = array.Length / rows;

    for (int i = 0; i < rows; i++)
    {
        
        for (int j = 0; j < colums; j++)

        {
            array[i, j] = new Random().Next(0,100);
            
        }
        
    }


}

Console.WriteLine("Input array length");
Console.WriteLine("Input m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Input n");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);

int rows = array.GetUpperBound(0) + 1;
int colums = array.Length / rows;

int [] tempArray = new int [rows];

for (int i = 0; i < rows; i++)
    {
        
        for (int j = 0; j < colums; j++)

        {
            tempArray[j] = array[i,j];
            
        }
        Array.Sort(tempArray);
        Array.Reverse(tempArray);

        for (int j = 0; j < colums; j++)

        {
           array[i,j] = tempArray[j];
            
        }

    }


for (int i = 0; i < rows; i++)
    {
        
        for (int j = 0; j < colums; j++)

        {
            Console.Write(array[i,j] + " ");
            
        }
        Console.WriteLine();
        
    }