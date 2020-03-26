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

namespace ShowDialogDemo
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

        private void BtnShowDialog_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Dialog();
            var result = dialog.ShowDialog();
            int x = 5;
        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Dialog();
            dialog.Show();
            int x = 5;
        }
    }
}
