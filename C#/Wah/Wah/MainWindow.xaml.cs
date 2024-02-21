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

namespace Wah
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double originalWidth;
        private double originalHeight;

        public MainWindow()
        {
            InitializeComponent();

            originalWidth = myLabel.Width;
            originalHeight = myLabel.Height;
        }

        private void ResizeButton_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Width += 10;
            myLabel.Height += 5;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Width = originalWidth;
            myLabel.Height = originalHeight;
        }

        private void ChangeBackgroundButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            System.Windows.Media.Color newColor = System.Windows.Media.Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));

            myLabel.Background = new System.Windows.Media.SolidColorBrush(newColor);
        }
    }
}
