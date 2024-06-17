using System;
using System.Collections.Generic;
using ServiceLayer.TestingServices;
using InfrastructureLayer.Repository.Databasse;

namespace ServiceLayer.Services.ModelServices
{
    public class DomainModelServices : IDomainModelServices, IDomainModelRepository
    {
        public DomainModelServices(IModelDataAnnotationCheck modelDataAnnotationCheck, IDomainModelRepository domainModelRepository) 
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
            _domainModelRepository = domainModelRepository;
        }

        public void ValidateDataModel<TDomainModel>(TDomainModel model) where TDomainModel : class
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotation(model);
        }

        public void Add<TDomainModel>(TDomainModel DomainDataModel) where TDomainModel : class
        {
            throw new NotImplementedException();
        }

        public void Update<TDomainModel>(TDomainModel DomainDataModel) where TDomainModel : class
        {
            throw new NotImplementedException();
        }

        public void Delete<TDomainModel>(TDomainModel DomainDataModel) where TDomainModel : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TDomainModel> GetAll<TDomainModel>() where TDomainModel : class
        {
            throw new NotImplementedException();
        }

        public TDomainModel GetByID<TDomainModel>(string id) where TDomainModel : class
        {
            throw new NotImplementedException();
        }

        private IModelDataAnnotationCheck _modelDataAnnotationCheck;
        private IDomainModelRepository _domainModelRepository;
    }
}
