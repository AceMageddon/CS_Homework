namespace Seminar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Задание 1. Случайная матрица");
            Console.WriteLine("Введите число строк для матрицы:");
            int input_i = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число стобцов для матрицы:");
            int input_j = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[input_i, input_j];
            Console.WriteLine();
            int matrix1_sum = 0;
            Console.WriteLine("Вывод матрицы:");
            for (int i = 0; i < input_i; i++)
                    {
              for (int j = 0; j < input_j; j++)
                {
                    matrix1[i, j] = r.Next(10);
                    matrix1_sum += matrix1[i, j];
                    Console.Write($"{matrix1[i, j]} ");
                }
                    Console.WriteLine();
                    }
                    Console.Write("Сумма элементов матрицы: "+ matrix1_sum);
            Console.WriteLine();

            Console.WriteLine("Задание 2. Сложение матриц");
            int[,] matrix2 = new int[input_i, input_j];
            Console.WriteLine("Вывод второй матрицы:");
            for (int i = 0; i < input_i; i++)
            {
                for (int j = 0; j < input_j; j++)
                {
                    matrix2[i, j] = r.Next(10);
                    Console.Write($"{matrix2[i, j]} ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int matrix_combined_sum = 0;
            Console.WriteLine("Вывод суммарной матрицы:");
            int[,] matrix_combined = new int[input_i, input_j];
            for (int i = 0; i < input_i; i++)
            {
                for (int j = 0; j < input_j; j++)
                {
                    matrix_combined[i, j] = matrix1[i, j] + matrix2[i, j];
                    matrix_combined_sum += matrix_combined[i, j];
                    Console.Write($"{matrix_combined[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.Write("Сумма элементов суммарной матрицы: " + matrix_combined_sum);
            Console.WriteLine();
        }
        }
    }