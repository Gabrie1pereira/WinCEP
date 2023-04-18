using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;

namespace CEPBLL
{
    public class ConsultaCEP
    {
        private readonly HttpClient _httpClient;
        public ConsultaCEP()

        {
            _httpClient = new HttpClient();
        }
   
        public CEP Consultar(string CepConsulta)
        {
            CEP cepRetorno = new CEP();
            cepRetorno.Bairro = "Boqueirao";
            cepRetorno.Logradouro = "Rua Osvaldo Cruz";
            cepRetorno.Complemento = "Lado Par";
            cepRetorno.Ddd = "13";
            cepRetorno.Localidade = "Santos";
            cepRetorno.Cep = "11045-907";
            cepRetorno.Uf = "SP";

            return _httpClient.GetFromJsonAsync<CEP>($"https://viacep.com.br/ws/{CepConsulta}/json/").Result;
        }
    }
}
