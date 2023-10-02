namespace ProyectoFinalBaseGestion
{
    partial class frmDgProductoVendido
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
            dgProductosVendidos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            IdVenta = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            cmdCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).BeginInit();
            SuspendLayout();
            // 
            // dgProductosVendidos
            // 
            dgProductosVendidos.AllowUserToAddRows = false;
            dgProductosVendidos.AllowUserToDeleteRows = false;
            dgProductosVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductosVendidos.Columns.AddRange(new DataGridViewColumn[] { Id, Stock, IdProducto, IdVenta, Editar, Eliminar });
            dgProductosVendidos.Location = new Point(17, 62);
            dgProductosVendidos.Margin = new Padding(4, 3, 4, 3);
            dgProductosVendidos.Name = "dgProductosVendidos";
            dgProductosVendidos.ReadOnly = true;
            dgProductosVendidos.RowHeadersWidth = 51;
            dgProductosVendidos.RowTemplate.Height = 29;
            dgProductosVendidos.Size = new Size(860, 427);
            dgProductosVendidos.TabIndex = 1;
            dgProductosVendidos.CellContentClick += dgProductosVendidos_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 125;
            // 
            // IdProducto
            // 
            IdProducto.DataPropertyName = "IdProducto";
            IdProducto.HeaderText = "IdProducto";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Width = 125;
            // 
            // IdVenta
            // 
            IdVenta.DataPropertyName = "IdVenta";
            IdVenta.HeaderText = "IdVenta";
            IdVenta.MinimumWidth = 8;
            IdVenta.Name = "IdVenta";
            IdVenta.ReadOnly = true;
            IdVenta.Width = 150;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 150;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.Width = 150;
            // 
            // cmdCrear
            // 
            cmdCrear.Location = new Point(709, 12);
            cmdCrear.Name = "cmdCrear";
            cmdCrear.Size = new Size(139, 43);
            cmdCrear.TabIndex = 2;
            cmdCrear.Text = "Crear";
            cmdCrear.UseVisualStyleBackColor = true;
            cmdCrear.Click += cmdCrear_Click;
            // 
            // frmDgProductoVendido
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 505);
            Controls.Add(cmdCrear);
            Controls.Add(dgProductosVendidos);
            Name = "frmDgProductoVendido";
            Text = "Productos Vendidos";
            Load += frmDgProductoVendido_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgProductosVendidos;
        private Button cmdCrear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn IdVenta;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}