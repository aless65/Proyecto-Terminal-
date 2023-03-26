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
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@clie_ID", id, DbType.Int32, ParameterDirection.Input);

            return db.QueryFirst<VW_tbClientes>(ScriptsDataBase.UDP_Clientes_Find, parametros, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<VW_tbClientes> List()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();

            return db.Query<VW_tbClientes>(ScriptsDataBase.UDP_Clientes_Select, null, commandType: CommandType.StoredProcedure);
        }
            
        public RequestStatus Insert(tbClientes item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@clie_UsuarioCreador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@clie_Nombres", item.clie_Nombres, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Apellidos", item.clie_Apellidos, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_DNI", item.clie_DNI, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Sexo", item.clie_Sexo, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Telefono", item.clie_Telefono, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Email", item.clie_Email, DbType.String, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Clientes_Insert, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbClientes item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@clie_UsuarioModificador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@clie_ID", item.clie_ID, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@clie_Nombres", item.clie_Nombres, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Apellidos", item.clie_Apellidos, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_DNI", item.clie_DNI, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Sexo", item.clie_Sexo, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Telefono", item.clie_Telefono, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Email", item.clie_Telefono, DbType.String, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Clientes_Update, parametros, commandType: CommandType.StoredProcedure);
        }


        public RequestStatus Delete(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@clie_ID", id, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Clientes_Delete, parametros, commandType: CommandType.StoredProcedure);
        }
    }
}
