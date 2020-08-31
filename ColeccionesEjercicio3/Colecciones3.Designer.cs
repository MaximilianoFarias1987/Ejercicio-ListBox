namespace ColeccionesEjercicio3
{
    partial class Colecciones3
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
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.lstSueldos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstNuevoSueldo = new System.Windows.Forms.ListBox();
            this.btnAumento = new System.Windows.Forms.Button();
            this.lblCountEmpleados = new System.Windows.Forms.Label();
            this.lblCountNuevo = new System.Windows.Forms.Label();
            this.lblCountSueldos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(164, 35);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(174, 20);
            this.txtEmpleado.TabIndex = 0;
            this.txtEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpleado_KeyDown);
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.Location = new System.Drawing.Point(21, 123);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(173, 251);
            this.lstEmpleados.TabIndex = 2;
            // 
            // lstSueldos
            // 
            this.lstSueldos.FormattingEnabled = true;
            this.lstSueldos.Location = new System.Drawing.Point(243, 123);
            this.lstSueldos.Name = "lstSueldos";
            this.lstSueldos.Size = new System.Drawing.Size(162, 251);
            this.lstSueldos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese un empleado  nuevo:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(358, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 33);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(477, 28);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(102, 33);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(596, 28);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 33);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Empleados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(531, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nuevo Sueldo";
            this.label3.TextChanged += new System.EventHandler(this.label3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sueldos";
            // 
            // lstNuevoSueldo
            // 
            this.lstNuevoSueldo.FormattingEnabled = true;
            this.lstNuevoSueldo.Location = new System.Drawing.Point(536, 123);
            this.lstNuevoSueldo.Name = "lstNuevoSueldo";
            this.lstNuevoSueldo.Size = new System.Drawing.Size(162, 251);
            this.lstNuevoSueldo.TabIndex = 5;
            // 
            // btnAumento
            // 
            this.btnAumento.Location = new System.Drawing.Point(420, 123);
            this.btnAumento.Name = "btnAumento";
            this.btnAumento.Size = new System.Drawing.Size(102, 33);
            this.btnAumento.TabIndex = 4;
            this.btnAumento.Text = "Aumento";
            this.btnAumento.UseVisualStyleBackColor = true;
            this.btnAumento.Click += new System.EventHandler(this.btnAumento_Click);
            // 
            // lblCountEmpleados
            // 
            this.lblCountEmpleados.AutoSize = true;
            this.lblCountEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountEmpleados.Location = new System.Drawing.Point(169, 388);
            this.lblCountEmpleados.Name = "lblCountEmpleados";
            this.lblCountEmpleados.Size = new System.Drawing.Size(25, 25);
            this.lblCountEmpleados.TabIndex = 10;
            this.lblCountEmpleados.Text = "0";
            // 
            // lblCountNuevo
            // 
            this.lblCountNuevo.AutoSize = true;
            this.lblCountNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountNuevo.Location = new System.Drawing.Point(673, 388);
            this.lblCountNuevo.Name = "lblCountNuevo";
            this.lblCountNuevo.Size = new System.Drawing.Size(25, 25);
            this.lblCountNuevo.TabIndex = 11;
            this.lblCountNuevo.Text = "0";
            // 
            // lblCountSueldos
            // 
            this.lblCountSueldos.AutoSize = true;
            this.lblCountSueldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSueldos.Location = new System.Drawing.Point(380, 388);
            this.lblCountSueldos.Name = "lblCountSueldos";
            this.lblCountSueldos.Size = new System.Drawing.Size(25, 25);
            this.lblCountSueldos.TabIndex = 12;
            this.lblCountSueldos.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Colecciones3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCountSueldos);
            this.Controls.Add(this.lblCountNuevo);
            this.Controls.Add(this.lblCountEmpleados);
            this.Controls.Add(this.btnAumento);
            this.Controls.Add(this.lstNuevoSueldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSueldos);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.txtEmpleado);
            this.Name = "Colecciones3";
            this.Text = "Colecciones";
            this.Load += new System.EventHandler(this.Colecciones3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.ListBox lstSueldos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstNuevoSueldo;
        private System.Windows.Forms.Button btnAumento;
        private System.Windows.Forms.Label lblCountEmpleados;
        private System.Windows.Forms.Label lblCountNuevo;
        private System.Windows.Forms.Label lblCountSueldos;
        private System.Windows.Forms.Button button1;
    }
}

