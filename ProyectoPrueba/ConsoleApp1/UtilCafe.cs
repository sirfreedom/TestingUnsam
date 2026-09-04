using System;

namespace App
{
    public class UtilCafe
    {
        private static readonly UtilCafe instance = new UtilCafe();

        private UtilCafe() { 
        
        }

        public static UtilCafe getInstance() 
        { 
            return instance;
        }








    }
}
