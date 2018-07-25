using ControleAcesso.Model;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso.Controller
{
    public class StatusCatracaController : BaseObject
    {
        private StatusCatracaController() { }

        private static StatusCatracaController instance;
        public static StatusCatracaController Instance
        {
            get
            {
                if (instance == null)
                    instance = new StatusCatracaController();

                return instance;
            }
        }

        public bool ChangeSerialPortState(SerialPort _serialPort)
        {
            if (!_serialPort.IsOpen)
                return ConectSerialPort(_serialPort);
            else
                return DisconectSerialPort(_serialPort);
        }

        private bool ConectSerialPort(SerialPort _serialPort)
        {
            _serialPort.Open();
            return _serialPort.IsOpen;
        }

        private bool DisconectSerialPort(SerialPort _serialPort)
        {
            _serialPort.Close();
            return _serialPort.IsOpen;
        }

        public void SendSignal(SerialPort _serialPort)
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    TelaInicial.Instance.WriteLog("Selected serial port is currently closed;\n");
                    return;
                }
                _serialPort.WriteTimeout = 10;
                _serialPort.WriteLine("test");
                MessageBox.Show(_serialPort.ReadLine());

                TelaInicial.Instance.WriteLog($"Sending signal to {_serialPort.PortName};\n");
            }
            catch(TimeoutException timeOutEx)
            {
                MessageBox.Show("O tempo limite de envio de sinal foi excedido. Tente novamente.");
                Console.WriteLine($"====================================" +
                                  $"{timeOutEx.Message}" +
                                  $"==================================== ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar enviar o sinal da porta serial. Comunique o suporte!");
                Console.WriteLine("====================================" +
                                  $"{ex.Message}" +
                                  "====================================");
            }
        }
    }
}