using Generico.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Generico.Domain.Endereco
{
    public class CepModel : Entity<Guid>
    {               
              
        public string Cep { get; set; }
        
        public string Logradouro { get; set; }

        public string Complemento { get; set; }
      
        public string Bairro { get; set; }
       
        public string Localidade { get; set; }
       
        public string Uf { get; set; }
               
        public string Ibge { get; set; }
       
        public string Gia { get; set; }
      
        public string Ddd { get; set; }
        
        public string Diafi { get; set; }
    }
}

