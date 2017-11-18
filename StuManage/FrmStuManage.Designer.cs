namespace StuManage
{
    partial class FrmStuManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStuManage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbnew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbSortAsc = new System.Windows.Forms.ToolStripButton();
            this.tsbSortDesc = new System.Windows.Forms.ToolStripButton();
            this.dgvStuManage = new System.Windows.Forms.DataGridView();
            this.stunun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stusex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stupolicy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stufolk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsStuManager = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmaz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmza = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuManage)).BeginInit();
            this.cmsStuManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbnew,
            this.tsbSave,
            this.tsbDelete,
            this.tsbRefresh,
            this.tsbSortAsc,
            this.tsbSortDesc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(551, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbnew
            // 
            this.tsbnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbnew.Image = global::StuManage.Properties.Resources._new;
            this.tsbnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbnew.Name = "tsbnew";
            this.tsbnew.Size = new System.Drawing.Size(23, 22);
            this.tsbnew.Text = "toolStripButton1";
            this.tsbnew.Click += new System.EventHandler(this.tsbnew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::StuManage.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "toolStripButton1";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::StuManage.Properties.Resources.cancel;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "toolStripButton2";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = global::StuManage.Properties.Resources.refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "toolStripButton3";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbSortAsc
            // 
            this.tsbSortAsc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSortAsc.Image = global::StuManage.Properties.Resources.a_z;
            this.tsbSortAsc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSortAsc.Name = "tsbSortAsc";
            this.tsbSortAsc.Size = new System.Drawing.Size(23, 22);
            this.tsbSortAsc.Text = "toolStripButton1";
            this.tsbSortAsc.Click += new System.EventHandler(this.tsbSortAsc_Click);
            // 
            // tsbSortDesc
            // 
            this.tsbSortDesc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSortDesc.Image = global::StuManage.Properties.Resources.z_a;
            this.tsbSortDesc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSortDesc.Name = "tsbSortDesc";
            this.tsbSortDesc.Size = new System.Drawing.Size(23, 22);
            this.tsbSortDesc.Text = "toolStripButton2";
            this.tsbSortDesc.Click += new System.EventHandler(this.tsbSortDesc_Click);
            // 
            // dgvStuManage
            // 
            this.dgvStuManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stunun,
            this.stuname,
            this.stusex,
            this.stupolicy,
            this.stufolk,
            this.stuclass});
            this.dgvStuManage.ContextMenuStrip = this.cmsStuManager;
            this.dgvStuManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStuManage.Location = new System.Drawing.Point(0, 25);
            this.dgvStuManage.Name = "dgvStuManage";
            this.dgvStuManage.RowTemplate.Height = 23;
            this.dgvStuManage.Size = new System.Drawing.Size(551, 414);
            this.dgvStuManage.TabIndex = 1;
            // 
            // stunun
            // 
            this.stunun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stunun.DataPropertyName = "id";
            this.stunun.HeaderText = "学生编号";
            this.stunun.Name = "stunun";
            // 
            // stuname
            // 
            this.stuname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stuname.DataPropertyName = "name";
            this.stuname.HeaderText = "学生姓名";
            this.stuname.Name = "stuname";
            // 
            // stusex
            // 
            this.stusex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stusex.DataPropertyName = "sex";
            this.stusex.HeaderText = "性别";
            this.stusex.Name = "stusex";
            // 
            // stupolicy
            // 
            this.stupolicy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stupolicy.DataPropertyName = "policy";
            this.stupolicy.HeaderText = "政治面貌";
            this.stupolicy.Name = "stupolicy";
            // 
            // stufolk
            // 
            this.stufolk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stufolk.DataPropertyName = "nation";
            this.stufolk.HeaderText = "民族";
            this.stufolk.Name = "stufolk";
            // 
            // stuclass
            // 
            this.stuclass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stuclass.DataPropertyName = "classid";
            this.stuclass.HeaderText = "所属班级";
            this.stuclass.Name = "stuclass";
            // 
            // cmsStuManager
            // 
            this.cmsStuManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.tsmSave,
            this.tsmDelete,
            this.tsmRefresh,
            this.tsmaz,
            this.tsmza});
            this.cmsStuManager.Name = "cmsClasses";
            this.cmsStuManager.Size = new System.Drawing.Size(101, 136);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Image = global::StuManage.Properties.Resources._new;
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(100, 22);
            this.tsmAdd.Text = "添加";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
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
            this.tsmRefresh.Click += new System.EventHandler(this.tsmRefresh_Click);
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
            // FrmStuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 439);
            this.Controls.Add(this.dgvStuManage);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmStuManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "学生管理";
            this.Load += new System.EventHandler(this.FrmStuManage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuManage)).EndInit();
            this.cmsStuManager.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.DataGridView dgvStuManage;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbSortAsc;
        private System.Windows.Forms.ToolStripButton tsbSortDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunun;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stusex;
        private System.Windows.Forms.DataGridViewTextBoxColumn stupolicy;
        private System.Windows.Forms.DataGridViewTextBoxColumn stufolk;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuclass;
        private System.Windows.Forms.ToolStripButton tsbnew;
        private System.Windows.Forms.ContextMenuStrip cmsStuManager;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsmaz;
        private System.Windows.Forms.ToolStripMenuItem tsmza;
    }
}