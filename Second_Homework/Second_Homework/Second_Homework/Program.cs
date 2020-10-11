using System;

namespace Second_Homework
{
    class Program
    {
        // рассчет первого сегмента графика
        static double FirstSegment(double x, double r)
        {
            double a = -6; // центр окружности
            double y;

            y = -Math.Sqrt(Math.Abs(r * r - (x - a) * (x - a)));
            // возвращаем значение на участке
            return y;

        }

        // рассчет второго сегмента графика
        static double SecondSegment(double x)
        {

            double y;
            y = x + 3;
            // возвращаем значение на участке
            return y;
        }

        // рассчет третьего сегмента графика
        static double ThirdSegment(double x, double r)
        {

            double y; // центр в нуле 

            y = Math.Sqrt(Math.Abs(r * r - x * x));
            // возвращаем значение на участке
            return y;

        }

        // рассчет четвертого сегмента графика
        static double ForthSegment(double x)
        {
            double y;
            y = 3 - x;
            // возвращаем значение на участке
            return y;
        }

        // рассчет первого сегмента графика
        static double FivethSegment(double x)
        {

            double y;
            y = (x - 3) * 0.5;
            // возвращаем значение на участке
            return y;
        }

        static void Main(string[] args)
        {
            // Запрос на ввод радиуса для первого участка
            Console.WriteLine("Введите значение радиуса на первом участке:");
            double r1 = double.Parse(Console.ReadLine());

            // Запрос на ввод радиуса для третьго участка
            Console.WriteLine("Введите значение радиуса на третьем участке:");
            double r3 = double.Parse(Console.ReadLine());

            // Вывод на экран
            Console.WriteLine("\nТаблица значений функции на промежутке (-9,9):\n");
            for (double x = -9; x <= 9.2; x += 0.2)
            {
                if (x < -9)
                    Console.WriteLine("x лежит вне функции");
                else
                  if (x < -6)
                {
                    if (r1 < 3)
                    {
                        // проверяем определена ли функция
                        if (x < -r1 - 6)
                            Console.WriteLine("Функция не определена на участке x({0:0.00})", x);
                        else
                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, FirstSegment(x, r1));
                    }
                    else
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, FirstSegment(x, r1));
                }
                else
                   if (x < -3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, SecondSegment(x));
                }
                else
                   if (x < 0)
                {

                    if (r3 < 3)
                    {
                        // проверяем определена ли функция
                        if (x < -r3)
                            Console.WriteLine("Функция не определена на участке x({0:0.00})", x);
                        else

                            Console.WriteLine("y({0:0.00}) = {1:0.00}", x, ThirdSegment(x, r3)); ;
                    }
                    else
                        Console.WriteLine("y({0:0.00}) = {1:0.00}", x, ThirdSegment(x, r3)); ;
                }
                else
                   if (x < 3)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, ForthSegment(x));
                }
                else
                   if (x <= 9.2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", x, FivethSegment(x));
                }
            }
     
        }
    }
}

