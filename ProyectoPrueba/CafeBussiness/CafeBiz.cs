using CafeEntity;
using System.Text;

namespace CafeBussiness
{
    public class CafeBiz
    {

        public CafeBiz()
        {
    
        }


        public void Capuchino() 
        {
            StringBuilder sb = new StringBuilder();
            IProducto b = new Cafe(); // Cafe solo


            //sb.Append(b.Description);
            //sb.Append(b.Price);
            //sb.AppendLine();

            b = new Leche(new Chocolate(new Canela(new Cafe()))); // Cafe Decorado
            sb.Append(b.Description);
            sb.Append(b.Price);
            sb.AppendLine();

            //b = new Leche(new Te());
            //sb.Append(b.Description);
            //sb.Append(b.Price);
            //sb.AppendLine();

            Console.WriteLine(sb.ToString());
        }





    }
}
