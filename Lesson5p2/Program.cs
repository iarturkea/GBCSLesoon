Console.WriteLine("Input array length");
int arlength = int.Parse(Console.ReadLine());

void FillArray (int [] array){

    int i = 0;

    while (i < array.Length){
        array[i] = new Random().Next(-100, 100);
        i++;
    }


}

int NotEvenSum  (int [] array){

    int sum = 0;

    for (int i = 1; i < array.Length;)
    {
        sum = sum + array[i];
        i = i + 2;
    }

    return sum;

}

int[] array = new int[arlength]; 

FillArray(array);

 foreach (var num in array)
    {
        Console.WriteLine(num);
    }

int neSum  = NotEvenSum(array);

Console.WriteLine("Sum of not even positions = " + neSum);
