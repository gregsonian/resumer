using System.Web;
using System.Web.Mvc;

namespace net.mattersofgrey.resumer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
