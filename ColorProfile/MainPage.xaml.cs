﻿using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ColorProfile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public SettingsModel ViewModel = new SettingsModel();

        public MainPage()
        {
            this.InitializeComponent();
            ImageViewScrollViewer.ChangeView(null, ImageView.Width / 2, null);
            Window.Current.SizeChanged += Current_SizeChanged;
            Loaded += MainPage_Loaded;
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationView.GetForCurrentView().TitleBar.ButtonBackgroundColor = Colors.Transparent;
            ApplicationView.GetForCurrentView().TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Picture1.Width = ActualWidth;
            Picture2.Width = ActualWidth;
            Picture3.Width = ActualWidth;
            Picture4.Width = ActualWidth;
            ViewModel.RefreshEverything();
        }

        private void Current_SizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
            Picture1.Width = e.Size.Width;
            Picture2.Width = e.Size.Width;
            Picture3.Width = e.Size.Width;
            Picture4.Width = e.Size.Width;
        }
    }
}
