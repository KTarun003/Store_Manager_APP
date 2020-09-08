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
            List<Item> items = new List<Item>();
            InventoryClient inventoryClient = new InventoryClient();
            List<Inventory> inventory = await inventoryClient.GetInventoryAsync();
            foreach (var billItem in bill.Items)
            {
                foreach (var item in inventory)
                {
                    if (!item.Id.Equals(billItem.ItemId)) continue;
                    billItem.Name = item.Name;
                    billItem.Type = item.Type;
                    billItem.Size = item.Size;
                    billItem.Price = item.Price;
                }
            }
            ItemsList.ItemsSource = bill.Items;
        }
    }
}