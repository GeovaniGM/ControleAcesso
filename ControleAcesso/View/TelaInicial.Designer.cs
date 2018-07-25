using System.IO.Ports;

namespace ControleAcesso
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.tbvTelaInicial = new System.Windows.Forms.TabControl();
            this.tabStatusCatraca = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcularRaio = new System.Windows.Forms.Button();
            this.txtCircunferencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnComunicate1 = new System.Windows.Forms.Button();
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.lblSerialPortName1 = new System.Windows.Forms.Label();
            this.gbxSerial2 = new System.Windows.Forms.GroupBox();
            this.rdbReceivedSignal2 = new System.Windows.Forms.RadioButton();
            this.txtParity2 = new System.Windows.Forms.TextBox();
            this.lblConectado2 = new System.Windows.Forms.Label();
            this.txtStopBits2 = new System.Windows.Forms.TextBox();
            this.lblSimboloConectado2 = new System.Windows.Forms.Label();
            this.txtDataBits2 = new System.Windows.Forms.TextBox();
            this.btnConect2 = new System.Windows.Forms.Button();
            this.txtBaudRate2 = new System.Windows.Forms.TextBox();
            this.lblSerialPort2 = new System.Windows.Forms.Label();
            this.txtSerialPort2 = new System.Windows.Forms.TextBox();
            this.lblDataBits2 = new System.Windows.Forms.Label();
            this.lblParity2 = new System.Windows.Forms.Label();
            this.lblBaudRate2 = new System.Windows.Forms.Label();
            this.lblStopBits2 = new System.Windows.Forms.Label();
            this.lblTituloStatusCatraca = new System.Windows.Forms.Label();
            this.gbxSerial1 = new System.Windows.Forms.GroupBox();
            this.rdbReceivedSignal1 = new System.Windows.Forms.RadioButton();
            this.txtParity1 = new System.Windows.Forms.TextBox();
            this.lblConectado1 = new System.Windows.Forms.Label();
            this.txtStopBits1 = new System.Windows.Forms.TextBox();
            this.lblSimboloConectado1 = new System.Windows.Forms.Label();
            this.txtDataBits1 = new System.Windows.Forms.TextBox();
            this.btnConect1 = new System.Windows.Forms.Button();
            this.txtBaudRate1 = new System.Windows.Forms.TextBox();
            this.lblSerialPort1 = new System.Windows.Forms.Label();
            this.txtSerialPort1 = new System.Windows.Forms.TextBox();
            this.lblDataBits1 = new System.Windows.Forms.Label();
            this.lblParity1 = new System.Windows.Forms.Label();
            this.lblBaudRate1 = new System.Windows.Forms.Label();
            this.lblStopBits1 = new System.Windows.Forms.Label();
            this.tabCadastroCliente = new System.Windows.Forms.TabPage();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.tbvTelaInicial.SuspendLayout();
            this.tabStatusCatraca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxLog.SuspendLayout();
            this.gbxSerial2.SuspendLayout();
            this.gbxSerial1.SuspendLayout();
            this.tabCadastroCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbvTelaInicial
            // 
            this.tbvTelaInicial.Controls.Add(this.tabStatusCatraca);
            this.tbvTelaInicial.Controls.Add(this.tabCadastroCliente);
            this.tbvTelaInicial.Location = new System.Drawing.Point(-1, -1);
            this.tbvTelaInicial.Name = "tbvTelaInicial";
            this.tbvTelaInicial.SelectedIndex = 0;
            this.tbvTelaInicial.Size = new System.Drawing.Size(800, 452);
            this.tbvTelaInicial.TabIndex = 0;
            // 
            // tabStatusCatraca
            // 
            this.tabStatusCatraca.Controls.Add(this.groupBox1);
            this.tabStatusCatraca.Controls.Add(this.gbxLog);
            this.tabStatusCatraca.Controls.Add(this.gbxSerial2);
            this.tabStatusCatraca.Controls.Add(this.lblTituloStatusCatraca);
            this.tabStatusCatraca.Controls.Add(this.gbxSerial1);
            this.tabStatusCatraca.Location = new System.Drawing.Point(4, 22);
            this.tabStatusCatraca.Name = "tabStatusCatraca";
            this.tabStatusCatraca.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusCatraca.Size = new System.Drawing.Size(792, 426);
            this.tabStatusCatraca.TabIndex = 0;
            this.tabStatusCatraca.Text = "Status da Catraca";
            this.tabStatusCatraca.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRaio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCalcularRaio);
            this.groupBox1.Controls.Add(this.txtCircunferencia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 137);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raio do Circulo";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(6, 94);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.ReadOnly = true;
            this.txtRaio.Size = new System.Drawing.Size(128, 20);
            this.txtRaio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raio (cm) : ";
            // 
            // btnCalcularRaio
            // 
            this.btnCalcularRaio.Location = new System.Drawing.Point(170, 35);
            this.btnCalcularRaio.Name = "btnCalcularRaio";
            this.btnCalcularRaio.Size = new System.Drawing.Size(80, 79);
            this.btnCalcularRaio.TabIndex = 2;
            this.btnCalcularRaio.Text = "Calcular Raio";
            this.btnCalcularRaio.UseVisualStyleBackColor = true;
            this.btnCalcularRaio.Click += new System.EventHandler(this.btnCalcularRaio_Click);
            // 
            // txtCircunferencia
            // 
            this.txtCircunferencia.Location = new System.Drawing.Point(6, 35);
            this.txtCircunferencia.Name = "txtCircunferencia";
            this.txtCircunferencia.Size = new System.Drawing.Size(128, 20);
            this.txtCircunferencia.TabIndex = 1;
            this.txtCircunferencia.TextChanged += new System.EventHandler(this.txtCircunferencia_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Circunferência (cm) :";
            // 
            // gbxLog
            // 
            this.gbxLog.Controls.Add(this.txtLog);
            this.gbxLog.Controls.Add(this.btnComunicate1);
            this.gbxLog.Controls.Add(this.cmbSerialPort);
            this.gbxLog.Controls.Add(this.lblSerialPortName1);
            this.gbxLog.Location = new System.Drawing.Point(297, 39);
            this.gbxLog.Name = "gbxLog";
            this.gbxLog.Size = new System.Drawing.Size(200, 235);
            this.gbxLog.TabIndex = 17;
            this.gbxLog.TabStop = false;
            this.gbxLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 19);
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(188, 164);
            this.txtLog.TabIndex = 16;
            this.txtLog.Text = "";
            // 
            // btnComunicate1
            // 
            this.btnComunicate1.Location = new System.Drawing.Point(119, 200);
            this.btnComunicate1.Name = "btnComunicate1";
            this.btnComunicate1.Size = new System.Drawing.Size(75, 23);
            this.btnComunicate1.TabIndex = 18;
            this.btnComunicate1.Text = "Enviar Sinal";
            this.btnComunicate1.UseVisualStyleBackColor = true;
            this.btnComunicate1.Click += new System.EventHandler(this.btnComunicate1_Click);
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(6, 202);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(107, 21);
            this.cmbSerialPort.TabIndex = 18;
            // 
            // lblSerialPortName1
            // 
            this.lblSerialPortName1.AutoSize = true;
            this.lblSerialPortName1.Location = new System.Drawing.Point(6, 186);
            this.lblSerialPortName1.Name = "lblSerialPortName1";
            this.lblSerialPortName1.Size = new System.Drawing.Size(61, 13);
            this.lblSerialPortName1.TabIndex = 18;
            this.lblSerialPortName1.Text = "Porta Serial";
            // 
            // gbxSerial2
            // 
            this.gbxSerial2.Controls.Add(this.rdbReceivedSignal2);
            this.gbxSerial2.Controls.Add(this.txtParity2);
            this.gbxSerial2.Controls.Add(this.lblConectado2);
            this.gbxSerial2.Controls.Add(this.txtStopBits2);
            this.gbxSerial2.Controls.Add(this.lblSimboloConectado2);
            this.gbxSerial2.Controls.Add(this.txtDataBits2);
            this.gbxSerial2.Controls.Add(this.btnConect2);
            this.gbxSerial2.Controls.Add(this.txtBaudRate2);
            this.gbxSerial2.Controls.Add(this.lblSerialPort2);
            this.gbxSerial2.Controls.Add(this.txtSerialPort2);
            this.gbxSerial2.Controls.Add(this.lblDataBits2);
            this.gbxSerial2.Controls.Add(this.lblParity2);
            this.gbxSerial2.Controls.Add(this.lblBaudRate2);
            this.gbxSerial2.Controls.Add(this.lblStopBits2);
            this.gbxSerial2.Location = new System.Drawing.Point(503, 39);
            this.gbxSerial2.Name = "gbxSerial2";
            this.gbxSerial2.Size = new System.Drawing.Size(282, 235);
            this.gbxSerial2.TabIndex = 15;
            this.gbxSerial2.TabStop = false;
            this.gbxSerial2.Text = "Porta Serial COM4";
            // 
            // rdbReceivedSignal2
            // 
            this.rdbReceivedSignal2.AutoSize = true;
            this.rdbReceivedSignal2.Location = new System.Drawing.Point(6, 202);
            this.rdbReceivedSignal2.Name = "rdbReceivedSignal2";
            this.rdbReceivedSignal2.Size = new System.Drawing.Size(92, 17);
            this.rdbReceivedSignal2.TabIndex = 20;
            this.rdbReceivedSignal2.TabStop = true;
            this.rdbReceivedSignal2.Text = "Sinal recebido";
            this.rdbReceivedSignal2.UseVisualStyleBackColor = true;
            // 
            // txtParity2
            // 
            this.txtParity2.Enabled = false;
            this.txtParity2.Location = new System.Drawing.Point(161, 169);
            this.txtParity2.Name = "txtParity2";
            this.txtParity2.Size = new System.Drawing.Size(100, 20);
            this.txtParity2.TabIndex = 13;
            // 
            // lblConectado2
            // 
            this.lblConectado2.AutoSize = true;
            this.lblConectado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectado2.Location = new System.Drawing.Point(41, 30);
            this.lblConectado2.Name = "lblConectado2";
            this.lblConectado2.Size = new System.Drawing.Size(139, 29);
            this.lblConectado2.TabIndex = 2;
            this.lblConectado2.Text = "Conectado";
            // 
            // txtStopBits2
            // 
            this.txtStopBits2.Enabled = false;
            this.txtStopBits2.Location = new System.Drawing.Point(161, 144);
            this.txtStopBits2.Name = "txtStopBits2";
            this.txtStopBits2.Size = new System.Drawing.Size(100, 20);
            this.txtStopBits2.TabIndex = 12;
            // 
            // lblSimboloConectado2
            // 
            this.lblSimboloConectado2.AutoSize = true;
            this.lblSimboloConectado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimboloConectado2.Location = new System.Drawing.Point(9, 30);
            this.lblSimboloConectado2.Name = "lblSimboloConectado2";
            this.lblSimboloConectado2.Size = new System.Drawing.Size(0, 29);
            this.lblSimboloConectado2.TabIndex = 1;
            // 
            // txtDataBits2
            // 
            this.txtDataBits2.Enabled = false;
            this.txtDataBits2.Location = new System.Drawing.Point(161, 120);
            this.txtDataBits2.Name = "txtDataBits2";
            this.txtDataBits2.Size = new System.Drawing.Size(100, 20);
            this.txtDataBits2.TabIndex = 11;
            // 
            // btnConect2
            // 
            this.btnConect2.Location = new System.Drawing.Point(179, 33);
            this.btnConect2.Name = "btnConect2";
            this.btnConect2.Size = new System.Drawing.Size(82, 23);
            this.btnConect2.TabIndex = 3;
            this.btnConect2.Text = "Conectar";
            this.btnConect2.UseVisualStyleBackColor = true;
            this.btnConect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // txtBaudRate2
            // 
            this.txtBaudRate2.Enabled = false;
            this.txtBaudRate2.Location = new System.Drawing.Point(161, 95);
            this.txtBaudRate2.Name = "txtBaudRate2";
            this.txtBaudRate2.Size = new System.Drawing.Size(100, 20);
            this.txtBaudRate2.TabIndex = 10;
            // 
            // lblSerialPort2
            // 
            this.lblSerialPort2.AutoSize = true;
            this.lblSerialPort2.Location = new System.Drawing.Point(43, 75);
            this.lblSerialPort2.Name = "lblSerialPort2";
            this.lblSerialPort2.Size = new System.Drawing.Size(70, 13);
            this.lblSerialPort2.TabIndex = 4;
            this.lblSerialPort2.Text = "Porta Serial : ";
            // 
            // txtSerialPort2
            // 
            this.txtSerialPort2.Enabled = false;
            this.txtSerialPort2.Location = new System.Drawing.Point(161, 72);
            this.txtSerialPort2.Name = "txtSerialPort2";
            this.txtSerialPort2.Size = new System.Drawing.Size(100, 20);
            this.txtSerialPort2.TabIndex = 9;
            // 
            // lblDataBits2
            // 
            this.lblDataBits2.AutoSize = true;
            this.lblDataBits2.Location = new System.Drawing.Point(43, 123);
            this.lblDataBits2.Name = "lblDataBits2";
            this.lblDataBits2.Size = new System.Drawing.Size(56, 13);
            this.lblDataBits2.TabIndex = 5;
            this.lblDataBits2.Text = "DataBits : ";
            // 
            // lblParity2
            // 
            this.lblParity2.AutoSize = true;
            this.lblParity2.Location = new System.Drawing.Point(43, 172);
            this.lblParity2.Name = "lblParity2";
            this.lblParity2.Size = new System.Drawing.Size(42, 13);
            this.lblParity2.TabIndex = 8;
            this.lblParity2.Text = "Parity : ";
            // 
            // lblBaudRate2
            // 
            this.lblBaudRate2.AutoSize = true;
            this.lblBaudRate2.Location = new System.Drawing.Point(43, 98);
            this.lblBaudRate2.Name = "lblBaudRate2";
            this.lblBaudRate2.Size = new System.Drawing.Size(64, 13);
            this.lblBaudRate2.TabIndex = 6;
            this.lblBaudRate2.Text = "BaudRate : ";
            // 
            // lblStopBits2
            // 
            this.lblStopBits2.AutoSize = true;
            this.lblStopBits2.Location = new System.Drawing.Point(43, 147);
            this.lblStopBits2.Name = "lblStopBits2";
            this.lblStopBits2.Size = new System.Drawing.Size(55, 13);
            this.lblStopBits2.TabIndex = 7;
            this.lblStopBits2.Text = "StopBits : ";
            // 
            // lblTituloStatusCatraca
            // 
            this.lblTituloStatusCatraca.AutoSize = true;
            this.lblTituloStatusCatraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloStatusCatraca.Location = new System.Drawing.Point(241, 3);
            this.lblTituloStatusCatraca.Name = "lblTituloStatusCatraca";
            this.lblTituloStatusCatraca.Size = new System.Drawing.Size(264, 33);
            this.lblTituloStatusCatraca.TabIndex = 0;
            this.lblTituloStatusCatraca.Text = "Status da Catraca";
            // 
            // gbxSerial1
            // 
            this.gbxSerial1.Controls.Add(this.rdbReceivedSignal1);
            this.gbxSerial1.Controls.Add(this.txtParity1);
            this.gbxSerial1.Controls.Add(this.lblConectado1);
            this.gbxSerial1.Controls.Add(this.txtStopBits1);
            this.gbxSerial1.Controls.Add(this.lblSimboloConectado1);
            this.gbxSerial1.Controls.Add(this.txtDataBits1);
            this.gbxSerial1.Controls.Add(this.btnConect1);
            this.gbxSerial1.Controls.Add(this.txtBaudRate1);
            this.gbxSerial1.Controls.Add(this.lblSerialPort1);
            this.gbxSerial1.Controls.Add(this.txtSerialPort1);
            this.gbxSerial1.Controls.Add(this.lblDataBits1);
            this.gbxSerial1.Controls.Add(this.lblParity1);
            this.gbxSerial1.Controls.Add(this.lblBaudRate1);
            this.gbxSerial1.Controls.Add(this.lblStopBits1);
            this.gbxSerial1.Location = new System.Drawing.Point(9, 39);
            this.gbxSerial1.Name = "gbxSerial1";
            this.gbxSerial1.Size = new System.Drawing.Size(282, 235);
            this.gbxSerial1.TabIndex = 14;
            this.gbxSerial1.TabStop = false;
            this.gbxSerial1.Text = "Porta Serial COM3";
            // 
            // rdbReceivedSignal1
            // 
            this.rdbReceivedSignal1.AutoSize = true;
            this.rdbReceivedSignal1.Location = new System.Drawing.Point(6, 202);
            this.rdbReceivedSignal1.Name = "rdbReceivedSignal1";
            this.rdbReceivedSignal1.Size = new System.Drawing.Size(92, 17);
            this.rdbReceivedSignal1.TabIndex = 21;
            this.rdbReceivedSignal1.TabStop = true;
            this.rdbReceivedSignal1.Text = "Sinal recebido";
            this.rdbReceivedSignal1.UseVisualStyleBackColor = true;
            // 
            // txtParity1
            // 
            this.txtParity1.Enabled = false;
            this.txtParity1.Location = new System.Drawing.Point(161, 169);
            this.txtParity1.Name = "txtParity1";
            this.txtParity1.Size = new System.Drawing.Size(100, 20);
            this.txtParity1.TabIndex = 13;
            // 
            // lblConectado1
            // 
            this.lblConectado1.AutoSize = true;
            this.lblConectado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectado1.Location = new System.Drawing.Point(41, 30);
            this.lblConectado1.Name = "lblConectado1";
            this.lblConectado1.Size = new System.Drawing.Size(139, 29);
            this.lblConectado1.TabIndex = 2;
            this.lblConectado1.Text = "Conectado";
            // 
            // txtStopBits1
            // 
            this.txtStopBits1.Enabled = false;
            this.txtStopBits1.Location = new System.Drawing.Point(161, 144);
            this.txtStopBits1.Name = "txtStopBits1";
            this.txtStopBits1.Size = new System.Drawing.Size(100, 20);
            this.txtStopBits1.TabIndex = 12;
            // 
            // lblSimboloConectado1
            // 
            this.lblSimboloConectado1.AutoSize = true;
            this.lblSimboloConectado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimboloConectado1.Location = new System.Drawing.Point(9, 30);
            this.lblSimboloConectado1.Name = "lblSimboloConectado1";
            this.lblSimboloConectado1.Size = new System.Drawing.Size(0, 29);
            this.lblSimboloConectado1.TabIndex = 1;
            // 
            // txtDataBits1
            // 
            this.txtDataBits1.Enabled = false;
            this.txtDataBits1.Location = new System.Drawing.Point(161, 120);
            this.txtDataBits1.Name = "txtDataBits1";
            this.txtDataBits1.Size = new System.Drawing.Size(100, 20);
            this.txtDataBits1.TabIndex = 11;
            // 
            // btnConect1
            // 
            this.btnConect1.Location = new System.Drawing.Point(179, 33);
            this.btnConect1.Name = "btnConect1";
            this.btnConect1.Size = new System.Drawing.Size(82, 23);
            this.btnConect1.TabIndex = 3;
            this.btnConect1.Text = "Conectar";
            this.btnConect1.UseVisualStyleBackColor = true;
            this.btnConect1.Click += new System.EventHandler(this.btnConnect1_Click);
            // 
            // txtBaudRate1
            // 
            this.txtBaudRate1.Enabled = false;
            this.txtBaudRate1.Location = new System.Drawing.Point(161, 95);
            this.txtBaudRate1.Name = "txtBaudRate1";
            this.txtBaudRate1.Size = new System.Drawing.Size(100, 20);
            this.txtBaudRate1.TabIndex = 10;
            // 
            // lblSerialPort1
            // 
            this.lblSerialPort1.AutoSize = true;
            this.lblSerialPort1.Location = new System.Drawing.Point(43, 75);
            this.lblSerialPort1.Name = "lblSerialPort1";
            this.lblSerialPort1.Size = new System.Drawing.Size(70, 13);
            this.lblSerialPort1.TabIndex = 4;
            this.lblSerialPort1.Text = "Porta Serial : ";
            // 
            // txtSerialPort1
            // 
            this.txtSerialPort1.Enabled = false;
            this.txtSerialPort1.Location = new System.Drawing.Point(161, 72);
            this.txtSerialPort1.Name = "txtSerialPort1";
            this.txtSerialPort1.Size = new System.Drawing.Size(100, 20);
            this.txtSerialPort1.TabIndex = 9;
            // 
            // lblDataBits1
            // 
            this.lblDataBits1.AutoSize = true;
            this.lblDataBits1.Location = new System.Drawing.Point(43, 123);
            this.lblDataBits1.Name = "lblDataBits1";
            this.lblDataBits1.Size = new System.Drawing.Size(56, 13);
            this.lblDataBits1.TabIndex = 5;
            this.lblDataBits1.Text = "DataBits : ";
            // 
            // lblParity1
            // 
            this.lblParity1.AutoSize = true;
            this.lblParity1.Location = new System.Drawing.Point(43, 172);
            this.lblParity1.Name = "lblParity1";
            this.lblParity1.Size = new System.Drawing.Size(42, 13);
            this.lblParity1.TabIndex = 8;
            this.lblParity1.Text = "Parity : ";
            // 
            // lblBaudRate1
            // 
            this.lblBaudRate1.AutoSize = true;
            this.lblBaudRate1.Location = new System.Drawing.Point(43, 98);
            this.lblBaudRate1.Name = "lblBaudRate1";
            this.lblBaudRate1.Size = new System.Drawing.Size(64, 13);
            this.lblBaudRate1.TabIndex = 6;
            this.lblBaudRate1.Text = "BaudRate : ";
            // 
            // lblStopBits1
            // 
            this.lblStopBits1.AutoSize = true;
            this.lblStopBits1.Location = new System.Drawing.Point(43, 147);
            this.lblStopBits1.Name = "lblStopBits1";
            this.lblStopBits1.Size = new System.Drawing.Size(55, 13);
            this.lblStopBits1.TabIndex = 7;
            this.lblStopBits1.Text = "StopBits : ";
            // 
            // tabCadastroCliente
            // 
            this.tabCadastroCliente.Controls.Add(this.btnNew);
            this.tabCadastroCliente.Controls.Add(this.btnEdit);
            this.tabCadastroCliente.Controls.Add(this.btnDelete);
            this.tabCadastroCliente.Controls.Add(this.dgvClientes);
            this.tabCadastroCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCadastroCliente.Name = "tabCadastroCliente";
            this.tabCadastroCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastroCliente.Size = new System.Drawing.Size(792, 426);
            this.tabCadastroCliente.TabIndex = 1;
            this.tabCadastroCliente.Text = "Cadastro de Cliente";
            this.tabCadastroCliente.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(547, 395);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(628, 395);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(709, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(9, 7);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(776, 381);
            this.dgvClientes.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 2400;
            this.serialPort1.ReadTimeout = 500;
            this.serialPort1.WriteTimeout = 500;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 2400;
            this.serialPort2.ReadTimeout = 500;
            this.serialPort2.WriteTimeout = 500;
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // serialPort3
            // 
            this.serialPort3.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbvTelaInicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Catraca";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.tbvTelaInicial.ResumeLayout(false);
            this.tabStatusCatraca.ResumeLayout(false);
            this.tabStatusCatraca.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxLog.ResumeLayout(false);
            this.gbxLog.PerformLayout();
            this.gbxSerial2.ResumeLayout(false);
            this.gbxSerial2.PerformLayout();
            this.gbxSerial1.ResumeLayout(false);
            this.gbxSerial1.PerformLayout();
            this.tabCadastroCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //TabControl
        private System.Windows.Forms.TabControl tbvTelaInicial;
        private System.Windows.Forms.TabPage tabStatusCatraca;
        private System.Windows.Forms.TabPage tabCadastroCliente;
        //DataGridView
        private System.Windows.Forms.DataGridView dgvClientes;
        //Button
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnConect1;
        private System.Windows.Forms.Button btnConect2;
        //Label
        private System.Windows.Forms.Label lblBaudRate1;
        private System.Windows.Forms.Label lblBaudRate2;
        private System.Windows.Forms.Label lblConectado1;
        private System.Windows.Forms.Label lblConectado2;
        private System.Windows.Forms.Label lblDataBits1;
        private System.Windows.Forms.Label lblDataBits2;
        private System.Windows.Forms.Label lblParity1;
        private System.Windows.Forms.Label lblParity2;
        private System.Windows.Forms.Label lblSerialPort1;
        private System.Windows.Forms.Label lblSerialPort2;
        private System.Windows.Forms.Label lblSimboloConectado1;
        private System.Windows.Forms.Label lblSimboloConectado2;
        private System.Windows.Forms.Label lblStopBits1;
        private System.Windows.Forms.Label lblStopBits2;
        private System.Windows.Forms.Label lblTituloStatusCatraca;
        //TextBox
        private System.Windows.Forms.TextBox txtBaudRate1;
        private System.Windows.Forms.TextBox txtBaudRate2;
        private System.Windows.Forms.TextBox txtDataBits1;
        private System.Windows.Forms.TextBox txtDataBits2;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtParity1;
        private System.Windows.Forms.TextBox txtParity2;
        private System.Windows.Forms.TextBox txtSerialPort1;
        private System.Windows.Forms.TextBox txtSerialPort2;
        private System.Windows.Forms.TextBox txtStopBits1;
        private System.Windows.Forms.TextBox txtStopBits2;
        //GroupBox
        private System.Windows.Forms.GroupBox gbxSerial1;
        private System.Windows.Forms.GroupBox gbxSerial2;
        private System.Windows.Forms.GroupBox gbxLog;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button btnComunicate1;
        private System.Windows.Forms.Label lblSerialPortName1;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.RadioButton rdbReceivedSignal2;
        private System.Windows.Forms.RadioButton rdbReceivedSignal1;
        private System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcularRaio;
        private System.Windows.Forms.TextBox txtCircunferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

