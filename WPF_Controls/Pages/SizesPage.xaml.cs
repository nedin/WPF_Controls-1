using System.Windows;
using System.Windows.Controls;

namespace WpfControls.Pages
{
    /// <summary>
    /// Interaction logic for SizesPage.xaml
    /// </summary>
    public partial class SizesPage : Page
    {
        public SizesPage()
        {
            InitializeComponent();
        }

        private void LeftActionButton_Click(object sender, RoutedEventArgs e)
        {
            string message = $"Width: {LeftActionButton.Width}\nDesired Width: {LeftActionButton.DesiredSize.Width}\nActualSize: {LeftActionButton.ActualWidth}";
            LeftMessage.Text = message;
        }

        private void RightActionButton_Click(object sender, RoutedEventArgs e)
        {
            string message = $"Width: {RightActionButton.Width}\nDesired Width: {RightActionButton.DesiredSize.Width}\nActualSize: {RightActionButton.ActualWidth}";
            RightMessage.Text = message;
        }
    }
}