
namespace PPAI.UI
{
    partial class PantallaRegistrarRespuesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistrarRespuesta));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblSubopcion = new System.Windows.Forms.Label();
            this.dgvValidaciones = new System.Windows.Forms.DataGridView();
            this.txtRespuestaOperador = new System.Windows.Forms.TextBox();
            this.lblDescripcionOperador = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.cboAcciones = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.txtSubOpcion = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Validaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuestas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(264, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Llamada En Curso..";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.lblCliente.Location = new System.Drawing.Point(41, 100);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(64, 18);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.lblCategoria.Location = new System.Drawing.Point(25, 146);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 18);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.lblOpcion.Location = new System.Drawing.Point(311, 102);
            this.lblOpcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(56, 18);
            this.lblOpcion.TabIndex = 3;
            this.lblOpcion.Text = "Opcion";
            // 
            // lblSubopcion
            // 
            this.lblSubopcion.AutoSize = true;
            this.lblSubopcion.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.lblSubopcion.Location = new System.Drawing.Point(296, 144);
            this.lblSubopcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubopcion.Name = "lblSubopcion";
            this.lblSubopcion.Size = new System.Drawing.Size(80, 18);
            this.lblSubopcion.TabIndex = 4;
            this.lblSubopcion.Text = "SubOpcion";
            // 
            // dgvValidaciones
            // 
            this.dgvValidaciones.AllowUserToAddRows = false;
            this.dgvValidaciones.AllowUserToDeleteRows = false;
            this.dgvValidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValidaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Validaciones,
            this.Respuestas});
            this.dgvValidaciones.Location = new System.Drawing.Point(73, 215);
            this.dgvValidaciones.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgvValidaciones.Name = "dgvValidaciones";
            this.dgvValidaciones.Size = new System.Drawing.Size(723, 152);
            this.dgvValidaciones.TabIndex = 4;
            // 
            // txtRespuestaOperador
            // 
            this.txtRespuestaOperador.Enabled = false;
            this.txtRespuestaOperador.Location = new System.Drawing.Point(44, 454);
            this.txtRespuestaOperador.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtRespuestaOperador.Multiline = true;
            this.txtRespuestaOperador.Name = "txtRespuestaOperador";
            this.txtRespuestaOperador.Size = new System.Drawing.Size(785, 73);
            this.txtRespuestaOperador.TabIndex = 6;
            // 
            // lblDescripcionOperador
            // 
            this.lblDescripcionOperador.AutoSize = true;
            this.lblDescripcionOperador.Font = new System.Drawing.Font("Consolas", 18F);
            this.lblDescripcionOperador.Location = new System.Drawing.Point(39, 423);
            this.lblDescripcionOperador.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescripcionOperador.Name = "lblDescripcionOperador";
            this.lblDescripcionOperador.Size = new System.Drawing.Size(298, 28);
            this.lblDescripcionOperador.TabIndex = 8;
            this.lblDescripcionOperador.Text = "Respuesta del Operador";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(45, 553);
            this.lblAccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(56, 18);
            this.lblAccion.TabIndex = 9;
            this.lblAccion.Text = "Accion";
            // 
            // cboAcciones
            // 
            this.cboAcciones.FormattingEnabled = true;
            this.cboAcciones.Location = new System.Drawing.Point(115, 548);
            this.cboAcciones.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cboAcciones.Name = "cboAcciones";
            this.cboAcciones.Size = new System.Drawing.Size(236, 25);
            this.cboAcciones.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(684, 584);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 31);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(475, 584);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(145, 31);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(115, 97);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(166, 24);
            this.txtCliente.TabIndex = 0;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(115, 140);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(166, 24);
            this.txtCategoria.TabIndex = 2;
            // 
            // txtOpcion
            // 
            this.txtOpcion.Enabled = false;
            this.txtOpcion.Location = new System.Drawing.Point(385, 98);
            this.txtOpcion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(220, 24);
            this.txtOpcion.TabIndex = 1;
            // 
            // txtSubOpcion
            // 
            this.txtSubOpcion.Enabled = false;
            this.txtSubOpcion.Location = new System.Drawing.Point(385, 140);
            this.txtSubOpcion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtSubOpcion.Name = "txtSubOpcion";
            this.txtSubOpcion.Size = new System.Drawing.Size(221, 24);
            this.txtSubOpcion.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(503, 396);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(326, 31);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar Respuestas";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(667, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Validaciones
            // 
            this.Validaciones.FillWeight = 300F;
            this.Validaciones.HeaderText = "Validaciones";
            this.Validaciones.Name = "Validaciones";
            this.Validaciones.ReadOnly = true;
            this.Validaciones.Width = 200;
            // 
            // Respuestas
            // 
            this.Respuestas.FillWeight = 150F;
            this.Respuestas.HeaderText = "Respuestas";
            this.Respuestas.Name = "Respuestas";
            this.Respuestas.Width = 399;
            // 
            // PantallaRegistrarRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 633);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtSubOpcion);
            this.Controls.Add(this.txtOpcion);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboAcciones);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblDescripcionOperador);
            this.Controls.Add(this.txtRespuestaOperador);
            this.Controls.Add(this.dgvValidaciones);
            this.Controls.Add(this.lblSubopcion);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "PantallaRegistrarRespuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaRegistrarRespuesta";
            this.Load += new System.EventHandler(this.PantallaRegistrarRespuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblSubopcion;
        private System.Windows.Forms.DataGridView dgvValidaciones;
        private System.Windows.Forms.TextBox txtRespuestaOperador;
        private System.Windows.Forms.Label lblDescripcionOperador;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.ComboBox cboAcciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.TextBox txtSubOpcion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respuestas;
    }
}