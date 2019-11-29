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
            return C / ( 2 * D * tau) + C_bound * gamma / (2 * D);
        }
    }
}
