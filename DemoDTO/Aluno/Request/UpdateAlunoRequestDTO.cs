using System;

namespace DemoDTO
{
    public class UpdateAlunoRequestDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
    }
}
