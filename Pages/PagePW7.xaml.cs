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
    /// <summary>
    /// Логика взаимодействия для PagePW7.xaml
    /// </summary>
    public partial class PagePW7 : Page
    {
        public PagePW7()
        {
            InitializeComponent();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            LstResult.Items.Clear();
            double[] z = new double[35];
            Random random= new Random();
            double R = 0;
            double P = 0;
            double S = 0;
            LstResult.Items.Add("Практическая работа №7 МДК.01.01, Вариант №18, Проказников");
            for (int i = 0; i<35;i++)
            {
                z[i] = Math.Round(random.NextDouble(), 2) * 100 - 50;
                LstResult.Items.Add(z[i]);
                if (z[i]<3 && z[i] % 2 == 0)
                {
                   S = S + z[i];
                }
                if (z[i]>1 && z[i]%2==1)
                {
                    P = P + z[i];
                }
            }
            R = P + S;
            LstResult.Items.Add("...");
            LstResult.Items.Add("...");
            LstResult.Items.Add("...");
            LstResult.Items.Add($"R = {R}");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.frmObj.Navigate(new PageMain());
        }
    }
}
