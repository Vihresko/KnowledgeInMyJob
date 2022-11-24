using KIJ.Data.DtoModels;

namespace KIJ.Core.Interfaces
{
    public interface IAlgorithmService
    {
        public Task CreateAlgorithm(CreateAlgorithmDto createAlgorithmDto);
        public Task<ICollection<GetAlgorithmInfo>> CollectAllAlgorithmesInfo();
    }
}
