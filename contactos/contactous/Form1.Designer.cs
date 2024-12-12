namespace contactous
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBut = new System.Windows.Forms.PictureBox();
            this.LookContactoBut = new System.Windows.Forms.PictureBox();
            this.RemoveContactoBut = new System.Windows.Forms.PictureBox();
            this.UpdateContactoBut = new System.Windows.Forms.PictureBox();
            this.AñadirContactoBut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookContactoBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactoBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateContactoBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AñadirContactoBut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(611, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Contactos";
            // 
            // ExitBut
            // 
            this.ExitBut.Image = global::contactous.Properties.Resources.rect93;
            this.ExitBut.Location = new System.Drawing.Point(619, 684);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(320, 109);
            this.ExitBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBut.TabIndex = 5;
            this.ExitBut.TabStop = false;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // LookContactoBut
            // 
            this.LookContactoBut.Image = global::contactous.Properties.Resources.rect90;
            this.LookContactoBut.Location = new System.Drawing.Point(619, 559);
            this.LookContactoBut.Name = "LookContactoBut";
            this.LookContactoBut.Size = new System.Drawing.Size(320, 109);
            this.LookContactoBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LookContactoBut.TabIndex = 4;
            this.LookContactoBut.TabStop = false;
            this.LookContactoBut.Click += new System.EventHandler(this.LookContactoBut_Click);
            // 
            // RemoveContactoBut
            // 
            this.RemoveContactoBut.Image = global::contactous.Properties.Resources.rect81;
            this.RemoveContactoBut.Location = new System.Drawing.Point(619, 434);
            this.RemoveContactoBut.Name = "RemoveContactoBut";
            this.RemoveContactoBut.Size = new System.Drawing.Size(320, 109);
            this.RemoveContactoBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemoveContactoBut.TabIndex = 3;
            this.RemoveContactoBut.TabStop = false;
            this.RemoveContactoBut.Click += new System.EventHandler(this.RemoveContactoBut_Click);
            // 
            // UpdateContactoBut
            // 
            this.UpdateContactoBut.Image = global::contactous.Properties.Resources.rect9;
            this.UpdateContactoBut.Location = new System.Drawing.Point(619, 309);
            this.UpdateContactoBut.Name = "UpdateContactoBut";
            this.UpdateContactoBut.Size = new System.Drawing.Size(320, 109);
            this.UpdateContactoBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpdateContactoBut.TabIndex = 2;
            this.UpdateContactoBut.TabStop = false;
            this.UpdateContactoBut.Click += new System.EventHandler(this.UpdateContactoBut_Click);
            // 
            // AñadirContactoBut
            // 
            this.AñadirContactoBut.Image = global::contactous.Properties.Resources.rect2;
            this.AñadirContactoBut.Location = new System.Drawing.Point(619, 184);
            this.AñadirContactoBut.Name = "AñadirContactoBut";
            this.AñadirContactoBut.Size = new System.Drawing.Size(320, 109);
            this.AñadirContactoBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AñadirContactoBut.TabIndex = 1;
            this.AñadirContactoBut.TabStop = false;
            this.AñadirContactoBut.Click += new System.EventHandler(this.AñadirContactoBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1477, 825);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.LookContactoBut);
            this.Controls.Add(this.RemoveContactoBut);
            this.Controls.Add(this.UpdateContactoBut);
            this.Controls.Add(this.AñadirContactoBut);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ExitBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookContactoBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactoBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateContactoBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AñadirContactoBut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AñadirContactoBut;
        private System.Windows.Forms.PictureBox UpdateContactoBut;
        private System.Windows.Forms.PictureBox RemoveContactoBut;
        private System.Windows.Forms.PictureBox LookContactoBut;
        private System.Windows.Forms.PictureBox ExitBut;
    }
}

