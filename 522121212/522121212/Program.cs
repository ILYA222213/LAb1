double n = Convert.ToDouble(Console.ReadLine());
double x = Convert.ToDouble(Console.ReadLine());
// Проверяем, если модуль x больше 1
if (Math.Abs(x) > 1)
{
    // Инициализируем переменную result, которая будет хранить результат вычислений
    double result = 0;

    // Запускаем цикл от 0 до n (включительно)
    for (double i = 0; i <= n; i++)
    {
        // Вычисляем одно слагаемое в ряде и добавляем его к result
        result += 1 / ((2 * i + 1) * Math.Pow(x, 2 * i + 1));

        // Выводим промежуточный результат
        Console.WriteLine(result);
    }

    // Выводим окончательный результат
    Console.WriteLine(result);
}
else
{
    // Если модуль x меньше или равен 1, выводим сообщение об ошибке
    Console.WriteLine("х должно быть меньше 1");
}
