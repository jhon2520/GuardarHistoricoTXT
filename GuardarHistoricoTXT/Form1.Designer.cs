
namespace GuardarHistoricoTXT
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxEdad = new System.Windows.Forms.TextBox();
            this.tbxCarrera = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCrearTXT = new System.Windows.Forms.Button();
            this.btnTraerDatos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tbxFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carrera";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(121, 103);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(192, 20);
            this.tbxNombre.TabIndex = 4;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(121, 151);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(192, 20);
            this.tbxTelefono.TabIndex = 5;
            // 
            // tbxEdad
            // 
            this.tbxEdad.Location = new System.Drawing.Point(121, 199);
            this.tbxEdad.Name = "tbxEdad";
            this.tbxEdad.Size = new System.Drawing.Size(192, 20);
            this.tbxEdad.TabIndex = 6;
            // 
            // tbxCarrera
            // 
            this.tbxCarrera.Location = new System.Drawing.Point(121, 247);
            this.tbxCarrera.Name = "tbxCarrera";
            this.tbxCarrera.Size = new System.Drawing.Size(192, 20);
            this.tbxCarrera.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(401, 167);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar Histórico";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(121, 26);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // btnCrearTXT
            // 
            this.btnCrearTXT.Location = new System.Drawing.Point(401, 105);
            this.btnCrearTXT.Name = "btnCrearTXT";
            this.btnCrearTXT.Size = new System.Drawing.Size(174, 23);
            this.btnCrearTXT.TabIndex = 10;
            this.btnCrearTXT.Text = "Crear TXT";
            this.btnCrearTXT.UseVisualStyleBackColor = true;
            this.btnCrearTXT.Click += new System.EventHandler(this.btnCrearTXT_Click);
            // 
            // btnTraerDatos
            // 
            this.btnTraerDatos.Location = new System.Drawing.Point(401, 229);
            this.btnTraerDatos.Name = "btnTraerDatos";
            this.btnTraerDatos.Size = new System.Drawing.Size(174, 23);
            this.btnTraerDatos.TabIndex = 11;
            this.btnTraerDatos.Text = "Traer Datos";
            this.btnTraerDatos.UseVisualStyleBackColor = true;
            this.btnTraerDatos.Click += new System.EventHandler(this.btnTraerDatos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(401, 291);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(174, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tbxFecha
            // 
            this.tbxFecha.Location = new System.Drawing.Point(121, 295);
            this.tbxFecha.Name = "tbxFecha";
            this.tbxFecha.Size = new System.Drawing.Size(192, 20);
            this.tbxFecha.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 532);
            this.Controls.Add(this.tbxFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnTraerDatos);
            this.Controls.Add(this.btnCrearTXT);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbxCarrera);
            this.Controls.Add(this.tbxEdad);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.TextBox tbxEdad;
        private System.Windows.Forms.TextBox tbxCarrera;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCrearTXT;
        private System.Windows.Forms.Button btnTraerDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox tbxFecha;
        private System.Windows.Forms.Label label5;
    }
}

