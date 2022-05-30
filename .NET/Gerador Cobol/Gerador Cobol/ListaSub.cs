using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_Cobol
{
    class ListaSub
    {
        private String _subNome;
        private String _subBook;

        public string SubNome { get => _subNome; set => _subNome = value; }
        public string SubBook { get => _subBook; set => _subBook = value; }

        public override string ToString()
        {
            return _subNome + " | " + _subBook;
        }
    }
}
