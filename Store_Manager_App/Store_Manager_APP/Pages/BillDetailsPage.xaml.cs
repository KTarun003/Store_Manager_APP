using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Store_Manager_APP.Data;
using Store_Manager_APP.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Store_Manager_APP.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BillDetailsPage : ContentPage
    {
        public BillDetailsPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            Bills bill = (Bills)BindingContext;
            InventoryClient inventoryClient = new InventoryClient();
            List<Inventory> items = new List<Inventory>();
            foreach (var item in bill.Items)
            {
                Inventory content = await inventoryClient.GetItemAsync(item.ItemId);
                items.Add(content);
            }
            ItemsList.ItemsSource = items;
        }
    }
}