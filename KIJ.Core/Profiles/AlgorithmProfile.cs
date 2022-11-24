using AutoMapper;
using KIJ.Data.DBModels;
using KIJ.Data.DtoModels;

namespace KIJ.Core.Profiles
{
    public class AlgorithmProfile : Profile
    {
        public AlgorithmProfile()
        {
            // source -> target
            CreateMap<CreateAlgorithmDto, Algorithm>();
            CreateMap<Algorithm, GetAlgorithmInfo>();
        }
    }
}
