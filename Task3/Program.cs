/*  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

// как задать массив с типом double и рандомными вещественными числами так и не разобрался, все время выдает ошибку
// сделал задание с обычными рандомными числами 

int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int MinMaxNumbers(int[] array)
{
    int min = 0;
    int max = 0;
    int minimax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i]; 
        
    }
    minimax = max - min;
    return minimax;
}

int dimension = GetNumber("Введите размер массива");
int[] array = InitArray(dimension);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {MinMaxNumbers(array)}");
