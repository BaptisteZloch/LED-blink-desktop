
namespace Arduino_serial_communication
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Serialports = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.on_button = new System.Windows.Forms.Button();
            this.off_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.baudrates = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select COM port :";
            // 
            // Serialports
            // 
            this.Serialports.FormattingEnabled = true;
            this.Serialports.Location = new System.Drawing.Point(152, 33);
            this.Serialports.Name = "Serialports";
            this.Serialports.Size = new System.Drawing.Size(121, 24);
            this.Serialports.TabIndex = 1;
            // 
            // on_button
            // 
            this.on_button.Location = new System.Drawing.Point(70, 190);
            this.on_button.Name = "on_button";
            this.on_button.Size = new System.Drawing.Size(75, 23);
            this.on_button.TabIndex = 2;
            this.on_button.Text = "ON";
            this.on_button.UseVisualStyleBackColor = true;
            this.on_button.Click += new System.EventHandler(this.on_button_Click);
            // 
            // off_button
            // 
            this.off_button.Location = new System.Drawing.Point(190, 190);
            this.off_button.Name = "off_button";
            this.off_button.Size = new System.Drawing.Size(75, 23);
            this.off_button.TabIndex = 3;
            this.off_button.Text = "OFF";
            this.off_button.UseVisualStyleBackColor = true;
            this.off_button.Click += new System.EventHandler(this.off_button_Click);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(198, 106);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 4;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // disconnect_button
            // 
            this.disconnect_button.Location = new System.Drawing.Point(280, 318);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(90, 23);
            this.disconnect_button.TabIndex = 5;
            this.disconnect_button.Text = "Disconnect";
            this.disconnect_button.UseVisualStyleBackColor = true;
            this.disconnect_button.Click += new System.EventHandler(this.disconnect_button_Click);
            // 
            // baudrates
            // 
            this.baudrates.FormattingEnabled = true;
            this.baudrates.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400"});
            this.baudrates.Location = new System.Drawing.Point(152, 63);
            this.baudrates.Name = "baudrates";
            this.baudrates.Size = new System.Drawing.Size(121, 24);
            this.baudrates.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select baud rate :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.baudrates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disconnect_button);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.off_button);
            this.Controls.Add(this.on_button);
            this.Controls.Add(this.Serialports);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Serial communication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Serialports;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button on_button;
        private System.Windows.Forms.Button off_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.ComboBox baudrates;
        private System.Windows.Forms.Label label2;
    }
}

