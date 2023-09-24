using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты точки (x; y):");
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

       var aaa = y <= Math.Exp(x) && x * x + Math.Pow(y - 3, 2) <= 4;
       var bbb = y <= Math.Exp(x) && (x - 1) * (x - 1) + y * y <= 4;
        if (aaa && bbb)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
