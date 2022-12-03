
Console.WriteLine("Input m");
int m = int.Parse(Console.ReadLine());

void Print (int m){

    Console.Write(m);
    m = m - 1;
    if (m > 0){
    Console.Write(", ");
    Print(m);
    }
}
Print(m);