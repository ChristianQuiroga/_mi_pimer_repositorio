﻿namespace SistemaGestionUI
{
    partial class frmModificarProductoVendido
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
            numStock.Location = new Point(110, 64);
            numStock.Margin = new Padding(4, 5, 4, 5);
            numStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(160, 39);
            numStock.TabIndex = 1;
            // 
            // numIdVenta
            // 
            numIdVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numIdVenta.Location = new Point(110, 279);
            numIdVenta.Margin = new Padding(4, 5, 4, 5);
            numIdVenta.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numIdVenta.Name = "numIdVenta";
            numIdVenta.Size = new Size(160, 39);
            numIdVenta.TabIndex = 3;
            // 
            // numIdProducto
            // 
            numIdProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numIdProducto.Location = new Point(110, 178);
            numIdProducto.Margin = new Padding(4, 5, 4, 5);
            numIdProducto.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numIdProducto.Name = "numIdProducto";
            numIdProducto.Size = new Size(160, 39);
            numIdProducto.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(149, 375);
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
            lblStock.Location = new Point(110, 29);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(73, 31);
            lblStock.TabIndex = 27;
            lblStock.Text = "Stock:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(110, 244);
            lblPrecioVenta.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(103, 31);
            lblPrecioVenta.TabIndex = 26;
            lblPrecioVenta.Text = "Id Venta:";
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioCosto.Location = new Point(110, 141);
            lblPrecioCosto.Margin = new Padding(4, 0, 4, 0);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new Size(138, 31);
            lblPrecioCosto.TabIndex = 25;
            lblPrecioCosto.Text = "Id Producto:";
            // 
            // frmModificarProductoVendido
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(419, 450);
            Controls.Add(numStock);
            Controls.Add(numIdVenta);
            Controls.Add(numIdProducto);
            Controls.Add(btnGuardar);
            Controls.Add(lblStock);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblPrecioCosto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmModificarProductoVendido";
            Text = "Modificar Producto Vendido";
            Load += frmModificarProductoVendido_Load;
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