namespace ITexport
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDogovor = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbConn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDogovor
            // 
            this.btnDogovor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDogovor.Location = new System.Drawing.Point(13, 13);
            this.btnDogovor.Name = "btnDogovor";
            this.btnDogovor.Size = new System.Drawing.Size(211, 23);
            this.btnDogovor.TabIndex = 0;
            this.btnDogovor.Text = "Договора";
            this.btnDogovor.UseVisualStyleBackColor = true;
            this.btnDogovor.Click += new System.EventHandler(this.btnDogovor_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(13, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(211, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закончить";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbConn
            // 
            this.tbConn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConn.Location = new System.Drawing.Point(13, 43);
            this.tbConn.Multiline = true;
            this.tbConn.Name = "tbConn";
            this.tbConn.Size = new System.Drawing.Size(211, 118);
            this.tbConn.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 202);
            this.Controls.Add(this.tbConn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDogovor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вигрузка данных в Е-Дата";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDogovor;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbConn;
    }
}

