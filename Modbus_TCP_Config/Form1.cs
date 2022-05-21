﻿using MetroFramework;
using MetroFramework.Forms;
using Modbus_TCP_Config.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modbus_TCP_Config
{
    public partial class Form1 : MetroForm
    {
        static SerialPort _port;
        DateTime dateTime;
        private Queue<byte> recievedData = new Queue<byte>();
        delegate void SetTextDeleg(byte[] trama);
        string diaActual = "";

        string evento = "";
        byte[] direccionIP = new byte[4];
        byte[] gatewayIP = new byte[4];
        byte[] mac = new byte[6];
        byte[] mascara = new byte[4];
        byte[] dns = new byte[4];
        byte[] puerto = new byte[2];
        public Form1()
        {
            var serial = SerialPort.GetPortNames();
            InitializeComponent();

            cmbPorts.DataSource = serial;

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (cmbPorts.SelectedIndex == -1)
            {
                MessageBox.Show("No selecciono un puerto");
            }
            else
            {
                try
                {
                    _port = new SerialPort(cmbPorts.SelectedItem.ToString());

                    // configure serial port
                    _port.BaudRate = 9600;
                    _port.DataBits = 8;
                    _port.Parity = Parity.None;
                    _port.StopBits = StopBits.One;
                    _port.ReadTimeout = 5000;
                    _port.WriteTimeout = 5000;
                    _port.DataReceived += new
                     SerialDataReceivedEventHandler(port_DataReceived);
                    _port.Open();

                    btnConectar.Enabled = false;
                    btnConectar.Style = MetroColorStyle.Green;
                    btnDesconectar.Enabled = true;
                    lblCOMEvent.BackColor = Color.Green;
                    btnConectarEthernet.Enabled = true;
                }
                catch (Exception)
                {
                    lblCOMEvent.BackColor = Color.Red;

                }

            }
        }
        private void port_DataReceived(object sender,
                SerialDataReceivedEventArgs e)
        {
            byte[] data = new byte[_port.BytesToRead];
            _port.Read(data, 0, data.Length);
            data.ToList().ForEach(b => recievedData.Enqueue(b));
            processData();
            // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.  
            // ---- The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.  

        }

        private void processData()
        {

            if (evento == "ConectarEthernet" && recievedData.Count == 91)
            {
                this.BeginInvoke(new SetTextDeleg(drawer), new object[] { recievedData.ToArray() });
            }

            if ((evento == "CambiarIP" || evento == "btnGrabar" ) && recievedData.Count == 1)
            {
                this.BeginInvoke(new SetTextDeleg(drawer), new object[] { recievedData.ToArray() });

            }
            if ((evento == "DesconectarEthernet"))
            {
                this.BeginInvoke(new SetTextDeleg(drawer), new object[] { new byte[] { recievedData.ElementAt(0) } });

            }
        }

        private void drawer(byte[] trama)
        {


            if (trama[0] == 1)
            {
                CrearTrama(trama);

                btnCambiarIP.Enabled = true;
                btnDesconectarEthernet.Enabled = true;
                btnConectarEthernet.Enabled = false;
                cargaDireccionIP(direccionIP);
                cargaGateWayIP(gatewayIP);
                cargaMACIP(mac);
                cargaMascara(mascara);
                cargaDns(dns);
           

                MessageBox.Show(" Dispositivo conectado");
            }
            else if (trama[0] == 2)
            {
                MessageBox.Show(" Dirección IP Cambiada!!");

            }
            else if (trama[0] == 3)
            {
                btnCambiarIP.Enabled = false;
                btnDesconectarEthernet.Enabled = false;
                btnConectarEthernet.Enabled = true;
                txtBye1.Enabled = false;
                txtBye2.Enabled = false;
                txtBye3.Enabled = false;
                txtBye4.Enabled = false;

                MessageBox.Show(" Dispositivo desconectado");

            }
          
            recievedData.Clear();


        }

        private void CrearTrama(byte[] trama)
        {
            direccionIP = trama.SubArray(1, 4);
           
            gatewayIP = trama.SubArray(71, 4);
            mac = trama.SubArray(75, 6);
            mascara = trama.SubArray(81, 4);
            dns = trama.SubArray(85, 4);
            puerto = trama.SubArray(89, 2);


            var puerto1 = Convert.ToString(Convert.ToInt32(trama[89]), 2).PadLeft(8, '0');
            var puerto2 = Convert.ToString(Convert.ToInt32(trama[90]), 2).PadLeft(8, '0');


            var port = Convert.ToInt32(puerto2 + puerto1, 2);
            if (Convert.ToInt32(trama[90]) == 0)
            {
                port = Convert.ToInt32(trama[89]);
            }

            txtPort.Text = port.ToString();
            txtPort.Enabled = true;
        }

        private void cargaDireccionIP(byte[] direccionIP)
        {
            txtBye1.Text = direccionIP[0].ToString();
            txtBye2.Text = direccionIP[1].ToString();
            txtBye3.Text = direccionIP[2].ToString();
            txtBye4.Text = direccionIP[3].ToString();

            txtBye1.Enabled = true;
            txtBye2.Enabled = true;
            txtBye3.Enabled = true;
            txtBye4.Enabled = true;
        }
        private void cargaGateWayIP(byte[] gateWay)
        {
            txtGateway1.Text = gateWay[0].ToString();
            txtGateway2.Text = gateWay[1].ToString();
            txtGateway3.Text = gateWay[2].ToString();
            txtGateway4.Text = gateWay[3].ToString();

            txtGateway1.Enabled = true;
            txtGateway2.Enabled = true;
            txtGateway3.Enabled = true;
            txtGateway4.Enabled = true;
        }
        private void cargaMACIP(byte[] mac)
        {
            txtMac1.Text = mac[0].ToHexa();
            txtMac2.Text = mac[1].ToHexa();
            txtMac3.Text = mac[2].ToHexa();
            txtMac4.Text = mac[3].ToHexa();
            txtMac5.Text = mac[4].ToHexa();
            txtMac6.Text = mac[5].ToHexa();


            txtMac1.Enabled = true;
            txtMac2.Enabled = true;
            txtMac3.Enabled = true;
            txtMac4.Enabled = true;
            txtMac5.Enabled = true;
            txtMac6.Enabled = true;

        }
        private void cargaMascara(byte[] mac)
        {
            txtMascara1.Text = mac[0].ToString();
            txtMascara2.Text = mac[1].ToString();
            txtMascara3.Text = mac[2].ToString();
            txtMascara4.Text = mac[3].ToString();


            txtMascara1.Enabled = true;
            txtMascara2.Enabled = true;
            txtMascara3.Enabled = true;
            txtMascara4.Enabled = true;


        }

        private void cargaDns(byte[] mac)
        {
            txtDns1.Text = mac[0].ToString();
            txtDns2.Text = mac[1].ToString();
            txtDns3.Text = mac[2].ToString();
            txtDns4.Text = mac[3].ToString();


            txtDns1.Enabled = true;
            txtDns2.Enabled = true;
            txtDns3.Enabled = true;
            txtDns4.Enabled = true;


        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            _port.Close();
            _port = null;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnConectar.Style = MetroColorStyle.White;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_port != null)
                _port.Close();
        }

        private void btnConectarEthernet_Click(object sender, EventArgs e)
        {
            try
            {
                evento = "ConectarEthernet";
                byte[] data = { 3, 3, 1 };
                _port.Write(data, 0, data.Length);


                lblEthernetEvent.BackColor = Color.Green;

            }
            catch (Exception)
            {

                lblEthernetEvent.BackColor = Color.Red;

            }
        }

        private void btnDesconectarEthernet_Click(object sender, EventArgs e)
        {
            evento = "DesconectarEthernet";

            byte[] data = { 3, 3, 3 };
            _port.Write(data, 0, data.Length);
        }

        private void btnCambiarIP_Click(object sender, EventArgs e)
        {
            evento = "CambiarIP";
            const string PATTERN = @"([^A-Fa-f0-9]|\s+?)+";
            var regex = new Regex(PATTERN);



            if (!IsAddressValid(txtBye1.Text + "." + txtBye2.Text + "." + txtBye3.Text + "." + txtBye4.Text))
            {
                MessageBox.Show("El formato de la  direccion IP es incorrecto los rangos son [0,255]");
                return;
            }

            if (Convert.ToInt32(txtPort.Text) <= 0)
            {
                MessageBox.Show("El valor del puerto incorrecto");
                return;
            }
            if (!IsAddressValid(txtGateway1.Text + "." + txtGateway2.Text + "." + txtGateway3.Text + "." + txtGateway4.Text))
            {
                MessageBox.Show("El formato de la  puerta de enlace es incorrecto los rangos son [0,255]");
                return;
            }

            if (!IsAddressValid(txtMascara1.Text + "." + txtMascara2.Text + "." + txtMascara3.Text + "." + txtMascara4.Text))
            {
                MessageBox.Show("El formato de la  mascara es incorrecto los rangos son [0,255]");
                return;
            }

            if (regex.IsMatch(txtMac1.Text))
            {
                MessageBox.Show("El formato de un valor de la mac es incorrecto los rangos son [0-9][A-F]");
                return;
            }

            if (!IsAddressValid(txtDns1.Text + "." + txtDns2.Text + "." + txtDns3.Text + "." + txtDns4.Text))
            {
                MessageBox.Show("El formato del  dns es incorrecto los rangos son [0,255]");
                return;
            }


            if (_port != null)
            {
                //GUSTAVO

                byte[] direccionIP = { Convert.ToByte(txtBye1.Text), Convert.ToByte(txtBye2.Text), Convert.ToByte(txtBye3.Text), Convert.ToByte(txtBye4.Text) };
                byte[] gatewayIP = { Convert.ToByte(txtGateway1.Text), Convert.ToByte(txtGateway2.Text), Convert.ToByte(txtGateway3.Text), Convert.ToByte(txtGateway4.Text) };
                byte[] mac = { Convert.ToByte(txtMac1.Text.ToDecimalFromHexa()), Convert.ToByte(txtMac2.Text.ToDecimalFromHexa()), Convert.ToByte(txtMac3.Text.ToDecimalFromHexa())
                            , Convert.ToByte(txtMac4.Text.ToDecimalFromHexa()), Convert.ToByte(txtMac5.Text.ToDecimalFromHexa()), Convert.ToByte(txtMac6.Text.ToDecimalFromHexa()) };
                byte[] mascara = { Convert.ToByte(txtMascara1.Text), Convert.ToByte(txtMascara2.Text), Convert.ToByte(txtMascara3.Text), Convert.ToByte(txtMascara4.Text) };
                byte[] dns = { Convert.ToByte(txtDns1.Text), Convert.ToByte(txtDns2.Text), Convert.ToByte(txtDns3.Text), Convert.ToByte(txtDns4.Text) };


                var portBinario = Convert.ToInt32(txtPort.Text).decimalBinario().ToString().PadLeft(16, '0');

                var port1 = ((byte)Convert.ToInt32(portBinario.Substring(0, 8), 2));
                var port2 = (byte)Convert.ToInt32(portBinario.Substring(8, 8), 2);
                var port = new byte[] { port2, port1 };

                byte[] data = { 3, 3, 2 };
                data = data.Concat(direccionIP)
                    .Concat(gatewayIP)
                    .Concat(mac)
                    .Concat(mascara)
                    .Concat(dns)
                    .Concat(port)
                    .ToArray();

                _port.Write(data, 0, data.Length);


            }

            else
            {
                MessageBox.Show("Problemas con el puerto");

            }
        }
        public bool IsAddressValid(string addrString)
        {
            IPAddress address;
            return IPAddress.TryParse(addrString, out address);
        }
    }
}
