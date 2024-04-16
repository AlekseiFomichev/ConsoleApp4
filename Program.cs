namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Задание 1.Случайная матрица
           Выведите на экран матрицу заданного размера и заполните её случайными числами.Детальный алгоритм работы приложения:

           Сначала пользователю предлагается ввести количество строк в будущей матрице.
           Затем — ввести количество столбцов в будущей матрице.
           Когда данные будут получены, нужно создать в памяти матрицу заданного размера.
           Используя Random, заполнить матрицу случайными целыми числами.
           Вывести полученную матрицу на экран.
           Вывести сумму всех элементов этой матрицы на экран отдельной строкой.
           */
            /*Console.WriteLine("Введите количество строк массива: ");
            var row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива: ");
            var col = int.Parse(Console.ReadLine());
            Console.WriteLine("Первая матрица : ");
            var matrix = new int[row, col];
            var thirdMatrix = new int[row, col];
            var secondMatrix = new int[row, col];
            int sumMatrix = 0;
            Random random = new Random();
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    matrix[i, j] = random.Next(5);
                    sumMatrix += matrix[i, j];
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов первой матрицы : {sumMatrix}");*/


            /*Задание 2.Сложение матриц
            Что нужно сделать
            Используя размеры матрицы из предыдущего задания, создайте ещё одну матрицу.Сложите две матрицы.
            Сложение матриц А и В — это нахождение такой матрицы С, все элементы которой представляют собой 
            сложенные попарно соответствующие элементы исходных матриц А и В. Складывать допускается только матрицы 
            одинаковой размерности(допустим, m × n), то есть имеющие равное количество строк и равное количество столбцов.*/

            Console.WriteLine("Введите количество строк массива: ");
            var row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива: ");
            var col = int.Parse(Console.ReadLine());
            Console.WriteLine("Первая матрица : ");
            var matrix = new int[row, col];
            var secondMatrix = new int[row, col];
            Random random = new Random();
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    matrix[i, j] = random.Next(5);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вторая матрица: ");
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    secondMatrix[i, j] = random.Next(5);

                    Console.Write(secondMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            var thirdMatrix = new int[row, col];
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    thirdMatrix[i, j] = matrix[i, j] + secondMatrix[i, j];
                }
            }
            Console.WriteLine("\nСложение матриц:");
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    Console.Write($"{thirdMatrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
