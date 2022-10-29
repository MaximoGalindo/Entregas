using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontBanco.Servicio.HTTP
{
     class ClienteHTTP
    {
        private static ClienteHTTP instancia;
        private HttpClient cliente;

        private ClienteHTTP()
        {
            cliente = new HttpClient(); 
        }

        public static ClienteHTTP GetInstance()
        {
            if(instancia == null)
               instancia = new ClienteHTTP();
            return instancia;
        }

        public async Task<string> GetAsync(string url)
        {
            var resultado = await cliente.GetAsync(url);
            var content = "";
            if(resultado.IsSuccessStatusCode)
                content = await resultado.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<string> PostAsync(string url,string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await cliente.PostAsync(url, content);
            var response = "";
            if(result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }



    }
}
