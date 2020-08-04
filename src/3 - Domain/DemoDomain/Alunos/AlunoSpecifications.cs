using System.Collections.Generic;
using DemoDomain.Specifications;

namespace DemoDomain.Alunos
{
    public class AlunoSpecifications : List<SpecificationBase<Aluno>>
    {
        public AlunoSpecifications()
        {
            AddRange(new List<SpecificationBase<Aluno>>()
            {
                new AlunoShouldHaveId()
            });
        }
    }
}
