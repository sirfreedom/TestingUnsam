using CafeBussiness;
using OpenQA.Selenium.Chrome;

namespace UnitTest
{
    public class UnitTest1
    {

        [Fact]
        public void PrepararCafe_ConInsumosSuficientes_RestaInsumosYDevuelveTrue()
        {
            //CafeBiz maquina = new CafeBiz(aguaInicial: 500, cafeInicial: 50);
            //int tamanoTaza = 200;

            //// 2. Act (Ejecutar la acción a probar)
            //bool resultado = maquina.PrepararCafe(tamanoTaza);

            //// 3. Assert (Verificar el resultado esperado)
            //Assert.True(resultado);
            //Assert.Equal(300, maquina.NivelAguaMl);
            //Assert.Equal(30, maquina.GranosCafeGramos);
        }

        [Fact]
        public void PruebaSelenium()
        {
             using (var driver = new ChromeDriver())
             {
                 SeleniumHelper seleniumHelper = new SeleniumHelper(driver, "https://quotes.toscrape.com/");
                 seleniumHelper.TestSelenium();
             }
        }





    }
}
