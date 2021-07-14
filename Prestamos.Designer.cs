
using System;

namespace NatilleraCobroDuro
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.Saludo = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnConfirmarSolicitud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatosPersonales = new System.Windows.Forms.Panel();
            this.barrio = new System.Windows.Forms.ComboBox();
            this.tipodocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatosPrestamo = new System.Windows.Forms.Panel();
            this.monto = new System.Windows.Forms.TextBox();
            this.cuotas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DatosPersonales.SuspendLayout();
            this.DatosPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Saludo.Location = new System.Drawing.Point(46, 44);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(159, 31);
            this.Saludo.TabIndex = 0;
            this.Saludo.Text = "Bienvenido, ";
            this.Saludo.Click += new System.EventHandler(this.Saludo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegresar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRegresar.Location = new System.Drawing.Point(669, 386);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(123, 63);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnConfirmarSolicitud
            // 
            this.btnConfirmarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmarSolicitud.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConfirmarSolicitud.Location = new System.Drawing.Point(312, 333);
            this.btnConfirmarSolicitud.Name = "btnConfirmarSolicitud";
            this.btnConfirmarSolicitud.Size = new System.Drawing.Size(180, 70);
            this.btnConfirmarSolicitud.TabIndex = 2;
            this.btnConfirmarSolicitud.Text = "Confirmar Solicitud";
            this.btnConfirmarSolicitud.UseVisualStyleBackColor = false;
            this.btnConfirmarSolicitud.Click += new System.EventHandler(this.BtnConfirmarSolicitud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos personales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(444, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalle del préstamo";
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DatosPersonales.Controls.Add(this.barrio);
            this.DatosPersonales.Controls.Add(this.tipodocumento);
            this.DatosPersonales.Controls.Add(this.label4);
            this.DatosPersonales.Controls.Add(this.label3);
            this.DatosPersonales.Location = new System.Drawing.Point(52, 175);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(333, 142);
            this.DatosPersonales.TabIndex = 5;
            // 
            // barrio
            // 
            this.barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.barrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barrio.FormattingEnabled = true;
            this.barrio.Location = new System.Drawing.Point(181, 64);
            this.barrio.Name = "barrio";
            this.barrio.Size = new System.Drawing.Size(121, 21);
            this.barrio.TabIndex = 3;
            // 
            // tipodocumento
            // 
            this.tipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipodocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipodocumento.FormattingEnabled = true;
            this.tipodocumento.Location = new System.Drawing.Point(181, 18);
            this.tipodocumento.Name = "tipodocumento";
            this.tipodocumento.Size = new System.Drawing.Size(121, 21);
            this.tipodocumento.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Barrio donde vive";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de documento";
            // 
            // DatosPrestamo
            // 
            this.DatosPrestamo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DatosPrestamo.Controls.Add(this.monto);
            this.DatosPrestamo.Controls.Add(this.cuotas);
            this.DatosPrestamo.Controls.Add(this.label6);
            this.DatosPrestamo.Controls.Add(this.label5);
            this.DatosPrestamo.Location = new System.Drawing.Point(410, 175);
            this.DatosPrestamo.Name = "DatosPrestamo";
            this.DatosPrestamo.Size = new System.Drawing.Size(340, 142);
            this.DatosPrestamo.TabIndex = 6;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(195, 17);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(121, 20);
            this.monto.TabIndex = 3;
            this.monto.TextChanged += new System.EventHandler(this.monto_TextChanged);
            // 
            // cuotas
            // 
            this.cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuotas.FormattingEnabled = true;
            this.cuotas.Location = new System.Drawing.Point(195, 60);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(121, 21);
            this.cuotas.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cuotas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto del préstamo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.DatosPrestamo);
            this.Controls.Add(this.DatosPersonales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmarSolicitud);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.Saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            this.DatosPrestamo.ResumeLayout(false);
            this.DatosPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void monto_TextChanged(object sender, EventArgs e) => throw new NotImplementedException();

        private void Saludo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnConfirmarSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DatosPersonales;
        private System.Windows.Forms.Panel DatosPrestamo;
        private System.Windows.Forms.ComboBox barrio;
        private System.Windows.Forms.ComboBox tipodocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.ComboBox cuotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}