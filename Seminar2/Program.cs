using System;
using System.Formats.Asn1;

namespace Seminar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задание:");
            byte exercise = byte.Parse(Console.ReadLine());

            while (exercise > 0 && exercise < 6)
            {
                if (exercise == 1)
                {
                    Console.WriteLine("\nЗадание 1. Приложение по определению чётного или нечётного числа");
                    Console.WriteLine("Введите любое целое число:");
                    int input_N = int.Parse(Console.ReadLine());
                    Console.WriteLine(input_N % 2 == 0 ? "Число четное" : "Число нечетное");
                }

                if (exercise == 2)
                {
                    Console.WriteLine("\nЗадание 2. Программа подсчёта суммы карт в игре «21»");
                    Console.WriteLine("Доброго дня! Давайте сыграем в «21». Сколько у вас карт на руках? Введите число:");
                    byte card_N = byte.Parse(Console.ReadLine());
                    int card_Sum = 0;
                    for (int i = 1; i <= card_N; i++)

                    {
                        Console.WriteLine("\nВведите номинал карты номер " + i);
                        string card_Input = Console.ReadLine();
                        switch (card_Input)
                        {
                            case "J": Console.WriteLine("Номинал карты номер " + i + ": Валет"); card_Sum = card_Sum + 10; break;
                            case "Q": Console.WriteLine("Номинал карты номер " + i + ": Королева"); card_Sum = card_Sum + 10; break;
                            case "K": Console.WriteLine("Номинал карты номер " + i + ": Король"); card_Sum = card_Sum + 10; break;
                            case "T": Console.WriteLine("Номинал карты номер " + i + ": Туз"); card_Sum = card_Sum + 10; break;

                            default:
                                Console.WriteLine("Номинал карты номер " + i + ": " + card_Input);
                                card_Sum = card_Sum + int.Parse(card_Input);
                                break;
                        }
                    }
                    Console.WriteLine("Общая суммма карт на ваших руках:" + card_Sum);
                }

                if (exercise == 3)
                {
                    Console.WriteLine("\nЗадание 3. Проверка простого числа");
                    Console.WriteLine("Введите простое число:");
                    bool num_Prime_Res = false;
                    uint num_Prime = uint.Parse(Console.ReadLine());
                    for (uint i = 1; i < num_Prime; i++)
                    {
                        if (((num_Prime % i) == 0) && (i != 1))
                        {
                            num_Prime_Res = true;
                            break;
                        }
                    }
                    if (num_Prime_Res == false) 
                    { Console.WriteLine("Число простое"); }
                    else
                    {
                        Console.WriteLine("Число не простое");
                    }
                }

                if (exercise == 4)
                {
                    Console.WriteLine("\nЗадание 4. Наименьший элемент в последовательности");
                    Console.WriteLine("Введите длинну вашей последовательности:");
                    uint num_Len = uint.Parse(Console.ReadLine());
                    int num_MinValue = 0;
                    for (uint i = 1; i <= num_Len; i++)
                    {
                        Console.WriteLine("\nВведите число для номера последовательности " + i);
                        int num = int.Parse(Console.ReadLine());
                        if ((num_MinValue == 0) || (num < num_MinValue))
                        {
                            num_MinValue = num;
                        }
                    }
                    Console.WriteLine("\nМинимальное число: " + num_MinValue);
                }

                if (exercise == 5)
                {
                    Console.WriteLine("\nЗадание 5. Игра «Угадай число»");
                    Console.WriteLine("Введите максимальное число диапозона: ");
                    int num_Max = int.Parse(Console.ReadLine());
                    Random rand = new Random();
                    int num_Random = rand.Next(0, num_Max+1);
                    Console.WriteLine("\nУгадайте число от 0 до " + num_Max + " (чтобы сдаться, введите комманду exit):");
                    int num_Guess = -1;
                    bool num_Res = true;
                    while (num_Guess != num_Random)
                    {
                        string num_Input = Console.ReadLine();
                        num_Res = (num_Input == "exit") ? true : false;
                        if (num_Res == true)
                        {
                            break;
                        }
                        else
                        {
                            num_Guess = int.Parse(num_Input);
                            if (num_Guess < num_Random)
                            {
                                Console.WriteLine("\nВведенное число меньше загаданного. Попробуйте ещё раз:");
                            }
                            else if (num_Guess > num_Random)
                            {
                                Console.WriteLine("\nВведенное число больше загаданного. Попробуйте ещё раз:");
                            }
                        }

                    }
                    if (num_Res == true)
                    {
                        Console.WriteLine("\nЗагаданным числом было: " + num_Random + "! Удачи при следующей попытке!");
                    }
                    else
                    {
                        Console.WriteLine("\nПравильно! Загаданное число: " + num_Random + "! Поздравляю с победой!");
                    }
                }

                Console.WriteLine("\nВыберите задание:");
                exercise = byte.Parse(Console.ReadLine());
            }
            Console.WriteLine("Данного задания не существует. Выход из программы.");
        }
    }
}