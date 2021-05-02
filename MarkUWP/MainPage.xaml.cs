using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MarkUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnPaneClosing(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewPaneClosingEventArgs args)
        {
            AdaptiveBodyContainer(sender.IsPaneOpen);
        }

        private void OnPaneOpening(Microsoft.UI.Xaml.Controls.NavigationView sender, object args)
        {
            AdaptiveBodyContainer(sender.IsPaneOpen);
        }

        private void AdaptiveBodyContainer(bool isPaneOpen)
        {
            if (isPaneOpen)
            {
                BodyContainer.Margin = new Thickness(200, 0, 0, 0);
            }
            else
            {
                BodyContainer.Margin = new Thickness(40, 0, 0, 0);
            }
        }

        private void SideNav_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            //if (args.IsSettingsInvoked == true)
            //{
            //}
            //else

            /// handle navigation view item menu click
            if (args.InvokedItemContainer != null)
            {
            }
        }
    }
}