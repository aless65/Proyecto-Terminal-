using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal.DataAccess.Repository
{
    public class ScriptsDataBase
    {
        #region Clientes
            public static string UDP_Clientes_Select = "term.UDP_VW_tbClientes_VW";
            public static string UDP_Clientes_Insert = "term.UDP_tbClientes_Create";
            public static string UDP_Clientes_Find = "term.UDP_tbClientes_Find";
            public static string UDP_Clientes_Update = "term.UDP_tbClientes_Update";
            public static string UDP_Clientes_Delete = "term.UDP_tbClientes_Delete";

        #endregion


        #region Cargos
            public static string UDP_Cargos_Select = "term.UDP_VW_tbCargos_VW";
            public static string UDP_Cargos_Insert = "term.UDP_tbCargos_Create";
            public static string UDP_Cargos_Find = "term.UDP_tbCargos_Find ";
            public static string UDP_Cargos_Update = "term.UDP_tbCargos_Update";
            public static string UDP_Cargos_Delete = "term.UDP_tbCargos_Delete";

        #endregion


        #region Terminales
            public static string UDP_Terminales_Select = "term.UDP_VW_tbTerminales_VW";
            public static string UDP_Terminales_Insert = "term.UDP_tbTerminales_Create";
            public static string UDP_Terminales_Find = "term.UDP_VW_tbTerminales_Find";
            public static string UDP_Terminales_Update = "term.UDP_tbTerminales_Update";
            public static string UDP_Terminales_Delete = "term.UDP_tbTerminales_Delete";
        #endregion


        #region Horarios
            public static string UDP_Horarios_Select = "term.UDP_VW_tbHorarios_VW";
            public static string UDP_Horarios_Insert = "term.UDP_tbHorarios_Create";
            public static string UDP_Horarios_Find = "term.UDP_VW_tbHorarios_Find";
            public static string UDP_Horarios_Update = "term.UDP_tbHorarios_Update";
            public static string UDP_Horarios_Delete = "term.UDP_tbHorarios_Delete";
        #endregion


        #region Boletos
            public static string UDP_Boletos_Select = "term.UDP_VW_tbBoletos_VW";
            public static string UDP_Boletos_Insert = "term.UDP_tbBoletos_Create";
            public static string UDP_Boletos_Find = "term.UDP_VW_tbBoletos_Find";
            public static string UDP_Boletos_Update = "term.UDP_tbBoletos_Update";
            public static string UDP_Boletos_Delete = "term.UDP_tbBoletos_Delete";
        #endregion

        #region ddls
        public static string UDP_CargarDepartamento_Load = "gral.UDP_CargarDepartamento_Load";
        public static string UDP_CargarMunicipio_Load = "gral.UDP_CargarMunicipio_Load";

        #endregion

        #region Graficas

        public static string UDP_GraficaViajes_Load = "gral.UDP_GraficaViajes_Load";
        public static string UDP_GraficaSexo_Load = "gral.UDP_GraficaSexo_Load";

        #endregion
    }
}
