using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEPBLL
{
    public class ConsultaCEP
    {
        public CEP Consultar(string CepConslta)
        {
            CEP cepRetorno = new CEP();
            cepRetorno.Bairro = "Boqueirao";
            cepRetorno.Logradouro = "Rua Osvaldo Cruz";
            cepRetorno.Complemento = "Lado Par";
            cepRetorno.Ddd = "13";
            cepRetorno.Localidade = "Santos";
            cepRetorno.Cep = "11045-907";
            cepRetorno.Uf = "SP";
            return cepRetorno;
        }
    }
}
