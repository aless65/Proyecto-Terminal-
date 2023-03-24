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
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@clie_UsuarioCreador",1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@clie_Nombres",item.clie_Nombres, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Apellidos", item.clie_Apellidos, DbType.String, ParameterDirection.Input);    
            parametros.Add("@clie_DNI", item.clie_DNI, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Sexo", item.clie_Sexo, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Telefono", item.clie_Telefono, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Email", item.clie_Telefono, DbType.String, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Insertar_Clientes, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<VW_tbClientes> List()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            return db.Query<VW_tbClientes>(ScriptsDataBase.UDP_Listar_Clientes, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbClientes item)
        {
            throw new NotImplementedException();
        }
    }
}
