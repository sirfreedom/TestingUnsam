namespace CafeEntity
{
    public class Canela : Bebida
    {

        IProducto _Bebida;
        const double PRICE = 1.10;
        const string DESCRIPTION = " Canela ";

        public Canela(IProducto bebida)
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
