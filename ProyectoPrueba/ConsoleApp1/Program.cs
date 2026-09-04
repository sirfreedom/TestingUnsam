

public static class Program
{
    public static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        Console.WriteLine("test");
        Console.ReadKey();


        SeleniumHelper.Instance.TestSelenium();
    }


}