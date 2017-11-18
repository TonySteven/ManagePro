namespace StuManage
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMainInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClassManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSubjectManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tspstuInfoManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmscorpinput = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmscorpselect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmcascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmArrange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.Horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssAdminName = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSystem,
            this.tsmMainInfo,
            this.tsmStuManage,
            this.tsmWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSystem
            // 
            this.tsmSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuit});
            this.tsmSystem.Name = "tsmSystem";
            this.tsmSystem.Size = new System.Drawing.Size(44, 21);
            this.tsmSystem.Text = "系统";
            // 
            // tsmQuit
            // 
            this.tsmQuit.Name = "tsmQuit";
            this.tsmQuit.Size = new System.Drawing.Size(152, 22);
            this.tsmQuit.Text = "退出";
            this.tsmQuit.Click += new System.EventHandler(this.tsmQuit_Click);
            // 
            // tsmMainInfo
            // 
            this.tsmMainInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProManage,
            this.tsmClassManage,
            this.tsmSubjectManage});
            this.tsmMainInfo.Name = "tsmMainInfo";
            this.tsmMainInfo.Size = new System.Drawing.Size(68, 21);
            this.tsmMainInfo.Text = "基本信息";
            // 
            // tsmProManage
            // 
            this.tsmProManage.Name = "tsmProManage";
            this.tsmProManage.Size = new System.Drawing.Size(152, 22);
            this.tsmProManage.Text = "专业管理";
            this.tsmProManage.Click += new System.EventHandler(this.tsmProManage_Click);
            // 
            // tsmClassManage
            // 
            this.tsmClassManage.Name = "tsmClassManage";
            this.tsmClassManage.Size = new System.Drawing.Size(152, 22);
            this.tsmClassManage.Text = "班级管理";
            this.tsmClassManage.Click += new System.EventHandler(this.tsmClassManage_Click);
            // 
            // tsmSubjectManage
            // 
            this.tsmSubjectManage.Name = "tsmSubjectManage";
            this.tsmSubjectManage.Size = new System.Drawing.Size(152, 22);
            this.tsmSubjectManage.Text = "课程管理";
            this.tsmSubjectManage.Click += new System.EventHandler(this.tsmSubjectManage_Click);
            // 
            // tsmStuManage
            // 
            this.tsmStuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspstuInfoManage,
            this.tsmscorpinput,
            this.tsmscorpselect});
            this.tsmStuManage.Name = "tsmStuManage";
            this.tsmStuManage.Size = new System.Drawing.Size(68, 21);
            this.tsmStuManage.Text = "学籍管理";
            // 
            // tspstuInfoManage
            // 
            this.tspstuInfoManage.Name = "tspstuInfoManage";
            this.tspstuInfoManage.Size = new System.Drawing.Size(148, 22);
            this.tspstuInfoManage.Text = "学生信息管理";
            this.tspstuInfoManage.Click += new System.EventHandler(this.tspstuInfoManage_Click);
            // 
            // tsmscorpinput
            // 
            this.tsmscorpinput.Name = "tsmscorpinput";
            this.tsmscorpinput.Size = new System.Drawing.Size(148, 22);
            this.tsmscorpinput.Text = "成绩录入";
            this.tsmscorpinput.Click += new System.EventHandler(this.tsmscorpinput_Click);
            // 
            // tsmscorpselect
            // 
            this.tsmscorpselect.Name = "tsmscorpselect";
            this.tsmscorpselect.Size = new System.Drawing.Size(148, 22);
            this.tsmscorpselect.Text = "成绩查询";
            this.tsmscorpselect.Click += new System.EventHandler(this.tsmscorpselect_Click);
            // 
            // tsmWindow
            // 
            this.tsmWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmcascade,
            this.tsmArrange,
            this.tsmVertical,
            this.Horizontal});
            this.tsmWindow.Name = "tsmWindow";
            this.tsmWindow.Size = new System.Drawing.Size(44, 21);
            this.tsmWindow.Text = "窗口";
            // 
            // tsmcascade
            // 
            this.tsmcascade.Name = "tsmcascade";
            this.tsmcascade.Size = new System.Drawing.Size(100, 22);
            this.tsmcascade.Text = "层叠";
            this.tsmcascade.Click += new System.EventHandler(this.tsmcascade_Click);
            // 
            // tsmArrange
            // 
            this.tsmArrange.Name = "tsmArrange";
            this.tsmArrange.Size = new System.Drawing.Size(100, 22);
            this.tsmArrange.Text = "排列";
            this.tsmArrange.Click += new System.EventHandler(this.tsmArrange_Click);
            // 
            // tsmVertical
            // 
            this.tsmVertical.Name = "tsmVertical";
            this.tsmVertical.Size = new System.Drawing.Size(100, 22);
            this.tsmVertical.Text = "垂直";
            this.tsmVertical.Click += new System.EventHandler(this.tsmVertical_Click);
            // 
            // Horizontal
            // 
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(100, 22);
            this.Horizontal.Text = "水平";
            this.Horizontal.Click += new System.EventHandler(this.Horizontal_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssAdminName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssAdminName
            // 
            this.tssAdminName.Name = "tssAdminName";
            this.tssAdminName.Size = new System.Drawing.Size(59, 17);
            this.tssAdminName.Text = "当前用户:";
            this.tssAdminName.Click += new System.EventHandler(this.tssAdminName_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 583);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学籍管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmMainInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmStuManage;
        private System.Windows.Forms.ToolStripMenuItem tsmWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmProManage;
        private System.Windows.Forms.ToolStripMenuItem tsmClassManage;
        private System.Windows.Forms.ToolStripMenuItem tsmSubjectManage;
        private System.Windows.Forms.ToolStripMenuItem tspstuInfoManage;
        private System.Windows.Forms.ToolStripMenuItem tsmscorpinput;
        private System.Windows.Forms.ToolStripMenuItem tsmscorpselect;
        private System.Windows.Forms.ToolStripMenuItem tsmcascade;
        private System.Windows.Forms.ToolStripMenuItem tsmArrange;
        private System.Windows.Forms.ToolStripMenuItem tsmVertical;
        private System.Windows.Forms.ToolStripMenuItem Horizontal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssAdminName;
    }
}

