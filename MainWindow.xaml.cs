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

namespace ISPO_PR3_3__Cherednichenko_primer
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

        private void Pusk_Click(object sender, RoutedEventArgs e)
        {
            //Получение исходных данных из TextBox
            double x = Convert.ToDouble(X.Text);
            double y = Convert.ToDouble(Y.Text);
            double z = Convert.ToDouble(Z.Text);

            //Ввод исходных данных в окно результатов
            Itog.Text = "Результаты работы программы ст. гр. 402 ИСП Чередниченко Е.К." + Environment.NewLine;
            Itog.Text += "При X = " + X.Text + Environment.NewLine;
            Itog.Text += "При Y = " + Y.Text + Environment.NewLine;
            Itog.Text += "При Z = " + Z.Text + Environment.NewLine;

            //Определение номера выбранной функции
            int n = 0;
            double u;

            if (Radio2.IsChecked == true) n = 1;
            else if (Radio3.IsChecked == true) n = 2;

            //Вычисление U
            switch (n)
            {
                case 0:
                    if ((z - x) == 0) u = y * Math.Sin(x) * Math.Sin(x) + z;
                    else if ((z - x) < 0) u = y * Math.Exp(Math.Sin(x)) - z;
                    else u = y * Math.Sin(Math.Sin(x)) + z;
                    Itog.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;

                case 1:
                    if ((z - x) == 0) u = y * Math.Cos(x) * Math.Cos(x) + z;
                    else if ((z - x) < 0) u = y * Math.Exp(Math.Cos(x)) - z;
                    else u = y * Math.Sin(Math.Cos(x)) + z;
                    Itog.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;

                case 2:
                    if ((z - x) == 0) u = y * Math.Exp(x) * Math.Exp(x) + z;
                    else if ((z - x) < 0) u = y * Math.Exp(Math.Exp(x)) - z;
                    else u = y * Math.Sin(Math.Exp(x)) + z;
                    Itog.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
                    break;
            }

        }

        private void Clin_Click(object sender, RoutedEventArgs e)
        {
            Itog.Clear(); 
        }
    }
}
