using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Manager_APP.Data;
using Store_Manager_APP.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Store_Manager_APP.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InventoryTabPage : ContentPage
    {
        public InventoryTabPage()
        {
            InitializeComponent();
        }

        public void OnItemAddClicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new AddItemPage());
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            InventoryClient inventoryClient = new InventoryClient();
            List<Inventory> inventory = await inventoryClient.GetInventoryAsync();
            var trends = new ObservableCollection<Inventory>(inventory);
            InventoryList.ItemsSource = trends;


        }

        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}