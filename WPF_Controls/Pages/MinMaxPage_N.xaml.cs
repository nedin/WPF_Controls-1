using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfControls.Pages
{
    /// <summary>
    /// Interaction logic for MinMaxPage_N.xaml
    /// </summary>
    public partial class MinMaxPage_N : Page
    {
        public MinMaxPage_N()
        {
            InitializeComponent();
        }

        private static string _souceText = "The quick onyx goblin jumps over the lazy dwarf.Jinxed wizards pluck ivy from the big quilt.";
        private int _count = 10;

        private void AddLetters_Click(object sender, RoutedEventArgs e)
        {
            _count += 10;
            ButtonMinWidth.Content = ButtonMaxWidth.Content = _souceText.Substring(0, Math.Min(_count, _souceText.Length));
        }

        private void RemoveLetters_Click(object sender, RoutedEventArgs e)
        {
            _count -= 10;
            ButtonMinWidth.Content = ButtonMaxWidth.Content = _souceText.Substring(0, Math.Max(_count, 0));
        }
    }
}