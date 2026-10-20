using CafeBussiness;
using OpenQA.Selenium.Chrome;

public static class Program
{


    public static void Main(string[] args)
    {
        //Console.BackgroundColor = ConsoleColor.DarkBlue;
        //Console.Clear();
        //Console.WriteLine("test");
        //CafeBiz cafebiz = new CafeBiz();
        //cafebiz.Capuchino();

        using (var driver = new ChromeDriver())
        {
            SeleniumHelper seleniumHelper = new SeleniumHelper(driver, "https://quotes.toscrape.com/");
            seleniumHelper.TestSelenium();
        }

        Console.ReadKey(); // esto funciona como pause

        //Proximamente lo vamos a usar
        //SeleniumHelper.Instance.TestSelenium();
    }


}