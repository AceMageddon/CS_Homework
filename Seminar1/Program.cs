namespace Seminar1;
class Program
{
    static void Main(string[] args)
    {
        string fullName = "Глазунов Даниил Андреевич";
        byte age = 18;
        string email = "dg@gmail.ru";
        double scoreIT = 83.3;
        double scoreMath = 78.2;
        double scorePhys = 70.7;
        string patternBasic = "ФИО: {0} \nВозраст: {1} \nПочта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5} \nНажмите на любую клавишу для просмотра дальнейшей информации по баллам...";
        Console.WriteLine(patternBasic, fullName, age, email, scoreIT, scoreMath, scorePhys);
        Console.ReadKey();

        double scoreTotal = scoreIT + scoreMath + scorePhys;
        double scoreMiddle = scoreTotal / 3;

        string patternScore = "Общая сумма баллов: {0} \nСредний арифмитический балл: {1}";
        Console.WriteLine(patternScore, scoreTotal, scoreMiddle.ToString("#.##"));

    }
}
