namespace Taller_Validacion
{
    partial class FrmPrestacionServicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestacionServicio));
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.lblCostoServicio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtCostoServicio = new System.Windows.Forms.TextBox();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cbxRango = new System.Windows.Forms.ComboBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Location = new System.Drawing.Point(28, 34);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(123, 15);
            this.lblNombrePaciente.TabIndex = 0;
            this.lblNombrePaciente.Text = "&Nombre del Paciente";
            this.lblNombrePaciente.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(28, 74);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(115, 15);
            this.lblTipoDocumento.TabIndex = 1;
            this.lblTipoDocumento.Text = "&Tipo de Documento";
            this.lblTipoDocumento.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(28, 117);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(35, 15);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "&Sexo";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(28, 163);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(136, 15);
            this.lblNumeroDocumento.TabIndex = 3;
            this.lblNumeroDocumento.Text = "Número de &Documento";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Location = new System.Drawing.Point(28, 202);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(44, 15);
            this.lblRango.TabIndex = 4;
            this.lblRango.Text = "&Rango";
            // 
            // lblCostoServicio
            // 
            this.lblCostoServicio.AutoSize = true;
            this.lblCostoServicio.Location = new System.Drawing.Point(28, 245);
            this.lblCostoServicio.Name = "lblCostoServicio";
            this.lblCostoServicio.Size = new System.Drawing.Size(104, 15);
            this.lblCostoServicio.TabIndex = 5;
            this.lblCostoServicio.Text = "&Costo del Servicio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(201, 34);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 21);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(201, 163);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(242, 21);
            this.txtNumeroDocumento.TabIndex = 7;
            // 
            // txtCostoServicio
            // 
            this.txtCostoServicio.Location = new System.Drawing.Point(201, 245);
            this.txtCostoServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCostoServicio.Name = "txtCostoServicio";
            this.txtCostoServicio.Size = new System.Drawing.Size(242, 21);
            this.txtCostoServicio.TabIndex = 8;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Location = new System.Drawing.Point(201, 66);
            this.cbxTipoDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(242, 23);
            this.cbxTipoDocumento.TabIndex = 9;
            // 
            // cbxRango
            // 
            this.cbxRango.FormattingEnabled = true;
            this.cbxRango.Location = new System.Drawing.Point(201, 202);
            this.cbxRango.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxRango.Name = "cbxRango";
            this.cbxRango.Size = new System.Drawing.Size(242, 23);
            this.cbxRango.TabIndex = 10;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(201, 113);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(81, 19);
            this.rbtnFemenino.TabIndex = 11;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "&Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(342, 113);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(82, 19);
            this.rbtnMasculino.TabIndex = 12;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "&Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(204, 298);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 26);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "R&egistrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(327, 298);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 26);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Ca&ncelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(89, 298);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 26);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "C&alcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmPrestacionServicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(476, 350);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.cbxRango);
            this.Controls.Add(this.cbxTipoDocumento);
            this.Controls.Add(this.txtCostoServicio);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCostoServicio);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblNombrePaciente);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrestacionServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Prestación de Servicios";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Label lblCostoServicio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtCostoServicio;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.ComboBox cbxRango;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalcular;
    }
}

