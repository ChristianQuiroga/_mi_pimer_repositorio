namespace ProyectoFinalBaseGestion
{
    partial class frmAltaProductoVendido
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
            numStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numStock.Location = new Point(83, 38);
            numStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(112, 29);
            numStock.TabIndex = 24;
            // 
            // numIdVenta
            // 
            numIdVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numIdVenta.Location = new Point(83, 167);
            numIdVenta.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numIdVenta.Name = "numIdVenta";
            numIdVenta.Size = new Size(112, 29);
            numIdVenta.TabIndex = 23;
            // 
            // numIdProducto
            // 
            numIdProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numIdProducto.Location = new Point(83, 106);
            numIdProducto.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(112, 29);
            numIdProducto.TabIndex = 22;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(73, 223);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(139, 23);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(83, 17);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(48, 20);
            lblStock.TabIndex = 18;
            lblStock.Text = "Stock:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(83, 146);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(66, 20);
            lblPrecioVenta.TabIndex = 17;
            lblPrecioVenta.Text = "Id Venta:";
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioCosto.Location = new Point(83, 84);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new Size(89, 20);
            lblPrecioCosto.TabIndex = 16;
            lblPrecioCosto.Text = "Id Producto:";
            // 
            // frmAltaProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 278);
            Controls.Add(numStock);
            Controls.Add(numIdVenta);
            Controls.Add(numIdProducto);
            Controls.Add(btnGuardar);
            Controls.Add(lblStock);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblPrecioCosto);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmAltaProductoVendido";
            Text = "Alta de Producto Vendido";
            Load += frmAltaProductoVendido_Load;
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