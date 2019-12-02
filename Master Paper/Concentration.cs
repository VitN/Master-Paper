using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Master_Paper
{
    //Клас для концентрації
    static class Concentration
    {
        //Обчислення mu
        public static double getMu(double h1, double V, double D)
        {
            return 1 / (1 + (h1 * Abs(V) / D));
        }

        //Обчислення rPlus
        public static double getRPlus(double V, double D)
        {
            double r = -V / D;
            return (r + Abs(r)) / 2;
        }

        //Обчислення rMinus
        public static double getRMinus(double V, double D)
        {
            double r = -V / D;
            return (r - Abs(r)) / 2;
        }

        //Обчислення додатку до коефіцієнта с
        public static double getAddition(double D, double gamma, double tau)
        {
            return gamma / (2 * D) + 1 / (2 * D * tau);
        }

        //Обчислення f
        public static double getF(double C, double C_bound, double gamma, double D, double tau)
        {
            return C / (2 * D * tau) + C_bound * gamma / (2 * D);
        }

        public static void Initialize(ref double[,] C, double bound, double CBound)
        {
            int n = C.GetLength(0) - 1;
            int m = C.GetLength(1) - 1;

            for (int j = 0; j <= n; j++)
            {
                C[j, 0] = bound;
            }
            C[0, m] = CBound;
        }

        //Початкова умова
        public static void Initialize(ref double[,] C, double right, double left, double h1, double xLen)
        {
            int n = C.GetLength(0) - 1;
            int m = C.GetLength(1) - 1;

            for (int j = 0; j <= n; j++)
            {
                C[0, j] = left;
                C[n, j] = right;
            }

            double x = 0;
            for (int i = 1; i < n; i++)
            {
                x = i * h1;
                for (int j = 0; j <= m; j++)
                {
                    
                    C[i, j] = Abs(C[0, j] - C[n, j]) * x / xLen + C[0, 0];
                }
            }
        }

    }
}
