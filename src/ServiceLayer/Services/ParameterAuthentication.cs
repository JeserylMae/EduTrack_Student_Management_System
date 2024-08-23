
using DomainLayer.DataModels;
using System.Reflection;
using System.Threading.Tasks;
using System;
using ServiceLayer.Database;


namespace ServiceLayer.Services
{
    public class ParameterAuthentication
    {
        // NOTE: Use method overriding for creating method ValidateParameter for other
        // models.
        public async Task<Task> ValidateParameter(PersonalInfoModel<StudentPersonalInfoModel> parameters)
        {
            if (HasNullOrEmptyString(parameters) || HasNullOrEmptyString(parameters.InfoModel))
            {
                throw new TargetParameterCountException("Parameter count mismatch. "
                                        + "Ensure that all are fields are filled.");
            }

            StudentPersonalInfoServices services = new StudentPersonalInfoServices();
            StudentPersonalInfoModel model = await services.GetById(parameters.InfoModel.SrCode);
            if (!string.IsNullOrEmpty(model.SrCode))
            {
                throw new Exception($"Student with SR Code {parameters.InfoModel.SrCode} already exists.");
            }

            return Task.CompletedTask;
        }

        private bool HasNullOrEmptyString<TModel>(TModel model)
        {
            bool isNull = false;

            foreach (PropertyInfo property in model.GetType().GetProperties())
            {
                object value = property.GetValue(model);

                if (string.IsNullOrEmpty(value.ToString()))
                {
                    isNull = true;
                    break;
                }
            }
            return isNull;
        }
    }
}
