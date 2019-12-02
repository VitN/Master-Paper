using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Master_Paper
{
    static class FileWork
    {
        //Запис у файл двовимірного масиву
        public static void Write(string path, double[,] array)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   for (int i = 0; i < array.GetLength(0); i++)
                    {
                        writer.Write($"{array[i, j]:F8}");
                        if (i != array.GetLength(0) - 1)
                        {
                            writer.Write(" ");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }

        //Зчитування з файла масиву
        public static double[,] ReadAllLines(string path, int n)
        {
            string[] lines = File.ReadAllLines(path);
            double[,] array = new double[lines.Length - n, lines[n].Split(' ').Length];

            for (int i = n; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                    array[i - n, j] = Convert.ToDouble(temp[j]);
            }
     
            return array;
        }

        //Запис у файл одновимірного масиву
        public static void Write(string path, double[] array)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                for (int j = 0; j < array.Length; j++)
                {
                        writer.Write($"{array[j]:F8}");
                        if (j != array.GetLength(0) - 1)
                        {
                            writer.Write(" ");
                        }
                }
                writer.WriteLine();
            }
        }

        //Зчитування з файлу параметрів
        public static double[] ReadOneLine(string path, int n)
        {
            string[] lines = File.ReadAllLines(path);
            double[] array = new double[lines[n].Split(' ').Length];

            string[] temp = lines[n].Split(' ');
            for (int j = 0; j < temp.Length; j++)
                array[j] = Convert.ToDouble(temp[j]);

            return array;
        }
    }
}
