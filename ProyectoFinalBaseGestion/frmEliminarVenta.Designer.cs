﻿namespace ProyectoFinalBaseGestion
{
    partial class frmEliminarVenta
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
            txtIdUsuario = new TextBox();
            txtComentarios = new TextBox();
            txtId = new TextBox();
            btnGuardar = new Button();
            lblStock = new Label();
            lblPrecioVenta = new Label();
            lblPrecioCosto = new Label();
            SuspendLayout();
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Enabled = false;
            txtIdUsuario.Location = new Point(21, 165);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(55, 23);
            txtIdUsuario.TabIndex = 38;
            // 
            // txtComentarios
            // 
            txtComentarios.Enabled = false;
            txtComentarios.Location = new Point(21, 103);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(178, 23);
            txtComentarios.TabIndex = 37;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(21, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(55, 23);
            txtId.TabIndex = 36;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(21, 216);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(167, 23);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "Confirmar Eliminación";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.Location = new Point(21, 13);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(25, 20);
            lblStock.TabIndex = 34;
            lblStock.Text = "Id:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioVenta.Location = new Point(21, 142);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(85, 20);
            lblPrecioVenta.TabIndex = 33;
            lblPrecioVenta.Text = "Id Usuarios:";
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioCosto.Location = new Point(21, 80);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new Size(96, 20);
            lblPrecioCosto.TabIndex = 32;
            lblPrecioCosto.Text = "Comentarios:";
            // 
            // frmEliminarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 280);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(txtId);
            Controls.Add(btnGuardar);
            Controls.Add(lblStock);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblPrecioCosto);
            Name = "frmEliminarVenta";
            Text = "Eliminar Venta";
            Load += frmEliminarVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdUsuario;
        private TextBox txtComentarios;
        private TextBox txtId;
        private Button btnGuardar;
        private Label lblStock;
        private Label lblPrecioVenta;
        private Label lblPrecioCosto;
    }
}