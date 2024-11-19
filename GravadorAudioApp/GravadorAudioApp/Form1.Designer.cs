namespace GravadorAudioApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.labelDevice = new System.Windows.Forms.Label();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Location = new System.Drawing.Point(12, 9);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(111, 13);
            this.labelDevice.TabIndex = 0;
            this.labelDevice.Text = "Selecionar Dispositivo";
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(12, 25);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(270, 21);
            this.comboBoxDevices.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 70);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Iniciar Gravação";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(130, 70);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 23);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Parar Gravação";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 110);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(68, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status: Pronto";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTimer.Location = new System.Drawing.Point(180, 110);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(49, 20);
            this.labelTimer.TabIndex = 5;
            this.labelTimer.Text = "00:00";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(294, 151);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.labelDevice);
            this.Name = "Form1";
            this.Text = "Gravador de Áudio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelTimer;
    }
}
