using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Store_Manager_APP.Data
{
    public class BillsClient
    {
        HttpClient _client;

        public BillsClient()
        {
            _client = new HttpClient();
        }
    }
}
