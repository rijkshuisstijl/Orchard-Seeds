using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;


namespace $rootnamespace$
{
    //Remove MyContentPartRecord class and update references to your Content part record
    public class MyContentPartRecord : ContentPartRecord
    {
        public virtual string Prop1 { get; set; }
    }

    public class $safeitemname$ : ContentPart<MyContentPartRecord>
    {
        public string Prop1
        {
            get { return Record.Prop1; }
            set { Record.Prop1 = value; }
        }
    }
}