using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Terminal.Entities.Entities;

namespace Terminal.DataAccess.Repository
{
    public class CompañiaRepository : IRepository<tbCompania, tbCompania>
    {
        public RequestStatus Delete(int id)
        {
            throw new NotImplementedException();
        }

        public tbCompania Find(int id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbCompania item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbCompania> List()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();

            return db.Query<tbCompania>(ScriptsDataBase.UDP_Compañia_Select, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbCompania item)
        {
            throw new NotImplementedException();
        }
    }
}
