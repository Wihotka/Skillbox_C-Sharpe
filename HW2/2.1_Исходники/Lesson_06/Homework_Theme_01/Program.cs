using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        /// <summary>
        /// Метод Main()
        /// Входная точка проекта
        /// </summary>
        /// <param name="args">Аргумент метода Main()</param>
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.
            
            // Исходные данные
            string getName = "Павел";
            byte getAge = 28;
            float getHeight = 194.5F;
            float getHistoryMark = 3.5F;
            float getMathMark = 5F;
            float getRussianMark = 4F;

            // Подсчёт среднего балла
            float getAverageMark = (getHistoryMark + getMathMark + getRussianMark) / 3;
            
            // Выводим результат в консоль при помощи обычного вывода
            Console.WriteLine("1 способ");
            Console.WriteLine("Имя: " + getName + ";\nВозраст: " + getAge + ";\nРост: " + getHeight + ";\nСредний балл: " + Math.Round(getAverageMark, 2) + ".\n");
            
            // Выводим результат в консоль при помощи форматированного вывода
            Console.WriteLine("2 способ");
            Console.WriteLine("Имя: {0, 15};\nВозраст: {1, 11};\nРост: {2, 14};\nСредний балл: {3, 6}.\n",
                getName,
                getAge,
                getHeight,
                Math.Round(getAverageMark, 2));
            
            // Выводим результат в консоль при помощи интерполяции строк
            Console.WriteLine("3 способ");
            Console.WriteLine($"Имя: {getName, 15};\nВозраст: {getAge, 11};\nРост: {getHeight, 14};\nСредний балл: {Math.Round(getAverageMark, 2), 6}.\n");

            // Выводим результат в центре консоли
            string text = $"Имя: {getName}; Возраст: {getAge}; Рост: {getHeight}; Средний балл: {Math.Round(getAverageMark, 2)}.";
            Console.SetCursorPosition((Console.WindowWidth / 2) - (text.Length / 2), Console.WindowHeight / 2);
            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
