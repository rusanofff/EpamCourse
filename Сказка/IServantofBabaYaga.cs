using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сказка
{
    interface IServantofBabaYaga
    {
        BabaYaga baba { get; set; }
        string Bribe { get; }
        string Reproach();
        string Skip();
    }
}
