using MaterialDesignThemes.Wpf;
using System.Windows;

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
                button: MessageBoxButton.OK, 
                stylePrimaryColor: MaterialDesignColors.PrimaryColor.DeepOrange);
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
        
        private void button_MessageWithCaptionButtonImageColor_Click(object sender, RoutedEventArgs e)
        {
            MaterialMessageBox.ShowDialog(
                this,
                "Are you sure you are ready to fly this plane?",
                "Confirm Ready to Fly",
                MessageBoxButton.OKCancel,
                PackIconKind.Exclamation,
                MaterialDesignColors.PrimaryColor.DeepOrange);
        }
    }
}
