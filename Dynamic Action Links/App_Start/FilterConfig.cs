using System.Web;
using System.Web.Mvc;

namespace Dynamic_Action_Links
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
