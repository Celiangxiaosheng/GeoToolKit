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
//using GaussProj;

namespace GeoToolKit
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
        private void But3_Click(object sender, RoutedEventArgs e)
        {
             //GuassWindow g1 = new GuassWindow();
             //g1.Show();
        }

        private void But_CopyRight_Click(object sender, RoutedEventArgs e)
        {           
            About a1= new About();
            a1.ShowDialog();
        }
        private void But_Helper_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
