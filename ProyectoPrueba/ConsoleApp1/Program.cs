using CafeBussiness;

public static class Program
{








    public static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        Console.WriteLine("test");


        CafeBiz cafebiz = new CafeBiz();
        
        cafebiz.Capuchino();



        Console.ReadKey(); // esto funciona como pause



        //Proximamente lo vamos a usar
        //SeleniumHelper.Instance.TestSelenium();
    }


}