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
        
        //Крайова умова
        public static void Initialize(ref double[,] V, double right, double left, double h1, double xLen)
        {
            int n = V.GetLength(0);
            int m = V.GetLength(1);

            //Граничні умови
            for (int j = 0; j <= m; j++)
            {
                V[0, j] = left;
                V[n, j] = right;
            }

            //Початкова умова
            double x = 0;
            for (int i = 1; i < n; i++)
            {
                x = i * h1;
                V[i, 0] = (V[0, 0] - V[n, 0]) * x / xLen + V[0, 0];
            }
        }
    }
}
