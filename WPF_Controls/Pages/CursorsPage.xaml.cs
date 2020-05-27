using System.Windows;
using System.Windows.Controls;

namespace WpfControls.Pages
{
    /// <summary>
    /// Interaction logic for CursorsPage.xaml
    /// </summary>
    public partial class CursorsPage : Page
    {
        public CursorsPage()
        {
            InitializeComponent();
            CustomCursorGrid.Cursor = ((FrameworkElement)Resources["CursorBusy"]).Cursor;
        }
    }
}