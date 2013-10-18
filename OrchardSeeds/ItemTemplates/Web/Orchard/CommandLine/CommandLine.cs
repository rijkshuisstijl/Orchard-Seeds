using Orchard.Commands;


namespace $rootnamespace$
{
    public class $safeitemname$ : DefaultOrchardCommandHandler
    {

        public $safeitemname$()
        {
        }

        [CommandName("command1 argument1")]
        [CommandHelp("command1 argument1\r\n\tDoes the following action")]
        public void Argument1()
        {
            //Do some action

            Context.Output.WriteLine(T("Action done").Text);
        }

    }
}