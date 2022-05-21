namespace Modbus_TCP_Config
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCOMEvent = new System.Windows.Forms.Label();
            this.btnDesconectar = new MetroFramework.Controls.MetroButton();
            this.btnConectar = new MetroFramework.Controls.MetroButton();
            this.cmbPorts = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEthernetEvent = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDns4 = new MetroFramework.Controls.MetroTextBox();
            this.txtDns3 = new MetroFramework.Controls.MetroTextBox();
            this.txtDns2 = new MetroFramework.Controls.MetroTextBox();
            this.txtDns1 = new MetroFramework.Controls.MetroTextBox();
            this.txtMascara4 = new MetroFramework.Controls.MetroTextBox();
            this.txtMascara3 = new MetroFramework.Controls.MetroTextBox();
            this.txtMascara2 = new MetroFramework.Controls.MetroTextBox();
            this.txtMascara1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtMac6 = new MetroFramework.Controls.MetroTextBox();
            this.txtMac5 = new MetroFramework.Controls.MetroTextBox();
            this.txtMac4 = new MetroFramework.Controls.MetroTextBox();
            this.txtMac3 = new MetroFramework.Controls.MetroTextBox();
            this.txtMac2 = new MetroFramework.Controls.MetroTextBox();
            this.txtMac1 = new MetroFramework.Controls.MetroTextBox();
            this.txtGateway4 = new MetroFramework.Controls.MetroTextBox();
            this.txtGateway3 = new MetroFramework.Controls.MetroTextBox();
            this.txtGateway2 = new MetroFramework.Controls.MetroTextBox();
            this.txtGateway1 = new MetroFramework.Controls.MetroTextBox();
            this.txtBye4 = new MetroFramework.Controls.MetroTextBox();
            this.txtBye3 = new MetroFramework.Controls.MetroTextBox();
            this.txtBye2 = new MetroFramework.Controls.MetroTextBox();
            this.txtBye1 = new MetroFramework.Controls.MetroTextBox();
            this.btnCambiarIP = new MetroFramework.Controls.MetroButton();
            this.btnDesconectarEthernet = new MetroFramework.Controls.MetroButton();
            this.btnConectarEthernet = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblCOMEvent);
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.cmbPorts);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Location = new System.Drawing.Point(153, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(445, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puerto COM";
            // 
            // lblCOMEvent
            // 
            this.lblCOMEvent.BackColor = System.Drawing.Color.White;
            this.lblCOMEvent.Location = new System.Drawing.Point(89, 10);
            this.lblCOMEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCOMEvent.Name = "lblCOMEvent";
            this.lblCOMEvent.Size = new System.Drawing.Size(283, 19);
            this.lblCOMEvent.TabIndex = 8;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.Location = new System.Drawing.Point(290, 32);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(82, 28);
            this.btnDesconectar.TabIndex = 7;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Highlight = true;
            this.btnConectar.Location = new System.Drawing.Point(202, 32);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(65, 28);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.ItemHeight = 23;
            this.cmbPorts.Location = new System.Drawing.Point(89, 35);
            this.cmbPorts.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(92, 29);
            this.cmbPorts.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEthernetEvent);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnDesconectarEthernet);
            this.groupBox2.Controls.Add(this.btnConectarEthernet);
            this.groupBox2.Location = new System.Drawing.Point(153, 166);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(445, 198);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuracion Ethernet";
            // 
            // lblEthernetEvent
            // 
            this.lblEthernetEvent.BackColor = System.Drawing.Color.White;
            this.lblEthernetEvent.Location = new System.Drawing.Point(4, 14);
            this.lblEthernetEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEthernetEvent.Name = "lblEthernetEvent";
            this.lblEthernetEvent.Size = new System.Drawing.Size(283, 19);
            this.lblEthernetEvent.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.txtPort);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.txtDns4);
            this.groupBox3.Controls.Add(this.txtDns3);
            this.groupBox3.Controls.Add(this.txtDns2);
            this.groupBox3.Controls.Add(this.txtDns1);
            this.groupBox3.Controls.Add(this.txtMascara4);
            this.groupBox3.Controls.Add(this.txtMascara3);
            this.groupBox3.Controls.Add(this.txtMascara2);
            this.groupBox3.Controls.Add(this.txtMascara1);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.txtMac6);
            this.groupBox3.Controls.Add(this.txtMac5);
            this.groupBox3.Controls.Add(this.txtMac4);
            this.groupBox3.Controls.Add(this.txtMac3);
            this.groupBox3.Controls.Add(this.txtMac2);
            this.groupBox3.Controls.Add(this.txtMac1);
            this.groupBox3.Controls.Add(this.txtGateway4);
            this.groupBox3.Controls.Add(this.txtGateway3);
            this.groupBox3.Controls.Add(this.txtGateway2);
            this.groupBox3.Controls.Add(this.txtGateway1);
            this.groupBox3.Controls.Add(this.txtBye4);
            this.groupBox3.Controls.Add(this.txtBye3);
            this.groupBox3.Controls.Add(this.txtBye2);
            this.groupBox3.Controls.Add(this.txtBye1);
            this.groupBox3.Controls.Add(this.btnCambiarIP);
            this.groupBox3.Location = new System.Drawing.Point(30, 39);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(396, 154);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(32, 117);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(38, 19);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "DNS:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel5.Location = new System.Drawing.Point(32, 89);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(65, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Mascara :";
            // 
            // txtDns4
            // 
            this.txtDns4.Enabled = false;
            this.txtDns4.Location = new System.Drawing.Point(226, 115);
            this.txtDns4.Margin = new System.Windows.Forms.Padding(2);
            this.txtDns4.Name = "txtDns4";
            this.txtDns4.Size = new System.Drawing.Size(28, 22);
            this.txtDns4.TabIndex = 34;
            // 
            // txtDns3
            // 
            this.txtDns3.Enabled = false;
            this.txtDns3.Location = new System.Drawing.Point(193, 115);
            this.txtDns3.Margin = new System.Windows.Forms.Padding(2);
            this.txtDns3.Name = "txtDns3";
            this.txtDns3.Size = new System.Drawing.Size(28, 22);
            this.txtDns3.TabIndex = 33;
            // 
            // txtDns2
            // 
            this.txtDns2.Enabled = false;
            this.txtDns2.Location = new System.Drawing.Point(160, 115);
            this.txtDns2.Margin = new System.Windows.Forms.Padding(2);
            this.txtDns2.Name = "txtDns2";
            this.txtDns2.Size = new System.Drawing.Size(28, 22);
            this.txtDns2.TabIndex = 32;
            // 
            // txtDns1
            // 
            this.txtDns1.Enabled = false;
            this.txtDns1.Location = new System.Drawing.Point(127, 115);
            this.txtDns1.Margin = new System.Windows.Forms.Padding(2);
            this.txtDns1.Name = "txtDns1";
            this.txtDns1.Size = new System.Drawing.Size(28, 22);
            this.txtDns1.TabIndex = 31;
            // 
            // txtMascara4
            // 
            this.txtMascara4.Enabled = false;
            this.txtMascara4.Location = new System.Drawing.Point(226, 89);
            this.txtMascara4.Margin = new System.Windows.Forms.Padding(2);
            this.txtMascara4.Name = "txtMascara4";
            this.txtMascara4.Size = new System.Drawing.Size(28, 22);
            this.txtMascara4.TabIndex = 30;
            // 
            // txtMascara3
            // 
            this.txtMascara3.Enabled = false;
            this.txtMascara3.Location = new System.Drawing.Point(193, 89);
            this.txtMascara3.Margin = new System.Windows.Forms.Padding(2);
            this.txtMascara3.Name = "txtMascara3";
            this.txtMascara3.Size = new System.Drawing.Size(28, 22);
            this.txtMascara3.TabIndex = 29;
            // 
            // txtMascara2
            // 
            this.txtMascara2.Enabled = false;
            this.txtMascara2.Location = new System.Drawing.Point(160, 89);
            this.txtMascara2.Margin = new System.Windows.Forms.Padding(2);
            this.txtMascara2.Name = "txtMascara2";
            this.txtMascara2.Size = new System.Drawing.Size(28, 22);
            this.txtMascara2.TabIndex = 28;
            // 
            // txtMascara1
            // 
            this.txtMascara1.Enabled = false;
            this.txtMascara1.Location = new System.Drawing.Point(127, 89);
            this.txtMascara1.Margin = new System.Windows.Forms.Padding(2);
            this.txtMascara1.Name = "txtMascara1";
            this.txtMascara1.Size = new System.Drawing.Size(28, 22);
            this.txtMascara1.TabIndex = 27;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 63);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "MAC :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 38);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Puerta Enlace:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel1.Location = new System.Drawing.Point(32, 11);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Direccion IP :";
            // 
            // txtMac6
            // 
            this.txtMac6.Enabled = false;
            this.txtMac6.Location = new System.Drawing.Point(291, 62);
            this.txtMac6.Margin = new System.Windows.Forms.Padding(2);
            this.txtMac6.Name = "txtMac6";
            this.txtMac6.Size = new System.Drawing.Size(28, 22);
            this.txtMac6.TabIndex = 23;
            // 
            // txtMac5
            // 
            this.txtMac5.Enabled = false;
            this.txtMac5.Location = new System.Drawing.Point(258, 63);
            this.txtMac5.Margin = new System.Windows.Forms.Padding(2);
            this.txtMac5.Name = "txtMac5";
            this.txtMac5.Size = new System.Drawing.Size(28, 22);
            this.txtMac5.TabIndex = 22;
            // 
            // txtMac4
            // 
            this.txtMac4.Enabled = false;
            this.txtMac4.Location = new System.Drawing.Point(225, 62);
            this.txtMac4.Margin = new System.Windows.Forms.Padding(2);
            this.txtMac4.Name = "txtMac4";
            this.txtMac4.Size = new System.Drawing.Size(28, 22);
            this.txtMac4.TabIndex = 21;
            // 
            // txtMac3
            // 
            this.txtMac3.Enabled = false;
            this.txtMac3.Location = new System.Drawing.Point(192, 63);
            this.txtMac3.Margin = new System.Windows.Forms.Padding(2);
            this.txtMac3.Name = "txtMac3";
            this.txtMac3.Size = new System.Drawing.Size(28, 22);
            this.txtMac3.TabIndex = 20;
            // 
            // txtMac2
            // 
            this.txtMac2.Enabled = false;
            this.txtMac2.Location = new System.Drawing.Point(159, 63);
            this.txtMac2.Margin = new System.Windows.Forms.Padding(2);
            this.txtMac2.Name = "txtMac2";
            this.txtMac2.Size = new System.Drawing.Size(28, 22);
            this.txtMac2.TabIndex = 19;
            // 
            // txtMac1
            // 
            this.txtMac1.Enabled = false;
            this.txtMac1.Location = new System.Drawing.Point(126, 63);
            this.txtMac1.Margin = new System.Windows.Forms.Padding(2);
            this.txtMac1.Name = "txtMac1";
            this.txtMac1.Size = new System.Drawing.Size(28, 22);
            this.txtMac1.TabIndex = 18;
            // 
            // txtGateway4
            // 
            this.txtGateway4.Enabled = false;
            this.txtGateway4.Location = new System.Drawing.Point(225, 36);
            this.txtGateway4.Margin = new System.Windows.Forms.Padding(2);
            this.txtGateway4.Name = "txtGateway4";
            this.txtGateway4.Size = new System.Drawing.Size(28, 22);
            this.txtGateway4.TabIndex = 17;
            // 
            // txtGateway3
            // 
            this.txtGateway3.Enabled = false;
            this.txtGateway3.Location = new System.Drawing.Point(192, 37);
            this.txtGateway3.Margin = new System.Windows.Forms.Padding(2);
            this.txtGateway3.Name = "txtGateway3";
            this.txtGateway3.Size = new System.Drawing.Size(28, 22);
            this.txtGateway3.TabIndex = 16;
            // 
            // txtGateway2
            // 
            this.txtGateway2.Enabled = false;
            this.txtGateway2.Location = new System.Drawing.Point(159, 37);
            this.txtGateway2.Margin = new System.Windows.Forms.Padding(2);
            this.txtGateway2.Name = "txtGateway2";
            this.txtGateway2.Size = new System.Drawing.Size(28, 22);
            this.txtGateway2.TabIndex = 15;
            // 
            // txtGateway1
            // 
            this.txtGateway1.Enabled = false;
            this.txtGateway1.Location = new System.Drawing.Point(126, 37);
            this.txtGateway1.Margin = new System.Windows.Forms.Padding(2);
            this.txtGateway1.Name = "txtGateway1";
            this.txtGateway1.Size = new System.Drawing.Size(28, 22);
            this.txtGateway1.TabIndex = 14;
            // 
            // txtBye4
            // 
            this.txtBye4.Enabled = false;
            this.txtBye4.Location = new System.Drawing.Point(225, 10);
            this.txtBye4.Margin = new System.Windows.Forms.Padding(2);
            this.txtBye4.Name = "txtBye4";
            this.txtBye4.Size = new System.Drawing.Size(28, 22);
            this.txtBye4.TabIndex = 13;
            // 
            // txtBye3
            // 
            this.txtBye3.Enabled = false;
            this.txtBye3.Location = new System.Drawing.Point(192, 11);
            this.txtBye3.Margin = new System.Windows.Forms.Padding(2);
            this.txtBye3.Name = "txtBye3";
            this.txtBye3.Size = new System.Drawing.Size(28, 22);
            this.txtBye3.TabIndex = 12;
            // 
            // txtBye2
            // 
            this.txtBye2.Enabled = false;
            this.txtBye2.Location = new System.Drawing.Point(159, 11);
            this.txtBye2.Margin = new System.Windows.Forms.Padding(2);
            this.txtBye2.Name = "txtBye2";
            this.txtBye2.Size = new System.Drawing.Size(28, 22);
            this.txtBye2.TabIndex = 11;
            // 
            // txtBye1
            // 
            this.txtBye1.Enabled = false;
            this.txtBye1.Location = new System.Drawing.Point(126, 11);
            this.txtBye1.Margin = new System.Windows.Forms.Padding(2);
            this.txtBye1.Name = "txtBye1";
            this.txtBye1.Size = new System.Drawing.Size(28, 22);
            this.txtBye1.TabIndex = 10;
            // 
            // btnCambiarIP
            // 
            this.btnCambiarIP.Enabled = false;
            this.btnCambiarIP.Location = new System.Drawing.Point(326, 115);
            this.btnCambiarIP.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarIP.Name = "btnCambiarIP";
            this.btnCambiarIP.Size = new System.Drawing.Size(65, 28);
            this.btnCambiarIP.TabIndex = 9;
            this.btnCambiarIP.Text = "Grabar";
            this.btnCambiarIP.Click += new System.EventHandler(this.btnCambiarIP_Click);
            // 
            // btnDesconectarEthernet
            // 
            this.btnDesconectarEthernet.Enabled = false;
            this.btnDesconectarEthernet.Location = new System.Drawing.Point(361, 8);
            this.btnDesconectarEthernet.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesconectarEthernet.Name = "btnDesconectarEthernet";
            this.btnDesconectarEthernet.Size = new System.Drawing.Size(80, 28);
            this.btnDesconectarEthernet.TabIndex = 9;
            this.btnDesconectarEthernet.Text = "Desconectar";
            this.btnDesconectarEthernet.Click += new System.EventHandler(this.btnDesconectarEthernet_Click);
            // 
            // btnConectarEthernet
            // 
            this.btnConectarEthernet.Enabled = false;
            this.btnConectarEthernet.Location = new System.Drawing.Point(290, 8);
            this.btnConectarEthernet.Margin = new System.Windows.Forms.Padding(2);
            this.btnConectarEthernet.Name = "btnConectarEthernet";
            this.btnConectarEthernet.Size = new System.Drawing.Size(65, 28);
            this.btnConectarEthernet.TabIndex = 8;
            this.btnConectarEthernet.Text = "Conectar";
            this.btnConectarEthernet.Click += new System.EventHandler(this.btnConectarEthernet_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(267, 12);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 39;
            this.metroLabel6.Text = "Puerto:";
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(322, 11);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(47, 22);
            this.txtPort.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Modbus_TCP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCOMEvent;
        private MetroFramework.Controls.MetroButton btnDesconectar;
        private MetroFramework.Controls.MetroButton btnConectar;
        private MetroFramework.Controls.MetroComboBox cmbPorts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEthernetEvent;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDns4;
        private MetroFramework.Controls.MetroTextBox txtDns3;
        private MetroFramework.Controls.MetroTextBox txtDns2;
        private MetroFramework.Controls.MetroTextBox txtDns1;
        private MetroFramework.Controls.MetroTextBox txtMascara4;
        private MetroFramework.Controls.MetroTextBox txtMascara3;
        private MetroFramework.Controls.MetroTextBox txtMascara2;
        private MetroFramework.Controls.MetroTextBox txtMascara1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtMac6;
        private MetroFramework.Controls.MetroTextBox txtMac5;
        private MetroFramework.Controls.MetroTextBox txtMac4;
        private MetroFramework.Controls.MetroTextBox txtMac3;
        private MetroFramework.Controls.MetroTextBox txtMac2;
        private MetroFramework.Controls.MetroTextBox txtMac1;
        private MetroFramework.Controls.MetroTextBox txtGateway4;
        private MetroFramework.Controls.MetroTextBox txtGateway3;
        private MetroFramework.Controls.MetroTextBox txtGateway2;
        private MetroFramework.Controls.MetroTextBox txtGateway1;
        private MetroFramework.Controls.MetroTextBox txtBye4;
        private MetroFramework.Controls.MetroTextBox txtBye3;
        private MetroFramework.Controls.MetroTextBox txtBye2;
        private MetroFramework.Controls.MetroTextBox txtBye1;
        private MetroFramework.Controls.MetroButton btnCambiarIP;
        private MetroFramework.Controls.MetroButton btnDesconectarEthernet;
        private MetroFramework.Controls.MetroButton btnConectarEthernet;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPort;
    }
}

