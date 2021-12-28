using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endlessMode = false;
            int addictionScore;

            Console.WriteLine("Добро пожаловать!");

            ShowSettingsGameMenu();
            addictionScore = Addition();

            void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Выберите команду");
            Console.WriteLine("1) Начать игру");
            Console.WriteLine("1) Выход");
        }
            void ShowGameMenu()
        {
            Console.Title = "Начать игру";
            Console.Clear();
            Console.WriteLine("Выберите режим");
            Console.WriteLine("1) Сложение");
            Console.WriteLine("2) Вычитание");
            Console.WriteLine("3) Умножение");
            Console.WriteLine("4) Деление");
            Console.WriteLine("5) Все вместе");
        }
            void ShowSettingsGameMenu()
            {
                int result = 0;
                Console.Title = "Начать игру";
                Console.Clear();
                Console.WriteLine("Бесконечный режим ?");
                Console.WriteLine("1) Да");
                Console.WriteLine("2) Нет");

                while (result != 1 && result != 2)
                {
                    result = int.Parse(Console.ReadLine());
                    if (result == 1)
                        endlessMode = true;
                    else
                        endlessMode = false;
                }    
        }
            int Addition()
            {
                bool inGame = true;
                int first;
                int second;
                Random rand = new Random();
                int score = 0;

                while (inGame)
                {
                    if (endlessMode)
                    {
                        first = rand.Next(1, 10);
                        second = rand.Next(1, 10);

                        Console.Write(first + " + " + second + " = ");
                        int result = int.Parse(Console.ReadLine());

                        if (result == (first + second))
                        {
                            Console.WriteLine("\tПравильный ответ!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("\tНеправильный ответ!");
                            inGame = false;
                        }
                    }
                    else
                    {
                        int count = 0;
                        int misCount = 0;
                        while (count <= 19)
                        {
                            first = rand.Next(1, 10);
                            second = rand.Next(1, 10);

                            Console.Write(first + " + " + second + " = ");
                            int result = int.Parse(Console.ReadLine());

                            if (result == (first + second))
                            {
                                Console.WriteLine("\tПравильный ответ!");
                                score++;
                                count++;
                            }
                            else
                            {
                                Console.WriteLine("\tНеправильный ответ!");
                                count++;
                                misCount++;
                            }
                        }
                        inGame = false;
                        Console.WriteLine("\n" + (count - misCount) + " правильных ответов из "+ count);
                    }
                }

                return score;
            }

        }
    }
}
