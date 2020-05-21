namespace app2led
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.off1 = new System.Windows.Forms.Button();
            this.on1 = new System.Windows.Forms.Button();
            this.textstatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usbHidPort1 = new UsbLibrary.UsbHidPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.text_sw2 = new System.Windows.Forms.TextBox();
            this.text_sw1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.on2 = new System.Windows.Forms.Button();
            this.off2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.off1);
            this.groupBox1.Controls.Add(this.on1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // off1
            // 
            resources.ApplyResources(this.off1, "off1");
            this.off1.Name = "off1";
            this.off1.UseVisualStyleBackColor = true;
            this.off1.Click += new System.EventHandler(this.off1_Click);
            // 
            // on1
            // 
            resources.ApplyResources(this.on1, "on1");
            this.on1.Name = "on1";
            this.on1.UseVisualStyleBackColor = true;
            this.on1.Click += new System.EventHandler(this.on1_Click);
            // 
            // textstatus
            // 
            this.textstatus.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.textstatus, "textstatus");
            this.textstatus.Name = "textstatus";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Name = "label2";
            // 
            // usbHidPort1
            // 
            this.usbHidPort1.ProductId = 0;
            this.usbHidPort1.VendorId = 0;
            this.usbHidPort1.OnSpecifiedDeviceArrived += new System.EventHandler(this.usbHidPort1_OnSpecifiedDeviceArrived);
            this.usbHidPort1.OnSpecifiedDeviceRemoved += new System.EventHandler(this.usbHidPort1_OnSpecifiedDeviceRemoved);
            this.usbHidPort1.OnDeviceArrived += new System.EventHandler(this.usbHidPort1_OnDeviceArrived);
            this.usbHidPort1.OnDeviceRemoved += new System.EventHandler(this.usbHidPort1_OnDeviceRemoved);
            this.usbHidPort1.OnDataRecieved += new UsbLibrary.DataRecievedEventHandler(this.usbHidPort1_OnDataRecieved);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.text_sw2);
            this.groupBox3.Controls.Add(this.text_sw1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // text_sw2
            // 
            resources.ApplyResources(this.text_sw2, "text_sw2");
            this.text_sw2.Name = "text_sw2";
            // 
            // text_sw1
            // 
            resources.ApplyResources(this.text_sw1, "text_sw1");
            this.text_sw1.Name = "text_sw1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // on2
            // 
            this.on2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.on2, "on2");
            this.on2.Name = "on2";
            this.on2.UseVisualStyleBackColor = true;
            this.on2.Click += new System.EventHandler(this.on2_Click_1);
            // 
            // off2
            // 
            this.off2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.off2, "off2");
            this.off2.Name = "off2";
            this.off2.UseVisualStyleBackColor = true;
            this.off2.Click += new System.EventHandler(this.off2_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.off2);
            this.groupBox2.Controls.Add(this.on2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textstatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button off1;
        private System.Windows.Forms.Button on1;
        private System.Windows.Forms.TextBox textstatus;
        private System.Windows.Forms.Label label2;
        private UsbLibrary.UsbHidPort usbHidPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_sw2;
        private System.Windows.Forms.TextBox text_sw1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button on2;
        private System.Windows.Forms.Button off2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

