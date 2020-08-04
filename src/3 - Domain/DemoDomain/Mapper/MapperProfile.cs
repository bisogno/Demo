using AutoMapper;
using DemoDomain.Alunos;
using DemoDTO;

namespace DemoDomain.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Aluno, CreateAlunoResponseDTO>();
            CreateMap<CreateAlunoRequestDTO, Aluno>();
        }
    }
}
