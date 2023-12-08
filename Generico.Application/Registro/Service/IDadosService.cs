using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Application.Registro.Service
{
    public interface IDadosService
    {
        Task<DadosDto> ListaDados(int quantidate);
    }

}
