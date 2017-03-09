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
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.dgvDoc = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForvard = new System.Windows.Forms.Button();
            this.lblDatePo = new System.Windows.Forms.Label();
            this.lblDataOt = new System.Windows.Forms.Label();
            this.dtpDatePo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataOt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContracts
            // 
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(4, 64);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.Size = new System.Drawing.Size(413, 308);
            this.dgvContracts.TabIndex = 0;
            // 
            // dgvDoc
            // 
            this.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoc.Location = new System.Drawing.Point(455, 64);
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.Size = new System.Drawing.Size(413, 308);
            this.dgvDoc.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.Yellow;
            this.btnBack.Location = new System.Drawing.Point(3, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Tag = "-1";
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnChangePeriod);
            // 
            // btnForvard
            // 
            this.btnForvard.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnForvard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForvard.ForeColor = System.Drawing.Color.Yellow;
            this.btnForvard.Location = new System.Drawing.Point(363, 11);
            this.btnForvard.Name = "btnForvard";
            this.btnForvard.Size = new System.Drawing.Size(32, 23);
            this.btnForvard.TabIndex = 19;
            this.btnForvard.Tag = "+1";
            this.btnForvard.Text = ">>";
            this.btnForvard.UseVisualStyleBackColor = false;
            this.btnForvard.Click += new System.EventHandler(this.btnChangePeriod);
            // 
            // lblDatePo
            // 
            this.lblDatePo.Location = new System.Drawing.Point(211, 14);
            this.lblDatePo.Name = "lblDatePo";
            this.lblDatePo.Size = new System.Drawing.Size(19, 20);
            this.lblDatePo.TabIndex = 18;
            this.lblDatePo.Text = "по";
            // 
            // lblDataOt
            // 
            this.lblDataOt.Location = new System.Drawing.Point(38, 14);
            this.lblDataOt.Name = "lblDataOt";
            this.lblDataOt.Size = new System.Drawing.Size(43, 20);
            this.lblDataOt.TabIndex = 17;
            this.lblDataOt.Text = "Дата с";
            // 
            // dtpDatePo
            // 
            this.dtpDatePo.Location = new System.Drawing.Point(237, 12);
            this.dtpDatePo.Name = "dtpDatePo";
            this.dtpDatePo.Size = new System.Drawing.Size(119, 20);
            this.dtpDatePo.TabIndex = 16;
            this.dtpDatePo.ValueChanged += new System.EventHandler(this.dtpDatePo_ValueChanged);
            // 
            // dtpDataOt
            // 
            this.dtpDataOt.Location = new System.Drawing.Point(86, 12);
            this.dtpDataOt.Name = "dtpDataOt";
            this.dtpDataOt.Size = new System.Drawing.Size(119, 20);
            this.dtpDataOt.TabIndex = 15;
            this.dtpDataOt.ValueChanged += new System.EventHandler(this.dtpDataOt_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 534);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnForvard);
            this.Controls.Add(this.lblDatePo);
            this.Controls.Add(this.lblDataOt);
            this.Controls.Add(this.dtpDatePo);
            this.Controls.Add(this.dtpDataOt);
            this.Controls.Add(this.dgvDoc);
            this.Controls.Add(this.dgvContracts);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вигрузка данных в Е-Дата";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.DataGridView dgvDoc;
        protected System.Windows.Forms.Button btnBack;
        protected System.Windows.Forms.Button btnForvard;
        protected System.Windows.Forms.Label lblDatePo;
        protected System.Windows.Forms.Label lblDataOt;
        protected System.Windows.Forms.DateTimePicker dtpDatePo;
        protected System.Windows.Forms.DateTimePicker dtpDataOt;

    }
}

