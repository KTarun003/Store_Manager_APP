using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Manager_APP.Models
{
    public class DashView
    {

        public string Name { get; set; }

        public string Numbers { get; set; }
    }

    public class Root
    {
        public List<DashView> dashList { get; set; }
    }
}
