using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Seminar6
{
    internal class Program
    {
        private static Repository repository = new Repository();
        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер комманды:");
            Console.WriteLine("1: Вывести всех работников на экран");
            Console.WriteLine("2: Найти работника по ID");
            Console.WriteLine("3: Удалить работника по ID");
            Console.WriteLine("4: Добавить работника");
            Console.WriteLine("5: Загрузка записей в выбранном диапазоне дат");
            byte choice = byte.Parse(Console.ReadLine());
            DirectoryInfo directory = new DirectoryInfo(@"G:\VisualStudioHomework\Seminar6");
            String file = directory + @"\test.txt";
            while (choice < 6 && choice > 0)
            {
                if (choice == 1)
                {
                    for (int i = 0; i < File.ReadAllLines(file).Length; i++)
                    {
                        Console.WriteLine(repository.GetAllWorkers(i).Print());
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Введите номер ID:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(repository.GetWorkerById(id).Print());
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Введите номер ID:");
                    int id = int.Parse(Console.ReadLine());
                    repository.DeleteWorker(id);
                }
                else if (choice == 4)
                {
                    InputData(file);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Выберите начальную дату:");
                    DateTime dateFrom = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Выберите конечную:");
                    DateTime dateTo = DateTime.Parse(Console.ReadLine());
                    repository.GetWorkersBetweenTwoDates(dateFrom, dateTo);
                    File.ReadAllLines(repository.time_file);
                    for (int i = 0; i < File.ReadAllLines(repository.time_file).Length; i++)
                    {
                        Console.WriteLine(repository.GetAllWorkers(i).Print());
                    }
                    File.Delete(repository.time_file);
                }
                else { break; }
                Console.WriteLine("\nВведите номер комманды:");
                choice = byte.Parse(Console.ReadLine());
            }
        }

        static void InputData(String file)
        {
            int id = CreateId(file);
            String dateString = CreateCurrentDate();
            string[] humanValues = CreateHumanValues();

            String fullName = humanValues.First();
            int age = int.Parse(humanValues[1]);
            int height = int.Parse(humanValues[2]);
            String birthdayString = CreateBirthday();
            String city = humanValues.Last();
            Worker worker = new Worker(id, dateString, fullName, age, height, birthdayString, city);
            repository.AddWorker(worker);
        }

        static int CreateId(String file)
        {
            string past_id_text;
            string[] past_id;
            int id;
            if (File.Exists(file))
            {
                var lines = File.ReadAllLines(file);
                past_id_text = repository.GetLine(lines.Length);
                past_id = past_id_text.Split("#");
                id = int.Parse(past_id[0]) + 1;
            }
            else
            {
                id = 1;
            }
            return id;
        }

        static String CreateCurrentDate()
        {
            DateTime date = DateTime.Now;
            String dateString = date.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("ru-RU"));
            return dateString = dateString.Remove(dateString.Length - 3);
        }

        static string[] CreateHumanValues()
        {
            string[] name;

            Console.WriteLine("Введите Фамилию:");
            String surname = Console.ReadLine();

            Console.WriteLine("Введите Имя:");
            String mainname = Console.ReadLine();

            Console.WriteLine("Введите Отчество:");
            String fathername = Console.ReadLine();

            String fullname = surname + " " + mainname + " " + fathername;

            Console.WriteLine("Введите Возраст:");
            String age = Console.ReadLine();

            Console.WriteLine("Введите Рост:");
            String height = Console.ReadLine();

            Console.WriteLine("Введите Город:");
            String city = "город " + Console.ReadLine();

            return name = new string[] { fullname, age, height, city };
        }

        static String CreateBirthday()
        {
            Console.WriteLine("Введите Год Рождения:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите Месяц Рождения (числом):");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите День Рождения:");
            int day = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day, 00, 00, 00);
            String birthdayString = birthDate.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("ru-RU"));
            return birthdayString = birthdayString.Remove(birthdayString.Length - 9);
        }
    }
}