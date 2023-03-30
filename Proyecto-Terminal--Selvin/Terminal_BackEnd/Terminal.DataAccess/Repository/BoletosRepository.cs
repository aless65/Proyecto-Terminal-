using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Terminal.Entities.Entities;

namespace Terminal.DataAccess.Repository
{
    public class BoletosRepository : IRepository<tbBoletos, VW_tbBoletos>
    {        
        public VW_tbBoletos Find(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@bole_ID", id, DbType.Int32, ParameterDirection.Input);

            return db.QueryFirst<VW_tbBoletos>(ScriptsDataBase.UDP_Boletos_Find, parametros, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<VW_tbBoletos> List()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<VW_tbBoletos>(ScriptsDataBase.UDP_Boletos_Select, null, commandType: CommandType.StoredProcedure);

        }


        public IEnumerable<VW_tbBoletos2> VistaPrevia()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<VW_tbBoletos2>(ScriptsDataBase.UDP_VW_VistaPrevia_VW, null, commandType: CommandType.StoredProcedure);

        }


        public RequestStatus Insert(tbBoletos item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@bole_UsuarioCreador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@term_ID", item.term_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@comp_ID", item.comp_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_ID", item.empl_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_ID", item.clie_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@hora_ID", item.hora_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@pago_ID", item.pago_ID, DbType.String, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Boletos_Insert, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbBoletos item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@bole_UsuarioModificador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@bole_ID", item.bole_ID, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@term_ID", item.term_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@comp_ID", item.comp_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_ID", item.empl_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_ID", item.clie_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@hora_ID", item.hora_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@pago_ID", item.pago_ID, DbType.String, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Boletos_Update, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Delete(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@bole_ID", id, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Boletos_Delete, parametros, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<VW_graficaViaje> LoadTrips()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<VW_graficaViaje>(ScriptsDataBase.UDP_GraficaViajes_Load, null, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<VW_graficaSexo> LoadSex()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<VW_graficaSexo>(ScriptsDataBase.UDP_GraficaSexo_Load, null, commandType: CommandType.StoredProcedure);

        }

    }
}
