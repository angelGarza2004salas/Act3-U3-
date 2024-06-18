namespace prueba1
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
            this.BtnAddAge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInsertName = new System.Windows.Forms.TextBox();
            this.LblInsertName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAddAge
            // 
            this.BtnAddAge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAddAge.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAge.Location = new System.Drawing.Point(493, 361);
            this.BtnAddAge.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddAge.Name = "BtnAddAge";
            this.BtnAddAge.Size = new System.Drawing.Size(193, 63);
            this.BtnAddAge.TabIndex = 0;
            this.BtnAddAge.Text = "Add age";
            this.BtnAddAge.UseVisualStyleBackColor = false;
            this.BtnAddAge.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "....";
            // 
            // TxtInsertName
            // 
            this.TxtInsertName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInsertName.Location = new System.Drawing.Point(488, 270);
            this.TxtInsertName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtInsertName.Name = "TxtInsertName";
            this.TxtInsertName.Size = new System.Drawing.Size(224, 26);
            this.TxtInsertName.TabIndex = 2;
            // 
            // LblInsertName
            // 
            this.LblInsertName.AutoSize = true;
            this.LblInsertName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LblInsertName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblInsertName.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInsertName.Location = new System.Drawing.Point(530, 221);
            this.LblInsertName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInsertName.Name = "LblInsertName";
            this.LblInsertName.Size = new System.Drawing.Size(144, 33);
            this.LblInsertName.TabIndex = 3;
            this.LblInsertName.Text = "Insert Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 686);
            this.Controls.Add(this.LblInsertName);
            this.Controls.Add(this.TxtInsertName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddAge);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtInsertName;
        private System.Windows.Forms.Label LblInsertName;
    }
}

