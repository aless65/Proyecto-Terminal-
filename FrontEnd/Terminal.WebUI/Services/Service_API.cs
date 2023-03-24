using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Terminal.WebUI.Models;
using System.Net.Http;

namespace Terminal.WebUI.Services
{
    public class Service_API: IService_API
    {
        private static string _baseurl;

        public Service_API()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseurl = builder.GetSection("ApiSettings:BaseUrl").Value;

        }
        public async Task<List<ClientesModel>> List()
        {
            List<ClientesModel> listado = new List<ClientesModel>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(_baseurl + "api/Clientes");

                // Analizar la respuesta en una lista de objetos de modelo
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    listado = JsonConvert.DeserializeObject<List<ClientesModel>>(jsonResponse);
                }
                return listado;
            }
        }


        public Task<bool> Create(ClientesModel item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int clie_Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(ClientesModel item)
        {
            throw new NotImplementedException();
        }

        public Task<ClientesModel> find(int clie_Id)
        {
            throw new NotImplementedException();
        }
    }
}
