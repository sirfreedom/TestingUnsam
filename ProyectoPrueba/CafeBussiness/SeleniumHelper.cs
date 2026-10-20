using OpenQA.Selenium;


public class SeleniumHelper
{

    private readonly IWebDriver _driver;
    private string _baseUrl = string.Empty;


    public SeleniumHelper(IWebDriver webdriver, string baseUrl)
    {
        _driver = webdriver;
        _baseUrl = baseUrl;
    }

    public void TestSelenium()
    {
        // 1. Configurar opciones de Chrome
        // Opcional: Ejecutar en modo Headless (sin abrir la ventana visual del navegador)
        // options.AddArgument("--headless=new");
        // 2. Inicializar el WebDriver
        {
            try
            {
                // Maximizar la ventana y configurar esperas implícitas
                _driver.Manage().Window.Maximize();
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                // 3. Navegar a la página web objetivos
                Console.WriteLine("Navegando al sitio web...");
                _driver.Navigate().GoToUrl(_baseUrl);  

                // 4. Ubicar los elementos contenedor de las citas
                IReadOnlyCollection<IWebElement> quoteElements = _driver.FindElements(By.ClassName("quote"));

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
                _driver.Quit();
                Console.WriteLine("\nNavegador cerrado correctamente.");
            }
        }
    }




}
