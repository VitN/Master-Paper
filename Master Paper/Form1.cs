using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Master_Paper.SweepMethod;
using static Master_Paper.Velocity;
using static Master_Paper.OtherWork;

namespace Master_Paper
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Обчислення швидкості
        private void calcVeloc_Click(object sender, EventArgs e)
        {
            //Отримання даних з форми
            double Z1 = double.Parse(Z1_Value.Text);
            double Z2 = double.Parse(Z2_Value.Text);
            double tau = double.Parse(tau_Value.Text);
            double h1 = double.Parse(dx_Value.Text);
            int length = int.Parse(x1Length_Value.Text);

            int n = (int)(length / h1);
            int m = 20;

            double[,] V = new double[n + 1, m + 1];
            double right = 0.03, left = 0.067;                 //Значення швидкості на межах
            double ro = 9.98E+2;                               //Густина води
            double nu = 1.004E-2;                              //Кінематична в'язкість води
            double gamma = 12;                                 //Питома вага рідини

            Initialize(ref V, right, left, h1, length);

            double[] mu = new double[n + 1];
            double[] rPlus = new double[n + 1];
            double[] rMinus = new double[n + 1];
            double[] a = new double[n + 1];
            double[] b = new double[n + 1];
            double[] c = new double[n + 1];
            double[] f = new double[n + 1];

            double[] alpha = new double[n + 1];
            double[] betha = new double[n + 1];

            alpha[1] = 0; betha[1] = V[0, 0];
            //Метод прогонки
            for (int j = 1; j <= m; j++)
            {
                for (int i = 2; i <= n; i++)
                {
                    mu[i - 1] = getMu(h1, V[i - 1, j - 1], nu);
                    rPlus[i - 1] = getRPlus(V[i - 1, j - 1]);
                    rMinus[i - 1] = getRMinus(V[i - 1, j - 1]);

                    a[i - 1] = getA(mu[i - 1], rMinus[i - 1], h1);
                    b[i - 1] = getB(mu[i - 1], rPlus[i - 1], h1);
                    c[i - 1] = getC(mu[i - 1], rPlus[i - 1], rMinus[i - 1], getAddition(tau), h1);
                    f[i - 1] = getF(V[i - 1, j - 1], tau, getPressure(ro, gamma, length, Z1, Z2));

                    alpha[i] = getAlpha(a[i - 1], b[i - 1], c[i - 1], alpha[i - 1]);
                    betha[i] = getBetha(a[i - 1], b[i - 1], c[i - 1], f[i - 1], alpha[i - 1], betha[i - 1]);
                }

                for (int i = n; i >= 2; i--)
                    V[i - 1, j] = getValue(V[i, j], alpha[i], betha[i]);
            }


        }
    }
}
