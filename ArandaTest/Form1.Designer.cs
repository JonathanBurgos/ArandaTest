
namespace ArandaTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Btn1 = new System.Windows.Forms.Button();
            this.LblVersionSystem = new System.Windows.Forms.Label();
            this.LblLocalName = new System.Windows.Forms.Label();
            this.LblHardDisk = new System.Windows.Forms.Label();
            this.LblLocalIP = new System.Windows.Forms.Label();
            this.LblDateTimeNow = new System.Windows.Forms.Label();
            this.LblProcessorName = new System.Windows.Forms.Label();
            this.LblLocalRAM = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl1.Location = new System.Drawing.Point(88, 25);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(612, 25);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Este aplicativo obtiene las propiedades o caracteristicas de este equipo.";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl2.Location = new System.Drawing.Point(51, 50);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(678, 25);
            this.Lbl2.TabIndex = 1;
            this.Lbl2.Text = "De click en el boton \"Obtener Datos\" para obtener la informacion de su equipo.";
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn1.Location = new System.Drawing.Point(296, 88);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(168, 40);
            this.Btn1.TabIndex = 2;
            this.Btn1.Text = "Obtener Datos";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // LblVersionSystem
            // 
            this.LblVersionSystem.AutoSize = true;
            this.LblVersionSystem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblVersionSystem.Location = new System.Drawing.Point(110, 160);
            this.LblVersionSystem.Name = "LblVersionSystem";
            this.LblVersionSystem.Size = new System.Drawing.Size(0, 21);
            this.LblVersionSystem.TabIndex = 3;
            // 
            // LblLocalName
            // 
            this.LblLocalName.AutoSize = true;
            this.LblLocalName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLocalName.Location = new System.Drawing.Point(110, 190);
            this.LblLocalName.Name = "LblLocalName";
            this.LblLocalName.Size = new System.Drawing.Size(0, 21);
            this.LblLocalName.TabIndex = 4;
            // 
            // LblHardDisk
            // 
            this.LblHardDisk.AutoSize = true;
            this.LblHardDisk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHardDisk.Location = new System.Drawing.Point(110, 251);
            this.LblHardDisk.Name = "LblHardDisk";
            this.LblHardDisk.Size = new System.Drawing.Size(0, 21);
            this.LblHardDisk.TabIndex = 6;
            // 
            // LblLocalIP
            // 
            this.LblLocalIP.AutoSize = true;
            this.LblLocalIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLocalIP.Location = new System.Drawing.Point(110, 221);
            this.LblLocalIP.Name = "LblLocalIP";
            this.LblLocalIP.Size = new System.Drawing.Size(0, 21);
            this.LblLocalIP.TabIndex = 5;
            // 
            // LblDateTimeNow
            // 
            this.LblDateTimeNow.AutoSize = true;
            this.LblDateTimeNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDateTimeNow.Location = new System.Drawing.Point(110, 348);
            this.LblDateTimeNow.Name = "LblDateTimeNow";
            this.LblDateTimeNow.Size = new System.Drawing.Size(0, 21);
            this.LblDateTimeNow.TabIndex = 9;
            // 
            // LblProcessorName
            // 
            this.LblProcessorName.AutoSize = true;
            this.LblProcessorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProcessorName.Location = new System.Drawing.Point(110, 312);
            this.LblProcessorName.Name = "LblProcessorName";
            this.LblProcessorName.Size = new System.Drawing.Size(0, 21);
            this.LblProcessorName.TabIndex = 8;
            // 
            // LblLocalRAM
            // 
            this.LblLocalRAM.AutoSize = true;
            this.LblLocalRAM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblLocalRAM.Location = new System.Drawing.Point(110, 282);
            this.LblLocalRAM.Name = "LblLocalRAM";
            this.LblLocalRAM.Size = new System.Drawing.Size(0, 21);
            this.LblLocalRAM.TabIndex = 7;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(690, 112);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(0, 15);
            this.LblId.TabIndex = 10;
            this.LblId.Visible = false;
            // 
            // BtnExportar
            // 
            this.BtnExportar.Location = new System.Drawing.Point(622, 397);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(119, 23);
            this.BtnExportar.TabIndex = 11;
            this.BtnExportar.Text = "Exportar txt";
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Visible = false;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.LblDateTimeNow);
            this.Controls.Add(this.LblProcessorName);
            this.Controls.Add(this.LblLocalRAM);
            this.Controls.Add(this.LblHardDisk);
            this.Controls.Add(this.LblLocalIP);
            this.Controls.Add(this.LblLocalName);
            this.Controls.Add(this.LblVersionSystem);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Name = "Form1";
            this.Text = "Aranda Prueba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Label LblVersionSystem;
        private System.Windows.Forms.Label LblLocalName;
        private System.Windows.Forms.Label LblProcessorName;
        private System.Windows.Forms.Label LblLocalRAM;
        private System.Windows.Forms.Label LblLocalIP;
        private System.Windows.Forms.Label LblHardDisk;
        private System.Windows.Forms.Label LblDateTimeNow;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Button BtnExportar;
    }
}

