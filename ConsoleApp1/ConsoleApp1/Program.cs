void Main()
{

}

(string[]) Input()
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