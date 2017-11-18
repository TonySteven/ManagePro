namespace StuManage
{
    partial class FrmClassStuManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClassStuManage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbreFresh = new System.Windows.Forms.ToolStripButton();
            this.dgvClassManage = new System.Windows.Forms.DataGridView();
            this.ClassNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subjuct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsClasses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassManage)).BeginInit();
            this.cmsClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbCancel,
            this.tsbAdd,
            this.tsbreFresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "保存";
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
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancel.Image = global::StuManage.Properties.Resources.cancel;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(23, 22);
            this.tsbCancel.Text = "删除";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::StuManage.Properties.Resources.ADD;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "添加";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbreFresh
            // 
            this.tsbreFresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbreFresh.Image = global::StuManage.Properties.Resources.refresh;
            this.tsbreFresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbreFresh.Name = "tsbreFresh";
            this.tsbreFresh.Size = new System.Drawing.Size(23, 22);
            this.tsbreFresh.Text = "刷新";
            this.tsbreFresh.Click += new System.EventHandler(this.tsbreFresh_Click);
            // 
            // dgvClassManage
            // 
            this.dgvClassManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassNum,
            this.ClassName,
            this.ClassTeacher,
            this.Subjuct});
            this.dgvClassManage.ContextMenuStrip = this.cmsClasses;
            this.dgvClassManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClassManage.Location = new System.Drawing.Point(0, 25);
            this.dgvClassManage.Name = "dgvClassManage";
            this.dgvClassManage.RowTemplate.Height = 23;
            this.dgvClassManage.Size = new System.Drawing.Size(648, 484);
            this.dgvClassManage.TabIndex = 1;
            this.dgvClassManage.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassManage_CellEndEdit);
            // 
            // ClassNum
            // 
            this.ClassNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassNum.DataPropertyName = "id";
            this.ClassNum.HeaderText = "班级编号";
            this.ClassNum.Name = "ClassNum";
            this.ClassNum.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassName.DataPropertyName = "name";
            this.ClassName.HeaderText = "班级名称";
            this.ClassName.Name = "ClassName";
            // 
            // ClassTeacher
            // 
            this.ClassTeacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassTeacher.DataPropertyName = "HeadTeacher";
            this.ClassTeacher.HeaderText = "班主任";
            this.ClassTeacher.Name = "ClassTeacher";
            // 
            // Subjuct
            // 
            this.Subjuct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subjuct.DataPropertyName = "MajorID";
            this.Subjuct.HeaderText = "所属专业";
            this.Subjuct.Name = "Subjuct";
            // 
            // cmsClasses
            // 
            this.cmsClasses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSave,
            this.tsmDelete,
            this.tsmAdd,
            this.tsmRefresh});
            this.cmsClasses.Name = "cmsClasses";
            this.cmsClasses.Size = new System.Drawing.Size(101, 92);
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
            // tsmAdd
            // 
            this.tsmAdd.Image = global::StuManage.Properties.Resources.ADD;
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(100, 22);
            this.tsmAdd.Text = "添加";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // tsmRefresh
            // 
            this.tsmRefresh.Image = global::StuManage.Properties.Resources.refresh;
            this.tsmRefresh.Name = "tsmRefresh";
            this.tsmRefresh.Size = new System.Drawing.Size(100, 22);
            this.tsmRefresh.Text = "刷新";
            this.tsmRefresh.Click += new System.EventHandler(this.tsmRefresh_Click);
            // 
            // FrmClassStuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 509);
            this.Controls.Add(this.dgvClassManage);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClassStuManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "班级管理";
            this.Load += new System.EventHandler(this.FrmClassStuManage_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmClassStuManage_KeyPress);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassManage)).EndInit();
            this.cmsClasses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.DataGridView dgvClassManage;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbreFresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subjuct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNum;
        private System.Windows.Forms.ContextMenuStrip cmsClasses;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmRefresh;
    }
}