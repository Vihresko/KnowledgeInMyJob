using AutoMapper;
using KIJ.Core.Interfaces;
using KIJ.Data.DBContexts;
using KIJ.Data.DBModels;
using KIJ.Data.DtoModels;
using Microsoft.Extensions.Logging;

namespace KIJ.Core.Services
{
    public class AlgorithmService : IAlgorithmService
    {
        private readonly DbContextSQL _context;
        private readonly IMapper _mapper;
        private readonly ILogger<AlgorithmService> _logger;

        public AlgorithmService(DbContextSQL context, IMapper mapper, ILogger<AlgorithmService> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task CreateAlgorithm(CreateAlgorithmDto createAlgorithmDto)
        {
            _logger.LogInformation("You are in {0} implementation", nameof(CreateAlgorithm));

            try
            {
                var algorithm = _mapper.Map<Algorithm>(createAlgorithmDto);
                await _context.Algorithmes.AddAsync(algorithm);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError("{0}",ex.Message);
            }
            

        }
    }
}
