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
            this.scTables = new System.Windows.Forms.SplitContainer();
            this.lblDoc = new System.Windows.Forms.Label();
            this.dgvDoc = new System.Windows.Forms.DataGridView();
            this.lblContracts = new System.Windows.Forms.Label();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.pnConditions = new System.Windows.Forms.Panel();
            this.gbTypeDoc = new System.Windows.Forms.GroupBox();
            this.rbDocBoth = new System.Windows.Forms.RadioButton();
            this.rbDocParish = new System.Windows.Forms.RadioButton();
            this.rbDocAct = new System.Windows.Forms.RadioButton();
            this.cbContractAll = new System.Windows.Forms.CheckBox();
            this.cbContractTender = new System.Windows.Forms.CheckBox();
            this.cbContractKazna = new System.Windows.Forms.CheckBox();
            this.lblTypeContract = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForvard = new System.Windows.Forms.Button();
            this.lblDatePo = new System.Windows.Forms.Label();
            this.lblDataOt = new System.Windows.Forms.Label();
            this.dtpDatePo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataOt = new System.Windows.Forms.DateTimePicker();
            this.btnImport = new System.Windows.Forms.Button();
            this.scTables.Panel1.SuspendLayout();
            this.scTables.Panel2.SuspendLayout();
            this.scTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.pnConditions.SuspendLayout();
            this.gbTypeDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // scTables
            // 
            this.scTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scTables.Location = new System.Drawing.Point(0, 110);
            this.scTables.Name = "scTables";
            // 
            // scTables.Panel1
            // 
            this.scTables.Panel1.Controls.Add(this.lblDoc);
            this.scTables.Panel1.Controls.Add(this.dgvDoc);
            // 
            // scTables.Panel2
            // 
            this.scTables.Panel2.Controls.Add(this.lblContracts);
            this.scTables.Panel2.Controls.Add(this.dgvContracts);
            this.scTables.Size = new System.Drawing.Size(534, 357);
            this.scTables.SplitterDistance = 285;
            this.scTables.TabIndex = 21;
            // 
            // lblDoc
            // 
            this.lblDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDoc.Location = new System.Drawing.Point(0, 0);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(285, 23);
            this.lblDoc.TabIndex = 3;
            this.lblDoc.Text = "Документы";
            this.lblDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDoc
            // 
            this.dgvDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoc.Location = new System.Drawing.Point(6, 35);
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.Size = new System.Drawing.Size(273, 319);
            this.dgvDoc.TabIndex = 2;
            // 
            // lblContracts
            // 
            this.lblContracts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContracts.Location = new System.Drawing.Point(0, 0);
            this.lblContracts.Name = "lblContracts";
            this.lblContracts.Size = new System.Drawing.Size(245, 23);
            this.lblContracts.TabIndex = 2;
            this.lblContracts.Text = "Договора";
            this.lblContracts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvContracts
            // 
            this.dgvContracts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(6, 35);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.Size = new System.Drawing.Size(233, 319);
            this.dgvContracts.TabIndex = 1;
            this.dgvContracts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContracts_CellContentClick);
            this.dgvContracts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContracts_CellEndEdit);
            // 
            // pnConditions
            // 
            this.pnConditions.AutoScroll = true;
            this.pnConditions.Controls.Add(this.gbTypeDoc);
            this.pnConditions.Controls.Add(this.cbContractAll);
            this.pnConditions.Controls.Add(this.cbContractTender);
            this.pnConditions.Controls.Add(this.cbContractKazna);
            this.pnConditions.Controls.Add(this.lblTypeContract);
            this.pnConditions.Controls.Add(this.lblPeriod);
            this.pnConditions.Controls.Add(this.btnBack);
            this.pnConditions.Controls.Add(this.btnForvard);
            this.pnConditions.Controls.Add(this.lblDatePo);
            this.pnConditions.Controls.Add(this.lblDataOt);
            this.pnConditions.Controls.Add(this.dtpDatePo);
            this.pnConditions.Controls.Add(this.dtpDataOt);
            this.pnConditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnConditions.Location = new System.Drawing.Point(0, 0);
            this.pnConditions.Name = "pnConditions";
            this.pnConditions.Size = new System.Drawing.Size(534, 104);
            this.pnConditions.TabIndex = 22;
            // 
            // gbTypeDoc
            // 
            this.gbTypeDoc.Controls.Add(this.rbDocBoth);
            this.gbTypeDoc.Controls.Add(this.rbDocParish);
            this.gbTypeDoc.Controls.Add(this.rbDocAct);
            this.gbTypeDoc.Location = new System.Drawing.Point(11, 51);
            this.gbTypeDoc.Name = "gbTypeDoc";
            this.gbTypeDoc.Size = new System.Drawing.Size(392, 40);
            this.gbTypeDoc.TabIndex = 36;
            this.gbTypeDoc.TabStop = false;
            this.gbTypeDoc.Text = "Типы документов";
            // 
            // rbDocBoth
            // 
            this.rbDocBoth.AutoSize = true;
            this.rbDocBoth.Location = new System.Drawing.Point(171, 18);
            this.rbDocBoth.Name = "rbDocBoth";
            this.rbDocBoth.Size = new System.Drawing.Size(45, 17);
            this.rbDocBoth.TabIndex = 2;
            this.rbDocBoth.Text = "Оба";
            this.rbDocBoth.UseVisualStyleBackColor = true;
            this.rbDocBoth.CheckedChanged += new System.EventHandler(this.rbDoc_CheckedChanged);
            // 
            // rbDocParish
            // 
            this.rbDocParish.AutoSize = true;
            this.rbDocParish.Location = new System.Drawing.Point(79, 18);
            this.rbDocParish.Name = "rbDocParish";
            this.rbDocParish.Size = new System.Drawing.Size(70, 17);
            this.rbDocParish.TabIndex = 1;
            this.rbDocParish.Text = "Приходы";
            this.rbDocParish.UseVisualStyleBackColor = true;
            this.rbDocParish.CheckedChanged += new System.EventHandler(this.rbDoc_CheckedChanged);
            // 
            // rbDocAct
            // 
            this.rbDocAct.AutoSize = true;
            this.rbDocAct.Checked = true;
            this.rbDocAct.Location = new System.Drawing.Point(6, 18);
            this.rbDocAct.Name = "rbDocAct";
            this.rbDocAct.Size = new System.Drawing.Size(51, 17);
            this.rbDocAct.TabIndex = 0;
            this.rbDocAct.TabStop = true;
            this.rbDocAct.Text = "Акты";
            this.rbDocAct.UseVisualStyleBackColor = true;
            this.rbDocAct.CheckedChanged += new System.EventHandler(this.rbDoc_CheckedChanged);
            // 
            // cbContractAll
            // 
            this.cbContractAll.AutoSize = true;
            this.cbContractAll.Location = new System.Drawing.Point(425, 74);
            this.cbContractAll.Name = "cbContractAll";
            this.cbContractAll.Size = new System.Drawing.Size(62, 17);
            this.cbContractAll.TabIndex = 35;
            this.cbContractAll.Text = "Любые";
            this.cbContractAll.UseVisualStyleBackColor = true;
            this.cbContractAll.CheckedChanged += new System.EventHandler(this.cbContractAll_CheckedChanged);
            // 
            // cbContractTender
            // 
            this.cbContractTender.AutoSize = true;
            this.cbContractTender.Checked = true;
            this.cbContractTender.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContractTender.Location = new System.Drawing.Point(425, 51);
            this.cbContractTender.Name = "cbContractTender";
            this.cbContractTender.Size = new System.Drawing.Size(83, 17);
            this.cbContractTender.TabIndex = 34;
            this.cbContractTender.Text = "Тендерные";
            this.cbContractTender.UseVisualStyleBackColor = true;
            this.cbContractTender.CheckedChanged += new System.EventHandler(this.cbContractTender_CheckedChanged);
            // 
            // cbContractKazna
            // 
            this.cbContractKazna.AutoSize = true;
            this.cbContractKazna.Checked = true;
            this.cbContractKazna.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContractKazna.Location = new System.Drawing.Point(425, 28);
            this.cbContractKazna.Name = "cbContractKazna";
            this.cbContractKazna.Size = new System.Drawing.Size(98, 17);
            this.cbContractKazna.TabIndex = 33;
            this.cbContractKazna.Text = "Казначейские";
            this.cbContractKazna.UseVisualStyleBackColor = true;
            this.cbContractKazna.CheckedChanged += new System.EventHandler(this.cbContractKazna_CheckedChanged);
            // 
            // lblTypeContract
            // 
            this.lblTypeContract.AutoSize = true;
            this.lblTypeContract.Location = new System.Drawing.Point(425, 9);
            this.lblTypeContract.Name = "lblTypeContract";
            this.lblTypeContract.Size = new System.Drawing.Size(90, 13);
            this.lblTypeContract.TabIndex = 29;
            this.lblTypeContract.Text = "Типы договоров";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(169, 6);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(120, 13);
            this.lblPeriod.TabIndex = 27;
            this.lblPeriod.Text = "Документы в периоде";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.Yellow;
            this.btnBack.Location = new System.Drawing.Point(11, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 23);
            this.btnBack.TabIndex = 26;
            this.btnBack.Tag = "-1";
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnForvard
            // 
            this.btnForvard.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnForvard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForvard.ForeColor = System.Drawing.Color.Yellow;
            this.btnForvard.Location = new System.Drawing.Point(371, 21);
            this.btnForvard.Name = "btnForvard";
            this.btnForvard.Size = new System.Drawing.Size(32, 23);
            this.btnForvard.TabIndex = 25;
            this.btnForvard.Tag = "+1";
            this.btnForvard.Text = ">>";
            this.btnForvard.UseVisualStyleBackColor = false;
            // 
            // lblDatePo
            // 
            this.lblDatePo.Location = new System.Drawing.Point(219, 24);
            this.lblDatePo.Name = "lblDatePo";
            this.lblDatePo.Size = new System.Drawing.Size(19, 20);
            this.lblDatePo.TabIndex = 24;
            this.lblDatePo.Text = "по";
            // 
            // lblDataOt
            // 
            this.lblDataOt.Location = new System.Drawing.Point(46, 24);
            this.lblDataOt.Name = "lblDataOt";
            this.lblDataOt.Size = new System.Drawing.Size(43, 20);
            this.lblDataOt.TabIndex = 23;
            this.lblDataOt.Text = "Дата с";
            // 
            // dtpDatePo
            // 
            this.dtpDatePo.Location = new System.Drawing.Point(245, 22);
            this.dtpDatePo.Name = "dtpDatePo";
            this.dtpDatePo.Size = new System.Drawing.Size(119, 20);
            this.dtpDatePo.TabIndex = 22;
            // 
            // dtpDataOt
            // 
            this.dtpDataOt.Location = new System.Drawing.Point(94, 22);
            this.dtpDataOt.Name = "dtpDataOt";
            this.dtpDataOt.Size = new System.Drawing.Size(119, 20);
            this.dtpDataOt.TabIndex = 21;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnImport.Location = new System.Drawing.Point(114, 477);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(306, 26);
            this.btnImport.TabIndex = 23;
            this.btnImport.Text = "Выгрузить отобранные документы";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 512);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.pnConditions);
            this.Controls.Add(this.scTables);
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вигрузка данных в Е-Дата";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.scTables.Panel1.ResumeLayout(false);
            this.scTables.Panel2.ResumeLayout(false);
            this.scTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.pnConditions.ResumeLayout(false);
            this.pnConditions.PerformLayout();
            this.gbTypeDoc.ResumeLayout(false);
            this.gbTypeDoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scTables;
        private System.Windows.Forms.DataGridView dgvDoc;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Panel pnConditions;
        protected System.Windows.Forms.Button btnBack;
        protected System.Windows.Forms.Button btnForvard;
        protected System.Windows.Forms.Label lblDatePo;
        protected System.Windows.Forms.Label lblDataOt;
        protected System.Windows.Forms.DateTimePicker dtpDatePo;
        protected System.Windows.Forms.DateTimePicker dtpDataOt;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblContracts;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.GroupBox gbTypeDoc;
        private System.Windows.Forms.RadioButton rbDocBoth;
        private System.Windows.Forms.RadioButton rbDocParish;
        private System.Windows.Forms.RadioButton rbDocAct;
        private System.Windows.Forms.CheckBox cbContractAll;
        private System.Windows.Forms.CheckBox cbContractTender;
        private System.Windows.Forms.CheckBox cbContractKazna;
        private System.Windows.Forms.Label lblTypeContract;
        private System.Windows.Forms.Button btnImport;

    }
}

