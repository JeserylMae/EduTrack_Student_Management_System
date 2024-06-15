using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfrastructureLayer.DataAccess.Repository.Access;


namespace InfrastructureLayer.DataAccess.Repository.Model
{
    public class CourseInfoModelRepository
    {
        public static string CourseInfoModelQueryGenerator(AccessDefaultVariation.RequestType requestType)
        {
            if (requestType == AccessDefaultVariation.RequestType.Add)
            {
                string df = "SELECT * FROM fdjss";
            }

            return string.Empty;
        }
    }
}
