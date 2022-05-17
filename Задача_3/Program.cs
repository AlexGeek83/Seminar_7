/* Задать двумерный массивю Найти эл-ты, у которых
оба индекса (строк и столбцов) чётные и замените эти эл-ты на их квадраты */


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

void FillNewArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 1 && j % 2 == 1)
               array[i,j] *= array[i,j];  // перемножаем - присваиваем массиву новые элементы
        }
    }
}


int[,] array = new int[m,n];

FillArrayRandom(array, 1,10);
PrintArray(array);
System.Console.WriteLine();
FillNewArray(array);
PrintArray(array);


