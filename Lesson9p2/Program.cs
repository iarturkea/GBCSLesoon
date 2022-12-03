
Console.WriteLine("Input m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Input n");
int n = int.Parse(Console.ReadLine());
int sum = 0;

int Sum (int m, int n, int sum){

    sum = sum + m + n; 
    m = m + 1;
    n = n - 1;
    if (n > m) sum = Sum(m, n, sum);
    
    if (n == m) sum = sum + n;

    return sum;
}
sum = Sum(m, n , sum);

Console.WriteLine("Sum m to n: " + sum);

