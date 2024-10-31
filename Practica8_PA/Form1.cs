using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Practica8_PA
{
    public partial class Form1 : Form
    {
        delegate void SetTextDelegate(string value);

        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.DataBits = 8;
            ArduinoPort.ReadTimeout = 1000;
            ArduinoPort.WriteTimeout = 1000;
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            //ArduinoPort.Open();
            //Para vincular eventos
            this.btnconectar.Click += btnconectar_Click;


        }

        private void DataReceivedHandler (object sender, SerialDataReceivedEventArgs e)
        {
            string dato = ArduinoPort.ReadLine();
            EscribirTxt(dato);
        }

        private void EscribirTxt(string dato)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(EscribirTxt), dato);
                }
                catch
                {
                    //Poner en accion de aviso de error
                }
            else
                lbtemp.Text = dato;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            //btnconectar.Enabled = true;
            //btndesconectar.Enabled = false;
            try
            {
                if (!ArduinoPort.IsOpen)
                    ArduinoPort.Open();
                if(int.TryParse(tblimtemp.Text, out int temperatureLimit))
                {
                    string limitString = temperatureLimit.ToString();
                    ArduinoPort.Write(limitString);
                }
                else
                {
                    MessageBox.Show("Ingresa un valor numerico valido en el TextBox de limite de temperatura");
                }

                lbconection.Text = "Conexión OK";
                lbconection.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                MessageBox.Show("Configure el puerto de comunicación correcto o desconectar ");
            }
        }

        private void btndesconectar_Click(object sender, EventArgs e)
        {
            btnconectar.Enabled = true;
            btndesconectar.Enabled = false;
            if (ArduinoPort.IsOpen)
                ArduinoPort.Close();
            lbconection.Text = "Desconectado";
            lbconection.ForeColor = System.Drawing.Color.Red;
            lbtemp.Text = "00.00";
        }

        private void lbtemp_Click(object sender, EventArgs e)
        {

        }
    }
}
