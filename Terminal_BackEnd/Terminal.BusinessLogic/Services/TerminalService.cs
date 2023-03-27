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
        private readonly CargosRepository _cargosRepository;
        private readonly TerminalesRepository _terminalesRepository;
        private readonly HorariosRepository _horariosRepository;
        private readonly BoletosRepository _boletosRepository;

        public TerminalService(ClientesRepository clientesRepository, CargosRepository cargosRepository, TerminalesRepository terminalesRepository, HorariosRepository horariosRepository, BoletosRepository boletosRepository)
        {
            _clientesRepository = clientesRepository;
            _cargosRepository = cargosRepository;
            _terminalesRepository = terminalesRepository;
            _horariosRepository = horariosRepository;
            _boletosRepository = boletosRepository;
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

        #region Cargos

        
        public IEnumerable<VW_tbCargos> ListadoCargos()
        {
            try
            {
                return _cargosRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbCargos>();
            }
        }
        public ServiceResult InsertarCargo(tbCargos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _cargosRepository.Insert(item);
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
        public VW_tbCargos BuscarCargos(int id)
        {
            try
            {
                return _cargosRepository.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus BorrarCargo(int id)
        {
            try
            {
                return _cargosRepository.Delete(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus UpdateCargos(tbCargos cargos)
        {
            try
            {
                return _cargosRepository.Update(cargos);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region Terminales

        public IEnumerable<VW_tbTerminales> ListadoTerminales()
        {
            try
            {
                return _terminalesRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbTerminales>();
            }
        }
        public ServiceResult InsertarTerminal(tbTerminales item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _terminalesRepository.Insert(item);
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
        public VW_tbTerminales BuscarTerminales(int id)
        {
            try
            {
                return _terminalesRepository.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus BorrarTerminales(int id)
        {
            try
            {
                return _terminalesRepository.Delete(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus UpdateTerminales(tbTerminales terminales)
        {
            try
            {
                return _terminalesRepository.Update(terminales);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region Horarios

        public IEnumerable<VW_tbHorarios> ListadoHorarios()
        {
            try
            {
                return _horariosRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbHorarios>();
            }
        }
        public ServiceResult InsertarHorario(tbHorarios item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _horariosRepository.Insert(item);
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
        public VW_tbHorarios BuscarHorarios(int id)
        {
            try
            {
                return _horariosRepository.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus BorrarHorarios(int id)
        {
            try
            {
                return _horariosRepository.Delete(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus UpdateHorarios(tbHorarios horarios)
        {
            try
            {
                return _horariosRepository.Update(horarios);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region Horarios

        public IEnumerable<VW_tbBoletos> ListadoBoletos()
        {
            try
            {
                return _boletosRepository.List();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_tbBoletos>();
            }
        }

        public ServiceResult InsertarBoletos(tbBoletos item)
        {
            var result = new ServiceResult();
            try
            {
                var map = _boletosRepository.Insert(item);
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

        public VW_tbBoletos BuscarBoletos(int id)
        {
            try
            {
                return _boletosRepository.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus BorrarBoletos(int id)
        {
            try
            {
                return _boletosRepository.Delete(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public RequestStatus UpdateBoletos(tbBoletos boletos)
        {
            try
            {
                return _boletosRepository.Update(boletos);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion

        #region ddls

        public IEnumerable<tbDepartamentos> LoadDepartamento()
        {
            try
            {
                return _terminalesRepository.LoadDepartamento();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<tbDepartamentos>();
            }
        }

        public IEnumerable<tbMunicipios> LoadMunicipio(string id)
        {
            try
            {
                return _terminalesRepository.LoadMunicipio(id);
            }
            catch (Exception e)
            {

                return Enumerable.Empty<tbMunicipios>();
            }
        }

        public IEnumerable<VW_graficaViaje> LoadTrips()
        {
            try
            {
                return _boletosRepository.LoadTrips();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_graficaViaje>();
            }
        }

        public IEnumerable<VW_graficaSexo> LoadSex()
        {
            try
            {
                return _boletosRepository.LoadSex();
            }
            catch (Exception e)
            {

                return Enumerable.Empty<VW_graficaSexo>();
            }
        }
        #endregion
    }
}
