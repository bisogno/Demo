using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDTO
{
    public class CreateAlunoResponseDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
    }
}
