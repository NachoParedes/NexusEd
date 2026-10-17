namespace Views
{
    partial class ConsultaGeneral
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
            this.lbInformacion = new System.Windows.Forms.ListBox();
            this.rbFiltroAlumno = new System.Windows.Forms.RadioButton();
            this.rbFiltroProfesor = new System.Windows.Forms.RadioButton();
            this.rbFiltroCurso = new System.Windows.Forms.RadioButton();
            this.rbFiltroInstituto = new System.Windows.Forms.RadioButton();
            this.bSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lCantAlumnos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbInformacion
            // 
            this.lbInformacion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformacion.FormattingEnabled = true;
            this.lbInformacion.ItemHeight = 14;
            this.lbInformacion.Location = new System.Drawing.Point(32, 90);
            this.lbInformacion.Name = "lbInformacion";
            this.lbInformacion.Size = new System.Drawing.Size(666, 228);
            this.lbInformacion.TabIndex = 0;
            this.lbInformacion.SelectedIndexChanged += new System.EventHandler(this.lbInformacion_SelectedIndexChanged);
            // 
            // rbFiltroAlumno
            // 
            this.rbFiltroAlumno.AutoSize = true;
            this.rbFiltroAlumno.Checked = true;
            this.rbFiltroAlumno.Location = new System.Drawing.Point(51, 58);
            this.rbFiltroAlumno.Name = "rbFiltroAlumno";
            this.rbFiltroAlumno.Size = new System.Drawing.Size(60, 17);
            this.rbFiltroAlumno.TabIndex = 1;
            this.rbFiltroAlumno.TabStop = true;
            this.rbFiltroAlumno.Text = "Alumno";
            this.rbFiltroAlumno.UseVisualStyleBackColor = true;
            this.rbFiltroAlumno.CheckedChanged += new System.EventHandler(this.rbFiltroAlumno_CheckedChanged);
            // 
            // rbFiltroProfesor
            // 
            this.rbFiltroProfesor.AutoSize = true;
            this.rbFiltroProfesor.Location = new System.Drawing.Point(138, 58);
            this.rbFiltroProfesor.Name = "rbFiltroProfesor";
            this.rbFiltroProfesor.Size = new System.Drawing.Size(64, 17);
            this.rbFiltroProfesor.TabIndex = 2;
            this.rbFiltroProfesor.Text = "Profesor";
            this.rbFiltroProfesor.UseVisualStyleBackColor = true;
            this.rbFiltroProfesor.CheckedChanged += new System.EventHandler(this.rbFiltroProfesor_CheckedChanged);
            // 
            // rbFiltroCurso
            // 
            this.rbFiltroCurso.AutoSize = true;
            this.rbFiltroCurso.Location = new System.Drawing.Point(229, 58);
            this.rbFiltroCurso.Name = "rbFiltroCurso";
            this.rbFiltroCurso.Size = new System.Drawing.Size(52, 17);
            this.rbFiltroCurso.TabIndex = 3;
            this.rbFiltroCurso.Text = "Curso";
            this.rbFiltroCurso.UseVisualStyleBackColor = true;
            this.rbFiltroCurso.CheckedChanged += new System.EventHandler(this.rbFiltroCurso_CheckedChanged);
            // 
            // rbFiltroInstituto
            // 
            this.rbFiltroInstituto.AutoSize = true;
            this.rbFiltroInstituto.Location = new System.Drawing.Point(308, 58);
            this.rbFiltroInstituto.Name = "rbFiltroInstituto";
            this.rbFiltroInstituto.Size = new System.Drawing.Size(62, 17);
            this.rbFiltroInstituto.TabIndex = 4;
            this.rbFiltroInstituto.Text = "Instituto";
            this.rbFiltroInstituto.UseVisualStyleBackColor = true;
            this.rbFiltroInstituto.CheckedChanged += new System.EventHandler(this.rbFiltroInstituto_CheckedChanged);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(642, 346);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 5;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "◆ Listar por:";
            // 
            // lCantAlumnos
            // 
            this.lCantAlumnos.AutoSize = true;
            this.lCantAlumnos.Location = new System.Drawing.Point(32, 336);
            this.lCantAlumnos.Name = "lCantAlumnos";
            this.lCantAlumnos.Size = new System.Drawing.Size(25, 13);
            this.lCantAlumnos.TabIndex = 7;
            this.lCantAlumnos.Text = "Info";
            // 
            // ConsultaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 390);
            this.Controls.Add(this.lCantAlumnos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.rbFiltroInstituto);
            this.Controls.Add(this.rbFiltroCurso);
            this.Controls.Add(this.rbFiltroProfesor);
            this.Controls.Add(this.rbFiltroAlumno);
            this.Controls.Add(this.lbInformacion);
            this.Name = "ConsultaGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbInformacion;
        private System.Windows.Forms.RadioButton rbFiltroAlumno;
        private System.Windows.Forms.RadioButton rbFiltroProfesor;
        private System.Windows.Forms.RadioButton rbFiltroCurso;
        private System.Windows.Forms.RadioButton rbFiltroInstituto;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCantAlumnos;
    }
}