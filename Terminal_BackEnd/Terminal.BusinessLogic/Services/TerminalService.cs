using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terminal.DataAccess.Repository;
using Terminal.Entities.Entities;

namespace Terminal.BusinessLogic.Services
{
    public class TerminalService
    {
        private readonly ClientesRepository _clientesRepository;

        public TerminalService(ClientesRepository clientesRepository)
        {
            _clientesRepository = clientesRepository;
        }

        #region Clientes
        public IEnumerable<VW_tbClientes> ListadoClientes()
        {
            try
            {
                return _clientesRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbClientes>();
            }
        }
        public ServiceResult InsertarCliente(tbClientes item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _clientesRepository.Insert(item);
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
        public VW_tbClientes BuscarCliente(int id)
        {
            try
            {
                return _clientesRepository.Find(id);
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public RequestStatus BorrarCliente(int id)
        {
            try
            {
                return _clientesRepository.Delete(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus UpdateCliente(tbClientes clientes)
        {
            try
            {
                return _clientesRepository.Update(clientes);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        public VW_tbClientes BuscarCliente(int id)
        {

            return _clientesRepository.Find(id);

        }

        public RequestStatus UpdateCliente(tbClientes clientes)
        {
            return _clientesRepository.Update(clientes);
        }

    }
}
