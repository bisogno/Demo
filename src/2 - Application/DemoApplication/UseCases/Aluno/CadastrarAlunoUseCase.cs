using System;
using System.Threading.Tasks;
using DemoDomain.Alunos.Interfaces;
using DemoDTO;

namespace DemoApplication.UseCases.Aluno
{
    public class CadastrarAlunoUseCase : ICadastrarAlunoUseCase
    {
        private readonly IAlunoFactory _alunoFactory;

        public CadastrarAlunoUseCase(IAlunoFactory alunoFactory)
        {
            _alunoFactory = alunoFactory;
        }
        public Task<CreateAlunoResponseDTO> Execute(CreateAlunoRequestDTO createRequest)
        {
            throw new NotImplementedException();
        }
    }
}
