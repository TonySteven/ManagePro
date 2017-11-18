namespace StuManage
{
    partial class FrmAddStu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddStu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cobNation = new System.Windows.Forms.ComboBox();
            this.cobClass = new System.Windows.Forms.ComboBox();
            this.cobPolicy = new System.Windows.Forms.ComboBox();
            this.cobGender = new System.Windows.Forms.ComboBox();
            this.txtCardId = new System.Windows.Forms.TextBox();
            this.txtStuNum = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtpBirth);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cobNation);
            this.groupBox1.Controls.Add(this.cobClass);
            this.groupBox1.Controls.Add(this.cobPolicy);
            this.groupBox1.Controls.Add(this.cobGender);
            this.groupBox1.Controls.Add(this.txtCardId);
            this.groupBox1.Controls.Add(this.txtStuNum);
            this.groupBox1.Controls.Add(this.txtStuName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 278);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(351, 95);
            this.textBox4.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(315, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(85, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cobNation
            // 
            this.cobNation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobNation.FormattingEnabled = true;
            this.cobNation.Items.AddRange(new object[] {
            "汉族",
            "满族",
            "蒙古族"});
            this.cobNation.Location = new System.Drawing.Point(85, 219);
            this.cobNation.Name = "cobNation";
            this.cobNation.Size = new System.Drawing.Size(121, 20);
            this.cobNation.TabIndex = 16;
            // 
            // cobClass
            // 
            this.cobClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobClass.FormattingEnabled = true;
            this.cobClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cobClass.Location = new System.Drawing.Point(315, 47);
            this.cobClass.Name = "cobClass";
            this.cobClass.Size = new System.Drawing.Size(121, 20);
            this.cobClass.TabIndex = 15;
            // 
            // cobPolicy
            // 
            this.cobPolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobPolicy.FormattingEnabled = true;
            this.cobPolicy.Items.AddRange(new object[] {
            "民众",
            "团员",
            "党员"});
            this.cobPolicy.Location = new System.Drawing.Point(315, 220);
            this.cobPolicy.Name = "cobPolicy";
            this.cobPolicy.Size = new System.Drawing.Size(121, 20);
            this.cobPolicy.TabIndex = 14;
            // 
            // cobGender
            // 
            this.cobGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobGender.FormattingEnabled = true;
            this.cobGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cobGender.Location = new System.Drawing.Point(85, 162);
            this.cobGender.Name = "cobGender";
            this.cobGender.Size = new System.Drawing.Size(121, 20);
            this.cobGender.TabIndex = 12;
            // 
            // txtCardId
            // 
            this.txtCardId.Location = new System.Drawing.Point(316, 104);
            this.txtCardId.Name = "txtCardId";
            this.txtCardId.Size = new System.Drawing.Size(121, 21);
            this.txtCardId.TabIndex = 11;
            // 
            // txtStuNum
            // 
            this.txtStuNum.Location = new System.Drawing.Point(85, 46);
            this.txtStuNum.Name = "txtStuNum";
            this.txtStuNum.Size = new System.Drawing.Size(121, 21);
            this.txtStuNum.TabIndex = 10;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(85, 104);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(121, 21);
            this.txtStuName.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(12, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "备注:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(240, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "政治面貌:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "民族:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(240, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "出生日期:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "性别:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(240, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "身份证号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "学生名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(240, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "所属班级:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生编号:";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(316, 164);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(120, 21);
            this.dtpBirth.TabIndex = 20;
            this.dtpBirth.Value = new System.DateTime(2016, 9, 23, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAddStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 449);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(485, 488);
            this.MinimumSize = new System.Drawing.Size(485, 488);
            this.Name = "FrmAddStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生添加";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cobNation;
        private System.Windows.Forms.ComboBox cobClass;
        private System.Windows.Forms.ComboBox cobPolicy;
        private System.Windows.Forms.ComboBox cobGender;
        private System.Windows.Forms.TextBox txtCardId;
        private System.Windows.Forms.TextBox txtStuNum;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Button button1;
    }
}