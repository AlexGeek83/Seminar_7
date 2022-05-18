/* Задать двумерный массив, заполнить его случайными числами.
Найти сумму эл-тов на главной диагонали (эл-ты с индексом 0,0 1,1....) */


int m, n;
System.Console.WriteLine("Введите кол-во строк (m): ");
m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов (n): ");
n = int.Parse(Console.ReadLine());

// метод заполняет массив (стоки, столбцы случайными числами)
void FillArrayRandom(int[,]array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue);  // присваиваем массиву новые элементы
        }
    }
}

// вывод на экран
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write(array[i,j] + " "); // выводим строку/столбец на экран
        System.Console.WriteLine(); // переход на новую строку
        
    }
}
/*
int FillNewArray(int[,]array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
               sum = array[i,j] + sum;  // ссумируем эл-ты по диагонали
        }
    }
    return sum;
}
*/
// более быстрый вариант и правильный


int FillNewArray(int[,]array)
{
    int sum = 0;
    int minLength = Math.Min(array.GetLength(0), array.GetLength(1));

        for (int j = 0; j < minLength; j++)
        {
               sum = array[j,j] + sum;  // ссумируем эл-ты по диагонали
        }
    
    return sum;
}


int[,] array = new int[m,n];

FillArrayRandom(array, 1,10);
PrintArray(array);
System.Console.WriteLine();

System.Console.WriteLine(FillNewArray(array));




