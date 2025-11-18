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

namespace WpfScope
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewWindow(object sender, RoutedEventArgs e)
        {
            MainWindow newWindow = new MainWindow();
            newWindow.Show();
        }

        private void CountButton(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            switch(button.Tag)
            {
                case "+":
                    count++;
                break;
                case "-":
                    count--;
                break;
            }

            resultField.Text = count.ToString();
        }
    }
}
