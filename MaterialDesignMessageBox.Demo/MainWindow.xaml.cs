using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaterialDesignMessageBox.Demo
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

        private void button_MessageWithButton_Click(object sender, RoutedEventArgs e)
        {
            MaterialMessageBox.ShowDialog(
                this,
                "Unable to Login, invalid username and/or password.",
                null,
                MessageBoxButton.OK, MaterialDesignColors.PrimaryColor.DeepOrange);
        }

        private void button_MessageWithCaptionAndButton_Click(object sender, RoutedEventArgs e)
        {
            MaterialMessageBox.ShowDialog(
                this, 
                "Unable to Login, invalid username and/or password.", 
                "Login Failure",
                MessageBoxButton.OK);
        }

        private void button_MessageWithCaptionButtonImage_Click(object sender, RoutedEventArgs e)
        {
            MaterialMessageBox.ShowDialog(
                this,
                "Are you sure you want to eject the nuclear fuel rods?",
                "Confirm Fuel Ejection",
                MessageBoxButton.OKCancel,
                PackIconKind.Exclamation);
        }
    }
}
