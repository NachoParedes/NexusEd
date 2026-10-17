namespace Views
{
    partial class DarAltaCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.pCursoExterno = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbInstituto = new System.Windows.Forms.ComboBox();
            this.pCursoUniversitario = new System.Windows.Forms.Panel();
            this.tHorarioCurso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tAulaCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProfesorCurso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtIdCurso = new System.Windows.Forms.MaskedTextBox();
            this.tNombreCurso = new System.Windows.Forms.TextBox();
            this.rbUniversitario = new System.Windows.Forms.RadioButton();
            this.rbExterno = new System.Windows.Forms.RadioButton();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.pCursoExterno.SuspendLayout();
            this.pCursoUniversitario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "◆ Id del Curso: ";
            // 
            // pCursoExterno
            // 
            this.pCursoExterno.Controls.Add(this.label6);
            this.pCursoExterno.Controls.Add(this.cbInstituto);
            this.pCursoExterno.Location = new System.Drawing.Point(32, 94);
            this.pCursoExterno.Name = "pCursoExterno";
            this.pCursoExterno.Size = new System.Drawing.Size(239, 113);
            this.pCursoExterno.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "◆ Instituto";
            // 
            // cbInstituto
            // 
            this.cbInstituto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstituto.FormattingEnabled = true;
            this.cbInstituto.Location = new System.Drawing.Point(33, 31);
            this.cbInstituto.Name = "cbInstituto";
            this.cbInstituto.Size = new System.Drawing.Size(176, 21);
            this.cbInstituto.TabIndex = 4;
            // 
            // pCursoUniversitario
            // 
            this.pCursoUniversitario.Controls.Add(this.tHorarioCurso);
            this.pCursoUniversitario.Controls.Add(this.label5);
            this.pCursoUniversitario.Controls.Add(this.tAulaCurso);
            this.pCursoUniversitario.Controls.Add(this.label3);
            this.pCursoUniversitario.Controls.Add(this.label4);
            this.pCursoUniversitario.Controls.Add(this.cbProfesorCurso);
            this.pCursoUniversitario.Location = new System.Drawing.Point(32, 94);
            this.pCursoUniversitario.Name = "pCursoUniversitario";
            this.pCursoUniversitario.Size = new System.Drawing.Size(442, 100);
            this.pCursoUniversitario.TabIndex = 2;
            // 
            // tHorarioCurso
            // 
            this.tHorarioCurso.Location = new System.Drawing.Point(79, 21);
            this.tHorarioCurso.Name = "tHorarioCurso";
            this.tHorarioCurso.Size = new System.Drawing.Size(100, 20);
            this.tHorarioCurso.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "◆ Elegir Profesor";
            // 
            // tAulaCurso
            // 
            this.tAulaCurso.Location = new System.Drawing.Point(79, 54);
            this.tAulaCurso.Name = "tAulaCurso";
            this.tAulaCurso.Size = new System.Drawing.Size(100, 20);
            this.tAulaCurso.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "◆ Horario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "◆ Aula: ";
            // 
            // cbProfesorCurso
            // 
            this.cbProfesorCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfesorCurso.FormattingEnabled = true;
            this.cbProfesorCurso.Location = new System.Drawing.Point(215, 40);
            this.cbProfesorCurso.Name = "cbProfesorCurso";
            this.cbProfesorCurso.Size = new System.Drawing.Size(215, 21);
            this.cbProfesorCurso.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "◆ Nombre: ";
            // 
            // mtIdCurso
            // 
            this.mtIdCurso.Location = new System.Drawing.Point(105, 36);
            this.mtIdCurso.Mask = "99999";
            this.mtIdCurso.Name = "mtIdCurso";
            this.mtIdCurso.Size = new System.Drawing.Size(100, 20);
            this.mtIdCurso.TabIndex = 6;
            this.mtIdCurso.ValidatingType = typeof(int);
            // 
            // tNombreCurso
            // 
            this.tNombreCurso.Location = new System.Drawing.Point(105, 68);
            this.tNombreCurso.Name = "tNombreCurso";
            this.tNombreCurso.Size = new System.Drawing.Size(100, 20);
            this.tNombreCurso.TabIndex = 7;
            // 
            // rbUniversitario
            // 
            this.rbUniversitario.AutoSize = true;
            this.rbUniversitario.Location = new System.Drawing.Point(238, 37);
            this.rbUniversitario.Name = "rbUniversitario";
            this.rbUniversitario.Size = new System.Drawing.Size(113, 17);
            this.rbUniversitario.TabIndex = 8;
            this.rbUniversitario.TabStop = true;
            this.rbUniversitario.Text = "Curso Universitario";
            this.rbUniversitario.UseVisualStyleBackColor = true;
            this.rbUniversitario.CheckedChanged += new System.EventHandler(this.rbUniversitario_CheckedChanged);
            // 
            // rbExterno
            // 
            this.rbExterno.AutoSize = true;
            this.rbExterno.Location = new System.Drawing.Point(238, 66);
            this.rbExterno.Name = "rbExterno";
            this.rbExterno.Size = new System.Drawing.Size(91, 17);
            this.rbExterno.TabIndex = 9;
            this.rbExterno.TabStop = true;
            this.rbExterno.Text = "Curso Externo";
            this.rbExterno.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(276, 216);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 10;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(367, 216);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 11;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // DarAltaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 251);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.pCursoUniversitario);
            this.Controls.Add(this.rbExterno);
            this.Controls.Add(this.rbUniversitario);
            this.Controls.Add(this.tNombreCurso);
            this.Controls.Add(this.pCursoExterno);
            this.Controls.Add(this.mtIdCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DarAltaCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar alta Curso";
            this.Load += new System.EventHandler(this.DarAltaCurso_Load);
            this.pCursoExterno.ResumeLayout(false);
            this.pCursoExterno.PerformLayout();
            this.pCursoUniversitario.ResumeLayout(false);
            this.pCursoUniversitario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pCursoExterno;
        private System.Windows.Forms.Panel pCursoUniversitario;
        private System.Windows.Forms.ComboBox cbProfesorCurso;
        private System.Windows.Forms.ComboBox cbInstituto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtIdCurso;
        private System.Windows.Forms.TextBox tNombreCurso;
        private System.Windows.Forms.RadioButton rbUniversitario;
        private System.Windows.Forms.RadioButton rbExterno;
        private System.Windows.Forms.TextBox tAulaCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tHorarioCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
    }
}