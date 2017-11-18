namespace StuManage
{
    partial class FrmSubjectManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubjectManage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbSortAsc = new System.Windows.Forms.ToolStripButton();
            this.tsbSortDesc = new System.Windows.Forms.ToolStripButton();
            this.dgvSubjectManage = new System.Windows.Forms.DataGridView();
            this.subjectNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsSubject = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmaz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmza = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectManage)).BeginInit();
            this.cmsSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbDelete,
            this.tsbRefresh,
            this.tsbSortAsc,
            this.tsbSortDesc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(407, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::StuManage.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::StuManage.Properties.Resources.cancel;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::StuManage.Properties.Resources.refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "刷新";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbSortAsc
            // 
            this.tsbSortAsc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSortAsc.Image = global::StuManage.Properties.Resources.a_z;
            this.tsbSortAsc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSortAsc.Name = "tsbSortAsc";
            this.tsbSortAsc.Size = new System.Drawing.Size(23, 22);
            this.tsbSortAsc.Text = "升序";
            this.tsbSortAsc.Click += new System.EventHandler(this.tsbSortAsc_Click);
            // 
            // tsbSortDesc
            // 
            this.tsbSortDesc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSortDesc.Image = global::StuManage.Properties.Resources.z_a;
            this.tsbSortDesc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSortDesc.Name = "tsbSortDesc";
            this.tsbSortDesc.Size = new System.Drawing.Size(23, 22);
            this.tsbSortDesc.Text = "降序";
            this.tsbSortDesc.Click += new System.EventHandler(this.tsbSortDesc_Click);
            // 
            // dgvSubjectManage
            // 
            this.dgvSubjectManage.AllowDrop = true;
            this.dgvSubjectManage.AllowUserToOrderColumns = true;
            this.dgvSubjectManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectNum,
            this.SubjectName});
            this.dgvSubjectManage.ContextMenuStrip = this.cmsSubject;
            this.dgvSubjectManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubjectManage.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvSubjectManage.Location = new System.Drawing.Point(0, 25);
            this.dgvSubjectManage.Name = "dgvSubjectManage";
            this.dgvSubjectManage.RowTemplate.Height = 23;
            this.dgvSubjectManage.Size = new System.Drawing.Size(407, 326);
            this.dgvSubjectManage.TabIndex = 1;
            // 
            // subjectNum
            // 
            this.subjectNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectNum.DataPropertyName = "id";
            this.subjectNum.HeaderText = "科目编号";
            this.subjectNum.Name = "subjectNum";
            // 
            // SubjectName
            // 
            this.SubjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubjectName.DataPropertyName = "name";
            this.SubjectName.HeaderText = "科目名称";
            this.SubjectName.Name = "SubjectName";
            // 
            // cmsSubject
            // 
            this.cmsSubject.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSave,
            this.tsmDelete,
            this.tsmRefresh,
            this.tsmaz,
            this.tsmza});
            this.cmsSubject.Name = "cmsClasses";
            this.cmsSubject.Size = new System.Drawing.Size(101, 114);
            // 
            // tsmSave
            // 
            this.tsmSave.Image = global::StuManage.Properties.Resources.save;
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(100, 22);
            this.tsmSave.Text = "保存";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::StuManage.Properties.Resources.cancel;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmDelete.Text = "删除";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmRefresh
            // 
            this.tsmRefresh.Image = global::StuManage.Properties.Resources.refresh;
            this.tsmRefresh.Name = "tsmRefresh";
            this.tsmRefresh.Size = new System.Drawing.Size(100, 22);
            this.tsmRefresh.Text = "刷新";
            // 
            // tsmaz
            // 
            this.tsmaz.Image = global::StuManage.Properties.Resources.a_z;
            this.tsmaz.Name = "tsmaz";
            this.tsmaz.Size = new System.Drawing.Size(100, 22);
            this.tsmaz.Text = "升序";
            this.tsmaz.Click += new System.EventHandler(this.tsmaz_Click);
            // 
            // tsmza
            // 
            this.tsmza.Image = global::StuManage.Properties.Resources.z_a;
            this.tsmza.Name = "tsmza";
            this.tsmza.Size = new System.Drawing.Size(100, 22);
            this.tsmza.Text = "降序";
            this.tsmza.Click += new System.EventHandler(this.tsmza_Click);
            // 
            // FrmSubjectManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 351);
            this.Controls.Add(this.dgvSubjectManage);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSubjectManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程管理";
            this.Load += new System.EventHandler(this.FrmSubjectManage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectManage)).EndInit();
            this.cmsSubject.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.DataGridView dgvSubjectManage;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbSortAsc;
        private System.Windows.Forms.ToolStripButton tsbSortDesc;
        private System.Windows.Forms.ContextMenuStrip cmsSubject;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsmaz;
        private System.Windows.Forms.ToolStripMenuItem tsmza;
    }
}