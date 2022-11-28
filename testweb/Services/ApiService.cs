using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using testweb.Models;

namespace testweb.Services
{
    public class ApiService
    {
        static readonly HttpClient cliente = new HttpClient();
        public static async Task<List<Cliente>> GetCliente()
        {
            try
            {
                HttpResponseMessage response = await ApiService.cliente.GetAsync(@"https://localhost:44338/api/Clientes");
                response.EnsureSuccessStatusCode();
                string clienteReturn = await response.Content.ReadAsStringAsync();
                var clientes = JsonConvert.DeserializeObject<List<Cliente>>(clienteReturn);
                return clientes;
            }
            catch (HttpRequestException e)
            {
                throw;
            }
        }
    }
}
