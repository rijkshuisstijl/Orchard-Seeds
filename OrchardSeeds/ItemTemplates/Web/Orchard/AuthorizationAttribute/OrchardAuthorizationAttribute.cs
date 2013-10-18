using System;
using System.Web.Mvc;
using Orchard;
using Orchard.Localization;
using Orchard.Security;
using Orchard.Security.Permissions;


namespace $rootnamespace$
{
    public class $safeitemname$ : AuthorizeAttribute
    {
        public String PermissionName { get; set; }


        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (String.IsNullOrEmpty(PermissionName))
            {
                throw new ApplicationException("No permission supplied");
            }


            //No authorization if permission is AllowAnonymous
            if (String.Equals(PermissionName, "AllowAnonymous", StringComparison.InvariantCultureIgnoreCase))
            {
                return;
            }

            WorkContext workContext = filterContext.GetWorkContext();
            IAuthorizer authorizer = workContext.Resolve<IAuthorizer>();
            Permission permission = new Permission {Name = PermissionName};

            if (authorizer.Authorize(permission,
                new LocalizedString("Access is denied")))
            {
                return;
            }

            //Access is denied
            filterContext.Result = new HttpUnauthorizedResult();
        }
    }
}