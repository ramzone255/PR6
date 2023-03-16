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

namespace WpfAppPractwork1.Pages
{

    public partial class PagePR2 : Page
    {
        public PagePR2()
        {
            InitializeComponent();
        }


        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            double u;
            lstResult.Items.Add("Лаб.раб.№2. Выполнили Проказников,Ткаченко");
            lstResult.Items.Add($"X={x}");
            lstResult.Items.Add($"Y={y}");
            int n = 0;
            if (rbtCos.IsChecked == true) n = 1;
            else if (rbtExp.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if (y > -1 && y < x) u = Math.Sin(5 * Math.Sin(x) + 3 * y * Math.Abs(Math.Sin(x)));
                    else if (x > y) u = Math.Cos(3 * Math.Sin(x) + 5 * y * Math.Abs(Math.Sin(x)));
                    else if (x == y) u = Math.Pow(Math.Sin(x), 2);
                    else
                    {
                        u = 0; Console.WriteLine("Нет решений");
                    }
                    lstResult.Items.Add($"Результат U={Math.Round(u, 3)}");
                    break;
                case 1:
                    if (y > -1 && y < x) u = Math.Sin(5 * Math.Cos(x) + 3 * y * Math.Abs(Math.Cos(x)));
                    else if (x > y) u = Math.Cos(3 * Math.Cos(x) + 5 * y * Math.Abs(Math.Cos(x)));
                    else if (x == y) u = Math.Pow(Math.Cos(x), 2);
                    else
                    {
                        u = 0; Console.WriteLine("Нет решений");
                    }
                    lstResult.Items.Add($"Результат U={Math.Round(u, 3)}");
                    break;
                case 2:
                    if (y > -1 && y < x) u = Math.Sin(5 * Math.Exp(x) + 3 * y * Math.Abs(Math.Exp(x)));
                    else if (x > y) u = Math.Cos(3 * Math.Exp(x) + 5 * y * Math.Abs(Math.Exp(x)));
                    else if (x == y) u = Math.Pow(Math.Exp(x), 2);
                    else
                    {
                        u = 0; Console.WriteLine("Нет решений");
                    }
                    lstResult.Items.Add($"Результат U={Math.Round(u, 3)}");
                    break;
                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;
            }


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            lstResult.Items.Clear();
        }

    }

}
