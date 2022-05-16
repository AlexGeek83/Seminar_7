// 

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
        {
            System.Console.Write(array[i,j] + " "); // выводим строку/столбец на экран
        System.Console.WriteLine(); // переход на новую строку
        }
    }
}

int m, n;
System.Console.WriteLine("Введите кол-во строк (m): ");
m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов (n): ");
n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

FillArrayRandom(array,-9,10);
PrintArray(array);


