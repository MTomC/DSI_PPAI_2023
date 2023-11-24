
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
            this.Validaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuestas = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 17.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Llamada En Curso..";
            // 
            // lblCliente
            // 
            this.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.lblCliente.Location = new System.Drawing.Point(17, 65);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(64, 18);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.lblCategoria.Location = new System.Drawing.Point(279, 65);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 18);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblOpcion
            // 
            this.lblOpcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.lblOpcion.Location = new System.Drawing.Point(23, 107);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(56, 18);
            this.lblOpcion.TabIndex = 3;
            this.lblOpcion.Text = "Opcion";
            // 
            // lblSubopcion
            // 
            this.lblSubopcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubopcion.AutoSize = true;
            this.lblSubopcion.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.lblSubopcion.Location = new System.Drawing.Point(279, 107);
            this.lblSubopcion.Name = "lblSubopcion";
            this.lblSubopcion.Size = new System.Drawing.Size(80, 18);
            this.lblSubopcion.TabIndex = 4;
            this.lblSubopcion.Text = "SubOpcion";
            // 
            // dgvValidaciones
            // 
            this.dgvValidaciones.AllowUserToAddRows = false;
            this.dgvValidaciones.AllowUserToDeleteRows = false;
            this.dgvValidaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvValidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValidaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Validaciones,
            this.Respuestas});
            this.dgvValidaciones.Location = new System.Drawing.Point(17, 148);
            this.dgvValidaciones.Name = "dgvValidaciones";
            this.dgvValidaciones.Size = new System.Drawing.Size(645, 169);
            this.dgvValidaciones.TabIndex = 16;
            // 
            // Validaciones
            // 
            this.Validaciones.HeaderText = "Validaciones";
            this.Validaciones.Name = "Validaciones";
            this.Validaciones.ReadOnly = true;
            this.Validaciones.Width = 200;
            // 
            // Respuestas
            // 
            this.Respuestas.HeaderText = "Respuestas";
            this.Respuestas.Name = "Respuestas";
            this.Respuestas.Width = 399;
            // 
            // txtRespuestaOperador
            // 
            this.txtRespuestaOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRespuestaOperador.Enabled = false;
            this.txtRespuestaOperador.Location = new System.Drawing.Point(17, 374);
            this.txtRespuestaOperador.Multiline = true;
            this.txtRespuestaOperador.Name = "txtRespuestaOperador";
            this.txtRespuestaOperador.Size = new System.Drawing.Size(645, 83);
            this.txtRespuestaOperador.TabIndex = 18;
            // 
            // lblDescripcionOperador
            // 
            this.lblDescripcionOperador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcionOperador.AutoSize = true;
            this.lblDescripcionOperador.Font = new System.Drawing.Font("Consolas", 15.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionOperador.Location = new System.Drawing.Point(16, 347);
            this.lblDescripcionOperador.Name = "lblDescripcionOperador";
            this.lblDescripcionOperador.Size = new System.Drawing.Size(274, 24);
            this.lblDescripcionOperador.TabIndex = 8;
            this.lblDescripcionOperador.Text = "Respuesta del Operador";
            // 
            // lblAccion
            // 
            this.lblAccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.lblAccion.Location = new System.Drawing.Point(15, 486);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(56, 18);
            this.lblAccion.TabIndex = 9;
            this.lblAccion.Text = "Accion";
            // 
            // cboAcciones
            // 
            this.cboAcciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAcciones.FormattingEnabled = true;
            this.cboAcciones.Location = new System.Drawing.Point(87, 483);
            this.cboAcciones.Name = "cboAcciones";
            this.cboAcciones.Size = new System.Drawing.Size(178, 21);
            this.cboAcciones.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.btnCancelar.Location = new System.Drawing.Point(553, 512);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.btnOk.Location = new System.Drawing.Point(396, 512);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(109, 23);
            this.btnOk.TabIndex = 20;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(87, 63);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(151, 20);
            this.txtCliente.TabIndex = 13;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(368, 62);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(155, 20);
            this.txtCategoria.TabIndex = 14;
            // 
            // txtOpcion
            // 
            this.txtOpcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOpcion.Enabled = false;
            this.txtOpcion.Location = new System.Drawing.Point(87, 105);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(151, 20);
            this.txtOpcion.TabIndex = 15;
            // 
            // txtSubOpcion
            // 
            this.txtSubOpcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSubOpcion.Enabled = false;
            this.txtSubOpcion.Location = new System.Drawing.Point(368, 105);
            this.txtSubOpcion.Name = "txtSubOpcion";
            this.txtSubOpcion.Size = new System.Drawing.Size(155, 20);
            this.txtSubOpcion.TabIndex = 16;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmar.Font = new System.Drawing.Font("Consolas", 10.75F);
            this.btnConfirmar.Location = new System.Drawing.Point(396, 323);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(266, 23);
            this.btnConfirmar.TabIndex = 17;
            this.btnConfirmar.Text = "Confirmar Respuestas";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(544, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaRegistrarRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 547);
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
            this.MinimizeBox = false;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Validaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respuestas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}