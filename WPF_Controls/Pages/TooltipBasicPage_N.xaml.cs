using System;
using System.Windows.Controls;

namespace WpfControls.Pages
{
    /// <summary>
    /// Interaction logic for TooltipBasicPage_N.xaml
    /// </summary>
    public partial class TooltipBasicPage_N : Page
    {
        public TooltipBasicPage_N()
        {
            InitializeComponent();
        }

        private void Image_ToolTipOpening(object sender, ToolTipEventArgs e)
        {
            var currentImage = sender as Image;

            if (currentImage != null)
            {
                currentImage.ToolTip = $"This tooltip created at {DateTime.Now.ToLongTimeString()}";
            }
        }
    }
}