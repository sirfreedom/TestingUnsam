using System;


namespace CafeEntity
{
    public abstract class Producto
    {
        public decimal Precio { get; set; } = 0;

        public string Nombre  {  get; set; } = string.Empty;

    }
}
