Console.WriteLine("input line 1 parm: A1x + B1y + C1 = 0" );
Console.WriteLine("input A1");
double a1 = double.Parse(Console.ReadLine());
Console.WriteLine("input B1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("input C1");
double c1 = double.Parse(Console.ReadLine());

Console.WriteLine("input line 2 parm: A2x + B2y + C2 = 0");
Console.WriteLine("input A2");
double a2 = double.Parse(Console.ReadLine());
Console.WriteLine("input B2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("input C2");
double c2 = double.Parse(Console.ReadLine());

if(a1 * b2 - a2 * b1 == 0) Console.WriteLine("Lines are equal or parallel");

else{

    double x = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
    double y = (a1 * c2 - a2 * c1) / (a1 * b2 - a2 * b1);

    Console.WriteLine("lines intersection point: [" + x + ", " + y + "]");

}