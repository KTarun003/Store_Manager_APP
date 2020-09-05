using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store_Manager_APP.Data;
using Xamarin.Forms;

namespace Store_Manager_APP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            DashboardClient dashboard = new DashboardClient();
            BindingContext = await dashboard.GetDashboardAsync();
        }
    }
}
