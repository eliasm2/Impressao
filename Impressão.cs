using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;                  // Para Impressão

namespace Windows_Forms___Impressão 
{
    public class Impressão : PrintDocument      // Classe Pública (Observar Herança...)
    {
        private string[] _Texto;                // Campos
        private int _NúmeroPágina;
        private int _OffSet;

        public string[] Texto                   // Propriedades
        {
            get { return _Texto; }
            set { _Texto = value; }
        }

        public int NúmeroPágina
        {
            get { return _NúmeroPágina; }
            set { _NúmeroPágina = value; }
        }

        public int Offset
        {
            get { return _OffSet; }
            set { _OffSet = value; }
        }

        public Impressão(string[] _Texto)       // Construtor
        {
            this.Texto = _Texto;
        }
    }
}
