using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.TestingServices;

namespace ServiceLayer.Services.ModelServices
{
    public class DomainModelServices
    {
        public DomainModelServices(IModelDataAnnotationCheck modelDataAnnotationCheck) 
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }

        public void ValidateDataModel<TDomainModel>(TDomainModel model) where TDomainModel : class
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotation(model);
        }


        private IModelDataAnnotationCheck _modelDataAnnotationCheck;
    }
}
