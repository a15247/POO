using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    class Class1
    {
        public static int MaiorValor(int[] v)
        {
            int aux = v[0];
            for (int i = 1; i < v.Length; i++)
            {
                if (aux < v[i])
                {
                     aux= v[i];
                }
            }
            return aux;
        }
    }
}
