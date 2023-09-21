namespace ListasBasicas
{
    partial class AlaCarta_actividad
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
            lstMenu = new ListBox();
            SuspendLayout();
            // 
            // lstMenu
            // 
            lstMenu.FormattingEnabled = true;
            lstMenu.ItemHeight = 25;
            lstMenu.Location = new Point(12, 12);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(776, 429);
            lstMenu.TabIndex = 0;
            // 
            // AlaCarta_actividad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(lstMenu);
            Name = "AlaCarta_actividad";
            Text = "Bienvenidos a CoderHouse";
            Load += AlaCarta_actividad_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstMenu;
    }
}