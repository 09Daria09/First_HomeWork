using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_HomeWork
{
    public partial class Form1 : Form
    {
        public static int MessageBoxCount = 0;
        public Form1()
        {
            InitializeComponent();
            MessageBoxCount++;
            string Text1 = "Меня зовут Кукуруза Дарья Романовна";
            MessageBox.Show(Text1, "Резюме", MessageBoxButtons.OK);
            MessageBoxCount++;
            string Text2 = "Я являюсь начинающим программистом, владею языками программирования С++, С#, JS и имею опыт в создании приложений на Unity. " +
                "Моя цель - получение опыта работы и постоянное совершенствование своих навыков в области программирования.";
            MessageBox.Show(Text2, "Навыки", MessageBoxButtons.OK);
            MessageBoxCount++;
            string Text3 = "Я имею навыки работы с английским языком на уровне B1 и владею немецким языком на уровне A2, " +
                "что позволяет мне эффективно общаться с иностранными коллегами и клиентами.";
            MessageBox.Show(Text3, "Языки", MessageBoxButtons.OK);
            MessageBoxCount++;
            string Text4 = "Среднее образование (11 классов), школа №4\nНезаконченное высшее образование по специальности \"Тележурналистика\", Киевский Национальный Университет Культуры и Искусств.\nКурс по программированию на втором курсе в \"ШАГ\".";
            MessageBox.Show(Text4, "Образование", MessageBoxButtons.OK);

            string ResultText = Text1 + Text2 + Text3 + Text4;
            double ResultCount = ResultText.Length /MessageBoxCount;
            MessageBox.Show("Среднее число символов", $"{ResultCount}");
        }
    }
}
