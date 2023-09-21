namespace ListasBasicas
{
    partial class Form1
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
            lblSaludo = new Label();
            lstRazas = new ListBox();
            lblRazaPerros = new Label();
            lblPrecioMayor = new Label();
            lblPrecioMasCaro = new Label();
            lstCiudadesxPaises = new ListBox();
            lblCiudadxPais = new Label();
            btnBuscar = new Button();
            btnEliminarItem = new Button();
            btnModificar = new Button();
            btnLimpiar = new Button();
            lstProductoPetShop = new ListBox();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.BackColor = Color.FromArgb(64, 64, 64);
            lblSaludo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaludo.ForeColor = Color.White;
            lblSaludo.Location = new Point(48, 29);
            lblSaludo.Margin = new Padding(2, 0, 2, 0);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(266, 30);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "Bienvenido a CoderHouse";
            // 
            // lstRazas
            // 
            lstRazas.FormattingEnabled = true;
            lstRazas.ItemHeight = 15;
            lstRazas.Location = new Point(48, 118);
            lstRazas.Margin = new Padding(2);
            lstRazas.Name = "lstRazas";
            lstRazas.Size = new Size(136, 109);
            lstRazas.TabIndex = 1;
            // 
            // lblRazaPerros
            // 
            lblRazaPerros.AutoSize = true;
            lblRazaPerros.BackColor = Color.FromArgb(64, 64, 64);
            lblRazaPerros.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblRazaPerros.ForeColor = Color.White;
            lblRazaPerros.Location = new Point(48, 79);
            lblRazaPerros.Margin = new Padding(2, 0, 2, 0);
            lblRazaPerros.Name = "lblRazaPerros";
            lblRazaPerros.Size = new Size(165, 30);
            lblRazaPerros.TabIndex = 2;
            lblRazaPerros.Text = "Razas de Perros";
            // 
            // lblPrecioMayor
            // 
            lblPrecioMayor.AutoSize = true;
            lblPrecioMayor.BackColor = Color.FromArgb(64, 64, 64);
            lblPrecioMayor.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioMayor.ForeColor = Color.White;
            lblPrecioMayor.Location = new Point(48, 241);
            lblPrecioMayor.Margin = new Padding(2, 0, 2, 0);
            lblPrecioMayor.Name = "lblPrecioMayor";
            lblPrecioMayor.Size = new Size(147, 30);
            lblPrecioMayor.TabIndex = 3;
            lblPrecioMayor.Text = "Precio Mayor:";
            // 
            // lblPrecioMasCaro
            // 
            lblPrecioMasCaro.AutoSize = true;
            lblPrecioMasCaro.BackColor = Color.FromArgb(64, 64, 64);
            lblPrecioMasCaro.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioMasCaro.ForeColor = Color.White;
            lblPrecioMasCaro.Location = new Point(48, 274);
            lblPrecioMasCaro.Margin = new Padding(2, 0, 2, 0);
            lblPrecioMasCaro.Name = "lblPrecioMasCaro";
            lblPrecioMasCaro.Size = new Size(176, 30);
            lblPrecioMasCaro.TabIndex = 4;
            lblPrecioMasCaro.Text = "Precio Más Caro:";
            // 
            // lstCiudadesxPaises
            // 
            lstCiudadesxPaises.FormattingEnabled = true;
            lstCiudadesxPaises.ItemHeight = 15;
            lstCiudadesxPaises.Location = new Point(406, 118);
            lstCiudadesxPaises.Margin = new Padding(2);
            lstCiudadesxPaises.Name = "lstCiudadesxPaises";
            lstCiudadesxPaises.Size = new Size(155, 109);
            lstCiudadesxPaises.TabIndex = 5;
            // 
            // lblCiudadxPais
            // 
            lblCiudadxPais.AutoSize = true;
            lblCiudadxPais.BackColor = Color.FromArgb(64, 64, 64);
            lblCiudadxPais.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblCiudadxPais.ForeColor = Color.White;
            lblCiudadxPais.Location = new Point(403, 79);
            lblCiudadxPais.Margin = new Padding(2, 0, 2, 0);
            lblCiudadxPais.Name = "lblCiudadxPais";
            lblCiudadxPais.Size = new Size(184, 30);
            lblCiudadxPais.TabIndex = 6;
            lblCiudadxPais.Text = "Ciudades por País";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(406, 244);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(52, 38);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminarItem
            // 
            btnEliminarItem.Location = new Point(464, 244);
            btnEliminarItem.Name = "btnEliminarItem";
            btnEliminarItem.Size = new Size(63, 38);
            btnEliminarItem.TabIndex = 8;
            btnEliminarItem.Text = "Eliminar Item";
            btnEliminarItem.UseVisualStyleBackColor = true;
            btnEliminarItem.Click += btnEliminarItem_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(533, 244);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(74, 38);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(613, 244);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(63, 38);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lstProductoPetShop
            // 
            lstProductoPetShop.FormattingEnabled = true;
            lstProductoPetShop.ItemHeight = 15;
            lstProductoPetShop.Location = new Point(48, 365);
            lstProductoPetShop.Name = "lstProductoPetShop";
            lstProductoPetShop.Size = new Size(628, 274);
            lstProductoPetShop.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(704, 700);
            Controls.Add(lstProductoPetShop);
            Controls.Add(btnLimpiar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminarItem);
            Controls.Add(btnBuscar);
            Controls.Add(lblCiudadxPais);
            Controls.Add(lstCiudadesxPaises);
            Controls.Add(lblPrecioMasCaro);
            Controls.Add(lblPrecioMayor);
            Controls.Add(lblRazaPerros);
            Controls.Add(lstRazas);
            Controls.Add(lblSaludo);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
        private ListBox lstRazas;
        private Label lblRazaPerros;
        private Label lblPrecioMayor;
        private Label lblPrecioMasCaro;
        private ListBox lstCiudadesxPaises;
        private Label lblCiudadxPais;
        private Button btnBuscar;
        private Button btnEliminarItem;
        private Button btnModificar;
        private Button btnLimpiar;
        private ListBox lstProductoPetShop;
    }
}