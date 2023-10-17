// Вызов методов
PrintResult(Sampling(Input()));
Console.ReadKey();


// Получениие данных от пользователя
string[] Input()
{
    Console.WriteLine("Введите количество элементов в массиве: ");
    int count = int.Parse(Console.ReadLine());
    string[] array = new string[count];
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Введите элемент №{i + 1}");
        array[i] = Console.ReadLine();
    } 
    return array;
}

// Выборка нужных элементов
string[] Sampling(string[] input)
{

    int j = 0;
    //Цикл считающий количество нужных элементов
    for (int i = 0;i < input.Length;i++)
    {
        if (input[i].Length <= 3)
        {           
            j++;
            
        }
        else continue;
    }

    string[] result = new string[j];
    j = 0;
    // Цикл переносящий их в отдельный массив
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            result[j] = input[i];
            j++;

        }
        else continue;
    }
    return result;
}

// Вывод результата
void PrintResult(string[] result)
{
    Console.WriteLine("Результат: ");
    for (int i = 0; i < result.Length; i++)
    {
        if (result[i].Length != 0)
        {
            Console.WriteLine(result[i]);
        }
        else continue;
    }
}