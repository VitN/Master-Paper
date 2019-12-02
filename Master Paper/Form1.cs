using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Master_Paper.SweepMethod;
using static Master_Paper.Velocity;
using static Master_Paper.Concentration;
using static Master_Paper.OtherWork;
using static Master_Paper.FileWork;

namespace Master_Paper
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            diffusion_Value.SelectedIndex = 0;
            massTransfer_Value.SelectedIndex = 0;
        }

        List<double[,]> C;
        List<double[,]> CAdd;

        //Обчислення швидкості
        private void calcVeloc_Click(object sender, EventArgs e)
        {
            //Отримання даних з форми
            double Z1 = double.Parse(Z1_Value.Text);
            double Z2 = double.Parse(Z2_Value.Text);
            double tau = double.Parse(tau_Value.Text);
            double h1 = double.Parse(dx_Value.Text);
            int length = int.Parse(x1Length_Value.Text);

            double[] var = { Z1, Z2, tau, h1, length };

            string path = @"Velocity.txt";

            double[] fileVar;


            if (File.Exists(path))
            {
                fileVar = ReadOneLine(path, 0);
            }
            else
            {
                fileVar = new double[var.Length];
            }

            //Перевірка рівності даних, введених на формі і записаних у файл
            //Якщо вони рівні, то швидкість повторно не обчислюється
            if (!Equal(var, fileVar))
            {
                File.Delete(path);
                int n = (int)(length / h1);
                int m = 20;

                double[,] V = new double[n + 1, m + 1];
                double left = 0.03, right = 0.067;                 //Значення швидкості на межах
                double ro = 9.98E+2;                               //Густина води
                double nu = 1.004E-2;                              //Кінематична в'язкість води
                double gamma = 12;                                 //Питома вага рідини

                Velocity.Initialize(ref V, right, left, h1, length);

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
                        mu[i - 1] = Velocity.getMu(h1, V[i - 1, j - 1], nu);
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

                //Запис даних, введених на формі у файл
                Write(path, var);
                //Запис масиву зі швидкостями у файл
                Write(path, V);

                FillData(dataGridView4, V, tau, h1, "t");
            }
            else
            {
                double[,] Vel = ReadAllLines(path, 1);
                FillData(dataGridView4, Transpose(Vel), tau, h1, "t");
            }
        }

        //Обчислення концентрації
        private void calcConc_Click(object sender, EventArgs e)
        {
            //Отримання даних з форми
            double tau = double.Parse(timeStep2_Value.Text);
            double h1 = double.Parse(xStep2_Value.Text);
            double h2 = double.Parse(yStep_Value.Text);
            int xLength = int.Parse(xLength_Value.Text);
            int yLength = int.Parse(yLength_Value.Text);

            int n = (int)(xLength / h1);
            int m = (int)(yLength / h2);
            int l = 20;

            double CBound = 0.05;
            double right = 0.05;
            double left = 0.001;

            string path = @"Velocity.txt";

            double[] var = { tau, h1, h2, xLength, yLength };
            double[,] V = new double[n + 1, l + 1];

            V = Transpose(ReadAllLines(path, 1));

            double D = double.Parse(diffusion_Value.Text);
            double gamma = double.Parse(massTransfer_Value.Text);

            //Список для поздовжньої прогонки
            C = new List<double[,]>();

            double[,] LiC = new double[n + 1, m + 1];

            //Список для поперчної прогонки
            CAdd = new List<double[,]>();


            Concentration.Initialize(ref LiC, right, left, h1, xLength);

            C.Add(LiC);

            double[] mu = new double[n + 1];
            double[] rPlus = new double[n + 1];
            double[] rMinus = new double[n + 1];
            double[] a = new double[n + 1];
            double[] b = new double[n + 1];
            double[] c = new double[n + 1];
            double[] f = new double[n + 1];

            double a1 = 0, b1 = 0, c1 = 0;

            a1 = getA(h2);
            b1 = getB(h2);
            c1 = getC(h2, gamma, D, tau);

            double[] f1 = new double[m + 1];

            double[] alpha = new double[n + 1];
            double[] betha = new double[n + 1];

            alpha[1] = 0; betha[1] = LiC[0, 0];

            double[] alpha1 = new double[m + 1];
            double[] betha1 = new double[m + 1];

            alpha1[1] = 0; betha1[1] = LiC[0, 0];

            for (int k = 1; k <= l; k++)
            {
                double[,] LiCAdd = new double[n + 1, m + 1];
                Initialize(ref LiCAdd, left, CBound);

                for (int j = 1; j < m; j++)
                {
                    for (int i = 1; i < n; i++)
                    {
                        mu[i] = Concentration.getMu(h1, V[i, k - 1], D);
                        rPlus[i] = getRPlus(V[i, k - 1]);
                        rMinus[i] = getRMinus(V[i, k - 1]);

                        a[i] = getA(mu[i], rMinus[i], h1);
                        b[i] = getB(mu[i], rPlus[i], h1);
                        c[i] = getC(mu[i], rPlus[i], rMinus[i], getAddition(D, gamma, tau), h1);
                        f[i] = getF(C[k - 1][i, j], CBound, gamma, D, tau);

                        alpha[i + 1] = getAlpha(a[i], b[i], c[i], alpha[i]);
                        betha[i + 1] = getBetha(a[i], b[i], c[i], f[i], alpha[i], betha[i]);
                    }

                    for (int i = n - 1; i >= 0; i--)
                        LiCAdd[i, j] = getValue(C[k - 1][i + 1, j], alpha[i + 1], betha[i + 1]);
                }

                CAdd.Add(LiCAdd);

                LiC = new double[n + 1, m + 1];
                Concentration.Initialize(ref LiC, right, left, h1, xLength);
                for (int i = 1; i < n; i++)
                {
                    for (int j = 1; j < m; j++)
                    {
                        f1[j] = getF(CAdd[k - 1][i, j], CBound, gamma, D, tau);

                        alpha1[j + 1] = getAlpha(a1, b1, c1, alpha[j]);
                        betha[j + 1] = getBetha(a1, b1, c1, f[j], alpha[j], betha[j]);

                        if (j == m)
                            LiC[i, j] = betha1[j] / (1 - alpha1[j]);
                    }

                    for (int j = m - 1; j >= 0; j--)
                        LiC[i, j] = getValue(C[k - 1][i, j + 1], alpha[j + 1], betha[j + 1]);
                }

                C.Add(LiC);

            }

            for (int i = 0; i < l; i++)
            {
                timeLayer_Value.Items.Add(i);
            }
        }

        private void tau_Value_TextChanged(object sender, EventArgs e)
        {
            timeStep2_Value.Text = ((TextBox)sender).Text;
        }

        private void dx_Value_TextChanged(object sender, EventArgs e)
        {
            xStep2_Value.Text = ((TextBox)sender).Text;
        }

        private void x1Length_Value_TextChanged(object sender, EventArgs e)
        {
            xLength_Value.Text = ((TextBox)sender).Text;
        }

        private void showConc_Click(object sender, EventArgs e)
        {
            double h1 = double.Parse(xStep2_Value.Text);
            double h2 = double.Parse(yStep_Value.Text);
            int layer = int.Parse(timeLayer_Value.Text);
            FillData(dataGridView5, C[layer], h2, h1, "y");
            FillData(dataGridView1, C[layer + 1], h2, h1, "y");
        }
    }
}
