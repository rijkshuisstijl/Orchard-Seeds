using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Orchard;

namespace $rootnamespace$
{
    //Place this attribute on your inputmodel
    //
    // [CustomValidation(typeof($safeitemname$), "ValidateMethod")]
    // string Property1 {get; set;}

    public static class $safeitemname$
    {
        public static ValidationResult ValidateMethod(string property1, ValidationContext context)
        {

            //You can use all properties of the inputmodel for your validation
            var inputModel = context.ObjectInstance as ClassOfInputmodel;
            if (inputModel == null)
            {
                throw new NullReferenceException("ValidationContext");
            }


            if (HttpContext.Current == null)
            {
                return new ValidationResult("Could not find a http context for validating Property1");
            }

            var workContext = HttpContext.Current.Request.RequestContext.GetWorkContext();
            var service = workContext.Resolve<IService>();

            bool validate = service.testmethod(property1, inputModel.OtherProperty);

            if (!validate)
            {
                return new ValidationResult("Inputmodel is not valid");
            }

            return ValidationResult.Success;
        }
    }
}