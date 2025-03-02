﻿
using DomainLayer.DataModels;
using System.Reflection;
using System.Threading.Tasks;
using System;
using ServiceLayer.Database;
using DomainLayer.DataModels.Instructor;


namespace ServiceLayer.Services
{
    public class ParameterAuthentication
    {
        // NOTE: Use method overriding for creating method ValidateParameter for other
        // models.
        public async Task<Task> ValidateParameter(PStudentPersonalInfoModel<RStudentPersonalInfoModel> parameters, 
                                                  string validateFrom)
        {
            if (HasNullOrEmptyString(parameters) || HasNullOrEmptyString(parameters.InfoModel))
            {
                throw new TargetParameterCountException("Parameter count mismatch. "
                                        + "Ensure that all are fields are filled.");
            }

            StudentPersonalInfoServices services = new StudentPersonalInfoServices();
            RStudentPersonalInfoModel model = await services.GetById(parameters.InfoModel.SrCode);
            if (!string.IsNullOrEmpty(model.SrCode) && validateFrom == "ADD")
            {
                throw new Exception($"Student with SR Code {parameters.InfoModel.SrCode} already exists.");
            }

            return Task.CompletedTask;
        }

        public async Task<Task> ValidateParameter(PInstructorPersonalInfoModel<RInstructorPersonalInfoModel> parameters,
                                                  string validateFrom)
        {
            if (HasNullOrEmptyString(parameters) || HasNullOrEmptyString(parameters.InfoModel))
            {
                throw new TargetParameterCountException("Parameter count mismatch. "
                                        + "Ensure that all are fields are filled.");
            }

            StudentPersonalInfoServices services = new StudentPersonalInfoServices();
            RStudentPersonalInfoModel model = await services.GetById(parameters.InfoModel.ItrCode);
            if (!string.IsNullOrEmpty(model.SrCode) && validateFrom == "ADD")
            {
                throw new Exception($"Instructor with Code {parameters.InfoModel.ItrCode} already exists.");
            }

            return Task.CompletedTask;
        }

        private bool HasNullOrEmptyString<TModel>(TModel model)
        {
            bool isNull = false;

            foreach (PropertyInfo property in model.GetType().GetProperties())
            {
                object value = property.GetValue(model);

                if (property.Name == "HouseNumber" || property.Name == "GuardianHouseNumber")
                {
                    continue;
                }

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
