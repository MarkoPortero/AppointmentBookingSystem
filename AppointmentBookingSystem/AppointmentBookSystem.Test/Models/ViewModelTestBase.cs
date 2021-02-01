using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppointmentBookSystem.Test
{
    public class ViewModelTestBase
    {
        public IList<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(model, null, null);

            Validator.TryValidateObject(model, validationContext, validationResults, true);
            return validationResults;
        }
    }
}
