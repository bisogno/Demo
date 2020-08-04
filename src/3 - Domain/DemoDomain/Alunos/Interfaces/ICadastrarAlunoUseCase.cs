using System.Threading.Tasks;
using DemoDTO;

namespace DemoDomain.Alunos.Interfaces
{
    public interface ICadastrarAlunoUseCase 
    {
        Task<CreateAlunoResponseDTO> Execute(CreateAlunoRequestDTO createRequest);
    }
}
