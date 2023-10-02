namespace ProyectoFinalBaseGestion
{
    partial class frmAltaUsuario
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
            btnGuardar = new Button();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            txtContraseña = new TextBox();
            label2 = new Label();
            txtNombreUsuario = new TextBox();
            label4 = new Label();
            txtMail = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(135, 480);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 38);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 75);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(355, 31);
            txtNombre.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(28, 30);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(103, 31);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(28, 147);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(355, 31);
            txtApellido.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 111);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 31);
            label1.TabIndex = 25;
            label1.Text = "Apellido:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(30, 322);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(355, 31);
            txtContraseña.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 280);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 31);
            label2.TabIndex = 29;
            label2.Text = "Contraseña:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(30, 230);
            txtNombreUsuario.Margin = new Padding(4, 5, 4, 5);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(355, 31);
            txtNombreUsuario.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 194);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(181, 31);
            label4.TabIndex = 27;
            label4.Text = "NombreUsuario:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(30, 406);
            txtMail.Margin = new Padding(4, 5, 4, 5);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(355, 31);
            txtMail.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 364);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 31);
            label5.TabIndex = 31;
            label5.Text = "eMail:";
            // 
            // frmAltaUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 561);
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
            Name = "frmAltaUsuario";
            Text = "Alta Usuario";
            Load += frmAltaUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtContraseña;
        private Label label2;
        private TextBox txtNombreUsuario;
        private Label label4;
        private TextBox txtMail;
        private Label label5;
    }
}