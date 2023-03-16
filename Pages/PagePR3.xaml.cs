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
    /// Логика взаимодействия для PagePR3.xaml
    /// </summary>
    public partial class PagePR3 : Page
    {
        public PagePR3()
        {
            InitializeComponent();
        }

        private void Btn1Solve_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double X0 = Convert.ToDouble(TxtInputX0.Text);
                double Xk = Convert.ToDouble(TxtInputXk.Text);
                double Dx = Convert.ToDouble(TxtInputDx.Text);
                double b = Convert.ToDouble(TxtInputA.Text);
                LstResult.Items.Add("Практическая работа №3 МДК.01.01, студенты группы ИСП21.1А Проказников,Ткаченко");
                for (double i = X0; i <= Xk; i = i + Dx)
                {
                    double y = 0.8 * Math.Pow(10, -5) * Math.Pow((Math.Pow(i, 3) + Math.Pow(b, 3)), 7 / 6);
                    LstResult.Items.Add($"x = {i}, y = {y}");
                }
            }
            catch
            {
                Console.WriteLine("Проверьте вводимые данные!");
            
            double X0 = Convert.ToDouble(TxtInputX0.Text);
            double Xk = Convert.ToDouble(TxtInputXk.Text);
            double Dx = Convert.ToDouble(TxtInputDx.Text);
            double b = Convert.ToDouble(TxtInputA.Text);
            for (double i = X0; i <= Xk; i = i + Dx)
            {
                double y = 0.8 * Math.Pow(10, -5) * Math.Pow((Math.Pow(i, 3) + Math.Pow(b, 3)), 7 / 6);
                LstResult.Items.Add($"x = {i}, y = {y}");
            }
            }
        }
    }
    
}

    
