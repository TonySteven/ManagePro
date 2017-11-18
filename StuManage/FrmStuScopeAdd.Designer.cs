namespace StuManage
{
    partial class FrmStuScopeAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStuScopeAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEntering = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvStuScopeAdd = new System.Windows.Forms.DataGridView();
            this.StuNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuScope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuScopeAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEntering);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.cboSubject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnEntering
            // 
            this.btnEntering.Location = new System.Drawing.Point(399, 26);
            this.btnEntering.Name = "btnEntering";
            this.btnEntering.Size = new System.Drawing.Size(75, 23);
            this.btnEntering.TabIndex = 2;
            this.btnEntering.Text = "刷新";
            this.btnEntering.UseVisualStyleBackColor = true;
            this.btnEntering.Click += new System.EventHandler(this.btnEntering_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(480, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(75, 25);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(121, 20);
            this.cboClass.TabIndex = 2;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // cboSubject
            // 
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(257, 25);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(121, 20);
            this.cboSubject.Sorted = true;
            this.cboSubject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(202, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "科目:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级:";
            // 
            // dgvStuScopeAdd
            // 
            this.dgvStuScopeAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuScopeAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuNum,
            this.StuName,
            this.StuScope});
            this.dgvStuScopeAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStuScopeAdd.Location = new System.Drawing.Point(0, 68);
            this.dgvStuScopeAdd.Name = "dgvStuScopeAdd";
            this.dgvStuScopeAdd.RowTemplate.Height = 23;
            this.dgvStuScopeAdd.Size = new System.Drawing.Size(561, 408);
            this.dgvStuScopeAdd.TabIndex = 1;
            // 
            // StuNum
            // 
            this.StuNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StuNum.DataPropertyName = "id";
            this.StuNum.HeaderText = "学生编号";
            this.StuNum.Name = "StuNum";
            // 
            // StuName
            // 
            this.StuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StuName.DataPropertyName = "name";
            this.StuName.HeaderText = "学生姓名";
            this.StuName.Name = "StuName";
            // 
            // StuScope
            // 
            this.StuScope.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StuScope.DataPropertyName = "scope";
            this.StuScope.HeaderText = "学生分数";
            this.StuScope.Name = "StuScope";
            // 
            // FrmStuScopeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 476);
            this.Controls.Add(this.dgvStuScopeAdd);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStuScopeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩查询";
            this.Load += new System.EventHandler(this.FrmStuScopeAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuScopeAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEntering;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvStuScopeAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuScope;
    }
}