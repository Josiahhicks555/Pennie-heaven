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

namespace Pennie_Heaven
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

        }

        



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //int change = 0;

            int dollar = 1;
            int quarter = 4;
            int dime = 10;
            int nickel = 20;
            int pennies = 100;

            if (dollar >= 1)
            {

                
                numbDollar.Text = Dollar.Text;
                numbQuarters.Text = quarter + Dollar.Text;
                numbDimes.Text = dime + Dollar.Text;
                numbNickles.Text = nickel + Dollar.Text;
                numbPennies.Text = pennies + Dollar.Text;

               
            }

            else
            {
                numbDollar.ToString();
                numbQuarters.ToString();
                numbDimes.ToString();
                numbNickles.ToString();
                numbPennies.ToString();
            }

            


            //numbDollar.Text = Dollar.Text;

            // if (numbDollar.Text >= 1)
            // {
            //       numbQuarters = numbDollar * 25 %;

            // }


            //numbQuarters.Text = Dollar.Text / 25;
            // numbDimes.Text = Dollar.Text /;
            // numbNickles.Text = Dollar.Text /;
            //numbPennies.Text = Dollar.Text /;
        }


    }
}
