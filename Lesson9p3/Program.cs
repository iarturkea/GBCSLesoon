
Console.WriteLine("Input m");
long m = long.Parse(Console.ReadLine());
Console.WriteLine("Input n");
long n = long.Parse(Console.ReadLine());
long sum = 0;

long Akker (long m, long n){

    if (m == 0) return (n + 1);

    if (n == 0) return (Akker((m - 1), 1));

    return Akker(m - 1, Akker(m, n - 1));
}
sum = Akker(m, n);

Console.WriteLine("Akker: " + sum);