namespace AppClientesUserInterface
{
    partial class frmClientes
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
            dgClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NombreApellido = new DataGridViewTextBoxColumn();
            Domicilio = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            SuspendLayout();
            // 
            // dgClientes
            // 
            dgClientes.AllowUserToAddRows = false;
            dgClientes.AllowUserToDeleteRows = false;
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Columns.AddRange(new DataGridViewColumn[] { Id, NombreApellido, Domicilio, Telefono });
            dgClientes.Location = new Point(12, 47);
            dgClientes.Name = "dgClientes";
            dgClientes.ReadOnly = true;
            dgClientes.RowHeadersWidth = 62;
            dgClientes.RowTemplate.Height = 33;
            dgClientes.Size = new Size(776, 381);
            dgClientes.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // NombreApellido
            // 
            NombreApellido.DataPropertyName = "NombreApellido";
            NombreApellido.HeaderText = "NombreApellido";
            NombreApellido.MinimumWidth = 8;
            NombreApellido.Name = "NombreApellido";
            NombreApellido.ReadOnly = true;
            NombreApellido.Width = 150;
            // 
            // Domicilio
            // 
            Domicilio.DataPropertyName = "Domicilio";
            Domicilio.HeaderText = "Domicilio";
            Domicilio.MinimumWidth = 8;
            Domicilio.Name = "Domicilio";
            Domicilio.ReadOnly = true;
            Domicilio.Width = 150;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 150;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgClientes);
            Name = "frmClientes";
            Text = "Clientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgClientes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombreApellido;
        private DataGridViewTextBoxColumn Domicilio;
        private DataGridViewTextBoxColumn Telefono;
    }
}