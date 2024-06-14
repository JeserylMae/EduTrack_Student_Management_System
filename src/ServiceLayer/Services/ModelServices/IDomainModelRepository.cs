using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.ModelServices
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
