namespace SistemaGestionUI
{
    partial class FrmEliminarProducto
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
            numStock = new NumericUpDown();
            numVenta = new NumericUpDown();
            numCosto = new NumericUpDown();
            btnGuardar = new Button();
            txtUsuario = new TextBox();
            label3 = new Label();
            lblStock = new Label();
            lblPrecioVenta = new Label();
            lblPrecioCosto = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            SuspendLayout();
            // 
            // numStock
            // 
            numStock.DecimalPlaces = 2;
            numStock.Enabled = false;
            numStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numStock.Location = new Point(58, 384);
            numStock.Margin = new Padding(4, 5, 4, 5);
            numStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(171, 39);
            numStock.TabIndex = 4;
            // 
            // numVenta
            // 
            numVenta.DecimalPlaces = 2;
            numVenta.Enabled = false;
            numVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numVenta.Location = new Point(58, 287);
            numVenta.Margin = new Padding(4, 5, 4, 5);
            numVenta.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numVenta.Name = "numVenta";
            numVenta.Size = new Size(171, 39);
            numVenta.TabIndex = 3;
            // 
            // numCosto
            // 
            numCosto.DecimalPlaces = 2;
            numCosto.Enabled = false;
            numCosto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numCosto.Location = new Point(58, 176);
            numCosto.Margin = new Padding(4, 5, 4, 5);
            numCosto.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(171, 39);
            numCosto.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(109, 589);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(222, 38);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Confirmar Eliminación";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(58, 509);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(260, 31);
            txtUsuario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 473);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 31);
            label3.TabIndex = 19;
            label3.Text = "Id Usuario";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(58, 348);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(68, 31);
            lblStock.TabIndex = 18;
            lblStock.Text = "Stock";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(58, 251);
            lblPrecioVenta.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(173, 31);
            lblPrecioVenta.TabIndex = 17;
            lblPrecioVenta.Text = "Precio de Venta";
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioCosto.Location = new Point(58, 140);
            lblPrecioCosto.Margin = new Padding(4, 0, 4, 0);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new Size(173, 31);
            lblPrecioCosto.TabIndex = 16;
            lblPrecioCosto.Text = "Precio de Costo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(58, 71);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(355, 31);
            txtDescripcion.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(58, 35);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(134, 31);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "Descripción";
            // 
            // FrmEliminarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(440, 667);
            Controls.Add(numStock);
            Controls.Add(numVenta);
            Controls.Add(numCosto);
            Controls.Add(btnGuardar);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(lblStock);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblPrecioCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEliminarProducto";
            Text = "Eliminar Producto";
            Load += FrmEliminarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numStock;
        private NumericUpDown numVenta;
        private NumericUpDown numCosto;
        private Button btnGuardar;
        private TextBox txtUsuario;
        private Label label3;
        private Label lblStock;
        private Label lblPrecioVenta;
        private Label lblPrecioCosto;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
    }
}