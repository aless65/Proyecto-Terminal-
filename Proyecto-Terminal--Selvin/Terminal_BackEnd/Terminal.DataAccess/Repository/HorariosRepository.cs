using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Terminal.Entities.Entities;

namespace Terminal.DataAccess.Repository
{
    public class HorariosRepository : IRepository<tbHorarios, VW_tbHorarios>
    {        
        public VW_tbHorarios Find(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@hora_ID", id, DbType.Int32, ParameterDirection.Input);

            return db.QueryFirst<VW_tbHorarios>(ScriptsDataBase.UDP_Horarios_Find, parametros, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<VW_tbHorarios> List()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();

            return db.Query<VW_tbHorarios>(ScriptsDataBase.UDP_Horarios_Select, null, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Insert(tbHorarios item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@hora_UsuarioCreador", 1, DbType.Int32, ParameterDirection.Input);
            //parametros.Add("@hora_FechaSalida", item.hora_FechaSalida, DbType.DateTime, ParameterDirection.Input);
            //parametros.Add("@hora_FechaLlegada", item.hora_FechaLlegada, DbType.DateTime, ParameterDirection.Input);
            //parametros.Add("@hora_Origen", item.hora_Origen, DbType.String, ParameterDirection.Input);
            //parametros.Add("@hora_Destino", item.hora_Destino, DbType.String, ParameterDirection.Input);
            //parametros.Add("@hora_CantidadPasajeros", item.hora_CantidadPasajeros, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@hora_Precio", item.hora_Precio, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Horarios_Insert, parametros, commandType: CommandType.StoredProcedure);
        }

        public RequestStatus Update(tbHorarios item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@hora_UsuarioModificador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@hora_ID", item.hora_ID, DbType.Int32, ParameterDirection.Input);
            //parametros.Add("@hora_FechaSalida", item.hora_FechaSalida, DbType.DateTime, ParameterDirection.Input);
            //parametros.Add("@hora_FechaLlegada", item.hora_FechaLlegada, DbType.DateTime, ParameterDirection.Input);
            //parametros.Add("@hora_Origen", item.hora_Origen, DbType.String, ParameterDirection.Input);
            //parametros.Add("@hora_Destino", item.hora_Destino, DbType.String, ParameterDirection.Input);
            //parametros.Add("@hora_CantidadPasajeros", item.hora_CantidadPasajeros, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@hora_Precio", item.hora_Precio, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Horarios_Update, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Delete(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@hora_ID", id, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Horarios_Delete, parametros, commandType: CommandType.StoredProcedure);

        }
    }
}
