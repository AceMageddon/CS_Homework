namespace Seminar4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");
            byte exercise = byte.Parse(Console.ReadLine());
            while (exercise < 3 && exercise > 0) 
            {
                if (exercise == 1)
                {
                    Console.WriteLine("Задание 1. Метод разделения строки на слова");
                    string sentence1 = SentenceInput();
                    ArraySentenceReturn(sentence1);
                }
                else if (exercise == 2)
                {
                    Console.WriteLine("Задание 2. Перестановка слов в предложении");
                    ReverseSentence();
                    
                }
                else { break; }
                Console.WriteLine("\nВведите номер задания:");
                exercise = byte.Parse(Console.ReadLine());
            }
        }

        static string SentenceInput()
        {
            Console.WriteLine("Введите фразу:");
            string sentence1 = Console.ReadLine();
            return sentence1;
        }

        static void ArraySentenceReturn(string sentence1)
        {
            string[] wordArray = sentence1.Split(' ');
            Console.WriteLine("\nРезультат вывода:");
            foreach (var i in wordArray)
            {
                Console.WriteLine(i);
            }
        }

        static void ReverseSentence()
        {
            Console.WriteLine("Введите фразу:");
            string sentence1 = Console.ReadLine();
            string[] wordArray = sentence1.Split(' ');
            int wordArrayChangeLength = wordArray.Length-1;
            sentence1 = ("");
            for (int i = 0; i < wordArray.Length; i++)
            {
                for (int j = 0; j <= wordArrayChangeLength; j++)
                {
                    string saveword = wordArray[j];
                    wordArray[j] = wordArray[wordArrayChangeLength];
                    wordArray[wordArrayChangeLength] = saveword;
                    wordArrayChangeLength--;
                }
                sentence1 += wordArray[i] + " ";
            }
            ArraySentenceReturn(sentence1);


        }


    }
}