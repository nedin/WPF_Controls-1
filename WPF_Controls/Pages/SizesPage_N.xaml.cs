using System.Windows;
using System.Windows.Controls;

namespace WpfControls.Pages
{
    /// <summary>
    /// Interaction logic for SizesPage_N.xaml
    /// </summary>
    public partial class SizesPage_N : Page
    {
        public SizesPage_N()
        {
            InitializeComponent();
        }

        private void LeftActionButton_Click(object sender, RoutedEventArgs e)
        {
            LeftMessage.Text = $"Width: {LeftActionButton.Width}\nDesired Width: {LeftActionButton.DesiredSize.Width}\nActualSize: {LeftActionButton.ActualWidth}";
        }

        private void RightActionButton_Click(object sender, RoutedEventArgs e)
        {
            RightMessage.Text = $"Width: {RightActionButton.Width}\nDesired Width: {RightActionButton.DesiredSize.Width}\nActualSize: {RightActionButton.ActualWidth}";
        }
    }
}