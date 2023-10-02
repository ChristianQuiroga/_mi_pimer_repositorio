namespace ProyectoFinalBaseGestion
{
    partial class frmAltaVenta
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
            btnGuardar = new Button();
            lblStock = new Label();
            lblPrecioVenta = new Label();
            lblPrecioCosto = new Label();
            txtId = new TextBox();
            txtComentarios = new TextBox();
            txtIdUsuario = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(35, 228);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 23);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(16, 18);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(25, 20);
            lblStock.TabIndex = 27;
            lblStock.Text = "Id:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(16, 147);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(85, 20);
            lblPrecioVenta.TabIndex = 26;
            lblPrecioVenta.Text = "Id Usuarios:";
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioCosto.Location = new Point(16, 85);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new Size(96, 20);
            lblPrecioCosto.TabIndex = 25;
            lblPrecioCosto.Text = "Comentarios:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(16, 41);
            txtId.Name = "txtId";
            txtId.Size = new Size(55, 23);
            txtId.TabIndex = 29;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(16, 108);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(178, 23);
            txtComentarios.TabIndex = 30;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(16, 170);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(55, 23);
            txtIdUsuario.TabIndex = 31;
            // 
            // frmAltaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 302);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(txtId);
            Controls.Add(btnGuardar);
            Controls.Add(lblStock);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblPrecioCosto);
            Name = "frmAltaVenta";
            Text = "Alta Venta";
            Load += frmAltaVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label lblStock;
        private Label lblPrecioVenta;
        private Label lblPrecioCosto;
        private TextBox txtId;
        private TextBox txtComentarios;
        private TextBox txtIdUsuario;
    }
}