using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Terminal.Entities.Entities;

namespace Terminal.DataAccess.Repository
{
    public class CargosRepository : IRepository<tbCargos, VW_tbCargos>
    {
        public VW_tbCargos Find(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@carg_ID", id, DbType.Int32, ParameterDirection.Input);

            return db.QueryFirst<VW_tbCargos>(ScriptsDataBase.UDP_Cargos_Find, parametros, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<VW_tbCargos> List()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();

            return db.Query<VW_tbCargos>(ScriptsDataBase.UDP_Cargos_Select, null, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Insert(tbCargos item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@carg_UsuarioCreador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@carg_Nombre", item.carg_Nombre, DbType.String, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Cargos_Insert, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbCargos item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@carg_UsuarioModificador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@carg_ID", item.carg_ID, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@carg_Nombre", item.carg_Nombre, DbType.String, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Cargos_Update, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Delete(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@carg_ID", id, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Cargos_Delete, parametros, commandType: CommandType.StoredProcedure);

        }


    }
}
