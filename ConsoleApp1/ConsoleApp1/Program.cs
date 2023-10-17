void Main()
{
    PrintResult(Sampling(Input()));
}

// Получениие данных от пользователя
string[] Input()
{
    Console.WriteLine("Введите количество элементов в массиве: ");
    int count = int.Parse(Console.ReadLine());
    string[] array = new string[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Введите элемент №{i + 1}");
        count[i] = Console.ReadLine();
    } 
}

// Выборка нужных элементов
string[] Sampling(string[] input)
{
    string[] result = new string[input.Length];
    for (int i = 0;i < input.Length;i++)
    {
        if (input[i].Length <= 3)
        {
            for (int j = 0;j < result.Length; j++)
            {
                result[j] = input[i];
            }
        }
        else continue
    }
    return result;
}

// Вывод результата
void PrintResult(string[] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        if (result[i].Length != 0) 
        {
            Console.WriteLine(result[i]);
        }
    }
}