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
            return 1 / (1 + (h1 * V / D));
        }

        //Обчислення rPlus
        public static double getRPlus(double V, double D)
        {
            double r = -V / D;
            return (r + Abs(r)) / 2;
        }

        //Обчислення rMinus
        public static double getMinus(double V, double D)
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

        //Крайова умова
        public static void Initialize(ref double[,] C, double right, double left, double h1, double xLen, bool status)
        {
            int n = C.GetLength(0);
            int m = C.GetLength(1);

            //Граничні умови
            for (int j = 0; j <= m; j++)
                C[0, j] = left;

            //1 роду
            if (status)
            {
                for (int j = 0; j <= m; j++)
                    C[n, j] = right;
            }
            //2 роду
            else { C[n, 0] = right; }
            
            //Початкова умова
            double x = 0;
            for (int i = 1; i < n; i++)
            {
                x = i * h1;
                C[i, 0] = (C[0, 0] - C[n, 0]) * x / xLen + C[0, 0];
            }
        }

    }
}
