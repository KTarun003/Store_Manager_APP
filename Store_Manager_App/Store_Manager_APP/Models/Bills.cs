using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace Store_Manager_APP.Models
{
    public class Items
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("billId")]
        public int BillId { get; set; }
    }

    public class Bills
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("amount")]
        public float Amount { get; set; }

        [JsonProperty("billDate")]
        public DateTime BillDate { get; set; }

        [JsonProperty("items")] 
        public List<Items> Items { get; set; }

    }
}
