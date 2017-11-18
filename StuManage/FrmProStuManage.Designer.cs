namespace StuManage
{
    partial class FrmProStuManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProStuManage));
            this.dgvProstumanage = new System.Windows.Forms.DataGridView();
            this.ProNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.专业名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.cmsProstu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRefresh = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstumanage)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.cmsProstu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProstumanage
            // 
            this.dgvProstumanage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProstumanage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProstumanage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProNum,
            this.专业名称});
            this.dgvProstumanage.ContextMenuStrip = this.cmsProstu;
            this.dgvProstumanage.Location = new System.Drawing.Point(0, 28);
            this.dgvProstumanage.Name = "dgvProstumanage";
            this.dgvProstumanage.RowTemplate.Height = 23;
            this.dgvProstumanage.Size = new System.Drawing.Size(441, 336);
            this.dgvProstumanage.TabIndex = 0;
            // 
            // ProNum
            // 
            this.ProNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProNum.DataPropertyName = "id";
            this.ProNum.FillWeight = 500F;
            this.ProNum.HeaderText = "专业标号";
            this.ProNum.Name = "ProNum";
            this.ProNum.ToolTipText = "专业标号";
            // 
            // 专业名称
            // 
            this.专业名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.专业名称.DataPropertyName = "name";
            this.专业名称.FillWeight = 500F;
            this.专业名称.HeaderText = "专业名称";
            this.专业名称.Name = "专业名称";
            this.专业名称.ToolTipText = "专业名称";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbDelete,
            this.tsbRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(441, 25);
            this.toolStrip1.TabIndex = 1;
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
            // cmsProstu
            // 
            this.cmsProstu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSave,
            this.tsmDelete,
            this.tsmRefresh});
            this.cmsProstu.Name = "cmsClasses";
            this.cmsProstu.Size = new System.Drawing.Size(153, 92);
            // 
            // tsmSave
            // 
            this.tsmSave.Image = global::StuManage.Properties.Resources.save;
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(152, 22);
            this.tsmSave.Text = "保存";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::StuManage.Properties.Resources.cancel;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(152, 22);
            this.tsmDelete.Text = "删除";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmRefresh
            // 
            this.tsmRefresh.Image = global::StuManage.Properties.Resources.refresh;
            this.tsmRefresh.Name = "tsmRefresh";
            this.tsmRefresh.Size = new System.Drawing.Size(152, 22);
            this.tsmRefresh.Text = "刷新";
            this.tsmRefresh.Click += new System.EventHandler(this.tsmRefresh_Click);
            // 
            // FrmProStuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 366);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvProstumanage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProStuManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "专业管理";
            this.Load += new System.EventHandler(this.FrmProStuManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstumanage)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.cmsProstu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProstumanage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProNum;
        private System.Windows.Forms.ContextMenuStrip cmsProstu;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmRefresh;
    }
}