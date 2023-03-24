using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Entities.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Terminal.DataAccess.Repository
{
    public class ClientesRepository : IRepository<tbClientes, VW_tbClientes>
    {
        public VW_tbClientes Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VW_tbClientes> List()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();

            return db.Query<VW_tbClientes>(ScriptsDataBase.UDP_Clientes_Select, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Insert(tbClientes item)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbClientes item)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Delete(int id)
        {
            throw new NotImplementedException();
        }


    }
}
