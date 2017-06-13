namespace Upwork_MiniBattleShip
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
            this.pnlShips = new System.Windows.Forms.Panel();
            this.lblGamaResult = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlShips
            // 
            this.pnlShips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlShips.Location = new System.Drawing.Point(13, 13);
            this.pnlShips.Name = "pnlShips";
            this.pnlShips.Padding = new System.Windows.Forms.Padding(3);
            this.pnlShips.Size = new System.Drawing.Size(319, 249);
            this.pnlShips.TabIndex = 0;
            this.pnlShips.ClientSizeChanged += new System.EventHandler(this.pnlShips_ClientSizeChanged);
            // 
            // lblGamaResult
            // 
            this.lblGamaResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGamaResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGamaResult.Location = new System.Drawing.Point(13, 265);
            this.lblGamaResult.Name = "lblGamaResult";
            this.lblGamaResult.Size = new System.Drawing.Size(319, 41);
            this.lblGamaResult.TabIndex = 1;
            this.lblGamaResult.Text = "lblGamaResult";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Location = new System.Drawing.Point(135, 323);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 352);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGamaResult);
            this.Controls.Add(this.pnlShips);
            this.MaximumSize = new System.Drawing.Size(720, 780);
            this.MinimumSize = new System.Drawing.Size(360, 390);
            this.Name = "frmMain";
            this.Text = "Mini BattleShip";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShips;
        private System.Windows.Forms.Label lblGamaResult;
        private System.Windows.Forms.Button btnStart;

    }
}

