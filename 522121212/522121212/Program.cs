double n = Convert.ToDouble(Console.ReadLine());
double x = Convert.ToDouble(Console.ReadLine());
if (Math.Abs(x) > 1)
{
    double result = 0;
    for (double i = 0; i <= n; i++)
    {
        result += 1 / ((2 * i + 1) * Math.Pow(x, 2 * i + 1));
        Console.WriteLine(result);
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("х должно быть меньше 1");
}