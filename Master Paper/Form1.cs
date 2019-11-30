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
            double right = 0.03, left = 0.067;

            Initialize(ref V, right, left, h1, length);
            
            double[] mu, rPlus, rMinus, a, b, c, f, alpha, beta;
            

            for (int j = 1; j <= m; j++)
                for (int i = 2; i <= n; i++)
                {
                   
                }
  
            
        }


    }
}
