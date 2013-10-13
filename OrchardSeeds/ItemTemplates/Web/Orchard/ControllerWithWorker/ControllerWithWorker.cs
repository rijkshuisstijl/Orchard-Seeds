#region Usings

using System.Web.Mvc;
using Orchard;
using Orchard.UI.Notify;

#endregion

namespace $rootnamespace$
{
    //[Admin] or [Themed] for a default layout. Can be placed on the controller or methods
    public class $fileinputname$Controller : Controller
    {
        private readonly I$fileinputname$WorkerService _workerService;

        public $safeitemname$(I$fileinputname$WorkerService workerService)
        {
            _workerService = workerService;
        }
    }


    public interface I$fileinputname$WorkerService : IDependency
    {}

    public class $fileinputname$WorkerService : I$fileinputname$WorkerService 
    {
        private readonly INotifier _notifier;

        public $fileinputname$WorkerService(INotifier notifier)
        {
            _notifier = notifier;
            T = NullLocalizer.Instance;
            Logger = NullLogger.Instance;
        }

        public ILogger Logger { get; set; }
        public Localizer T { get; set; }

    }
}