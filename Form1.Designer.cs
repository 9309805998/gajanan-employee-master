namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt04 = new System.Windows.Forms.TextBox();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(59, 41);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(67, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Employee ID";
            // 
            // txt01
            // 
            this.txt01.Location = new System.Drawing.Point(173, 41);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(149, 20);
            this.txt01.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(56, 91);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(84, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Employee Name";
            // 
            // txt02
            // 
            this.txt02.Location = new System.Drawing.Point(173, 83);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(149, 20);
            this.txt02.TabIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(53, 134);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(112, 13);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Employee Designation";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "CEO",
            "HR Manager",
            "Jr. HR",
            "Manager",
            "Jr. Manager",
            "Sr. Developer",
            "Jr. Developer",
            "Accountant"});
            this.listBox1.Location = new System.Drawing.Point(173, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 17);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Master";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(59, 168);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(85, 13);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Employee Salary";
            // 
            // txt04
            // 
            this.txt04.Location = new System.Drawing.Point(173, 168);
            this.txt04.Name = "txt04";
            this.txt04.Size = new System.Drawing.Size(149, 20);
            this.txt04.TabIndex = 8;
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(173, 222);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(75, 23);
            this.btn01.TabIndex = 9;
            this.btn01.Text = "Save";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(279, 222);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(75, 23);
            this.btn02.TabIndex = 10;
            this.btn02.Text = "Delete";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.txt04);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt02);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt01);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Designation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt02;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt04;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
    }
}

