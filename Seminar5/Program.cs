using System.IO;

namespace Seminar5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер комманды:");
            Console.WriteLine("1: Вывести данные на экран");
            Console.WriteLine("2: Заполнить данные и добавить новую запись в конец файла.");
            byte choice = byte.Parse(Console.ReadLine());
            DirectoryInfo directory = new DirectoryInfo(@"G:\VisualStudioHomework\Seminar5");
            String file = directory + @"\test.txt";
            while (choice < 3 && choice > 0) 
            {
                if (choice == 1)
                {
                    if (File.Exists(file) == true) { InfoOutput(file); }
                    else
                    {
                        Console.WriteLine("Данного файла не существует. Создаем новый.");
                        InputData(file);
                    }
                }
                else if (choice == 2)
                {
                    InputData(file);
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
            string[] humanValuesFirst = humanValues.Take(humanValues.Length - 1).ToArray();
            String humanText = String.Join("#", humanValuesFirst);
            String birthday = CreateBirthday();

            string[] array = new string[] { id.ToString(), dateString, humanText, birthday, humanValues.Last() };
            String text = String.Join("#", array);
            CreateFile(text, file);
        }

        static int CreateId(String file)
        {
            int id;
            if (File.Exists(file))
            {
                var lines = File.ReadAllLines(file);
                id = lines.Length + 1;
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

            return name = new string[] {fullname, age, height, city};
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

        static void CreateFile(String text, String file) 
        {
            TextWriter tw = new StreamWriter(file, true);
            tw.WriteLine(text);
            tw.Close();
            InfoOutput(file);
        }

        static void InfoOutput(String file)
        {
            using (StreamReader  sr = new StreamReader(file)) 
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}