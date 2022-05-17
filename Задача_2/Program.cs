/* Задать двумерный массив размера m на n, каждый элемент в 
массиве находится по формуле A(m,n) = m + n. Вывести массив на экран. */


int m, n;
System.Console.WriteLine("Введите кол-во строк (m): ");
m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов (n): ");
n = int.Parse(Console.ReadLine());


void FillArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;  // присваиваем массиву новые элементы
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

int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);



