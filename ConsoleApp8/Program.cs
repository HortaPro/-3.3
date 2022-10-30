//Миронова Анастасия 22-ИСП-2/1
//3.3 Вариант 4
//Уровень Сложный
try
{
    Console.Write("Введите x: ");
    double sum = 0,
           x = double.Parse(Console.ReadLine());

    double n = 0;
    do
    {
        Console.Write("Введите n больше 0: ");
        n = int.Parse(Console.ReadLine());
    } while (n < 0);

    int a = 0;

    while (n > a)
    {
        int number = 1;
        for (int i = 1; i <= a; i++)
        {
            number++;
        }
        sum += Math.Cos(x) + Math.Cos(n * x) / number;
        a++;
    }

    Console.WriteLine($"Сумма {n} чисел: {sum:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}




