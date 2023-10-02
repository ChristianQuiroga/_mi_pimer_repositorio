namespace ProyectoFinalBaseGestion
{
    partial class frmEliminarUsuario
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
            txtMail = new TextBox();
            label5 = new Label();
            txtContraseña = new TextBox();
            label2 = new Label();
            txtNombreUsuario = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            SuspendLayout();
            // 
            // txtMail
            // 
            txtMail.Enabled = false;
            txtMail.Location = new Point(32, 408);
            txtMail.Margin = new Padding(4, 5, 4, 5);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(355, 31);
            txtMail.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 366);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 31);
            label5.TabIndex = 53;
            label5.Text = "eMail:";
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(32, 324);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(355, 31);
            txtContraseña.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 282);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 31);
            label2.TabIndex = 51;
            label2.Text = "Contraseña:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Enabled = false;
            txtNombreUsuario.Location = new Point(32, 232);
            txtNombreUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(355, 31);
            txtNombreUsuario.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 196);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(181, 31);
            label4.TabIndex = 49;
            label4.Text = "NombreUsuario:";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(30, 149);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(355, 31);
            txtApellido.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 113);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 31);
            label1.TabIndex = 47;
            label1.Text = "Apellido:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(116, 472);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(177, 38);
            btnGuardar.TabIndex = 46;
            btnGuardar.Text = "Eliminar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(30, 77);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(355, 31);
            txtNombre.TabIndex = 45;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(30, 32);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(103, 31);
            lblDescripcion.TabIndex = 44;
            lblDescripcion.Text = "Nombre:";
            // 
            // frmEliminarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 557);
            Controls.Add(txtMail);
            Controls.Add(label5);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Name = "frmEliminarUsuario";
            Text = "Eliminar Usuario";
            Load += frmEliminarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMail;
        private Label label5;
        private TextBox txtContraseña;
        private Label label2;
        private TextBox txtNombreUsuario;
        private Label label4;
        private TextBox txtApellido;
        private Label label1;
        private Button btnGuardar;
        private TextBox txtNombre;
        private Label lblDescripcion;
    }
}