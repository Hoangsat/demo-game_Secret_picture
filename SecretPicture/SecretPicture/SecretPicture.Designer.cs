namespace SecretPicture
{
    partial class SecretPicture
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretPicture));
            this.buttonShowPicture1 = new System.Windows.Forms.Button();
            this.buttonShowPicture2 = new System.Windows.Forms.Button();
            this.buttonShowPicture4 = new System.Windows.Forms.Button();
            this.buttonShowPicture3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShowPicture1
            // 
            this.buttonShowPicture1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowPicture1.Location = new System.Drawing.Point(12, 12);
            this.buttonShowPicture1.Name = "buttonShowPicture1";
            this.buttonShowPicture1.Size = new System.Drawing.Size(147, 68);
            this.buttonShowPicture1.TabIndex = 0;
            this.buttonShowPicture1.Text = "Wolf";
            this.buttonShowPicture1.UseVisualStyleBackColor = true;
            this.buttonShowPicture1.Click += new System.EventHandler(this.buttonShowPicture1_Click);
            // 
            // buttonShowPicture2
            // 
            this.buttonShowPicture2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowPicture2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowPicture2.Location = new System.Drawing.Point(443, 12);
            this.buttonShowPicture2.Name = "buttonShowPicture2";
            this.buttonShowPicture2.Size = new System.Drawing.Size(147, 68);
            this.buttonShowPicture2.TabIndex = 0;
            this.buttonShowPicture2.Text = "Raccoon";
            this.buttonShowPicture2.UseVisualStyleBackColor = true;
            this.buttonShowPicture2.Click += new System.EventHandler(this.buttonShowPicture2_Click);
            // 
            // buttonShowPicture4
            // 
            this.buttonShowPicture4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowPicture4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowPicture4.Location = new System.Drawing.Point(12, 257);
            this.buttonShowPicture4.Name = "buttonShowPicture4";
            this.buttonShowPicture4.Size = new System.Drawing.Size(147, 68);
            this.buttonShowPicture4.TabIndex = 0;
            this.buttonShowPicture4.Text = "Cat";
            this.buttonShowPicture4.UseVisualStyleBackColor = true;
            this.buttonShowPicture4.Click += new System.EventHandler(this.buttonShowPicture4_Click);
            // 
            // buttonShowPicture3
            // 
            this.buttonShowPicture3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowPicture3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowPicture3.Location = new System.Drawing.Point(443, 257);
            this.buttonShowPicture3.Name = "buttonShowPicture3";
            this.buttonShowPicture3.Size = new System.Drawing.Size(147, 68);
            this.buttonShowPicture3.TabIndex = 0;
            this.buttonShowPicture3.Text = "Leopard";
            this.buttonShowPicture3.UseVisualStyleBackColor = true;
            this.buttonShowPicture3.Click += new System.EventHandler(this.buttonShowPicture3_Click);
            // 
            // SecretPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 352);
            this.Controls.Add(this.buttonShowPicture3);
            this.Controls.Add(this.buttonShowPicture4);
            this.Controls.Add(this.buttonShowPicture2);
            this.Controls.Add(this.buttonShowPicture1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(507, 300);
            this.Name = "SecretPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecretPicture";
            this.TopMost = true;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SecretPicture_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SecretPicture_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowPicture1;
        private System.Windows.Forms.Button buttonShowPicture2;
        private System.Windows.Forms.Button buttonShowPicture4;
        private System.Windows.Forms.Button buttonShowPicture3;
    }
}

