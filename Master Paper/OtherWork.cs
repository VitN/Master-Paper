using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Paper
{
    static class OtherWork
    {
        static void ArrayInitial(int n, params double[][] arrays)
        {
            for(int i = 0; i < arrays.Length; i++)
            {
                arrays[i] = new double[n];
            }
        }
    }
}
