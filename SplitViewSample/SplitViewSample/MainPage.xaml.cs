using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SplitViewSample
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OptionButtonClick(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;

            var message = new MessageDialog(button.Content.ToString());
            await message.ShowAsync();
        }

        private void TogglePane1ButtonClick(object sender, RoutedEventArgs e)
        {
            if (LayoutRoot.IsPaneOpen)
            {
                if (LayoutRoot.DisplayMode == SplitViewDisplayMode.Inline)
                {
                    LayoutRoot.DisplayMode = SplitViewDisplayMode.CompactInline;
                }
            }
            else
            {
                if (LayoutRoot.DisplayMode == SplitViewDisplayMode.CompactInline)
                {
                    LayoutRoot.DisplayMode = SplitViewDisplayMode.Inline;
                }
            }

            LayoutRoot.IsPaneOpen = !LayoutRoot.IsPaneOpen;
        }

        private void ImageButtonClick(object sender, RoutedEventArgs e)
        {
            MyRelativePanel.Visibility = Visibility.Collapsed;
            MyImage.Visibility = Visibility.Visible;
        }

        private void RelativePanelButtonClick(object sender, RoutedEventArgs e)
        {
            MyRelativePanel.Visibility = Visibility.Visible;
            MyImage.Visibility = Visibility.Collapsed;
        }
    }
}
