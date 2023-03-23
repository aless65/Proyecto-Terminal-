using Dapper;
using Microsoft.Data.SqlClient;
using PruebaApi.BusinessLogic.Repository;
using PruebaApi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PruebaApi.DataAccess.Repository
{
    public class tbClientesRepository : IRepository<tbClientes, VW_tbClientes>
    {
        public RequestStatus Delete(int id)
        {
            throw new NotImplementedException();
        }

        public VW_tbClientes find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbClientes item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VW_tbClientes> List()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            return db.Query<VW_tbClientes>(ScriptsDataBase.UDP_Listar_Categorias, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbClientes item)
        {
            throw new NotImplementedException();
        }
    }
}
