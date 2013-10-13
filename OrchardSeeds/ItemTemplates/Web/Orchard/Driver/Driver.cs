#region Usings

using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.Handlers;

#endregion

namespace $rootnamespace$
{
    //remove the MyContentPart class and update the references to this dummy class
    public class MyContentPart : ContentPart
    {
        public string Prop1 { get; set; }
    }


    public class $safeitemname$ : ContentPartDriver<MyContentPart>
    {
        protected override string Prefix
        {
            get { return "MyContentPart"; }
        }

        protected override DriverResult Display(MyContentPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_MyContentPart",
                () => shapeHelper.Parts_MyContentPart(
                    Model: part));
        }

        protected override DriverResult Editor(MyContentPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_MyContentPart_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/MyContentPart",
                    Model: part,
                    Prefix: Prefix));
        }

        protected override DriverResult Editor(MyContentPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }

        protected override void Importing(MyContentPart part, ImportContentContext context)
        {
            string prop1 = context.Attribute(part.PartDefinition.Name, "Prop1");
            if (prop1 != null)
            {
                part.Prop1 = prop1;
            }
        }

        protected override void Exporting(MyContentPart part, ExportContentContext context)
        {
            context.Element(part.PartDefinition.Name).SetAttributeValue("Prop1", part.Prop1);
        }
    }
}