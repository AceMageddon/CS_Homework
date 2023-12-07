namespace Seminar7
{
    internal class Program
    {
        private static Exercise1 exercise1 = new Exercise1();
        private static Exercise2 exercise2 = new Exercise2();
        private static Exercise3 exercise3 = new Exercise3();
        private static Exercise4 exercise4 = new Exercise4();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите задание:");
            Console.WriteLine("Задание 1. Работа с листом.");
            Console.WriteLine("Задание 2. Телефонная книга.");
            Console.WriteLine("Задание 3. Проверка повторов.");
            Console.WriteLine("Задание 4. Записная книжка.");
            byte choice = byte.Parse(Console.ReadLine());
            while (choice < 5 && choice > 0)
            {
                if (choice == 1)
                {
                    exercise1.CreateList();
                    String result = exercise1.CollectionString();
                    Console.WriteLine("Изначальная коллекция:");
                    Console.WriteLine(result);
                    exercise1.RemoveItems();
                    result = exercise1.CollectionString();
                    Console.WriteLine("\nКоллекция после изменений:");
                    Console.WriteLine(result);

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Введите команду:");
                    Console.WriteLine("1. Добавить пользователей");
                    Console.WriteLine("2. Найти пользователя");
                    byte choice2 = byte.Parse(Console.ReadLine());

                    while (choice2 < 3 && choice2 > 0)
                    {
                        if (choice2 == 1)
                        {
                            Console.WriteLine("Введите ФИО:");
                            String fullname = Console.ReadLine();
                            String phoneNumberString = " ";
                            int phoneNumber = 0;
                            while (!string.IsNullOrEmpty(phoneNumberString))
                            {
                                Console.WriteLine("Введите его номер телефона:");
                                phoneNumberString = Console.ReadLine();
                                if (!string.IsNullOrEmpty(phoneNumberString))
                                {
                                    phoneNumber = int.Parse(phoneNumberString);
                                    exercise2.CreateDictionary(phoneNumber, fullname);
                                }
                            }
                            Console.WriteLine("\nТекущее содержание:");
                            String result = exercise2.DictionaryString();
                            Console.WriteLine(result);
                        }
                        else if (choice2 == 2)
                        {
                            Console.WriteLine("Введите номер телефона:");
                            int id = int.Parse(Console.ReadLine());
                            String result = exercise2.DictionaryFindById(id);
                            Console.WriteLine(result);
                        }
                        else
                        {
                            break;
                        }
                        Console.WriteLine("\nВведите комманду:");
                        Console.WriteLine("1. Добавить пользователей");
                        Console.WriteLine("2. Найти пользователя");
                        choice2 = byte.Parse(Console.ReadLine());
                    }
                }
                else if (choice == 3)
                {
                    String getElement = " ";
                    while (!string.IsNullOrEmpty(getElement))
                    {
                        Console.WriteLine("\nВведите элемент:");
                        getElement = Console.ReadLine();
                        if (!string.IsNullOrEmpty(getElement))
                        {
                            int id = int.Parse(getElement);
                            if (exercise3.hash.Contains(id))
                            {
                                Console.WriteLine("Данный элемент уже присутвует");
                            }
                            else
                            {
                                exercise3.hash.Add(id);
                                String result = exercise3.HashString();
                                Console.WriteLine(result);
                            }
                        }

                    }
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\nВведите ФИО:");
                    String fullname = Console.ReadLine();
                    Console.WriteLine("\nВведите название улицы:");
                    String streetname = Console.ReadLine();
                    Console.WriteLine("\nВведите название дома:");
                    String housename = Console.ReadLine();
                    Console.WriteLine("\nВведите номер квартиры:");
                    String flatnum = Console.ReadLine();
                    Console.WriteLine("\nВведите номер телефона:");
                    String phonenum = Console.ReadLine();
                    Console.WriteLine("\nВведите номер домашнего телефона:");
                    String flatphone = Console.ReadLine();
                    exercise4.CreateXML(fullname, streetname, housename, flatnum, phonenum, flatphone);
                }
                else { break; }
                Console.WriteLine("\nВведите номер комманды:");
                choice = byte.Parse(Console.ReadLine());
            }
        }
    }
}