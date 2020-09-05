using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Store_Manager_APP.Models;

namespace Store_Manager_APP.Data
{
    public class BillsClient
    {
        private readonly HttpClient _client;

        public BillsClient()
        {
            _client = new HttpClient();
        }

        // API Calls :

        //Get : Bills (All)

        public async Task<List<Bills>> GetInventoryAsync()
        {

            HttpResponseMessage response = await _client.GetAsync(UriGenerator.GetUri("inventory"));
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Bills>>(content);
            }
            else
            {
                return new List<Bills>();
            }
        }

        //Get : Inventory/id (One Item)
        public async Task<Bills> GetItemAsync(string id)
        {

            HttpResponseMessage response = await _client.GetAsync(UriGenerator.GetUri("bills", id));
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Bills>(content);
            }
            else
            {
                return new Bills();
            }
        }

        //Put : Inventory/id (One Item)
        public async Task PutItemAsync(string id, Bills bill)
        {

            string json = JsonConvert.SerializeObject(bill);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PutAsync(UriGenerator.GetUri("bills", id), content);
            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine(@"\t Bill successfully saved.");
            }

        }

        //Post : Inventory/id (One Item)
        public async Task PostItemAsync(Bills inventory)
        {

            string json = JsonConvert.SerializeObject(inventory);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync(UriGenerator.GetUri("bills"), content);
            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine(@"\t Bill successfully Created.");
            }
        }

        //Delete : Inventory/id (One Item)
        public async Task DeleteItemAsync(string id)
        {

            HttpResponseMessage response = await _client.DeleteAsync(UriGenerator.GetUri("bills", id));
            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine(@"\t Bill successfully Deleted.");
            }
        }
    }
}
