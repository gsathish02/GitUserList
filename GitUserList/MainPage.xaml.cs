using System.Collections.Generic;
using Xamarin.Forms;
using GitUserList.Model;
using System.Threading.Tasks;
using GitUserList.Helper;

namespace GitUserList
{
    public partial class MainPage : ContentPage
    {
        public IList<Users> GitContacts {get; private set;}

        private async void MainListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                // clear selected item
                var listView = (ListView)sender;
                listView.SelectedItem = null;

                var selctedItem = e.SelectedItem as Users;
                // Navigating to new page
                await Navigation.PushAsync(new SecondaryPage(selctedItem.OwnerList.OwnerGitUrl));
            }  
        }
         
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //Make API call while view appear
            await UpdatePostsAsync();
        }

        public async Task UpdatePostsAsync()
        {
            var newUsers = await JsonHelper.GetPostsAsync();
            GitContacts.Clear();
            newUsers.ForEach((userList) =>
            {
                GitContacts.Add(userList);
            });

            //Binding this data to UI
            BindingContext = this;
        }

        public MainPage()
        {
            InitializeComponent();
            GitContacts = new List<Users>();
        }
    }
}
