using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceLayer.TestingServices
{
    public interface IModelDataAnnotationCheck
    {
        void ValidateModelDataAnnotation<TDomainModel>(TDomainModel model) where TDomainModel : class;
    }
}