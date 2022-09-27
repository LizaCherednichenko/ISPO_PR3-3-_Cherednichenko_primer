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



        }
    }
}
