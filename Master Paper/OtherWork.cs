using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Paper
{
    static class OtherWork
    {
        //Перевірка на рівність двох масивів
        public static bool Equal(double[] var, double[] fileVar)
        {
            bool flag = true;

            for (int i = 0; i < var.Length; i++)
            {
                if (fileVar[i] == var[i])
                    flag &= true;
                else
                    flag &= false;
            }

            return flag;
        }

        //Транспонування масиву
        public static double[,] Transpose(double[,] array)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);

            double[,] newArr = new double[m, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    newArr[j, i] = array[i, j];
                }

            return newArr;
        }

        //Заповнення таблиці на формі даними
        public static void FillData(object dataView, double[,] array, double tau, double h)
        {
            int n = array.GetLength(0);
            int m = array.GetLength(1);

            DataGridView data = (DataGridView)dataView;
            data.RowCount = m;
            data.ColumnCount = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    data.Rows[j].Cells[i].Value = array[i, j];
                    data.Rows[j].HeaderCell.Value = "t = " + tau * j;
                }
                data.Columns[i].HeaderCell.Value = "x = " + h * i;
            }
        }
    }
}
