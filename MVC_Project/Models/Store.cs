using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    public class Store
    {
        public string stor_id { get; set; }
        public string stor_name { get; set; }
        public string stor_address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    }
}