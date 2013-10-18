using Orchard.UI.Resources;

namespace $rootnamespace$
{
    public class $safeitemname$ : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            Orchard.UI.Resources.ResourceManifest manifest = builder.Add();
            manifest.DefineScript("myscript").SetUrl("myjqueryscript.js").SetDependencies("jQuery");
            
            manifest.DefineStyle("mystyle").SetUrl("mystyle.css");
        }
    }
}