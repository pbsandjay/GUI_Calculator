namespace WindowsFormsApplication4
{
    partial class txtboxResult
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
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btEquals = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.btSubtract = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(12, 12);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(199, 20);
            this.tbxResult.TabIndex = 0;
            this.tbxResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(12, 57);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(45, 61);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.NumberClick);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(63, 57);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(41, 61);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.NumberClick);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(110, 57);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(45, 61);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.NumberClick);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(161, 57);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(43, 61);
            this.bt4.TabIndex = 4;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.NumberClick);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(110, 124);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(45, 61);
            this.bt8.TabIndex = 5;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.NumberClick);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(63, 124);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(41, 61);
            this.bt7.TabIndex = 6;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.NumberClick);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(12, 124);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(45, 61);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.NumberClick);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(210, 57);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(41, 61);
            this.bt5.TabIndex = 8;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.NumberClick);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(210, 124);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(41, 61);
            this.bt0.TabIndex = 9;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.NumberClick);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(161, 124);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(43, 61);
            this.bt9.TabIndex = 10;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.NumberClick);
            // 
            // btEquals
            // 
            this.btEquals.Location = new System.Drawing.Point(257, 57);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(45, 209);
            this.btEquals.TabIndex = 11;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.button5_Click);
            // 
            // btMultiply
            // 
            this.btMultiply.Location = new System.Drawing.Point(161, 191);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(43, 75);
            this.btMultiply.TabIndex = 12;
            this.btMultiply.Text = "*";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.btMultiply_Click);
            // 
            // btSubtract
            // 
            this.btSubtract.Location = new System.Drawing.Point(110, 191);
            this.btSubtract.Name = "btSubtract";
            this.btSubtract.Size = new System.Drawing.Size(45, 75);
            this.btSubtract.TabIndex = 13;
            this.btSubtract.Text = "-";
            this.btSubtract.UseVisualStyleBackColor = true;
            this.btSubtract.Click += new System.EventHandler(this.btSubtract_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(63, 191);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(41, 75);
            this.btPlus.TabIndex = 14;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btDivide
            // 
            this.btDivide.Location = new System.Drawing.Point(210, 191);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(41, 75);
            this.btDivide.TabIndex = 15;
            this.btDivide.Text = "/";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(229, 9);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 16;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDecimal
            // 
            this.btDecimal.Location = new System.Drawing.Point(12, 191);
            this.btDecimal.Name = "btDecimal";
            this.btDecimal.Size = new System.Drawing.Size(45, 75);
            this.btDecimal.TabIndex = 17;
            this.btDecimal.Text = ".";
            this.btDecimal.UseVisualStyleBackColor = true;
            this.btDecimal.Click += new System.EventHandler(this.btDecimal_Click);
            // 
            // txtboxResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 267);
            this.Controls.Add(this.btDecimal);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btSubtract);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tbxResult);
            this.Name = "txtboxResult";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.txtboxResult_Load);
            this.Click += new System.EventHandler(this.NumberClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button btSubtract;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDecimal;
    }
}

