using System.Web;
using System.Web.Mvc;

namespace Form_Validation__Built_in_and_custom_both_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
