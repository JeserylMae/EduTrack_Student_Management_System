using ServiceLayer.TestingServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.ModelServices
{
    public interface IDomainModelServices
    {
        void ValidateDataModel<TDomainModel>(TDomainModel model) where TDomainModel : class;
    }
}
