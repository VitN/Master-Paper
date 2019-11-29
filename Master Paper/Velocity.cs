using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Master_Paper
{
    //Клас для швидкості
    static class Velocity
    {
        //Обчислення mu
        public static double getMu(double h1, double V, double nu)
        {
            return 1 / (1 + (h1 * V / nu));
        }

        //Обчислення rPlus
        public static double getRPlus(double V)
        {
            return (V + Abs(V)) / 2;
        }

        //Обчислення rMinus
        public static double getRMinus(double V)
        {
            return (V - Abs(V)) / 2;
        }

        //Обчислення тиску
        public static double getPressure(double ro, double gamma, double l, double Z1, double Z2)
        {
            return gamma * (Z1 - Z2) / (ro * l);
        }

        //Обчислення додатку до коефіцієнта с
        public static double getAddition(double tau)
        {
            return 1 / (2 * tau);
        }

        //Обчислення f
        public static double getF(double V, double tau, double pressure)
        {
            return V / (2 * tau) - pressure;
        }
    }
}
