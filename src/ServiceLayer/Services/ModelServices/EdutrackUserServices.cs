using DomainLayer.Models.DerivedModel;
using InfrastructureLayer.Repository.Database;
using InfrastructureLayer.Repository.Databasse;
using ServiceLayer.TestingServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.ModelServices
{
    public class EdutrackUserServices : IDomainModelServices
    {
        public EdutrackUserServices(IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }

        public void Add<TDomainModel>(TDomainModel DomainDataModel) where TDomainModel : class
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

        public IEdutrackUserModel GetByID(string id) 
        {
            string modelQuery = "SELECT * FROM EdutrackUserTbl WHERE UserID = @UserID";

            IEdutrackUserModel edutrackUserModel = new EdutrackUserModel();
            IDomainModelRepository domainModelRepository = new DomainModelRepository();

            domainModelRepository.GetByID(ref edutrackUserModel, id, modelQuery);


            return edutrackUserModel;
        }

        public void Update<TDomainModel>(TDomainModel DomainDataModel) where TDomainModel : class
        {
            throw new NotImplementedException();
        }

        public void ValidateDataModel<TDomainModel>(TDomainModel model) where TDomainModel : class
        {
            throw new NotImplementedException();
        }


        private IModelDataAnnotationCheck _modelDataAnnotationCheck;
    }
}
