using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDomain.Alunos.Interfaces.Repositories
{
    public interface IAlunoRepository
    {
        Aluno GetById(Guid id);
    }
}
