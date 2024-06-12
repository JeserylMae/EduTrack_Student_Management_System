﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.TestingServices
{
    public class ModelDataAnnotationCheck : IModelDataAnnotationCheck
    {
        //public void ValidateModelDataAnnotation<TDomainModel>(TDomainModel model) where TDomainModel : class
        //{
        //    ICollection<ValidationResult> validationResultList = new List<ValidationResult>();

        //    ValidationContext validationContext = new ValidationContext(model, null, null);

        //    StringBuilder newErrorMessage = new StringBuilder();

        //    if (!Validator.TryValidateObject(model, validationContext, validationResultList, validateAllProperties: true))
        //    {
        //        foreach (ValidationResult validationResult in validationResultList)
        //            newErrorMessage.AppendLine(validationResult.ErrorMessage);
        //    }

        //    if (validationResultList.Count > 0) throw new ArgumentException(newErrorMessage.ToString());
        //}

        public void ValidateModelDataAnnotation<TDomainModel>(TDomainModel model) where TDomainModel : class
        {
            ICollection<ValidationResult> validationResultList = new List<ValidationResult>();
            StringBuilder newErrorMessage = new StringBuilder();

            ValidateRecursive(model, validationResultList, newErrorMessage);

            if (validationResultList.Count > 0) throw new ArgumentException(newErrorMessage.ToString());
        }

        private void ValidateRecursive(object obj, ICollection<ValidationResult> validationResultList, StringBuilder newErrorMessage)
        {
            ValidationContext validationContext = new ValidationContext(obj, null, null);

            if (!Validator.TryValidateObject(obj, validationContext, validationResultList, validateAllProperties: true))
            {
                foreach (ValidationResult validationResult in validationResultList)
                    newErrorMessage.AppendLine(validationResult.ErrorMessage);
            }

            foreach (var property in obj.GetType().GetProperties())
            {
                if (property.PropertyType.IsClass && property.PropertyType != typeof(string))
                {
                    var propertyValue = property.GetValue(obj);
                    ValidateRecursive(propertyValue, validationResultList, newErrorMessage);
                }
            }
        }
    }
}