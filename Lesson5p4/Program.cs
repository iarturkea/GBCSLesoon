void FillArray (int [] array){

    int i = 0;

    while (i < array.Length){
        array[i] = new Random().Next(-100, 100);
        i++;
    }


}

int NumSearch (int [] array){
    int index = -1;
    Console.WriteLine("Input number to search");
    int num = int.Parse(Console.ReadLine());

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) {
            index = i;
            break;
            
        }
            
        
    }
    return index;
}

Console.WriteLine("Input array length");
int arlength = int.Parse(Console.ReadLine());
int[] array = new int[arlength]; 
FillArray(array);

foreach (var num in array)
{
    Console.WriteLine(num);
}

int index = NumSearch(array);

Console.WriteLine("Index of seraching num = " + index);