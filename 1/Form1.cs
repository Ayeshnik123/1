using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_3;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // расчет
        private void work_Click(object sender, EventArgs e)
        {
            outRezults.Clear();
            outNumbers.Clear();

            Class1.Go(outNumbers, outRezults);
        }
        // сброс
        private void reset_Click(object sender, EventArgs e)
        {
            outRezults.Clear();
            outNumbers.Clear();
        }
        // изменение входного текстбокса
        private void sourceK_TextChanged(object sender, EventArgs e)
        {
            outRezults.Clear();
            outNumbers.Clear();
        }
        // о прграмме
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Генерировать случайные числа Х, распределенные в диапазоне от -4 до 7 и вычислять для чисел > 0 X, а для чисел < 0 функцию x2." +
                "Вычисления прекратить, когда подряд появится два одинаковых случайных числа.На экран необходимо выводить сгенерированное число и результат расчета функции на разных строках.");
        }
        // выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
