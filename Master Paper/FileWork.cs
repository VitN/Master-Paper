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
        public static void Write(string path, double[,] array)
        {
            using (StreamWriter write = new StreamWriter(path))
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        write.Write($"{array[i, j]:F6} ");
                    }
                }
            }
        }

        public static double[,] Read(string path)
        {
            string[] lines = File.ReadAllLines(path);
            double[,] array = new double[lines.Length, lines[0].Split(' ').Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                    array[i, j] = Convert.ToDouble(temp[j]);
            }
     
            return array;
        }
    }
}
