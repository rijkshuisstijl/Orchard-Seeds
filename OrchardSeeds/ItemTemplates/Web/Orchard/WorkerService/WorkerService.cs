#region Usings

using Orchard;
using Orchard.Localization;
using Orchard.Logging;
using Orchard.UI.Notify;

#endregion

namespace $rootnamespace$
{
    public interface I$safeitemname$ : IDependency
    {
    }

    public class $safeitemname$ : IMyWorkerService
    {
        private readonly INotifier _notifier;


        public MyWorkerService(INotifier notifier)
        {
            _notifier = notifier;
            T = NullLocalizer.Instance;
            Logger = NullLogger.Instance;
        }

        public ILogger Logger { get; set; }
        public Localizer T { get; set; }
    }
}