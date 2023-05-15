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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Culkul
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void sin_Click(object sender, RoutedEventArgs e)
        {
            StaticData.TrigExpr = "sin(";
            this.Close();
        }
        private void cos_Click(object sender, RoutedEventArgs e)
        {
            StaticData.TrigExpr = "cos(";
            this.Close();
        }
        private void tan_Click(object sender, RoutedEventArgs e)
        {
            StaticData.TrigExpr = "tan(";
            this.Close();
        }
        private void arcsin_Click(object sender, RoutedEventArgs e)
        {
            StaticData.TrigExpr = "arcsin(";
            this.Close();
        }
        private void arccos_Click(object sender, RoutedEventArgs e)
        {
            StaticData.TrigExpr = "arccos(";
            this.Close();
        }
        private void arctan_Click(object sender, RoutedEventArgs e)
        {
            StaticData.TrigExpr = "arctan(";
            this.Close();
        }
    }
}