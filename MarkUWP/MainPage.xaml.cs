using MarkUWP.Views;
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

        /// <summary>
        /// detect when NavigationViewMenu Pane is Collaped
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPaneClosing(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewPaneClosingEventArgs args)
        {
            AdaptiveBodyContainer(sender.IsPaneOpen);
        }

        /// <summary>
        /// detect when NavigationViewMenu Pane is Expanded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnPaneOpening(Microsoft.UI.Xaml.Controls.NavigationView sender, object args)
        {
            AdaptiveBodyContainer(sender.IsPaneOpen);
        }

        /// <summary>
        /// set Margin BodyContainer from left SideNave
        /// </summary>
        /// <param name="isPaneOpen"></param>
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

        /// <summary>
        /// handle NavigationMenuItem clicks, show the Popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SideNav_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            /// handle navigation view item menu click
            if (args.InvokedItemContainer != null)
            {
                /// determine Popup Content based on Tag name NavigationMenuItem
                var navItemTag = args.InvokedItemContainer.Tag.ToString();
                PopupContent.Content = new LoginForm();

                /// show Popup
                if (MainPopup.Visibility == Visibility.Collapsed) { MainPopup.Visibility = Visibility.Visible; }
            }
            //else if (args.IsSettingsInvoked == true)
            //{
            //}
        }

        /// <summary>
        /// hide the Popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPopup_ClosePopup(object sender, RoutedEventArgs e)
        {
            if (MainPopup.Visibility == Visibility.Visible) { MainPopup.Visibility = Visibility.Collapsed; }
        }
    }
}
