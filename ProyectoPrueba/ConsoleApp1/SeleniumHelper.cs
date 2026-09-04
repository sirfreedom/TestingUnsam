using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class SeleniumHelper
{

    private static SeleniumHelper _instance = null;
    private static readonly object _lock = new object();

    private SeleniumHelper() { } // Constructor privado para evitar instanciación externa

    public static SeleniumHelper Instance
    {
        get
        {
            if (_instance == null)          
            {
                lock (_lock) // Asegura que solo un hilo pueda crear la instancia
                {
                    if (_instance == null)
                        _instance = new SeleniumHelper();
                }
            }
            return _instance;
        }
    }


    public void TestSelenium()
    {
        // 1. Configurar opciones de Chrome
        ChromeOptions options = new ChromeOptions();

        // Opcional: Ejecutar en modo Headless (sin abrir la ventana visual del navegador)
        // options.AddArgument("--headless=new");

        // 2. Inicializar el WebDriver
        using (IWebDriver driver = new ChromeDriver(options))
        {
            try
            {
                // Maximizar la ventana y configurar esperas implícitas
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                // 3. Navegar a la página web objetivos
                Console.WriteLine("Navegando al sitio web...");
                driver.Navigate().GoToUrl("https://quotes.toscrape.com/");  

                // 4. Ubicar los elementos contenedor de las citas
                IReadOnlyCollection<IWebElement> quoteElements = driver.FindElements(By.ClassName("quote"));

                Console.WriteLine($"\nSe encontraron {quoteElements.Count} citas en la página principal:\n");
                Console.WriteLine(new string('-', 60));

                // 5. Iterar sobre los elementos y extraer el texto interno
                foreach (IWebElement quoteElement in quoteElements)
                {
                    // Extraer texto de elementos secundarios mediante consultas XPath/By relative
                    string text = quoteElement.FindElement(By.ClassName("text")).Text;
                    string author = quoteElement.FindElement(By.ClassName("author")).Text;

                    Console.WriteLine($"Cita: {text}");
                    Console.WriteLine($"Autor: {author}");
                    Console.WriteLine(new string('-', 60));
                }
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine($"Error: No se encontró un elemento esperado. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
            }
            finally
            {
                // 6. Cerrar sesión y liberar recursos del navegador
                driver.Quit();
                Console.WriteLine("\nNavegador cerrado correctamente.");
            }
        }
    }




}
