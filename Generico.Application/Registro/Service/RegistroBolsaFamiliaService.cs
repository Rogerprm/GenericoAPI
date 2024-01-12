using AutoMapper;
using Generico.Application.Registro;
using Generico.Application.Registro.Dtos;
using Generico.Domain.Registro;
using Newtonsoft.Json;


namespace Generico.Application.Registro.Service
{
    public class RegistroBolsaFamiliaService : IRegistroBolsaFamiliaService
    {
        private readonly IRegistroBolsaFamiliaRepository _registroBolsaFamiliaRepository;
        private readonly IMapper _mapper;

        public RegistroBolsaFamiliaService(
            IRegistroBolsaFamiliaRepository registroBolsaFamiliaRepository,
            IMapper mapper)
        {
            _registroBolsaFamiliaRepository = registroBolsaFamiliaRepository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<RegistroBolsaFamiliaDto>> GetAllAsync()
        {
            var registroBolsaFamilias = await _registroBolsaFamiliaRepository.GetAll();

            var result = _mapper.Map<IEnumerable<RegistroBolsaFamiliaDto>>(registroBolsaFamilias);

            return result;
        }

        public async Task<IEnumerable<RegistroBolsaFamiliaDto>> GetAllByFilter(RegistroBolsaFamiliaDto filter)
        {
            var registroBolsaFamilia = _mapper.Map<RegistroBolsaFamilia>(filter);

            var registroBolsaFamilias = await _registroBolsaFamiliaRepository.GetByFilter(registroBolsaFamilia);

            var result = _mapper.Map<IEnumerable<RegistroBolsaFamiliaDto>>(registroBolsaFamilias);
            string json = JsonConvert.SerializeObject(result);

            File.WriteAllText(@"C:\\ArquivosUteis", json);
            return result;
        }

        public ICollection<RegistroBolsaFamiliaDto> GetByQueryable(RegistroBolsaFamiliaFilter filter)
        {
            var query = _registroBolsaFamiliaRepository.GetByQueryable(filter);

            var result = _mapper.Map<ICollection<RegistroBolsaFamiliaDto>>(query);
            string json = JsonConvert.SerializeObject(result);
            string path = Path.Combine(Directory.GetCurrentDirectory(), "dados.txt");
            File.WriteAllText(path, json);
            return result;
        }
    }
}
