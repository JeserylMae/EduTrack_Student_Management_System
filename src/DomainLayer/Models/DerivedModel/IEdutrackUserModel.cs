using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.DerivedModel
{
    public interface IEdutrackUserModel
    {
        string UserID { get; set; }
        string AccountPassword { get; set; }
    }
}
