
namespace Practica8_PA
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbconection = new System.Windows.Forms.Label();
            this.lbTemperatura = new System.Windows.Forms.Label();
            this.lbtemp = new System.Windows.Forms.Label();
            this.btnconectar = new System.Windows.Forms.Button();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.tblimtemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(95, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limite de Temperatura";
            // 
            // lbconection
            // 
            this.lbconection.AutoSize = true;
            this.lbconection.Location = new System.Drawing.Point(121, 201);
            this.lbconection.Name = "lbconection";
            this.lbconection.Size = new System.Drawing.Size(77, 13);
            this.lbconection.TabIndex = 1;
            this.lbconection.Text = "Desconectado";
            // 
            // lbTemperatura
            // 
            this.lbTemperatura.AutoSize = true;
            this.lbTemperatura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTemperatura.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbTemperatura.Location = new System.Drawing.Point(372, 58);
            this.lbTemperatura.Name = "lbTemperatura";
            this.lbTemperatura.Size = new System.Drawing.Size(67, 13);
            this.lbTemperatura.TabIndex = 2;
            this.lbTemperatura.Text = "Temperatura";
            // 
            // lbtemp
            // 
            this.lbtemp.AutoSize = true;
            this.lbtemp.Location = new System.Drawing.Point(391, 201);
            this.lbtemp.Name = "lbtemp";
            this.lbtemp.Size = new System.Drawing.Size(34, 13);
            this.lbtemp.TabIndex = 3;
            this.lbtemp.Text = "00.00";
            this.lbtemp.Click += new System.EventHandler(this.lbtemp_Click);
            // 
            // btnconectar
            // 
            this.btnconectar.BackColor = System.Drawing.Color.Green;
            this.btnconectar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnconectar.Location = new System.Drawing.Point(98, 262);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(100, 55);
            this.btnconectar.TabIndex = 4;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = false;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // btndesconectar
            // 
            this.btndesconectar.BackColor = System.Drawing.Color.Red;
            this.btndesconectar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndesconectar.Location = new System.Drawing.Point(365, 262);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(100, 55);
            this.btndesconectar.TabIndex = 5;
            this.btndesconectar.Text = "Desconectar";
            this.btndesconectar.UseVisualStyleBackColor = false;
            this.btndesconectar.Click += new System.EventHandler(this.btndesconectar_Click);
            // 
            // tblimtemp
            // 
            this.tblimtemp.Location = new System.Drawing.Point(98, 82);
            this.tblimtemp.Name = "tblimtemp";
            this.tblimtemp.Size = new System.Drawing.Size(100, 20);
            this.tblimtemp.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblimtemp);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.btnconectar);
            this.Controls.Add(this.lbtemp);
            this.Controls.Add(this.lbTemperatura);
            this.Controls.Add(this.lbconection);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbconection;
        private System.Windows.Forms.Label lbTemperatura;
        private System.Windows.Forms.Label lbtemp;
        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.TextBox tblimtemp;
    }
}

