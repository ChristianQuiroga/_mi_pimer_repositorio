namespace SistemaGestionUI
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
            btnGuardar.Location = new Point(72, 378);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 38);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(23, 30);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 31);
            lblStock.TabIndex = 27;
            lblStock.Text = "Id:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(23, 245);
            lblPrecioVenta.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(133, 31);
            lblPrecioVenta.TabIndex = 26;
            lblPrecioVenta.Text = "Id Usuarios:";
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioCosto.Location = new Point(23, 142);
            lblPrecioCosto.Margin = new Padding(4, 0, 4, 0);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new Size(148, 31);
            lblPrecioCosto.TabIndex = 25;
            lblPrecioCosto.Text = "Comentarios:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(23, 68);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(77, 31);
            txtId.TabIndex = 29;
            // 
            // txtComentarios
            // 
            txtComentarios.Location = new Point(23, 180);
            txtComentarios.Margin = new Padding(4, 5, 4, 5);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(253, 31);
            txtComentarios.TabIndex = 1;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(23, 283);
            txtIdUsuario.Margin = new Padding(4, 5, 4, 5);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(77, 31);
            txtIdUsuario.TabIndex = 2;
            // 
            // frmAltaVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(306, 503);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(txtId);
            Controls.Add(btnGuardar);
            Controls.Add(lblStock);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblPrecioCosto);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
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