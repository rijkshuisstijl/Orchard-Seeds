using System.Collections.Generic;
using Orchard.Environment.Extensions.Models;
using Orchard.Security.Permissions;

namespace $rootnamespace$
{
    public class Permissions : IPermissionProvider
    {

        public const string $safeitemname$PermissionName = "Permission Name";

        public static readonly Permission $safeitemname$ = new Permission
        {
            Description = "Description of permission",
            Name = $safeitemname$PermissionName
        };
     
    
        public Feature Feature { get; set; }

        public IEnumerable<Permission> GetPermissions()
        {
            return new[] {$safeitemname$};
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes()
        {
            return new[]
            {
                new PermissionStereotype
                {
                    Name = "Administrator",
                    Permissions = new[]
                    {
                        $safeitemname$
                    }
                }
             };
        }
    }
}
