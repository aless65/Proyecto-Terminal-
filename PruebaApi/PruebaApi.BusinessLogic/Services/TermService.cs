using PruebaApi.DataAccess.Repository;
using PruebaApi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaApi.BusinessLogic.Services
{
    public class TermService
    {
        private readonly tbClientesRepository _tbClientesRepository;

        public TermService(tbClientesRepository tbClientesRepository)
        {
            _tbClientesRepository = tbClientesRepository;
        }

        #region Clientes
        public IEnumerable<VW_tbClientes> ListadoClientes()
        {
            try
            {
                return _tbClientesRepository.List();
            }
            catch (Exception e)
            {
                return Enumerable.Empty<VW_tbClientes>();
            }
        }
        #endregion
    }
}
