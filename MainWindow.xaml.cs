using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
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
using System.Globalization;
using AngouriMath;
using AngouriMath.Extensions;

namespace Culkul
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public static class StaticData
    {
        public static string TrigExpr = "";
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool IsNumberTest()
        {
            if (Expression.Text.Length > 0)
                if (Char.IsNumber(Expression.Text, Expression.Text.Length - 1) || Expression.Text[Expression.Text.Length - 1] == ')' || Expression.Text[Expression.Text.Length - 1] == 'e')
                    return true;
            return false;
        }
        private void Num0_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += '0';
        }
        private void Num1_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += '1';
        }
        private void Num2_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += '2';
        }
        private void Num3_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += '3';
        }
        private void Num4_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += '4';
        }
        private void Num5_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += '5';
        }
        private void Num6_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += '6';
        }
        private void Num7_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += '7';

        }
        private void Num8_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += '8';
        }
        private void Num9_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += '9';
        }
        private void trig_Click(object sender, RoutedEventArgs e)
        {
            Window1 trigWindow = new Window1();
            trigWindow.Owner = this;
            trigWindow.ShowDialog();
            Expression.Text += StaticData.TrigExpr;
            StaticData.TrigExpr = "";
        }
        private void pi_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += "pi";
        }
        private void e_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += 'e';
        }
        private void CE_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text = "";
            Solution.Text = "";
        }
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(Expression.Text))
            {
                Expression.Text = Expression.Text.Remove(Expression.Text.Length - 1);
            }
        }
        private void square_Click(object sender, RoutedEventArgs e)
        {
            if (IsNumberTest())
                Expression.Text += "^2";
        }
        private void onedivx_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += "1/";
        }
        private void abs_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += "abs(";
        }
        private void exp_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += "e^";
        }
        private void mod_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += "%";
        }
        private void sqrt_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += "sqrt(";
        }
        private void openbracket_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += '(';
        }
        private void closebracket_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += ')';
        }
        private void fact_Click(object sender, RoutedEventArgs e)
        {
            if (IsNumberTest())
                Expression.Text += '!';
        }
        private void div_Click(object sender, RoutedEventArgs e)
        {
            if (IsNumberTest())
                Expression.Text += '/';
        }
        private void deg_Click(object sender, RoutedEventArgs e)
        {
            if (IsNumberTest())
                Expression.Text += '^';
        }
        private void mult_Click(object sender, RoutedEventArgs e)
        {
            if (IsNumberTest())
                Expression.Text += '*';
        }
        private void deg10_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += "10^";
        }
        private void sub_Click(object sender, RoutedEventArgs e)
        {
            if (IsNumberTest())
                Expression.Text += '-';
        }
        private void log_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += "log(";
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (IsNumberTest())
                Expression.Text += '+';
        }
        private void ln_Click(object sender, RoutedEventArgs e)
        {
            Expression.Text += "ln(";
        }
        private void neg_Click(object sender, RoutedEventArgs e)
        {
            if (IsNumberTest())
                Expression.Text += "*(-1)";
        }
        private void dot_Click(object sender, RoutedEventArgs e)
        {
            if (Expression.Text.Length > 0)
                if (Char.IsNumber(Expression.Text, Expression.Text.Length - 1) )
                    Expression.Text += '.';
        }
        private void equals_Click(object sender, RoutedEventArgs e)
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-CA");
            double evalDouble;
            try
            {
                evalDouble = (double)Expression.Text.EvalNumerical();
                string specifier;
                if (evalDouble % 10.0 < 0.001)
                    specifier = "G";
                else
                    specifier = "N";
                if (evalDouble > 1000000000)
                    specifier = "E04";
                //Solution.Text = string.Format("{0}", evalDouble);
                Solution.Text = evalDouble.ToString(specifier, culture);
            }
            catch
            {
                Solution.Text = "Syntax error";
            }
        }

        public void sin_Click()
        {
            Expression.Text += "sin(";
        }
        public void cos_Click()
        {
            Expression.Text += "cos(";
        }
        public void tan_Click()
        {
            Expression.Text += "tan(";
        }
        public void arcsin_Click()
        {
            Expression.Text += "arcsin(";
        }
        public void arccos_Click()
        {
            Expression.Text += "arccos(";
        }
        public void arctan_Click()
        {
            Expression.Text += "arctan(";
        }
    }
}
