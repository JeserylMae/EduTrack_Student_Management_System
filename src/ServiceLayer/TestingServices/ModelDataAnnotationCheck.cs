using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.TestingServices
{
    class ModelDataAnnotationCheck : IModelDataAnnotationCheck
    {
        public void ValidateModelDataAnnotation<TDomainModel>(TDomainModel model) where TDomainModel : class
        {
            ICollection<ValidationResult> validationResultList = new List<ValidationResult>();

            ValidationContext validationContext = new ValidationContext(model, null, null);

            StringBuilder newErrorMessage = new StringBuilder();

            if (!Validator.TryValidateObject(model, validationContext, validationResultList, validateAllProperties: true))
            {
                foreach (ValidationResult validationResult in validationResultList)
                    newErrorMessage.AppendLine(validationResult.ErrorMessage);
            }

            if (validationResultList.Count > 0) throw new ArgumentException(newErrorMessage.ToString());
        }
    }
}
