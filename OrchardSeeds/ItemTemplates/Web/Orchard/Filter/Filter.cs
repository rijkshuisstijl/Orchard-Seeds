using System.Web.Mvc;
using Orchard.Mvc.Filters;


namespace $rootnamespace$
{
    public class $safeitemname$ : FilterProvider, IResultFilter, IActionFilter
    {
        public $safeitemname$()
        {
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //do something before the controller executes
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //do something after the controller has executed
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            // should only run on a full view rendering result
            if (!(filterContext.Result is ViewResult))
            {
                return;
            }

            //do something before the views executes
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //do something after the controller has executed
        }
    }
}