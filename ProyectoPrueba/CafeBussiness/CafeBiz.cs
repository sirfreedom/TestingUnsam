namespace CafeBussiness
{
    public class CafeBiz
    {
        public int NivelAguaMl { get; private set; }
        public int GranosCafeGramos { get; private set; } = 0;


        public CafeBiz(int aguaInicial, int cafeInicial)
        {
            NivelAguaMl = aguaInicial;
            GranosCafeGramos = cafeInicial;
        }

        public bool PrepararCafe(int tamanoTazaMl)
        {
            int cafeNecesario = tamanoTazaMl / 10;

            if (NivelAguaMl < tamanoTazaMl || GranosCafeGramos < cafeNecesario)
            {
                return false; // No hay suficientes insumos
            }

            NivelAguaMl -= tamanoTazaMl;
            GranosCafeGramos -= cafeNecesario;
            return true;
        }


    }
}
