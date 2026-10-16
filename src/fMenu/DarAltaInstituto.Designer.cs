namespace fMenu
{
    partial class DarAltaInstituto
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
            this.mtIdInstituto = new System.Windows.Forms.MaskedTextBox();
            this.mtTelefonoInstituto = new System.Windows.Forms.MaskedTextBox();
            this.tDireccionInstituto = new System.Windows.Forms.TextBox();
            this.tNombreInstituto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tContactoInstituto = new System.Windows.Forms.TextBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtIdInstituto
            // 
            this.mtIdInstituto.Location = new System.Drawing.Point(94, 37);
            this.mtIdInstituto.Mask = "99999999";
            this.mtIdInstituto.Name = "mtIdInstituto";
            this.mtIdInstituto.Size = new System.Drawing.Size(75, 20);
            this.mtIdInstituto.TabIndex = 25;
            this.mtIdInstituto.ValidatingType = typeof(int);
            // 
            // mtTelefonoInstituto
            // 
            this.mtTelefonoInstituto.Location = new System.Drawing.Point(94, 121);
            this.mtTelefonoInstituto.Mask = "000-0000";
            this.mtTelefonoInstituto.Name = "mtTelefonoInstituto";
            this.mtTelefonoInstituto.Size = new System.Drawing.Size(105, 20);
            this.mtTelefonoInstituto.TabIndex = 24;
            this.mtTelefonoInstituto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tDireccionInstituto
            // 
            this.tDireccionInstituto.Location = new System.Drawing.Point(94, 93);
            this.tDireccionInstituto.Name = "tDireccionInstituto";
            this.tDireccionInstituto.Size = new System.Drawing.Size(105, 20);
            this.tDireccionInstituto.TabIndex = 23;
            // 
            // tNombreInstituto
            // 
            this.tNombreInstituto.Location = new System.Drawing.Point(94, 65);
            this.tNombreInstituto.Name = "tNombreInstituto";
            this.tNombreInstituto.Size = new System.Drawing.Size(105, 20);
            this.tNombreInstituto.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "◆ Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "◆ Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "◆ Contacto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "◆ Direccion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "◆ ID:";
            // 
            // tContactoInstituto
            // 
            this.tContactoInstituto.Location = new System.Drawing.Point(92, 149);
            this.tContactoInstituto.Name = "tContactoInstituto";
            this.tContactoInstituto.Size = new System.Drawing.Size(105, 20);
            this.tContactoInstituto.TabIndex = 26;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(101, 190);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 27;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(182, 190);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 28;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // DarAltaInstituto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 255);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tContactoInstituto);
            this.Controls.Add(this.mtIdInstituto);
            this.Controls.Add(this.mtTelefonoInstituto);
            this.Controls.Add(this.tDireccionInstituto);
            this.Controls.Add(this.tNombreInstituto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DarAltaInstituto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de Alta Instituto";
            this.Load += new System.EventHandler(this.DarAltaInstituto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtIdInstituto;
        private System.Windows.Forms.MaskedTextBox mtTelefonoInstituto;
        private System.Windows.Forms.TextBox tDireccionInstituto;
        private System.Windows.Forms.TextBox tNombreInstituto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tContactoInstituto;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
    }
}