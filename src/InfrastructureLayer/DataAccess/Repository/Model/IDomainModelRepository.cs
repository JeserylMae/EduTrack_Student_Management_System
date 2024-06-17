using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.DataAccess.Repository.Model
{
    public interface IDomainModelRepository
    {
        void Add<TDomainModel>(TDomainModel DomainDataModel) where TDomainModel : class;
        void Update<TDomainModel>(TDomainModel DomainDataModel) where TDomainModel : class;
        void Delete<TDomainModel>(TDomainModel DomainDataModel) where TDomainModel : class;
        IEnumerable<TDomainModel> GetAll<TDomainModel>() where TDomainModel : class;
        TDomainModel GetByID<TDomainModel>(string id) where TDomainModel : class;
    }

}

// this is placed in this project instead of placing it in the InfrastructureLayer
// because ServiceLayer does not and should not have reference to the
// InfrastructureLayer. Only InfrastrutureLayer should have reference to the 
// ServiceLayer.