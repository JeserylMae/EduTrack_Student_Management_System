using CommonComponets;
using InfrastructureLayer.Repository.Access;
using InfrastructureLayer.Repository.Databasse;
using InfrastructureLayers.Repository.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repository.Database
{
    public class DomainModelRepository : IDomainModelRepository
    {
        public DomainModelRepository()
        {
            _connectionString = DatabaseManager.DatabaseConnectionStringGetter();
            AccessDefaultVariation.InitializeQueryGenerator();
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

        public void GetByID<TDomainModel>(ref TDomainModel domainModel, string id, string modelQuery) where TDomainModel : class
        {
            DataAccessStatus dataAccessStatus = new DataAccessStatus();
            bool MatchingRecordFound = false;

            MySqlConnection dbConnection = DatabaseManager.DatabaseConnection(_connectionString);
            
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = dbConnection;
                    cmd.CommandText = modelQuery;
                    cmd.Prepare();
                }
            }
            catch (Exception ex) { }
        }

        public void Update<TDomainModel>(TDomainModel DomainDataModel) where TDomainModel : class
        {
            throw new NotImplementedException();
        }

        private string _connectionString;
        private AccessDefaultVariation.RequestFrom _requestFrom;
        private AccessDefaultVariation.RequestType _requestType;
    }
}
