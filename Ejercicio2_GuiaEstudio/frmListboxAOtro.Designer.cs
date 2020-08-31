namespace Ejercicio2_GuiaEstudio
{
    partial class frmListboxAOtro
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
            this.lstMeses1 = new System.Windows.Forms.ListBox();
            this.lstMeses2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPasar1List1 = new System.Windows.Forms.Button();
            this.btnPasarTodosList1 = new System.Windows.Forms.Button();
            this.btnPasar1list2 = new System.Windows.Forms.Button();
            this.btnPasarTodosList2 = new System.Windows.Forms.Button();
            this.lblCont1 = new System.Windows.Forms.Label();
            this.lblCont2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblLista1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMeses1
            // 
            this.lstMeses1.FormattingEnabled = true;
            this.lstMeses1.Location = new System.Drawing.Point(158, 106);
            this.lstMeses1.Name = "lstMeses1";
            this.lstMeses1.Size = new System.Drawing.Size(152, 199);
            this.lstMeses1.TabIndex = 9;
            this.lstMeses1.SelectedIndexChanged += new System.EventHandler(this.lstMeses1_SelectedIndexChanged);
            // 
            // lstMeses2
            // 
            this.lstMeses2.FormattingEnabled = true;
            this.lstMeses2.Location = new System.Drawing.Point(491, 106);
            this.lstMeses2.Name = "lstMeses2";
            this.lstMeses2.Size = new System.Drawing.Size(152, 199);
            this.lstMeses2.TabIndex = 10;
            this.lstMeses2.SelectedIndexChanged += new System.EventHandler(this.lstMeses2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meses:";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(140, 38);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(170, 20);
            this.txtMeses.TabIndex = 0;
            this.txtMeses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMeses_KeyDown);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(363, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total:";
            // 
            // btnPasar1List1
            // 
            this.btnPasar1List1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasar1List1.Location = new System.Drawing.Point(363, 208);
            this.btnPasar1List1.Name = "btnPasar1List1";
            this.btnPasar1List1.Size = new System.Drawing.Size(75, 38);
            this.btnPasar1List1.TabIndex = 4;
            this.btnPasar1List1.Text = "<";
            this.btnPasar1List1.UseVisualStyleBackColor = true;
            this.btnPasar1List1.Click += new System.EventHandler(this.btnPasar1List1_Click);
            // 
            // btnPasarTodosList1
            // 
            this.btnPasarTodosList1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodosList1.Location = new System.Drawing.Point(363, 252);
            this.btnPasarTodosList1.Name = "btnPasarTodosList1";
            this.btnPasarTodosList1.Size = new System.Drawing.Size(75, 38);
            this.btnPasarTodosList1.TabIndex = 5;
            this.btnPasarTodosList1.Text = "<<";
            this.btnPasarTodosList1.UseVisualStyleBackColor = true;
            this.btnPasarTodosList1.Click += new System.EventHandler(this.btnPasarTodosList1_Click);
            // 
            // btnPasar1list2
            // 
            this.btnPasar1list2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasar1list2.Location = new System.Drawing.Point(363, 164);
            this.btnPasar1list2.Name = "btnPasar1list2";
            this.btnPasar1list2.Size = new System.Drawing.Size(75, 38);
            this.btnPasar1list2.TabIndex = 3;
            this.btnPasar1list2.Text = ">";
            this.btnPasar1list2.UseVisualStyleBackColor = true;
            this.btnPasar1list2.Click += new System.EventHandler(this.btnPasar1list2_Click);
            // 
            // btnPasarTodosList2
            // 
            this.btnPasarTodosList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodosList2.Location = new System.Drawing.Point(363, 120);
            this.btnPasarTodosList2.Name = "btnPasarTodosList2";
            this.btnPasarTodosList2.Size = new System.Drawing.Size(75, 38);
            this.btnPasarTodosList2.TabIndex = 2;
            this.btnPasarTodosList2.Text = ">>";
            this.btnPasarTodosList2.UseVisualStyleBackColor = true;
            this.btnPasarTodosList2.Click += new System.EventHandler(this.btnPasarTodosList2_Click);
            // 
            // lblCont1
            // 
            this.lblCont1.AutoSize = true;
            this.lblCont1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont1.Location = new System.Drawing.Point(212, 314);
            this.lblCont1.Name = "lblCont1";
            this.lblCont1.Size = new System.Drawing.Size(30, 31);
            this.lblCont1.TabIndex = 14;
            this.lblCont1.Text = "0";
            // 
            // lblCont2
            // 
            this.lblCont2.AutoSize = true;
            this.lblCont2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont2.Location = new System.Drawing.Point(557, 314);
            this.lblCont2.Name = "lblCont2";
            this.lblCont2.Size = new System.Drawing.Size(30, 31);
            this.lblCont2.TabIndex = 15;
            this.lblCont2.Text = "0";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(540, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 39);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(567, 35);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblLista1
            // 
            this.lblLista1.AutoSize = true;
            this.lblLista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista1.Location = new System.Drawing.Point(153, 78);
            this.lblLista1.Name = "lblLista1";
            this.lblLista1.Size = new System.Drawing.Size(83, 25);
            this.lblLista1.TabIndex = 18;
            this.lblLista1.Text = "Lista 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Lista 2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(455, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Quitar Mes";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmListboxAOtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLista1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCont2);
            this.Controls.Add(this.lblCont1);
            this.Controls.Add(this.btnPasarTodosList2);
            this.Controls.Add(this.btnPasar1list2);
            this.Controls.Add(this.btnPasarTodosList1);
            this.Controls.Add(this.btnPasar1List1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMeses2);
            this.Controls.Add(this.lstMeses1);
            this.Name = "frmListboxAOtro";
            this.Text = "Pasar de un Listbox a otro Listbox";
            this.Load += new System.EventHandler(this.frmListboxAOtro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeses1;
        private System.Windows.Forms.ListBox lstMeses2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPasar1List1;
        private System.Windows.Forms.Button btnPasarTodosList1;
        private System.Windows.Forms.Button btnPasar1list2;
        private System.Windows.Forms.Button btnPasarTodosList2;
        private System.Windows.Forms.Label lblCont1;
        private System.Windows.Forms.Label lblCont2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblLista1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

