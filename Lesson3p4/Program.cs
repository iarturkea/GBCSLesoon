Console.WriteLine("Input num");
int num = int.Parse(Console.ReadLine());

List<int> primeNum = new List<int>(); 

primeNum.Add(2);
bool prime = true;

for (int i = 3; i <= num; i++)
{
    for (int j = 0; j < primeNum.Count; j++)
    {
        if(i % primeNum[j] == 0){
            prime = false;
            break;
        }
        
    }
    if (prime) primeNum.Add(i);
        prime = true;
}

for (int i = 0; i < primeNum.Count - 1; i++)
{
    Console.Write(primeNum[i] + ", ");
}
Console.Write(primeNum[primeNum.Count - 1] + ". ");