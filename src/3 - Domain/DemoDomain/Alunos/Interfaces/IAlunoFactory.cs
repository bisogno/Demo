using DemoDTO;

namespace DemoDomain.Alunos.Interfaces
{
    public interface IAlunoFactory
    {
        Aluno RaiseToCreate(CreateAlunoRequestDTO createDTO);
        Aluno RaiseToUpdate(UpdateAlunoRequestDTO updateDTO);
    }
}
