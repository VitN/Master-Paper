using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Paper
{
     static class Input
    {
        static void parseValue(params double[] value)
        {
            void Object(params object[] text)
            {
                int n = value.Length;
                for (int i = 0, j = 0; i < n; i++, j++)
                {
                    value[i] = double.Parse(text[j].ToString());
                }
            }
        }
    }
}
