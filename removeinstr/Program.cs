class Program
{
    static void Main()
    {
        // Введення рядків
        Console.WriteLine("Введіть перший рядок:");
        string mainString = Console.ReadLine();

        Console.WriteLine("Введіть другий рядок:");
        string substring = Console.ReadLine();
        int index;
        while ((index = mainString.IndexOf(substring)) != -1)
        {
            mainString = mainString.Remove(index, substring.Length);
        }
        // Виведення результату
        Console.WriteLine("Результат:");
        Console.WriteLine(mainString);
    }
}
