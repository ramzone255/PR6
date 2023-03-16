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
    /// Логика взаимодействия для PagePW1.xaml
    /// </summary>
    public partial class PagePW1 : Page
    {
        public PagePW1()
        {
            InitializeComponent();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TxtInputX.Text);
            double y = Convert.ToDouble(TxtInputY.Text);
            double z = Convert.ToDouble(TxtInputZ.Text);
            double v = ((1+Math.Pow(Math.Sin(x),2)/Math.Abs(x-((2*y)/(1+Math.Pow(x,2)*Math.Pow(y,2))))*Math.Pow(x,Math.Abs(y))+Math.Pow(Math.Cos(Math.Atan(1/z)),2)));
            LstResult.Items.Clear();
            LstResult.Items.Add("Практическая работа №1 МДК.01.01, студенты группы ИСП21.1А Проказников,Ткаченко");
            LstResult.Items.Add($"x = {x}");
            LstResult.Items.Add($"y = {y}");
            LstResult.Items.Add($"z = {z}");
            LstResult.Items.Add($"Результат v = {v}");
        }
    }
}
