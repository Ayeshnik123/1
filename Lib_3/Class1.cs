using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_3
{
    public class Class1
    {
        // Генерировать случайные числа Х, распределенные в диапазоне от -4 до 7 и вычислять для чисел > 0 X, а для чисел < 0 функцию x2. 
        //Вычисления прекратить, когда подряд появится два одинаковых случайных числа.На экран необходимо выводить сгенерированное число и результат расчета функции на разных строках.
        public static void Go(TextBox tbNumbers, TextBox tbRezults)
        {
            int a,
                b;
            Random rand = new Random();
            a = rand.Next(-4, 7);
            tbNumbers.Text += a.ToString() + " ";

            if (a > 0)
            {
                tbRezults.Text += a.ToString() + " ";
            }
            else
            {
                tbRezults.Text += (a * a).ToString() + " ";
            }

            do
            {
                b = a;
                a = rand.Next(-4, 7);
                tbNumbers.Text += a.ToString() + " ";
                if (a > 0)
                {
                    tbRezults.Text += a.ToString() + " ";
                }
                else
                {
                    tbRezults.Text += (a * a).ToString() + " ";
                }
            }
            while (a != b);
        }
    }
}
