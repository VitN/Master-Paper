using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Master_Paper
{
    //Клас для методу прогонки
   static class SweepMethod
    {
        //Обчислення коефіцієнта а
        //для поздовжньої прогонки
        public static double getA(double mu, double rMinus, double h1)
        {
            return Pow(mu, 2) / Pow(h1, 2) - Pow(rMinus, 2) / h1;
        }
        
        //для поперечної прогонки
        public static double getA(double h2)
        {
            return 1 / Pow(h2, 2);
        }

        //Обчислення коефіцієнта b
        //для поздовжньої прогонки
        public static double getB(double mu, double rPlus, double h1)
        {
            return Pow(mu, 2) / Pow(h1, 2) + Pow(rPlus, 2) / h1;
        }

        //для поперечної прогонки
        public static double getB(double h2)
        {
            return 1 / Pow(h2, 2);
        }

        //Обчислення коефіцієнта c
        //для поздовжньої прогонки
        public static double getC(double mu, double rPlus, double rMinus, double Addition, double h1)
        {
            return 2 * Pow(mu, 2) / Pow(h1, 2) + (Pow(rPlus, 2) - Pow(rMinus, 2)) / h1 + Addition;
        }

        //для поперечної прогонки
        public static double getC(double h2, double gamma, double D, double tau)
        {
            return 2 / Pow(h2, 2) + 0.5 * gamma / D + 0.5 / (D * tau);
        }

        //Обчислення коефіцієнта альфа 
        public static double getAlpha(double a, double b, double c, double alphaPrev)
        {
            return b / (c - alphaPrev / a);
        }

        //Обчислення коефіцієнта бета
        public static double getBetha(double a, double b, double c, double f, double alphaPrev, double bethaPrev)
        {
            return  (a * bethaPrev + f)/ (c * c - alphaPrev * alphaPrev / (a * a));
        }

        //Обчислення значення концентрації чи швидкості
        public static double getValue(double NextValue, double alpha, double betha)
        {
            return alpha * NextValue + betha;
        }
    }
}
