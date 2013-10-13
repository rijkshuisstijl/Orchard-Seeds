#region Usings

using Orchard.Core.Contents;
using Orchard.Localization;
using Orchard.UI.Navigation;

#endregion

namespace $rootnamespace$
{
    public class $safeitemname$ : INavigationProvider
    {
        public $safeitemname$()
        {
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        public string MenuName
        {
            get { return "Admin"; }
        }

        public void GetNavigation(NavigationBuilder builder)
        {
            builder
                .AddImageSet("MyImage")
                .Add(T("MyMainMenuItem"), position: "2", itemBuilder: LinkSubMenu);
        }

        private void LinkSubMenu(NavigationBuilder menu)
        {
            menu.Add(item => item
                .Position("11")
                .Caption(T("MySubMenuItem"))
                .Action("<action>", "<controller>", new {area = "<module>"})
                .Permission(Permissions.EditContent));
        }
    }
}