namespace SistemaGestionUI
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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgVenta).BeginInit();
            SuspendLayout();
            // 
            // dgVenta
            // 
            dgVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVenta.Columns.AddRange(new DataGridViewColumn[] { Id, Comentarios, IdUsuario, Editar, Eliminar });
            dgVenta.Location = new Point(30, 106);
            dgVenta.Margin = new Padding(4, 5, 4, 5);
            dgVenta.Name = "dgVenta";
            dgVenta.RowHeadersWidth = 62;
            dgVenta.RowTemplate.Height = 25;
            dgVenta.Size = new Size(927, 363);
            dgVenta.TabIndex = 0;
            dgVenta.CellContentClick += dgVenta_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // Comentarios
            // 
            Comentarios.DataPropertyName = "Comentarios";
            Comentarios.HeaderText = "Comentarios";
            Comentarios.MinimumWidth = 8;
            Comentarios.Name = "Comentarios";
            Comentarios.Width = 200;
            // 
            // IdUsuario
            // 
            IdUsuario.DataPropertyName = "IdUsuario";
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.MinimumWidth = 8;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Width = 150;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 150;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.Width = 150;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(819, 45);
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
            label1.Location = new Point(248, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(372, 51);
            label1.TabIndex = 5;
            label1.Text = "Lista de Venta";
            // 
            // frmDgVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(974, 483);
            Controls.Add(label1);
            Controls.Add(btnCrear);
            Controls.Add(dgVenta);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmDgVenta";
            Text = "Venta";
            Load += frmDgVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgVenta;
        private Button btnCrear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Comentarios;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private Label label1;
    }
}