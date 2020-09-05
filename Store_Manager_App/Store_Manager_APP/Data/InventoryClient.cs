using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Store_Manager_APP.Data
{
    public class InventoryClient
    {
        HttpClient _client;

        public InventoryClient()
        {
            _client = new HttpClient();
        }
    }
}
