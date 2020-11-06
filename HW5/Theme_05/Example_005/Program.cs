using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005
{
    class Program
    {
        /// <summary>
        /// Метод вывода матрицы в консоль (1ая перегрузка)
        /// </summary>
        /// <param name="matrix">Готовая матрица</param>
        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод вывода слов одинаковой длины (2ая перегрузка)
        /// </summary>
        /// <param name="words">Итоговые слова</param>
        static void Print(string[] words)
        {
            Console.Write("Ответ: ");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"{words[i]} ");
            }
        }

        /// <summary>
        /// Метод для задания 1.1.
        /// </summary>
        /// <param name="matrix">Исходная матрица</param>
        /// <param name="number">Множитель</param>
        /// <returns></returns>
        static int[,] MatrixMultiplyNumber(int[,] matrix, int number)
        {
            int[,] array = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    array[i, j] = matrix[i, j] * number;
                }
            }
            return array;
        }

        /// <summary>
        /// Метод для задания 1.2.
        /// </summary>
        /// <param name="matrixOne">Первая матрица</param>
        /// <param name="matrixTwo">Вторая матрица</param>
        /// <returns></returns>
        static int[,] MatrixPlusMatrix(int[,] matrixOne, int[,] matrixTwo)
        {
            int[,] array = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];

            for (int i = 0; i < matrixOne.GetLength(0); i++)
            {
                for (int j = 0; j < matrixOne.GetLength(1); j++)
                {
                    array[i, j] = matrixOne[i, j] - matrixTwo[i, j];
                }
            }
            return array;
        }

        /// <summary>
        /// Метод для задания 1.3.
        /// </summary>
        /// <param name="matrixOne">Первая матрица</param>
        /// <param name="matrixTwo">Вторая матрица</param>
        /// <returns></returns>
        static int[,] MatrixMultiplyMatrix(int[,] matrixOne, int[,] matrixTwo)
        {
            int[,] array = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

            for (int i = 0; i < matrixOne.GetLength(0); i++)
            {
                for (int j = 0; j < matrixTwo.GetLength(1); j++)
                {
                    array[i, j] = 0;
                    for (int k = 0; k < matrixTwo.GetLength(0); k++)
                    {
                        array[i, j] += matrixOne[i, k] * matrixTwo[k, j];
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// Метод для задания 2.1.
        /// </summary>
        /// <param name="text">Исходный текст</param>
        static string MinLetters(string text)
        {
            char[] delimiterChars = {' ', ',', '.'}; // Указываем разделительные символы
            string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries); // Формируем текст в формате массива
            string word = ""; // Переменная для результата
            int max = Int32.MaxValue; // Максимальное значение для сравнения с длиной первого элемента

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < max)
                {
                    max = words[i].Length;
                    word = words[i];
                }
            }

            return word;
        }

        /// <summary>
        /// Метод для задания 2.2.
        /// </summary>
        /// <param name="text">Исходный текст</param>
        static string[] MaxLetters(string text)
        {
            char[] delimiterChars = {' ', ',', '.'}; // Указываем разделительные символы
            string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries); // Формируем текст в формате массива
            string word = ""; // Переменная для результата
            int min = 0; // Минимальное значение для сравнения с длиной первого элемента

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > min)
                {
                    min = words[i].Length;
                    word = words[i];
                }
            }

            string[] allWords = new string[words.Length];
            int j = 0;

            // Перебираем массив и выводим слова равной длины
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == word.Length)
                {
                    allWords[j] = words[i];
                    j++;
                }
            }

            return allWords;
        }

        /// <summary>
        /// Метод для задания 3.
        /// </summary>
        /// <param name="text">Исходный текст</param>
        static string DeleteDoubleLetters(string text)
        {
            char[] array = new char[text.Length]; // Создаем пустой массив для результата

            int j = 0; // Индекс массива
            for (int i = 1; i < text.Length; i++) // Цикл с условием для проверки одинаковых символов строки
            {                                     // и записи их в массив (начиная со второго символа)
                if (text[i] != text[i - 1])
                {
                    array[j] = text[i];
                    j++;
                }
            }

            string result = new string(array); // Преобразуем массив в строку
            string finalResult = text[0] + result;
            return finalResult;
        }

        /// <summary>
        /// Метод для задания 4.
        /// </summary>
        /// <param name="numbers">Последовательность чисел</param>
        static void DeterminingSequence(string numbers)
        {
            char[] delimiterChars = {' ', ',', '.'}; // Указываем разделительные символы
            int[] array = numbers.Split(delimiterChars).Select(i => int.Parse(i.ToString())).ToArray(); // Преобразуем строку в массив чисел
            bool arithmetic = false; // Булевый флаг арифметической прогрессии
            bool geometry = false; // Булевый флаг геометрической прогрессии
            
            // Сравниваем все элементы последовательности на принадлежность к арифметической прогрессии
            for (int i = 0; i < (array.Length - 1); i++)
            {
                if (array[i] == (array[0] + (((i + 1) - 1) * (array[i + 1] - array[i]))))
                {
                    arithmetic = true;
                }
                else
                {
                    arithmetic = false;
                    break;
                }
            }

            // Сравниваем все элементы последовательности на принадлежность к геометрической прогрессии
            for (int i = 0; i < (array.Length - 1); i++)
            {
                if (array[i] == (array[0] * Math.Pow((array[i + 1] / array[i]), i)))
                {
                    geometry = true;
                }
                else
                {
                    geometry = false;
                    break;
                }
            }

            // Вывод
            if (arithmetic)
            {
                Console.WriteLine("Данная последовательность является арифметической прогрессией");
            }
            else if (geometry)
            {
                Console.WriteLine("Данная последовательность является геоиетрической прогрессией");
            }
            else
            {
                Console.WriteLine("Данная последовательность не является никакой прогрессией");
            }
        }

        /// <summary>
        /// Метод для задания 5.
        /// </summary>
        /// <param name="n">Первое число</param>
        /// <param name="m">Второе число</param>
        /// <returns></returns>
        static int Ackerman(int n, int m)
        {
            if (n == 0)
                return m + 1;
            else if ((n != 0) && (m == 0))
                return Ackerman(n - 1, 1);
            else
                return Ackerman(n - 1, Ackerman(n, m - 1));
        }

        /// <summary>
        /// Домашнее задание №5
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // Задание 1.
            // Воспользовавшись решением задания 3 четвертого модуля
            // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
            // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
            // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение
            //
            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД
            //
            // Задание 3. Создать метод, принимающий текст. 
            // Результатом работы метода должен быть новый текст, в котором
            // удалены все кратные рядом стоящие символы, оставив по одному 
            // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
            // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
            // 
            // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
            // является заданная последовательность элементами арифметической или геометрической прогрессии
            // 
            // Примечание
            //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
            //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
            //
            // *Задание 5
            // Вычислить, используя рекурсию, функцию Аккермана:
            // A(2, 5), A(1, 2)
            // A(n, m) = m + 1, если n = 0,
            //         = A(n - 1, 1), если n <> 0, m = 0,
            //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
            // 
            // Весь код должен быть откоммментирован

            // Задание 1.1.
            Console.WriteLine("\nЗадание 1.1.\n");

            Random randomize = new Random();

            Console.Write("Введите число строк: ");
            int firstLines = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число столбцов: ");
            int firstColumns = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if ((firstLines < 1) || (firstColumns < 1))
            {
                Console.WriteLine("Введены некорректные значения.");
            }
            else
            {
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
                Print(MatrixMultiplyNumber(firstArray, firstMultiplier));
            }

            // Задание 1.2.
            Console.WriteLine("\nЗадание 1.2.\n");

            Console.Write("Введите число строк: ");
            int secondLines = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число столбцов: ");
            int secondColumns = int.Parse(Console.ReadLine());

            if ((secondLines < 1) || (secondColumns < 1))
            {
                Console.WriteLine("Введены некорректные значения.");
            }
            else
            {
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

                Print(MatrixPlusMatrix(secondArrayOne, secondArrayTwo));
            }

            // Задание 1.3.
            Console.WriteLine("\nЗадание 1.3.\n");

            // Запрашиваем данные
            Console.Write("Введите число строк первой матрицы: ");
            int thirdLinesOne = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число столбцов первой матрицы: ");
            int thirdColumnsOne = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число строк второй матрицы: ");
            int thirdLinesTwo = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число столбцов второй матрицы: ");
            int thirdColumnsTwo = int.Parse(Console.ReadLine());

            if ((thirdLinesOne < 1) || (thirdColumnsOne < 1) || (thirdLinesTwo < 1) || (thirdColumnsTwo < 1))
            {
                Console.WriteLine("Введены некорректные значения.");
            }
            else if (thirdColumnsOne != thirdLinesTwo)
            {
                Console.WriteLine("\nМатрицы несогласованные\n");
            }
            else
            {
                int[,] thirdArrayOne = new int[thirdLinesOne, thirdColumnsOne];
                int[,] thirdArrayTwo = new int[thirdLinesTwo, thirdColumnsTwo];

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

                Print(MatrixMultiplyMatrix(thirdArrayOne, thirdArrayTwo));
            }

            // Задание 2.1.
            Console.WriteLine("\nЗадание 2.1.\n");

            // Запрашиваем данные
            Console.Write("Введите строку: ");
            string strOne = Console.ReadLine();
            Console.WriteLine();

            // Вызываем метод
            Console.WriteLine($"Ответ: {MinLetters(strOne)}");
            Console.WriteLine();

            // Задание 2.2.
            Console.WriteLine("\nЗадание 2.2.\n");

            // Запрашиваем данные
            Console.Write("Введите строку: ");
            string strTwo = Console.ReadLine();
            Console.WriteLine();

            // Вызываем метод
            Print(MaxLetters(strTwo));
            Console.WriteLine();

            // Задание 3.
            Console.WriteLine("\nЗадание 3.\n");

            // Запрашиваем данные
            Console.Write("Введите строку: ");
            string phrase = Console.ReadLine().ToLower();
            Console.WriteLine();

            // Вызываем метод
            Console.WriteLine($"Ответ: {DeleteDoubleLetters(phrase)}");
            Console.WriteLine();

            // Задание 4.
            Console.WriteLine("\nЗадание 4.\n");

            // Запрашиваем данные
            Console.Write("Введите последовательность чисел: ");
            string sequence = Console.ReadLine();
            Console.WriteLine();

            // Вызываем метод
            DeterminingSequence(sequence);
            Console.WriteLine();

            // Задание 5.
            Console.WriteLine("\nЗадание 5.\n");
            Console.WriteLine($"Результат для A(2, 5): {Ackerman(2, 5)}\n");
            Console.WriteLine($"Результат для A(1, 2): {Ackerman(1, 2)}\n");

            Console.ReadKey();
        }
    }
}
