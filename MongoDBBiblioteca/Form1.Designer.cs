namespace MongoDBBiblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.autorLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTabla = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(12, 94);
            this.dgvTabla.Name = "dgvTabla";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabla.Size = new System.Drawing.Size(776, 344);
            this.dgvTabla.TabIndex = 1;
            this.dgvTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablaToolStripMenuItem
            // 
            this.tablaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem,
            this.libroToolStripMenuItem,
            this.serieToolStripMenuItem,
            this.toolStripMenuItem1,
            this.autorLibroToolStripMenuItem});
            this.tablaToolStripMenuItem.Name = "tablaToolStripMenuItem";
            this.tablaToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.tablaToolStripMenuItem.Text = "Tabla";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.libroToolStripMenuItem.Text = "Libro";
            this.libroToolStripMenuItem.Click += new System.EventHandler(this.libroToolStripMenuItem_Click);
            // 
            // serieToolStripMenuItem
            // 
            this.serieToolStripMenuItem.Name = "serieToolStripMenuItem";
            this.serieToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.serieToolStripMenuItem.Text = "Serie";
            this.serieToolStripMenuItem.Click += new System.EventHandler(this.serieToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // autorLibroToolStripMenuItem
            // 
            this.autorLibroToolStripMenuItem.Name = "autorLibroToolStripMenuItem";
            this.autorLibroToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.autorLibroToolStripMenuItem.Text = "AutorLibro";
            this.autorLibroToolStripMenuItem.Click += new System.EventHandler(this.autorLibroToolStripMenuItem_Click);
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(12, 46);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(76, 25);
            this.lblTabla.TabIndex = 3;
            this.lblTabla.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(632, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autorLibroToolStripMenuItem;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.Button btnAdd;
    }
}

