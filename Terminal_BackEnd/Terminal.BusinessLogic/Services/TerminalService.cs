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


    }
}
