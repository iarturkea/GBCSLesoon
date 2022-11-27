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

int sumHigh = 0;
int indexSumHight = 0;

for (int i = 0; i < colums; i++)
{
    sumHigh = sumHigh + array[0,i];
}

for (int i = 1; i < rows; i++)
    {   
        int sum = 0;
        
        for (int j = 0; j < colums; j++)

        {
            sum = sum + array[i, j];
            
        }

        if(sum > sumHigh){
            sumHigh = sum;
            indexSumHight = i;
        }

    }

Console.WriteLine("Row with the largest sum: " + (indexSumHight+1));

