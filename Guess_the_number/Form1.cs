using MahApps.Metro.Controls.Dialogs;
using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Guess_the_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = "";
            bool validInput = false;
            int iterator = 0;
            while (!validInput)
            {
                input = Microsoft.VisualBasic.Interaction.InputBox("Введите число:", "Запрос числа");
                int num;
                if (int.TryParse(input, out num))
                {
                    validInput = true;
                }
                else
                {
                    MessageBox.Show("Вы ввели некорректное значение");
                }
            }
            int min = 0;
            int max = 2000;
            int guess = 0;
            while (min <= max)
            {
                iterator++;
                guess = (min + max) / 2;
                DialogResult rez = MessageBox.Show($"Ваше число больше {guess}?", "Угадайка", MessageBoxButtons.YesNo);
                if (rez == DialogResult.Yes)
                {
                    min = guess + 1;
                }
                else
                {
                    max = guess - 1;
                }
            }
            MessageBox.Show($"Мы угадали ваше число это - {guess + 1}\nНам понадобалось {iterator} попыток", "Угадайка");
        }
    }
}
