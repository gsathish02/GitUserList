using GitUserList.Model;
using Xamarin.Forms;

namespace GitUserList
{
    public partial class SecondaryPage : ContentPage
    {
        public Users SelectedUser { get; }

        public SecondaryPage(string url)
        {
            InitializeComponent();
            // setting url to webview
            MyWebView.Source = url;
        }
    }
}
