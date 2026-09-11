namespace CafeEntity
{
    public abstract class Bebida : IProducto
    {
        private double _Price = 0;

        private string _Descripcion = string.Empty;

                
        public virtual string Description
        {
            get
            {
                return _Descripcion;
            }
        }

        public virtual double Price
        {
            get
            {
                return _Price;
            }
        }




    }
}
