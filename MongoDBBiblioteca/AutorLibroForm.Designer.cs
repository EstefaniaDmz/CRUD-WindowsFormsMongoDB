namespace MongoDBBiblioteca
{
    partial class AutorLibroForm
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
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAutor
            // 
            this.cmbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(25, 80);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(338, 26);
            this.cmbAutor.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Formulario de autor-libro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id Autor:";
            // 
            // cmbLibro
            // 
            this.cmbLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(25, 140);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(338, 26);
            this.cmbLibro.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Id Libro:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(24, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 34);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDo
            // 
            this.btnDo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDo.Location = new System.Drawing.Point(221, 192);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(142, 34);
            this.btnDo.TabIndex = 20;
            this.btnDo.Text = "Aceptar";
            this.btnDo.UseVisualStyleBackColor = true;
            // 
            // AutorLibroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 246);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.cmbLibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AutorLibroForm";
            this.Text = "AutorLibroForm";
            this.Load += new System.EventHandler(this.AutorLibroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDo;
    }
}