namespace SistemaGestionUI
{
    partial class frmMenu
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
            menuStrip1 = new MenuStrip();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            listarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            listarProductosToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            listarVentasToolStripMenuItem = new ToolStripMenuItem();
            productoVentasToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, productoToolStripMenuItem, ventasToolStripMenuItem, productoVentasToolStripMenuItem, acercaDeToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(184, 1144);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarUsuariosToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(175, 29);
            usuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // listarUsuariosToolStripMenuItem
            // 
            listarUsuariosToolStripMenuItem.Name = "listarUsuariosToolStripMenuItem";
            listarUsuariosToolStripMenuItem.Size = new Size(270, 34);
            listarUsuariosToolStripMenuItem.Text = "Listar Usuarios";
            listarUsuariosToolStripMenuItem.Click += listarUsuariosToolStripMenuItem_Click;
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarProductosToolStripMenuItem });
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(175, 29);
            productoToolStripMenuItem.Text = "Productos";
            // 
            // listarProductosToolStripMenuItem
            // 
            listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            listarProductosToolStripMenuItem.Size = new Size(241, 34);
            listarProductosToolStripMenuItem.Text = "Listar Productos";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarVentasToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(175, 29);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // listarVentasToolStripMenuItem
            // 
            listarVentasToolStripMenuItem.Name = "listarVentasToolStripMenuItem";
            listarVentasToolStripMenuItem.Size = new Size(212, 34);
            listarVentasToolStripMenuItem.Text = "Listar Ventas";
            // 
            // productoVentasToolStripMenuItem
            // 
            productoVentasToolStripMenuItem.Name = "productoVentasToolStripMenuItem";
            productoVentasToolStripMenuItem.Size = new Size(175, 29);
            productoVentasToolStripMenuItem.Text = "Producto Ventas";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(175, 29);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(175, 29);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Location = new Point(184, 1122);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1790, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1974, 1144);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú";
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem listarUsuariosToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem listarProductosToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem listarVentasToolStripMenuItem;
        private ToolStripMenuItem productoVentasToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private StatusStrip statusStrip1;
    }
}