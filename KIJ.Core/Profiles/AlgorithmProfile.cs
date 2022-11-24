using AutoMapper;
using KIJ.Data.DBModels;
using KIJ.Data.DtoModels;

namespace KIJ.Core.Profiles
{
    public class AlgorithmProfile : Profile
    {
        public AlgorithmProfile()
        {
            CreateMap<CreateAlgorithmDto, Algorithm>();
        }
    }
}
