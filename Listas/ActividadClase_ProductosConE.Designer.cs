namespace Listas
{
    partial class ActividadClase_ProductosConE
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
            dgProductosConE = new DataGridView();
            label1 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProductosConE).BeginInit();
            SuspendLayout();
            // 
            // dgProductosConE
            // 
            dgProductosConE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductosConE.Location = new Point(28, 65);
            dgProductosConE.Name = "dgProductosConE";
            dgProductosConE.RowHeadersWidth = 51;
            dgProductosConE.RowTemplate.Height = 29;
            dgProductosConE.Size = new Size(523, 221);
            dgProductosConE.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 29);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 1;
            label1.Text = "Productos con  E";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(457, 29);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // ActividadClase_ProductosConE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(578, 313);
            Controls.Add(btnLimpiar);
            Controls.Add(label1);
            Controls.Add(dgProductosConE);
            Name = "ActividadClase_ProductosConE";
            Text = "ActividadClase_ProductosConE";
            Load += ActividadClase_ProductosConE_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductosConE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProductosConE;
        private Label label1;
        private Button btnLimpiar;
    }
}