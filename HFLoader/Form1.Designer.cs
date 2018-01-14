namespace HFLoader
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_Url = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Icon = new System.Windows.Forms.Button();
            this.btn_ClonePE = new System.Windows.Forms.Button();
            this.btn_Build = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Url
            // 
            this.tb_Url.BackColor = System.Drawing.SystemColors.MenuText;
            this.tb_Url.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Url.ForeColor = System.Drawing.Color.Lime;
            this.tb_Url.Location = new System.Drawing.Point(12, 35);
            this.tb_Url.Name = "tb_Url";
            this.tb_Url.Size = new System.Drawing.Size(279, 24);
            this.tb_Url.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(191, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Icon
            // 
            this.btn_Icon.BackColor = System.Drawing.Color.Transparent;
            this.btn_Icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Icon.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Icon.ForeColor = System.Drawing.Color.Lime;
            this.btn_Icon.Location = new System.Drawing.Point(12, 65);
            this.btn_Icon.Name = "btn_Icon";
            this.btn_Icon.Size = new System.Drawing.Size(92, 31);
            this.btn_Icon.TabIndex = 2;
            this.btn_Icon.Text = "Icon";
            this.btn_Icon.UseVisualStyleBackColor = false;
            this.btn_Icon.Click += new System.EventHandler(this.btn_Icon_Click);
            // 
            // btn_ClonePE
            // 
            this.btn_ClonePE.BackColor = System.Drawing.Color.Transparent;
            this.btn_ClonePE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClonePE.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClonePE.ForeColor = System.Drawing.Color.Lime;
            this.btn_ClonePE.Location = new System.Drawing.Point(12, 134);
            this.btn_ClonePE.Name = "btn_ClonePE";
            this.btn_ClonePE.Size = new System.Drawing.Size(92, 31);
            this.btn_ClonePE.TabIndex = 3;
            this.btn_ClonePE.Text = "Clone PE";
            this.btn_ClonePE.UseVisualStyleBackColor = false;
            this.btn_ClonePE.Click += new System.EventHandler(this.btn_ClonePE_Click);
            // 
            // btn_Build
            // 
            this.btn_Build.BackColor = System.Drawing.Color.Transparent;
            this.btn_Build.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Build.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Build.ForeColor = System.Drawing.Color.Lime;
            this.btn_Build.Location = new System.Drawing.Point(191, 258);
            this.btn_Build.Name = "btn_Build";
            this.btn_Build.Size = new System.Drawing.Size(100, 31);
            this.btn_Build.TabIndex = 4;
            this.btn_Build.Text = "Build";
            this.btn_Build.UseVisualStyleBackColor = false;
            this.btn_Build.Click += new System.EventHandler(this.btn_Build_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HFLoader.Properties.Resources.cm;
            this.ClientSize = new System.Drawing.Size(303, 301);
            this.Controls.Add(this.btn_Build);
            this.Controls.Add(this.btn_ClonePE);
            this.Controls.Add(this.btn_Icon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_Url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Url;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Icon;
        private System.Windows.Forms.Button btn_ClonePE;
        private System.Windows.Forms.Button btn_Build;
    }
}

