class Program
{
    static void Main(string[] args)
    {
        IEnumerable<string> values = GetStrings().Take(10);
        foreach (string value in values)
        {
            Console.WriteLine(value);
        }

        Console.ReadLine();
    }

    static IEnumerable<string> GetStrings()
    {
        for (int i = 0; i < 100; i++)
        {
            yield return GetString();
            Console.WriteLine($"Rendu à [{i}]");
        }
    }

    static string GetString()
    {
        Thread.Sleep(1000);
        string value = new Random().Next().ToString();
        Console.WriteLine(value);

        return value;
    }
}