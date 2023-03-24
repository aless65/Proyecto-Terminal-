using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Terminal.WebUI.Models;

namespace Terminal.WebUI.Services
{
    public interface IService_API
    {
        Task<List<ClientesModel>> List();
        Task<ClientesModel> find(int clie_Id);
        Task<bool> Create(ClientesModel item);
        Task<bool> Edit(ClientesModel item);
        Task<bool> Delete(int clie_Id);
    }
}
