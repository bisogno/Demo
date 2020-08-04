using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDTO
{
    class PaginationResponseDTO
    {
        public IList<Object> Registros { get; set; }
        public int Total { get; set; }
        public bool TemMaisRegistros { get; set; }

    }
}
