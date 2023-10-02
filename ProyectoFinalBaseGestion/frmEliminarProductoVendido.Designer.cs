namespace ProyectoFinalBaseGestion
{
    partial class frmEliminarProductoVendido
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
            numIdVenta = new NumericUpDown();
            numIdProducto = new NumericUpDown();
            btnGuardar = new Button();
            lblStock = new Label();
            lblPrecioVenta = new Label();
            lblPrecioCosto = new Label();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).BeginInit();
            SuspendLayout();
            // 
            // numStock
            // 
            numStock.Enabled = false;
            numStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numStock.Location = new Point(98, 62);
            numStock.Margin = new Padding(4, 5, 4, 5);
            numStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(160, 39);
            numStock.TabIndex = 38;
            // 
            // numIdVenta
            // 
            numIdVenta.Enabled = false;
            numIdVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numIdVenta.Location = new Point(98, 277);
            numIdVenta.Margin = new Padding(4, 5, 4, 5);
            numIdVenta.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numIdVenta.Name = "numIdVenta";
            numIdVenta.Size = new Size(160, 39);
            numIdVenta.TabIndex = 37;
            // 
            // numIdProducto
            // 
            numIdProducto.Enabled = false;
            numIdProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numIdProducto.Location = new Point(98, 176);
            numIdProducto.Margin = new Padding(4, 5, 4, 5);
            numIdProducto.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(160, 39);
            numIdProducto.TabIndex = 36;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(83, 371);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(199, 38);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "Eliminar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(98, 27);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(73, 31);
            lblStock.TabIndex = 34;
            lblStock.Text = "Stock:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(98, 242);
            lblPrecioVenta.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(103, 31);
            lblPrecioVenta.TabIndex = 33;
            lblPrecioVenta.Text = "Id Venta:";
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioCosto.Location = new Point(98, 139);
            lblPrecioCosto.Margin = new Padding(4, 0, 4, 0);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new Size(138, 31);
            lblPrecioCosto.TabIndex = 32;
            lblPrecioCosto.Text = "Id Producto:";
            // 
            // frmEliminarProductoVendido
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 450);
            Controls.Add(numStock);
            Controls.Add(numIdVenta);
            Controls.Add(numIdProducto);
            Controls.Add(btnGuardar);
            Controls.Add(lblStock);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblPrecioCosto);
            Name = "frmEliminarProductoVendido";
            Text = "Eliminar Producto Vendido";
            Load += frmEliminarProductoVendido_Load;
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numStock;
        private NumericUpDown numIdVenta;
        private NumericUpDown numIdProducto;
        private Button btnGuardar;
        private Label lblStock;
        private Label lblPrecioVenta;
        private Label lblPrecioCosto;
    }
}