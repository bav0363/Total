string [] Input(int size)
{
    string[] array = new string[size];    
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"Введите [{index + 1}] элемент массива: ");
        array[index] = Convert.ToString(Console.ReadLine());
    }
    return array;
}