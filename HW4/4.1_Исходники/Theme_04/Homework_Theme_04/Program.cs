using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10


            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля


            // 
            // * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //
            //
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            //
            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //

            // Задание 1.
            Console.WriteLine("Задание 1.\n");

            // Массив доходов
            int[] income = new int[] {
                100000,
                120000,
                80000,
                70000,
                100000,
                200000,
                130000,
                150000,
                190000,
                110000,
                150000,
                100000
            };

            // Массив расходов
            int[] expence = new int[] {
                80000,
                90000,
                70000,
                70000,
                80000,
                120000,
                140000,
                65000,
                90000,
                70000,
                120000,
                80000
            };

            // Массив прибыли
            int[] profit = new int[income.Length];

            for (int p = 0; p < income.Length; p++)
                profit[p] = income[p] - expence[p];

            // Массив месяца
            int[] month = new int[income.Length];

            for (int m = 0; m < income.Length; m++)
                month[m] = m + 1;

            // Вывод в консоль
            Console.WriteLine("Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.");
            for(int i = 0; i < income.Length; i++)
                Console.WriteLine($"{month[i], 5}{income[i], 21}{expence[i], 19}{(profit[i]), 23}");
            
            // Создаем копии массива прибыли и сортируем для дальнейшего использования
            int[] worstProfitAll = new int[profit.Length];

            profit.CopyTo(worstProfitAll, 0);

            Array.Sort(worstProfitAll);

            int[] worstProfit = worstProfitAll.Distinct().ToArray(); // Удаляем одинаковые элементы массива

            // Определяем месяцы с худшей прибылью и выводим
            string worstResult = "";

            for (int w = 0; w < 3; w++)
            {
                for (int p = 0; p < profit.Length; p++)
                {
                    if (worstProfit[w] == profit[p]) 
                        worstResult += month[p] + ", "; 
                }
            }

            worstResult = worstResult.Remove(worstResult.Length - 2); // Удаляем последнюю запятую

            Console.WriteLine($"\nХудшая прибыль в месяцах: {worstResult}.");

            // Подсчитываем число месяцев с положительной прибылью и выводим
            int countOfPositiveMonths = 0;
            foreach (int positiveProfit in profit)
            {
                if (positiveProfit > 0)
                    countOfPositiveMonths++;
            }

            Console.WriteLine($"\nКоличество месяцев с положительной прибылью: {countOfPositiveMonths}.\n");

            // Задание 2.
            Console.WriteLine("\nЗадание 2.\n");

            // Запрашиваем число строк
            int n = 0;

            while (true)
            {
                Console.Write("Введите число строк N (0 < N < 25): ");

                n = int.Parse(Console.ReadLine());

                if ((n > 0) && (n < 25))
                    break;

                Console.WriteLine("Введено некорректное число!");
                Console.ReadKey();
            }

            Console.WriteLine();
            
            // Создаем ступенчатый массив
            int[][] triangle = new int[n][];

            // Создаем первую строку массива
            triangle[0] = new int[] { 1 };

            // Заполняем массив согласно алгоритму треугольника Паскаля
            for (int i = 1; i < n; i++)
            {
                triangle[i] = new int[i + 1];

                for (int j = 0; j <= i; j++)
                {
                    if ((j == 0) || (j == i))
                        triangle[i][j] = 1;  // Задаем крайние значения треугольника равными 1
                    else
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }
            }

            // Выводим треугольник в консоль
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k <= (n - i); k++)
                {
                    Console.Write("    "); // Добавляем определенное число пробелов в начало каждой строчки
                }

                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write("{0, -8}", triangle[i][j]); // Выводим элементы массива с определенной шириной поля
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Задание 3.1.
            Console.WriteLine("\nЗадание 3.1.\n");

            Random randomize = new Random();

            Console.Write("Введите число строк: ");
            int firstLines = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число столбцов: ");
            int firstColumns = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Заполняем массив
            Console.WriteLine("Исходный массив\n");
            int[,] firstArray = new int[firstLines, firstColumns];

            for (int i = 0; i < firstLines; i++)
            {
                for (int j = 0; j < firstColumns; j++)
                {
                    firstArray[i, j] = randomize.Next(1, 10);
                    Console.Write($"{firstArray[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.Write("\nВведите множитель: ");
            int firstMultiplier = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Производим умножение
            for (int i = 0; i < firstLines; i++)
            {
                for (int j = 0; j < firstColumns; j++)
                {
                    firstArray[i, j] *= firstMultiplier;
                    Console.Write($"{firstArray[i, j], 3} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Задание 3.2.
            Console.WriteLine("\nЗадание 3.2.\n");

            Console.Write("Введите число строк: ");
            int secondLines = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число столбцов: ");
            int secondColumns = int.Parse(Console.ReadLine());

            int[,] secondArrayOne = new int[secondLines, secondColumns];
            int[,] secondArrayTwo = new int[secondLines, secondColumns];

            // Заполняем массивы
            Console.WriteLine("\nПервая матрица\n");
            for (int i = 0; i < secondLines; i++)
            {
                for (int j = 0; j < secondColumns; j++)
                {
                    secondArrayOne[i, j] = randomize.Next(1, 10);
                    Console.Write($"{secondArrayOne[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nВторая матрица\n");
            for (int i = 0; i < secondLines; i++)
            {
                for (int j = 0; j < secondColumns; j++)
                {
                    secondArrayTwo[i, j] = randomize.Next(1, 10);
                    Console.Write($"{secondArrayTwo[i, j]} ");
                }
                Console.WriteLine();
            }

            // Производим вычитание
            Console.WriteLine("\nНажмите любую кнопку, чтобы произвести вычитание второй матрицы из первой\n");
            Console.ReadKey();

            for (int i = 0; i < secondLines; i++)
            {
                for (int j = 0; j < secondColumns; j++)
                {
                    secondArrayOne[i, j] -= secondArrayTwo[i, j];
                    Console.Write($"{secondArrayOne[i, j], 2} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Задание 3.3.
            Console.WriteLine("\nЗадание 3.3.\n");

            // Запрашиваем данные
            Console.Write("Введите число строк: ");
            int thirdLinesOne = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число столбцов: ");
            int thirdColumnsOne = int.Parse(Console.ReadLine());

            int thirdLinesTwo = thirdColumnsOne;
            int thirdColumnsTwo = thirdLinesOne;

            int[,] thirdArrayOne = new int[thirdLinesOne, thirdColumnsOne];
            int[,] thirdArrayTwo = new int[thirdLinesTwo, thirdColumnsTwo];
            int[,] thirdArrayThree = new int[thirdLinesOne, thirdColumnsTwo];

            // Заполняем массивы
            Console.WriteLine("\nПервая матрица\n");
            for (int i = 0; i < thirdLinesOne; i++)
            {
                for (int j = 0; j < thirdColumnsOne; j++)
                {
                    thirdArrayOne[i, j] = randomize.Next(1, 10);
                    Console.Write($"{thirdArrayOne[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nВторая матрица\n");
            for (int i = 0; i < thirdLinesTwo; i++)
            {
                for (int j = 0; j < thirdColumnsTwo; j++)
                {
                    thirdArrayTwo[i, j] = randomize.Next(1, 10);
                    Console.Write($"{thirdArrayTwo[i, j]} ");
                }
                Console.WriteLine();
            }

            // Производим умножение
            Console.WriteLine("\nНажмите любую кнопку, чтобы произвести умножение матриц\n");
            Console.ReadKey();

            for (int i = 0; i < thirdLinesOne; i++)
            {
                for (int j = 0; j < thirdColumnsTwo; j++)
                {
                    thirdArrayThree[i, j] = 0;
                    for (int k = 0; k < thirdColumnsOne; k++)
                    {
                        thirdArrayThree[i, j] += thirdArrayOne[i, k] * thirdArrayTwo[k, j];
                    }
                    Console.Write($"{thirdArrayThree[i, j], 3} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
