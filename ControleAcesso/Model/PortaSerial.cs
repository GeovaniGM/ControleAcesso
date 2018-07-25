using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Model
{
    public class PortaSerial : SerialPort
    {
        public override string ToString() => $"PortName";

    }
}
