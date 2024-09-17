using System.Web;
using System.Web.Mvc;

namespace MVC_Project
{
    public class FilterConfig
    {
        //Apply Fiter to all the Action Method
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) //called during application StartUp from Glaal.asax
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
