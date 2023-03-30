using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Terminal.Entities.Entities;

namespace Terminal.DataAccess.Repository
{
    public class TerminalesRepository : IRepository<tbTerminales, VW_tbTerminales>
    {           
        public VW_tbTerminales Find(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@term_ID", id, DbType.Int32, ParameterDirection.Input);

            return db.QueryFirst<VW_tbTerminales>(ScriptsDataBase.UDP_Terminales_Find, parametros, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<VW_tbTerminales> List()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();

            return db.Query<VW_tbTerminales>(ScriptsDataBase.UDP_Terminales_Select, null, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Insert(tbTerminales item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@term_UsuarioCreador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@muni_ID", item.muni_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@term_Nombre", item.term_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@term_DireccionExacta", item.term_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@term_CantidadTransportes", item.term_CantidadTransportes, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Terminales_Insert, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Update(tbTerminales item)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@term_UsuarioModificador", 1, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@term_ID", item.term_ID, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@muni_ID", item.muni_ID, DbType.String, ParameterDirection.Input);
            parametros.Add("@term_Nombre", item.term_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@term_DireccionExacta", item.term_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@term_CantidadTransportes", item.term_CantidadTransportes, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Terminales_Update, parametros, commandType: CommandType.StoredProcedure);

        }

        public RequestStatus Delete(int id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@term_ID", id, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<RequestStatus>(ScriptsDataBase.UDP_Terminales_Delete, parametros, commandType: CommandType.StoredProcedure);

        }



        public IEnumerable<tbDepartamentos> LoadDepartamento()
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            return db.Query<tbDepartamentos>(ScriptsDataBase.UDP_CargarDepartamento_Load, null, commandType: CommandType.StoredProcedure);

        }

        public IEnumerable<tbMunicipios> LoadMunicipio(string id)
        {
            using var db = new SqlConnection(TerminalContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@dept_ID", id, DbType.String, ParameterDirection.Input);

            return db.Query<tbMunicipios>(ScriptsDataBase.UDP_CargarMunicipio_Load, parametros, commandType: CommandType.StoredProcedure);

        }

    }
}
