using DemoDomain.Alunos;
using DemoDomain.Alunos.Interfaces;
using DemoDTO;

namespace DemoDomain.Factories
{
    public class AlunoFactory : IAlunoFactory
    {
        internal AlunoFactory()
        {
            
        }

        public Aluno RaiseToCreate(CreateAlunoRequestDTO createDTO)
        {
            throw new System.NotImplementedException();
        }

        public Aluno RaiseToUpdate(UpdateAlunoRequestDTO updateDTO)
        {
            throw new System.NotImplementedException();
        }
    }
}
