namespace SistemaGestionUI
{
    partial class frmDgProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgProductos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripciones = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            btnCrear = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // dgProductos
            // 
            dgProductos.AllowUserToAddRows = false;
            dgProductos.AllowUserToDeleteRows = false;
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Columns.AddRange(new DataGridViewColumn[] { Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario, Editar, Eliminar });
            dgProductos.Location = new Point(13, 123);
            dgProductos.Margin = new Padding(4, 3, 4, 3);
            dgProductos.Name = "dgProductos";
            dgProductos.ReadOnly = true;
            dgProductos.RowHeadersWidth = 51;
            dgProductos.RowTemplate.Height = 29;
            dgProductos.Size = new Size(1158, 427);
            dgProductos.TabIndex = 0;
            dgProductos.CellContentClick += dgProductos_CellContentClick;
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
            // Descripciones
            // 
            Descripciones.DataPropertyName = "Descripciones";
            Descripciones.HeaderText = "DESCRIPCIONES";
            Descripciones.MinimumWidth = 6;
            Descripciones.Name = "Descripciones";
            Descripciones.ReadOnly = true;
            Descripciones.Width = 150;
            // 
            // Costo
            // 
            Costo.DataPropertyName = "Costo";
            Costo.HeaderText = "Precio COSTO";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            Costo.Width = 180;
            // 
            // PrecioVenta
            // 
            PrecioVenta.DataPropertyName = "PrecioVenta";
            PrecioVenta.HeaderText = "PRECIO VENTA";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 180;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "STOCK";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 125;
            // 
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.MinimumWidth = 6;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Width = 125;
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
            // btnCrear
            // 
            btnCrear.Location = new Point(980, 55);
            btnCrear.Margin = new Padding(4, 5, 4, 5);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(138, 38);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Broadway", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(320, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(471, 51);
            label1.TabIndex = 4;
            label1.Text = "Lista de Productos";
            // 
            // frmDgProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1184, 562);
            Controls.Add(label1);
            Controls.Add(btnCrear);
            Controls.Add(dgProductos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDgProductos";
            Text = "Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProductos;
        private Button btnCrear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripciones;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private Label label1;
    }
}