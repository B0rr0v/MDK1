using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib_5;
//Вычислить сумму целых случайных чисел, распределенных в диапазоне от - 7 до 3,
//пока эта сумма не превышает некоторого числа K. Вывести на экран
//сгенерированные числа, значение суммы, и количество сгенерированных чисел.

namespace MDK1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Агальцов Даниил ИСП-31 Практическая работа №1:Вычислить сумму целых случайных чисел, распределенных в диапазоне от - 7 до 3, пока эта сумма не превышает некоторого числа K.Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел.123");
        }

        private void Генерация(object sender, RoutedEventArgs e)
        {
            bool f = Int32.TryParse(chislK.Text, out int y);// проверка на числовой тип данных
            if (f)
            {
                Lib_5.Class1.разработка(y,out String outputtb1, out int count1, out int sum1);

                tb1.Text = outputtb1;
                kolvochisl.Text = Convert.ToString(count1);
                cymma.Text = Convert.ToString(sum1);
            } else { MessageBox.Show("ошибка");  }
        }

        private void Очистить(object sender, RoutedEventArgs e)// очистка полей в tb
        {
            cymma.Clear();
            kolvochisl.Clear();
            tb1.Clear();
            chislK.Clear();
        }
    }
}
