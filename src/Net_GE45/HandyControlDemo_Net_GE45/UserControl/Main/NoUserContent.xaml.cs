using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Messaging;
using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Properties.Langs;
using HandyControlDemo.Data;
using HandyControlDemo.Tools;
using HandyControlDemo.Window;


namespace HandyControlDemo.UserControl
{
    public partial class NoUserContent
    {
        public NoUserContent()
        {
            InitializeComponent();
        }

        private void ButtonLangs_OnClick(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button && button.Tag is string tag)
            {
                PopupConfig.IsOpen = false;
                if (tag.Equals(GlobalData.Config.Lang)) return;
                Growl.Ask(Properties.Langs.Lang.ChangeLangAsk, b =>
                {
                    if (!b) return true;
                    GlobalData.Config.Lang = tag;
                    GlobalData.Save();
                    var ci = new CultureInfo(GlobalData.Config.Lang);
                    Thread.CurrentThread.CurrentUICulture = ci;
                    //Thread.CurrentThread.CurrentUICulture = ci;
                    //Process.Start(Process.GetCurrentProcess().MainModule.FileName);
                    //Application.Current.Shutdown();
                    //Application.Current.MainWindow?.InvalidateVisual();
                    Lang.UpdateLang(ci);
                    return true;
                });
            }
        }

        private void ButtonConfig_OnClick(object sender, RoutedEventArgs e) => PopupConfig.IsOpen = true;

        private void ButtonSkins_OnClick(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is Button button && button.Tag is SkinType tag)
            {
                PopupConfig.IsOpen = false;
                if (tag.Equals(GlobalData.Config.Skin)) return;
                GlobalData.Config.Skin = tag;
                GlobalData.Save();
                ((App)Application.Current).UpdateSkin(tag);
            }
        }

        private void MenuItemLinks_OnClick(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is MenuItem menuItem && menuItem.Tag is string tag)
            {
                Process.Start(tag);
            }
        }

        private void MenuItemQQGroup_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<object>(null, MessageToken.ClearLeftSelected);
            Messenger.Default.Send(true, MessageToken.FullSwitch);
            Messenger.Default.Send(AssemblyHelper.CreateInternalInstance($"UserControl.{MessageToken.QQGroupView}"), MessageToken.LoadShowContent);
        }

        private void MenuItemContributors_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send<object>(null, MessageToken.ClearLeftSelected);
            Messenger.Default.Send(true, MessageToken.FullSwitch);
            Messenger.Default.Send(AssemblyHelper.CreateInternalInstance($"UserControl.{MessageToken.ContributorsView}"), MessageToken.LoadShowContent);
        }

        private void MenuAbout_OnClick(object sender, RoutedEventArgs e)
        {
            new AboutWindow
            {
                Owner = Application.Current.MainWindow
            }.ShowDialog();
        }
    }
}
