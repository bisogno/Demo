using System.Collections.Generic;
using DemoDomain.Alunos;

namespace DemoDomain.Alunos.Interfaces
{
    public class Sala
    {
        public ICollection<Aluno> Alunos { get; set; }
        public Professor Professor { get; set; }

    }
}
