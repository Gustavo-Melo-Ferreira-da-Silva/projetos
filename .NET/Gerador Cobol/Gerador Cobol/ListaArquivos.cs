using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_Cobol
{
    class ListaArquivos
    {
        private Boolean _io;
        private String _arquivoNome;
        private String _ArquivoBook;
        private int _arquivoTamanho;
        private Boolean _fixo;

        public bool Io { get => _io; set => _io = value; }
        public string ArquivoNome { get => _arquivoNome; set => _arquivoNome = value; }
        public string ArquivoBook { get => _ArquivoBook; set => _ArquivoBook = value; }
        public int ArquivoTamanho { get => _arquivoTamanho; set => _arquivoTamanho = value; }
        public bool Fixo { get => _fixo; set => _fixo = value; }

        public override string ToString()
        {
            int lnome = _arquivoNome.Length;
            int lbook = _ArquivoBook.Length;
            String msg_io;
            String msg_fixo;

            if (_io)
            {
                msg_io = "Entrada | ";
            }
            else
            {
                msg_io = "Saída   | ";
            }

            if (_fixo)
            {
                msg_fixo = "FB | ";
            }
            else
            {
                msg_fixo = "VB | ";
            }

            return msg_io + msg_fixo + _arquivoNome + " | " + _ArquivoBook + " | LRECL=" + _arquivoTamanho; 
        }
    }
}
