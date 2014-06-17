namespace ExamenRefactorizacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAlmacenarCalificacion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMateria = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreAlumno = new System.Windows.Forms.TextBox();
            this.textBoxResultados = new System.Windows.Forms.TextBox();
            this.buttonMostrarResultados = new System.Windows.Forms.Button();
            this.buttonLimpiarDatos = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAlmacenarCalificacion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxNota);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxMateria);
            this.groupBox2.Location = new System.Drawing.Point(496, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 187);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calificaciones";
            // 
            // buttonAlmacenarCalificacion
            // 
            this.buttonAlmacenarCalificacion.Location = new System.Drawing.Point(133, 123);
            this.buttonAlmacenarCalificacion.Name = "buttonAlmacenarCalificacion";
            this.buttonAlmacenarCalificacion.Size = new System.Drawing.Size(102, 55);
            this.buttonAlmacenarCalificacion.TabIndex = 6;
            this.buttonAlmacenarCalificacion.Text = "Almacenar \r\nCalificación";
            this.buttonAlmacenarCalificacion.UseVisualStyleBackColor = true;
            this.buttonAlmacenarCalificacion.Click += new System.EventHandler(this.buttonAlmacenarCalificacion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nota:";
            this.label4.UseMnemonic = false;
            // 
            // textBoxNota
            // 
            this.textBoxNota.Location = new System.Drawing.Point(76, 78);
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.Size = new System.Drawing.Size(231, 20);
            this.textBoxNota.TabIndex = 4;
            this.textBoxNota.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Materia:";
            // 
            // textBoxMateria
            // 
            this.textBoxMateria.Location = new System.Drawing.Point(76, 40);
            this.textBoxMateria.Name = "textBoxMateria";
            this.textBoxMateria.Size = new System.Drawing.Size(231, 20);
            this.textBoxMateria.TabIndex = 2;
            this.textBoxMateria.Text = "Programación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxApellido2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxApellido1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNombreAlumno);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido2:";
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Location = new System.Drawing.Point(99, 127);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(292, 20);
            this.textBoxApellido2.TabIndex = 6;
            this.textBoxApellido2.Text = "Álvarez";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido1:";
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Location = new System.Drawing.Point(99, 82);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(292, 20);
            this.textBoxApellido1.TabIndex = 4;
            this.textBoxApellido1.Text = "Martín";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // textBoxNombreAlumno
            // 
            this.textBoxNombreAlumno.Location = new System.Drawing.Point(99, 44);
            this.textBoxNombreAlumno.Name = "textBoxNombreAlumno";
            this.textBoxNombreAlumno.Size = new System.Drawing.Size(292, 20);
            this.textBoxNombreAlumno.TabIndex = 2;
            this.textBoxNombreAlumno.Text = "Francisco";
            // 
            // textBoxResultados
            // 
            this.textBoxResultados.Enabled = false;
            this.textBoxResultados.Location = new System.Drawing.Point(35, 269);
            this.textBoxResultados.Multiline = true;
            this.textBoxResultados.Name = "textBoxResultados";
            this.textBoxResultados.Size = new System.Drawing.Size(798, 136);
            this.textBoxResultados.TabIndex = 7;
            // 
            // buttonMostrarResultados
            // 
            this.buttonMostrarResultados.Location = new System.Drawing.Point(496, 235);
            this.buttonMostrarResultados.Name = "buttonMostrarResultados";
            this.buttonMostrarResultados.Size = new System.Drawing.Size(159, 28);
            this.buttonMostrarResultados.TabIndex = 9;
            this.buttonMostrarResultados.Text = "Mostrar Resultados";
            this.buttonMostrarResultados.UseVisualStyleBackColor = true;
            this.buttonMostrarResultados.Click += new System.EventHandler(this.buttonMostrarResultados_Click);
            // 
            // buttonLimpiarDatos
            // 
            this.buttonLimpiarDatos.Location = new System.Drawing.Point(300, 235);
            this.buttonLimpiarDatos.Name = "buttonLimpiarDatos";
            this.buttonLimpiarDatos.Size = new System.Drawing.Size(159, 28);
            this.buttonLimpiarDatos.TabIndex = 10;
            this.buttonLimpiarDatos.Text = "Limpiar Datos";
            this.buttonLimpiarDatos.UseVisualStyleBackColor = true;
            this.buttonLimpiarDatos.Click += new System.EventHandler(this.buttonLimpiarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 430);
            this.Controls.Add(this.buttonLimpiarDatos);
            this.Controls.Add(this.buttonMostrarResultados);
            this.Controls.Add(this.textBoxResultados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAlmacenarCalificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreAlumno;
        private System.Windows.Forms.TextBox textBoxResultados;
        private System.Windows.Forms.Button buttonMostrarResultados;
        private System.Windows.Forms.Button buttonLimpiarDatos;



    }
}

