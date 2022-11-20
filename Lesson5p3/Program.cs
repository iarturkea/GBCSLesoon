

void FillArray (int [] array){

    int i = 0;

    while (i < array.Length){
        array[i] = new Random().Next(-100, 100);
        i++;
    }


}

Console.WriteLine("Input array length");
int arlength = int.Parse(Console.ReadLine());
int[] array = new int[arlength]; 
FillArray(array);

int max = array[0];
int min = array[0];

foreach (var num in array)
{
    if(num > max) max = num;
    else if(num < min) min = num;
    
}

foreach (var num in array)
{
    Console.WriteLine(num);
}

Console.WriteLine("Max and min dif = " + (max - min));
