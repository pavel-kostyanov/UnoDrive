using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UnoDrive.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Dashboard : Page
    {
        public Dashboard()
        {
            this.InitializeComponent();

            contentFrame.Navigate(typeof(MyFilesPage),null, new SuppressNavigationTransitionInfo());
        }

        void MenuItemSelected(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            // Signout is not implemented
            if (signOut == args.InvokedItemContainer)
                return;
            Type pageType;
            if (myFiles == args.InvokedItemContainer)
                pageType = typeof(MyFilesPage);
            else if (recentFiles == args.InvokedItemContainer)
                pageType = typeof(RecentFilesPage);
            else if (sharedFiles == args.InvokedItemContainer)
                pageType = typeof(SharedFilesPage);
            else if (recycleBin == args.InvokedItemContainer)
                pageType = typeof(RecycleBinPage);
            else
                return;
            contentFrame.Navigate(
            pageType, null, new CommonNavigationTransitionInfo());
        }
    }
}
