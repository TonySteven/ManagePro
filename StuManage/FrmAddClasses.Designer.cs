namespace StuManage
{
    partial class FrmAddClasses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddClasses));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtHeadTeacher = new System.Windows.Forms.TextBox();
            this.cboMajorin = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddCNum = new System.Windows.Forms.TextBox();
            this.labClassNum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "班级名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(42, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "班主任:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(26, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "所属专业:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(111, 60);
            this.txtClassName.MaxLength = 50;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 21);
            this.txtClassName.TabIndex = 6;
            // 
            // txtHeadTeacher
            // 
            this.txtHeadTeacher.Location = new System.Drawing.Point(111, 95);
            this.txtHeadTeacher.MaxLength = 50;
            this.txtHeadTeacher.Name = "txtHeadTeacher";
            this.txtHeadTeacher.Size = new System.Drawing.Size(100, 21);
            this.txtHeadTeacher.TabIndex = 7;
            // 
            // cboMajorin
            // 
            this.cboMajorin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMajorin.FormattingEnabled = true;
            this.cboMajorin.Items.AddRange(new object[] {
            "语文",
            "数学",
            "英语",
            "化学",
            "物理",
            "生物",
            "地理",
            "政治",
            "历史",
            "音乐",
            "体育"});
            this.cboMajorin.Location = new System.Drawing.Point(111, 136);
            this.cboMajorin.Name = "cboMajorin";
            this.cboMajorin.Size = new System.Drawing.Size(121, 20);
            this.cboMajorin.TabIndex = 8;
            this.cboMajorin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(30, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(157, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddCNum);
            this.groupBox1.Controls.Add(this.labClassNum);
            this.groupBox1.Controls.Add(this.txtClassName);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboMajorin);
            this.groupBox1.Controls.Add(this.txtHeadTeacher);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 266);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtAddCNum
            // 
            this.txtAddCNum.Location = new System.Drawing.Point(111, 29);
            this.txtAddCNum.MaxLength = 50;
            this.txtAddCNum.Name = "txtAddCNum";
            this.txtAddCNum.Size = new System.Drawing.Size(100, 21);
            this.txtAddCNum.TabIndex = 12;
            // 
            // labClassNum
            // 
            this.labClassNum.AutoSize = true;
            this.labClassNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labClassNum.Location = new System.Drawing.Point(26, 28);
            this.labClassNum.Name = "labClassNum";
            this.labClassNum.Size = new System.Drawing.Size(79, 22);
            this.labClassNum.TabIndex = 11;
            this.labClassNum.Text = "班级编号:";
            // 
            // FrmAddClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 266);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(289, 305);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(289, 305);
            this.Name = "FrmAddClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加班级";
            this.Load += new System.EventHandler(this.FrmAddClasses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtHeadTeacher;
        private System.Windows.Forms.ComboBox cboMajorin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddCNum;
        private System.Windows.Forms.Label labClassNum;
    }
}