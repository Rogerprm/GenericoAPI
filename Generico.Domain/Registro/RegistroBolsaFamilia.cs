

using Generico.Domain.Base;

namespace Generico.Domain.Registro
{
    public class RegistroBolsaFamilia 
    { 
        public Guid IdRegistro { get; set; }
        public string MesCompetencia { get; set; }
        public string MesReferencia { get; set; }
        public string UF { get; set; }
        public string CdMunicipioSIAFI { get; set; }
        public string NmMunicipio { get; set; }
        public string CPFFavorecido { get; set; }
        public string NISFavorecido { get; set; }
        public string NomeFavorecido { get; set; }
        public string ValorParcela { get; set; }
    }

}
