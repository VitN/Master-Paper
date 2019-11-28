using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Master_Paper
{
    //Клас для методу прогонки
    class SweepMethod
    {
        //Обчислення коефіцієнта а
        public double getA(double mu, double rMinus, double h1)
        {
            return Pow(mu, 2) / Pow(h1, 2) - Pow(rMinus, 2) / h1;
        }

        //Обчислення коефіцієнта b
        public double getB(double mu, double rPlus, double h1)
        {
            return Pow(mu, 2) / Pow(h1, 2) + Pow(rPlus, 2) / h1;
        }

        //Обчислення коефіцієнта b
        public double getC(double mu, double rPlus, double rMinus, double Addition, double h1)
        {
            return 2 * Pow(mu, 2) / Pow(h1, 2) + (Pow(rPlus, 2) - Pow(rMinus, 2)) / h1;
        }

        //Обчислення коефіцієнта альфа 
        public double getAlpha(double a, double b, double c, double alphaPrev)
        {
            return b / (c - alphaPrev / a);
        }

        //Обчислення коефіцієнта бета
        public double getBetha(double a, double b, double c, double f, double alphaPrev, double bethaPrev)
        {
            return  (a * bethaPrev + f)/ (c * c - alphaPrev * alphaPrev / (a * a));
        }

        //Обчислення значення концентрації чи швидкості
        public double getValue(double NextValue, double alpha, double betha)
        {
            return alpha * NextValue + betha;
        }
    }
}
