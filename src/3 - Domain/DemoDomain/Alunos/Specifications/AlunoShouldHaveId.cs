using System;
using DemoDomain.Specifications;

namespace DemoDomain.Alunos
{
    public class AlunoShouldHaveId : SpecificationBase<Aluno>
    {
        public override string Message => "Aluno deve ter um Id";
        public override string DetailMessage => string.Empty;
        public override string Code => AlunoSpecificationCode.AlunoShouldHaveId.ToString();
        public override Func<Aluno, bool> IsValid() => (aluno) => aluno.Id != default(Guid);
    }
}
