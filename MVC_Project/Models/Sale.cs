using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    public class Sale
    {
        public string stor_id { get; set; }
        public string ord_num { get; set; }
        public System.DateTime ord_date { get; set; }
        public short qty { get; set; }
        public string payterms { get; set; }
        public string title_id { get; set; }
    }
}