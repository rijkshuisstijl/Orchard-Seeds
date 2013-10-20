using Orchard.UI.Notify;


namespace $rootnamespace$.WorkerServices
{
  
    public class $safeitemname$ : I$safeitemname$ 
    {
        private readonly INotifier _notifier;

        public $safeitemname$(INotifier notifier)
        {
            _notifier = notifier;
            T = NullLocalizer.Instance;
            Logger = NullLogger.Instance;
        }

        public ILogger Logger { get; set; }
        public Localizer T { get; set; }

    }
}