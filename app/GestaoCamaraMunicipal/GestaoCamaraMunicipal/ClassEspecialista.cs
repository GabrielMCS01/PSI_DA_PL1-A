using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCamaraMunicipal
{
    public partial class Especialista
    {
        public override string ToString()
        {
            return string.Format("{0}", Funcionario);
        }
    }
}
