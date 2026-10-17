namespace Views
{
    partial class DarAltaProfesor
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
            this.mtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.mtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tTituloUniver = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtDocumento
            // 
            this.mtDocumento.Location = new System.Drawing.Point(110, 109);
            this.mtDocumento.Mask = "99999999";
            this.mtDocumento.Name = "mtDocumento";
            this.mtDocumento.Size = new System.Drawing.Size(102, 20);
            this.mtDocumento.TabIndex = 25;
            this.mtDocumento.ValidatingType = typeof(int);
            // 
            // mtFechaNacimiento
            // 
            this.mtFechaNacimiento.Location = new System.Drawing.Point(141, 83);
            this.mtFechaNacimiento.Mask = "00/00/0000";
            this.mtFechaNacimiento.Name = "mtFechaNacimiento";
            this.mtFechaNacimiento.Size = new System.Drawing.Size(71, 20);
            this.mtFechaNacimiento.TabIndex = 24;
            this.mtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(289, 57);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(164, 20);
            this.tEmail.TabIndex = 23;
            // 
            // tApellido
            // 
            this.tApellido.Location = new System.Drawing.Point(77, 57);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(135, 20);
            this.tApellido.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "◆ Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "◆ N° Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "◆ Fecha de Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "◆ Emal:";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(77, 29);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(135, 20);
            this.tNombre.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "◆ Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "◆ Legajo:";
            // 
            // tTituloUniver
            // 
            this.tTituloUniver.Location = new System.Drawing.Point(339, 83);
            this.tTituloUniver.Name = "tTituloUniver";
            this.tTituloUniver.Size = new System.Drawing.Size(114, 20);
            this.tTituloUniver.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "◆ Titulo Univeristario:";
            // 
            // mtLegajo
            // 
            this.mtLegajo.Location = new System.Drawing.Point(289, 29);
            this.mtLegajo.Mask = "99999999";
            this.mtLegajo.Name = "mtLegajo";
            this.mtLegajo.Size = new System.Drawing.Size(164, 20);
            this.mtLegajo.TabIndex = 29;
            this.mtLegajo.ValidatingType = typeof(int);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(318, 176);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 30;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(399, 176);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 31;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // DarAltaProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 215);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.mtLegajo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tTituloUniver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtDocumento);
            this.Controls.Add(this.mtFechaNacimiento);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label1);
            this.Name = "DarAltaProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de alta Profesor";
            this.Load += new System.EventHandler(this.DarAltaProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtDocumento;
        private System.Windows.Forms.MaskedTextBox mtFechaNacimiento;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tTituloUniver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtLegajo;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
    }
}