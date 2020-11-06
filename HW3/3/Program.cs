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

            // Запрашиваем число игроков
            Console.WriteLine("Введите число игроков: ");
            int quantityOfPlayers = int.Parse(Console.ReadLine());
            Console.WriteLine("\n"); 

            // Создаем массив для никнеймов
            string[] player;

            if (quantityOfPlayers == 1)
            {
                player = new string[quantityOfPlayers + 1];
            }
            else
            {
                player = new string[quantityOfPlayers];
            }

            // Переменная для порядкового номера массива
            int j = 0;

            // Переменная для проверки одиночного режима
            bool computerMod = false;
            bool singleMod = false;

            // Запрашиваем никнеймы игроков
            if (quantityOfPlayers == 1)
            {
                quantityOfPlayers++;
                Console.WriteLine("Введите имя игрока: ");
                player[0] = Console.ReadLine();
                player[1] = "Компьютер";
                Console.WriteLine("\n");
                singleMod = true;
            }
            else
            {
                for (int i = 0; i < quantityOfPlayers; i++)
                {
                    Console.WriteLine($"Введите имя игрока {i + 1}: ");
                    player[i] = Console.ReadLine();
                    Console.WriteLine("\n");
                }
            }

            // Генерируем случайное число
            Random randomize = new Random();
            int randomNumber = randomize.Next(12, 121);

            // Создаем переменную для пользовательского числа
            int number;

            // Создаем переменную для реванша
            string revenge;

            while (true) 
            {
                // Сброс на первый элемент массива при выходе порядкого номера за его границы
                if (j == quantityOfPlayers)
                {
                    j = 0;
                }

                // Выводим рандомное число в консоль
                Console.WriteLine($"Число: {randomNumber}");

                // Получаем число игрока
                Console.WriteLine("Введите число от 1 до 4");
                Console.Write($"Ход {player[j]}: ");

                if ((player[j] == "Компьютер") && (computerMod == true) && (singleMod == true))
                {
                    number = randomize.Next(1, 5);
                    Console.WriteLine(number);
                    Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
                    Console.ReadKey();
                }
                else
                {
                    number = int.Parse(Console.ReadLine());
                }

                // Работаем с числом игрока
                if ((number >= 1) && (number <= 4))
                {
                    randomNumber -= number;
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Введено некорректное число");
                    Console.WriteLine("\n");
                }

                // Победа
                if (randomNumber <= 0)
                {
                    Console.WriteLine($"{player[j]} победил!");

                    Console.Write("Реванш? (да/нет): "); // Реванш
                    revenge = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (revenge.ToLower() == "да")
                    {
                        randomNumber = randomize.Next(12, 121);
                        j = 0;
                        computerMod = false;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                computerMod = !computerMod; // Вкл/Выкл условия для компьютера
                j++; // Шаг цикла
            }

            Console.ReadKey();
        }
    }
}
