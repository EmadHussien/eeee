using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3

 

{


    public static class OS
    {

        public static bool number(int num)
        {
            if (num > 10)
                return true;
            else
                return false;


        }

    }

    public static class OP
    {


        
        public static bool prime(double prim)
        {
            int f = 0;
            for (int i = 2; i < prim; ++i)
            {

                if (prim % i == 0) f = 1;
            }

            if (f == 1)
            {
                return false;
            }

            else { return true; }
        }


        public static bool even_odd(int number)
        {
            if (number % 2 == 0 ) 
            {
                return true;
            }


            else if (number % 2 != 0) return false;
            else return true;

        }




    }
}

