namespace Create_CSV
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtempName = new System.Windows.Forms.TextBox();
            this.txtempID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnfirstvalue = new System.Windows.Forms.Button();
            this.btnspectvalu = new System.Windows.Forms.Button();
            this.txtcond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Populate CSV Values";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(221, 160);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 14;
            // 
            // txtempName
            // 
            this.txtempName.Location = new System.Drawing.Point(221, 119);
            this.txtempName.Name = "txtempName";
            this.txtempName.Size = new System.Drawing.Size(100, 20);
            this.txtempName.TabIndex = 13;
            // 
            // txtempID
            // 
            this.txtempID.Location = new System.Drawing.Point(221, 80);
            this.txtempID.Name = "txtempID";
            this.txtempID.Size = new System.Drawing.Size(100, 20);
            this.txtempID.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Employee Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Employee ID";
            // 
            // btnfirstvalue
            // 
            this.btnfirstvalue.Location = new System.Drawing.Point(443, 76);
            this.btnfirstvalue.Name = "btnfirstvalue";
            this.btnfirstvalue.Size = new System.Drawing.Size(75, 23);
            this.btnfirstvalue.TabIndex = 15;
            this.btnfirstvalue.Text = "Value";
            this.btnfirstvalue.UseVisualStyleBackColor = true;
            this.btnfirstvalue.Click += new System.EventHandler(this.btnfirstvalue_Click);
            // 
            // btnspectvalu
            // 
            this.btnspectvalu.Location = new System.Drawing.Point(443, 126);
            this.btnspectvalu.Name = "btnspectvalu";
            this.btnspectvalu.Size = new System.Drawing.Size(75, 23);
            this.btnspectvalu.TabIndex = 16;
            this.btnspectvalu.Text = "Spec Value";
            this.btnspectvalu.UseVisualStyleBackColor = true;
            this.btnspectvalu.Click += new System.EventHandler(this.btnspectvalu_Click);
            // 
            // txtcond
            // 
            this.txtcond.Location = new System.Drawing.Point(571, 129);
            this.txtcond.Name = "txtcond";
            this.txtcond.Size = new System.Drawing.Size(100, 20);
            this.txtcond.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 218);
            this.Controls.Add(this.txtcond);
            this.Controls.Add(this.btnspectvalu);
            this.Controls.Add(this.btnfirstvalue);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtempName);
            this.Controls.Add(this.txtempID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtempName;
        private System.Windows.Forms.TextBox txtempID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnfirstvalue;
        private System.Windows.Forms.Button btnspectvalu;
        private System.Windows.Forms.TextBox txtcond;
    }
}