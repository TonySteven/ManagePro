namespace StuManage
{
    partial class FrmStuSelectScope
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStuSelectScope));
            this.dgvSelectScope = new System.Windows.Forms.DataGridView();
            this.StuNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsScope = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmza = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmaz = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectScope)).BeginInit();
            this.cmsScope.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSelectScope
            // 
            this.dgvSelectScope.AllowUserToAddRows = false;
            this.dgvSelectScope.AllowUserToDeleteRows = false;
            this.dgvSelectScope.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectScope.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StuNum,
            this.StuName,
            this.Subject,
            this.Scope,
            this.StuClass});
            this.dgvSelectScope.ContextMenuStrip = this.cmsScope;
            this.dgvSelectScope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectScope.Location = new System.Drawing.Point(0, 0);
            this.dgvSelectScope.Name = "dgvSelectScope";
            this.dgvSelectScope.ReadOnly = true;
            this.dgvSelectScope.RowTemplate.Height = 23;
            this.dgvSelectScope.Size = new System.Drawing.Size(556, 508);
            this.dgvSelectScope.TabIndex = 0;
            // 
            // StuNum
            // 
            this.StuNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StuNum.DataPropertyName = "id";
            this.StuNum.HeaderText = "学生编号";
            this.StuNum.Name = "StuNum";
            this.StuNum.ReadOnly = true;
            // 
            // StuName
            // 
            this.StuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StuName.DataPropertyName = "name";
            this.StuName.HeaderText = "学生姓名";
            this.StuName.Name = "StuName";
            this.StuName.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.DataPropertyName = "subject";
            this.Subject.HeaderText = "科目";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Scope
            // 
            this.Scope.DataPropertyName = "scope";
            this.Scope.HeaderText = "考试分数";
            this.Scope.Name = "Scope";
            this.Scope.ReadOnly = true;
            // 
            // StuClass
            // 
            this.StuClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StuClass.DataPropertyName = "Class";
            this.StuClass.HeaderText = "班级";
            this.StuClass.Name = "StuClass";
            this.StuClass.ReadOnly = true;
            // 
            // cmsScope
            // 
            this.cmsScope.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRefresh,
            this.tsmaz,
            this.tsmza});
            this.cmsScope.Name = "cmsClasses";
            this.cmsScope.Size = new System.Drawing.Size(153, 92);
            // 
            // tsmRefresh
            // 
            this.tsmRefresh.Image = global::StuManage.Properties.Resources.refresh;
            this.tsmRefresh.Name = "tsmRefresh";
            this.tsmRefresh.Size = new System.Drawing.Size(152, 22);
            this.tsmRefresh.Text = "刷新";
            this.tsmRefresh.Click += new System.EventHandler(this.tsmRefresh_Click);
            // 
            // tsmza
            // 
            this.tsmza.Image = global::StuManage.Properties.Resources.z_a;
            this.tsmza.Name = "tsmza";
            this.tsmza.Size = new System.Drawing.Size(152, 22);
            this.tsmza.Text = "降序";
            this.tsmza.Click += new System.EventHandler(this.tsmza_Click);
            // 
            // tsmaz
            // 
            this.tsmaz.Image = global::StuManage.Properties.Resources.a_z;
            this.tsmaz.Name = "tsmaz";
            this.tsmaz.Size = new System.Drawing.Size(152, 22);
            this.tsmaz.Text = "升序";
            this.tsmaz.Click += new System.EventHandler(this.tsmaz_Click);
            // 
            // FrmStuSelectScope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 508);
            this.Controls.Add(this.dgvSelectScope);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStuSelectScope";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩查询";
            this.Load += new System.EventHandler(this.FrmStuSelectScope_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectScope)).EndInit();
            this.cmsScope.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectScope;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scope;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuClass;
        private System.Windows.Forms.ContextMenuStrip cmsScope;
        private System.Windows.Forms.ToolStripMenuItem tsmRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsmaz;
        private System.Windows.Forms.ToolStripMenuItem tsmza;
    }
}