namespace SistemaGestionUI
{
    partial class frmAltaProducto
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
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecioCosto = new Label();
            lblPrecioVenta = new Label();
            lblStock = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            btnGuardar = new Button();
            numCosto = new NumericUpDown();
            numVenta = new NumericUpDown();
            numStock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(56, 91);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(139, 31);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(56, 127);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(355, 31);
            txtDescripcion.TabIndex = 1;
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioCosto.Location = new Point(56, 181);
            lblPrecioCosto.Margin = new Padding(4, 0, 4, 0);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new Size(178, 31);
            lblPrecioCosto.TabIndex = 3;
            lblPrecioCosto.Text = "Precio de Costo:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(56, 293);
            lblPrecioVenta.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(178, 31);
            lblPrecioVenta.TabIndex = 4;
            lblPrecioVenta.Text = "Precio de Venta:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(56, 390);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(73, 31);
            lblStock.TabIndex = 5;
            lblStock.Text = "Stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 499);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 31);
            label3.TabIndex = 6;
            label3.Text = "Id Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(56, 535);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(260, 31);
            txtUsuario.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(185, 619);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 38);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numCosto
            // 
            numCosto.DecimalPlaces = 2;
            numCosto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numCosto.Location = new Point(56, 217);
            numCosto.Margin = new Padding(4, 5, 4, 5);
            numCosto.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(171, 39);
            numCosto.TabIndex = 2;
            // 
            // numVenta
            // 
            numVenta.DecimalPlaces = 2;
            numVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numVenta.Location = new Point(56, 329);
            numVenta.Margin = new Padding(4, 5, 4, 5);
            numVenta.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numVenta.Name = "numVenta";
            numVenta.Size = new Size(171, 39);
            numVenta.TabIndex = 3;
            // 
            // numStock
            // 
            numStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numStock.Location = new Point(56, 426);
            numStock.Margin = new Padding(4, 5, 4, 5);
            numStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(171, 39);
            numStock.TabIndex = 4;
            // 
            // frmAltaProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(487, 750);
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
            Name = "frmAltaProducto";
            Text = "Crear Producto";
            Load += frmAltaProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblPrecioCosto;
        private Label lblPrecioVenta;
        private Label lblStock;
        private Label label3;
        private TextBox txtUsuario;
        private Button btnGuardar;
        private NumericUpDown numCosto;
        private NumericUpDown numVenta;
        private NumericUpDown numStock;
    }
}