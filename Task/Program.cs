Console.WriteLine("Choose Task");
Console.WriteLine("Task 1: 2D array with double numbers");
Console.WriteLine("Task 2: find number in 2D array");
Console.WriteLine("Task 3: arithmetic mean of an 2D array column");
int task = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input m and n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array2d = new double[m, n];
int[,] massive = new int[m, n];


switch (task)
{
    case 1:
        Task1();
        break;
    case 2:
        Task2();
        break;
    case 3:
        Task3();
        break;
    default:
        Console.WriteLine("There is no such task");
        break;
}


// Блок функций
double[,] GetArray(double[,] array2d)                      // Функция заполнения массива вещественными числами вручную
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Input numbers with space");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0; j < n; j++)
        {
            array2d[i, j] = Convert.ToDouble(input[j]);
        }
    }
    return array2d;
}
int[,] InputRandomArray(int[,] massive)                    // Функция заполнения массива рандомом
{
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            massive[i, j] = random.Next(-10, 10);
            Console.Write(massive[i, j] + " ");
        }
        Console.WriteLine();
    }
    return massive;
}
int[,] InputHandArray(int[,] massiveHand)                  // Функция заполнения массива целыми числами вручную 
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Input numbers with space");
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0; j < n; j++)
        {
            massiveHand[i, j] = Convert.ToInt32(input[j]);
        }
    }
    return massiveHand;
}


// Задача 47. Задайте двумерный массив (вручную) размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void Task1()
{
    Console.WriteLine();
    GetArray(array2d);
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array2d[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве,
// и возвращает индекс этого элемента или же указание, что такого элемента нет.
// Если элементов несколько, то выводим позицию каждого. Двумерный массив задаётся на ваш выбор.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void Task2()
{
    Console.WriteLine("Input desired number");
    int FindNumber = Convert.ToInt32(Console.ReadLine());
    InputRandomArray(massive);
    int CountFindNumbers = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (massive[i, j] == FindNumber)
            {
                Console.WriteLine("index desired number is: " + "[" + i + ", " + j + "]");
                CountFindNumbers = CountFindNumbers + 1;
            }
        }

    }
    if (CountFindNumbers == 0)
        Console.WriteLine("Desired number " + FindNumber + " not found");
}

// Задача 52. Задайте двумерный массив (вручную) из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void Task3()
{
    InputHandArray(massive);
    double SrArifm = 0;
    for (int j = 0; j < n; j++)
    {
        double sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum = massive[i, j] + sum;
        }
        SrArifm = Math.Round(sum / m, 2);
        Console.WriteLine("Srednee arifm " + (j+1) + " stolbtsa: " + SrArifm);
    }
}