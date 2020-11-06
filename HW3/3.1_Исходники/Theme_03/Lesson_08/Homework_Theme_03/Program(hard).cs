using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!

            // Запрашиваем никнеймы игроков
            Console.WriteLine("Введите имя первого игрока: ");
            string playerOne = Console.ReadLine();

            Console.WriteLine("Введите имя второго игрока: ");
            string playerTwo = Console.ReadLine();

            // Запрашиваем границы диапазонов
            Console.Write("Укажите наибольшее значение генерируемого диапазона: ");
            int maxRandomNumber = int.Parse(Console.ReadLine());

            Console.Write("Укажите наибольшее допустимое пользовательское значение (больше 12): ");
            int maxNumber = int.Parse(Console.ReadLine());

            // Генерируем случайное число
            Random randomize = new Random();
            int randomNumber = randomize.Next(12, (maxRandomNumber + 1));

            // Создаем переменную для пользовательского числа
            int number;

            // Создаем переменную для реванша
            string revenge;

            while (true) 
            {
                Console.WriteLine($"Число: {randomNumber}"); // Выводим рандомное число в консоль

                Console.WriteLine($"Введите число от 1 до {maxNumber}"); // Получаем число первого игрока
                Console.Write($"Ход {playerOne}: ");
                number = int.Parse(Console.ReadLine());

                if ((number >= 1) && (number <= maxNumber)) // Работаем с числом первого игрока
                {
                    randomNumber -= number;
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Введено некорректное число");
                    Console.WriteLine("\n");
                }

                if (randomNumber <= 0)
                {
                    Console.WriteLine($"{playerOne} победил!");

                    Console.Write("Реванш? (да/нет): "); // Реванш
                    revenge = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (revenge.ToLower() == "да")
                    {
                        randomNumber = randomize.Next(12, (maxRandomNumber + 1));
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine($"Число: {randomNumber}"); // Выводим рандомное число в консоль

                Console.WriteLine($"Введите число от 1 до {maxNumber}"); // Получаем число второго игрока
                Console.Write($"Ход {playerTwo}: ");
                number = int.Parse(Console.ReadLine());

                if ((number >= 1) && (number <= maxNumber)) // Работаем с числом второго игрока
                {
                    randomNumber -= number;
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Введено некорректное число");
                    Console.WriteLine("\n");
                }

                if (randomNumber <= 0)
                {
                    Console.WriteLine($"{playerTwo} победил!");

                    Console.Write("Реванш? (да/нет): "); // Реванш
                    revenge = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (revenge.ToLower() == "да")
                    {
                        randomNumber = randomize.Next(12, (maxRandomNumber + 1));
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
