namespace ProyectoFinalBaseGestion
{
    partial class frmDgVenta
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
            dgVenta = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Comentarios = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgVenta).BeginInit();
            SuspendLayout();
            // 
            // dgVenta
            // 
            dgVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVenta.Columns.AddRange(new DataGridViewColumn[] { Id, Comentarios, IdUsuario, Editar, Eliminar });
            dgVenta.Location = new Point(21, 54);
            dgVenta.Name = "dgVenta";
            dgVenta.RowTemplate.Height = 25;
            dgVenta.Size = new Size(649, 218);
            dgVenta.TabIndex = 0;
            dgVenta.CellContentClick += dgVenta_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Comentarios
            // 
            Comentarios.DataPropertyName = "Comentarios";
            Comentarios.HeaderText = "Comentarios";
            Comentarios.Name = "Comentarios";
            Comentarios.Width = 200;
            // 
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(581, 17);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(89, 31);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // frmDgVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 290);
            Controls.Add(btnCrear);
            Controls.Add(dgVenta);
            Name = "frmDgVenta";
            Text = "Venta";
            Load += frmDgVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgVenta;
        private Button btnCrear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Comentarios;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}