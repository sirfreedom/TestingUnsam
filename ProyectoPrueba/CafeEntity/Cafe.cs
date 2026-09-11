namespace CafeEntity
{
    public class Cafe : Bebida, IProducto
    {

        public override double Price
        {
            get { return 10; }          
        }

        public override string Description 
        { 
            get { return "Shot Cafe"; }
        } 

    }
}
