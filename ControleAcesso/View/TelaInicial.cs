using ControleAcesso.Controller;
using ControleAcesso.Model;
using ControleAcesso.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso
{
    public partial class TelaInicial : BaseForm
    {
        private static TelaInicial instance;
        public static TelaInicial Instance
        {
            get
            {
                if (instance == null)
                    instance = new TelaInicial();

                return instance;
            }
        }

        #region Construtor
        private TelaInicial()
        {
            InitializeComponent();
        }
        #endregion      

        #region Events
        private void btnNew_Click(object sender, EventArgs e)
        {
            ConsultaClienteController.Instance.AdicionarCliente();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
                ConsultaClienteController.Instance.ExcluirCliente(dgvClientes.SelectedRows[0]);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
                ConsultaClienteController.Instance.EditarCliente(dgvClientes.SelectedRows[0]);
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            ConsultaClienteController.Instance.BuscarClientes(dgvClientes);
            lblSimboloConectado1.Text = "X";
            lblSimboloConectado1.ForeColor = Color.Red;
            lblSimboloConectado2.Text = "X";
            lblSimboloConectado2.ForeColor = Color.Red;

            serialPort1 = new SerialPort()
            {
                PortName = "COM3",
                BaudRate = 9600,
                DataBits = 8,
                StopBits = StopBits.One,
                Parity = Parity.None
            };
            serialPort2 = new SerialPort()
            {
                PortName = "COM4",
                BaudRate = 9600,
                DataBits = 8,
                StopBits = StopBits.One,
                Parity = Parity.None
            };

            GetSerialPorts();
            StartThreads();
        }

        private void btnConnect1_Click(object sender, EventArgs e)
        {
            StatusCatracaController.Instance.ChangeSerialPortState(serialPort1);

            if (serialPort1.IsOpen)
            {
                lblSimboloConectado1.Text = "✓";
                lblSimboloConectado1.ForeColor = Color.Green;
                btnConect1.Text = "Desconectar";
                txtLog.AppendText($"{serialPort1.PortName} : Connected;\n");
            }
            else
            {
                lblSimboloConectado1.Text = "X";
                lblSimboloConectado1.ForeColor = Color.Red;
                btnConect1.Text = "Conectar";
                txtLog.AppendText($"{serialPort1.PortName} : Disconnected;\n");
            }

            if (serialPort1.IsOpen)
            {
                txtSerialPort1.Text = serialPort1.PortName;
                txtBaudRate1.Text = serialPort1.BaudRate.ToString();
                txtDataBits1.Text = serialPort1.DataBits.ToString();
                txtStopBits1.Text = serialPort1.StopBits.ToString();
                txtParity1.Text = serialPort1.Parity.ToString();
            }
            else
            {
                txtSerialPort1.Clear();
                txtBaudRate1.Clear();
                txtDataBits1.Clear();
                txtStopBits1.Clear();
                txtParity1.Clear();
            }
        }

        private void btnConnect2_Click(object sender, EventArgs e)
        {
            StatusCatracaController.Instance.ChangeSerialPortState(serialPort2);

            if (serialPort2.IsOpen)
            {
                lblSimboloConectado2.Text = "✓";
                lblSimboloConectado2.ForeColor = Color.Green;
                btnConect2.Text = "Desconectar";
                txtLog.AppendText($"{serialPort2.PortName} : Connected;\n");
            }
            else
            {
                lblSimboloConectado2.Text = "X";
                lblSimboloConectado2.ForeColor = Color.Red;
                btnConect2.Text = "Conectar";
                txtLog.AppendText($"{serialPort2.PortName} : Disconnected;\n");
            }

            if (serialPort2.IsOpen)
            {
                txtSerialPort2.Text = serialPort2.PortName;
                txtBaudRate2.Text = serialPort2.BaudRate.ToString();
                txtDataBits2.Text = serialPort2.DataBits.ToString();
                txtStopBits2.Text = serialPort2.StopBits.ToString();
                txtParity2.Text = serialPort2.Parity.ToString();
            }
            else
            {
                txtSerialPort2.Clear();
                txtBaudRate2.Clear();
                txtDataBits2.Clear();
                txtStopBits2.Clear();
                txtParity2.Clear();
            }
        }

        private void btnComunicate1_Click(object sender, EventArgs e)
        {
            StatusCatracaController.Instance.SendSignal((SerialPort)cmbSerialPort.SelectedItem);
        }

        private void btnComunicate2_Click(object sender, EventArgs e)
        {
            StatusCatracaController.Instance.SendSignal((SerialPort)cmbSerialPort.SelectedItem);
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            rdbReceivedSignal1.Checked = true;
            WriteLog($"COM3 : Data Signal Received : {serialPort1.ReadExisting()} ;\n");
            Task.Delay(3000);
            rdbReceivedSignal1.Checked = false;
        }

        public void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                rdbReceivedSignal2.Checked = true;
                WriteLog($"{e.GetType().ToString()} : Data Signal Received;\n");
                Task.Delay(3000);
                rdbReceivedSignal2.Checked = false;

            }
            catch (TimeoutException timeOutEx)
            {
                MessageBox.Show("O tempo limite de envio de sinal foi excedido. Tente novamente.", "Timeout");
                Console.WriteLine($"====================================" +
                                  $"{timeOutEx.Message}" +
                                  $"==================================== ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu algum erro durante o envio de sinal. Comunique o suporte!", "Erro");
                Console.WriteLine($"====================================" +
                                  $"{ex.Message}" +
                                  $"==================================== ");
            }
        }

        private void btnCalcularRaio_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCircunferencia.Text == String.Empty)
                    throw new ArgumentException();
                txtRaio.Text = Utils.CalculaRaio(Convert.ToDouble(txtCircunferencia.Text)).ToString();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Informe um valor para o cálculo do raio!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtCircunferencia_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(@"([0-9])");
            txtCircunferencia.Text = Regex.Replace(txtCircunferencia.Text, @"([^0-9])", "");
        }
        #endregion

        #region Methods
        public void GetSerialPorts()
        {
            var SerialPortsPC = SerialPort.GetPortNames();
            var serialPorts = new List<SerialPort>();
            serialPorts.Add(serialPort1);
            serialPorts.Add(serialPort2);

            cmbSerialPort.DataSource = serialPorts;
            cmbSerialPort.DisplayMember = "PortName";
        }

        public void WriteLog(string _log)
        {
            txtLog.AppendText(_log);
        }

        public void StartThreads()
        {
            var _continue = true;
            var readThread = new Thread(() =>
            {
                while (_continue)
                {
                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu algum erro durante a execução da leitura do sinal. Comunique o suporte!");
                        Console.WriteLine("===================================" +
                                          $"{ex.Message}" +
                                          "===================================");
                        _continue = false;
                    }
                }
            });
        }
        #endregion
    }
}