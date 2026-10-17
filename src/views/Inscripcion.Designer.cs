namespace Views
{
    partial class Inscripcion
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
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bbuscar = new System.Windows.Forms.Button();
            this.bInscribir = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.lInfoPersonaSeleccionada = new System.Windows.Forms.Label();
            this.mtBusqueda = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(15, 146);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(177, 21);
            this.cbCurso.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "◆ Buscar Alumno por DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "◆ Seleccione curso:";
            // 
            // Bbuscar
            // 
            this.Bbuscar.Location = new System.Drawing.Point(151, 55);
            this.Bbuscar.Name = "Bbuscar";
            this.Bbuscar.Size = new System.Drawing.Size(75, 23);
            this.Bbuscar.TabIndex = 4;
            this.Bbuscar.Text = "Buscar";
            this.Bbuscar.UseVisualStyleBackColor = true;
            this.Bbuscar.Click += new System.EventHandler(this.Bbuscar_Click);
            // 
            // bInscribir
            // 
            this.bInscribir.Location = new System.Drawing.Point(204, 160);
            this.bInscribir.Name = "bInscribir";
            this.bInscribir.Size = new System.Drawing.Size(75, 23);
            this.bInscribir.TabIndex = 5;
            this.bInscribir.Text = "Inscribir";
            this.bInscribir.UseVisualStyleBackColor = true;
            this.bInscribir.Click += new System.EventHandler(this.bInscribir_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(285, 160);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 6;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // lInfoPersonaSeleccionada
            // 
            this.lInfoPersonaSeleccionada.AutoSize = true;
            this.lInfoPersonaSeleccionada.Location = new System.Drawing.Point(12, 89);
            this.lInfoPersonaSeleccionada.Name = "lInfoPersonaSeleccionada";
            this.lInfoPersonaSeleccionada.Size = new System.Drawing.Size(62, 13);
            this.lInfoPersonaSeleccionada.TabIndex = 9;
            this.lInfoPersonaSeleccionada.Text = "Informacion";
            // 
            // mtBusqueda
            // 
            this.mtBusqueda.Location = new System.Drawing.Point(15, 57);
            this.mtBusqueda.Mask = "99999999";
            this.mtBusqueda.Name = "mtBusqueda";
            this.mtBusqueda.Size = new System.Drawing.Size(129, 20);
            this.mtBusqueda.TabIndex = 10;
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 195);
            this.Controls.Add(this.mtBusqueda);
            this.Controls.Add(this.lInfoPersonaSeleccionada);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bInscribir);
            this.Controls.Add(this.Bbuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCurso);
            this.Name = "Inscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion";
            this.Load += new System.EventHandler(this.Inscripcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bbuscar;
        private System.Windows.Forms.Button bInscribir;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Label lInfoPersonaSeleccionada;
        private System.Windows.Forms.MaskedTextBox mtBusqueda;
    }
}