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

namespace Buttons
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
            MessageBox.Show(".....................................Hello to WPF.........", "Alert", MessageBoxButton.OK);
        }

        private void Rectangle_TouchDown(object sender, TouchEventArgs e)
        {
            MessageBox.Show("Helloooooooooooooooooooooooooooooooo");
        }

        private void Rectangle_Drop(object sender, DragEventArgs e)
        {
            MessageBox.Show("Drop");
        }
    }
}
