using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solid.Arduino;
using Solid.Arduino.Firmata;
using Solid.Arduino.I2C;
using Microsoft.Maker.Serial;
using Microsoft.Maker.RemoteWiring;

namespace ArduinoUNO
{
    public partial class Form1 : Form
    {
        private int redVal;
       
        public Form1()
        {
            InitializeComponent();
            redVal = trackRed.Value;
           
        }

        private void UpdateColorPanel()
        {
            panelColor.BackColor = Color.FromArgb(redVal, redVal, redVal);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var connection = new SerialConnection("COM7", SerialBaudRate.Bps_57600);
                var session = new ArduinoSession(connection, timeOut: 250);
                IFirmataProtocol firmata = (IFirmataProtocol)session;
                int redPin = 10;              
                firmata.SetDigitalPinMode(redPin, PinMode.PwmOutput);
                firmata.SetDigitalPin(redPin, redVal);             
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            redVal = trackRed.Value;
            lbRed.Text = redVal.ToString();
            UpdateColorPanel();        
            var connection = new SerialConnection("COM7", SerialBaudRate.Bps_57600);
            var session = new ArduinoSession(connection, timeOut: 250);
            IFirmataProtocol firmata = (IFirmataProtocol)session;
            int redPin = 10;
            firmata.SetDigitalPinMode(redPin, PinMode.PwmOutput);
            firmata.SetDigitalPin(redPin, redVal);
            connection.Close();
        }

       
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (DigiP10.Checked)
            {
                DigiP10.Text = "On";
                var connection = new SerialConnection("COM7", SerialBaudRate.Bps_57600);
                var session = new ArduinoSession(connection, timeOut: 250);
                IFirmataProtocol firmata = (IFirmataProtocol)session;
                firmata.SetDigitalPinMode(13, PinMode.DigitalOutput);
                firmata.SetDigitalPin(13, true);
                connection.Close();
            }
            else
            { 
                DigiP10.Text = "Off";
                var connection = new SerialConnection("COM7", SerialBaudRate.Bps_57600);
                var session = new ArduinoSession(connection, timeOut: 250);
                IFirmataProtocol firmata = (IFirmataProtocol)session;
                firmata.SetDigitalPinMode(13, PinMode.DigitalOutput);
                firmata.SetDigitalPin(13, false);
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var firmata = (II2CProtocol)session;
            //var x = firmata.GetI2CReply(0x77, 7);
            label3.Text = x.ToString();

        }
    }
}
