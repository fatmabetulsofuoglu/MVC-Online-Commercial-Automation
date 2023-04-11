using System.Web;
using System.Web.Mvc;

namespace MVC_Online_Commercial_Automation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
