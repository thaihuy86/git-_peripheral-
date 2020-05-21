using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsbLibrary;   //su dung thu vien USB

namespace app2led
{
    public partial class Form1 : Form
    {
        byte[] readbuff = new byte[3];
        byte[] writebuff = new byte[3];
        int count = 0, count1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.usbHidPort1.VendorId = 0x04D8;
            this.usbHidPort1.ProductId = 0x0001;
            this.usbHidPort1.CheckDevicePresent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void on1_Click(object sender, EventArgs e)
        {
            writebuff[1] = 1;
            if (this.usbHidPort1.SpecifiedDevice != null)
            {
                this.usbHidPort1.SpecifiedDevice.SendData(writebuff);
            }
            else
            {
                MessageBox.Show("Device not fuond. Please reconnect USB device to use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void off1_Click(object sender, EventArgs e)
        {
            writebuff[1] = 2;
            if (this.usbHidPort1.SpecifiedDevice != null)
            {
                this.usbHidPort1.SpecifiedDevice.SendData(writebuff);
            }
            else
            {
                MessageBox.Show("Device not fuond. Please reconnect USB device to use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


       
        private void usbHidPort1_OnSpecifiedDeviceArrived(object sender, EventArgs e)
        {
            textstatus.Text = "Connected";
            textstatus.BackColor = Color.Aqua;
            text_sw1.Text = "0";
            text_sw2.Text = "0";
        }
        private void usbHidPort1_OnSpecifiedDeviceRemoved(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler(usbHidPort1_OnSpecifiedDeviceRemoved), new object[] { sender, e });
            }
            else
            {
                textstatus.Text = "Disconnected";
                textstatus.BackColor = Color.Red;
            }
        }
        private void usbHidPort1_OnDataRecieved(object sender, DataRecievedEventArgs args)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new DataRecievedEventHandler(usbHidPort1_OnDataRecieved), new object[] { sender, args });
                }
                catch { }
            }
            else
            {
                readbuff = args.data;

                if (readbuff[1].ToString() == "115")
                {
                    count++;
                    text_sw1.Text = count.ToString();
                }
                else if (readbuff[1].ToString() == "119")
                {
                    count1++;
                    text_sw2.Text = count1.ToString();
                }
                else if (readbuff[1] == 5)
                {
                    pictureBox1.Image = app2led.Properties.Resources.LED_Sang;
                }
                else if (readbuff[1] == 6)
                {
                    pictureBox1.Image = app2led.Properties.Resources.t;
                }
                else if (readbuff[1]== 7)
                {
                    pictureBox2.Image = app2led.Properties.Resources.LED_Sang;
                }
                else if (readbuff[1] == 8)
                {
                    pictureBox2.Image = app2led.Properties.Resources.t;
                }

            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            usbHidPort1.RegisterHandle(Handle);
            
        }
        protected override void WndProc(ref Message m)
        {
            usbHidPort1.ParseMessages(ref m);
            base.WndProc(ref m);

        }

        private void on2_Click_1(object sender, EventArgs e)
        {
            writebuff[1] = 3;
            if (this.usbHidPort1.SpecifiedDevice != null)
            {
                this.usbHidPort1.SpecifiedDevice.SendData(writebuff);
            }
            else
            {
                MessageBox.Show("Device not fuond. Please reconnect USB device to use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void off2_Click(object sender, EventArgs e)
        {
            writebuff[1] = 4;
            if (this.usbHidPort1.SpecifiedDevice != null)
            {
                this.usbHidPort1.SpecifiedDevice.SendData(writebuff);
            }
            else
            {
                MessageBox.Show("Device not fuond. Please reconnect USB device to use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void usbHidPort1_OnDeviceArrived(object sender, EventArgs e)
        {

        }

        private void usbHidPort1_OnDeviceRemoved(object sender, EventArgs e)
        {

        }

        

       

       
             
    }
}
