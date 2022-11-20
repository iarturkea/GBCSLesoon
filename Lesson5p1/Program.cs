Console.WriteLine("Input array length");
int arlength = int.Parse(Console.ReadLine());

void FillArray (int [] array){

    int i = 0;

    while (i < array.Length){
        array[i] = new Random().Next(100, 999);
        i++;
    }


}

int EvenCount  (int [] array){

    int count = 0;

    foreach (var num in array)
    {
        if(num % 2 == 0) count++;
    }

    return count;

}

int[] array = new int[arlength]; 

FillArray(array);
int evenCount  = EvenCount(array);

Console.WriteLine("Array contains " + evenCount + " even numbers");