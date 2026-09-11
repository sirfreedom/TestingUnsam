namespace CafeEntity
{
    public class Leche : Bebida
    {
        IProducto _Bebida;

        const double PRICE = 0.75;
        const string DESCRIPTION = " Leche ";

        public Leche(IProducto bebida) 
        {
            _Bebida = bebida;
        }

        public override string Description
        {
            get
            {
                return base.Description + _Bebida.Description + DESCRIPTION;
            }
        }

        public override double Price
        {
            get
            {
                return base.Price + _Bebida.Price + PRICE;
            }
        }

    }
}
