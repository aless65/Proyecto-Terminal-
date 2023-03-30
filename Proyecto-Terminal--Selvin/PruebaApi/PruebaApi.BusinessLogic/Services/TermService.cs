using PruebaApi.DataAccess;
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
        public ServiceResult InsertarCliente(tbClientes item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _tbClientesRepository.Insert(item);
                return result.Ok(map);
                //if (map.CodeStatus > 0)
                //{

                //}
                //else
                //{ 
                //    map.MessageStatus = (map.CodeStatus == 0) ? "404 Error de consulta" : map.MessageStatus;
                //    return result.Error(map);
                //}

            }
            catch (Exception)
            {

                throw;
            }
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
