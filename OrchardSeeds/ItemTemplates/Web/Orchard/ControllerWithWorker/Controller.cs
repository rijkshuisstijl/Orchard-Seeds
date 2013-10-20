using System.Web.Mvc;


namespace $rootnamespace$.Controllers
{
    //[Admin] or [Themed] for a default layout. Can be placed on the controller or methods
    public class $safeitemname$ : Controller
    {
        private readonly I$fileinputname$WorkerService _workerService;

        public $safeitemname$(I$fileinputname$WorkerService workerService)
        {
            _workerService = workerService;
        }
    }
}