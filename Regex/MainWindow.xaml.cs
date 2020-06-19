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
using System.Text.RegularExpressions;

namespace RegexDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(
            @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, RoutedEventArgs e)
        {
            if (regex.IsMatch(txtValidate.Text))
            {
                MessageBox.Show("Yup, email.");
            }
            else
            {
                MessageBox.Show("Purportedly not an email.");
            }
        }

        private void btnParse_Click(object sender, RoutedEventArgs e)
        {
            MatchCollection matchedEmails = regex.Matches(txtParse.Text);
            string matches = "";

            for (int count = 0; count < matchedEmails.Count; count++)
                matches += matchedEmails[count].Value + Environment.NewLine;

            MessageBox.Show(matches);
        }
    }
}
