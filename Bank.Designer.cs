namespace BankService
{
    partial class Bank
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_check = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_C);
            this.groupBox1.Controls.Add(this.btn_B);
            this.groupBox1.Controls.Add(this.btn_A);
            this.groupBox1.Location = new System.Drawing.Point(53, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(71, 188);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(75, 23);
            this.btn_C.TabIndex = 0;
            this.btn_C.Text = "Credit";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.Btn_C_Click);
            // 
            // btn_B
            // 
            this.btn_B.Location = new System.Drawing.Point(71, 117);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(75, 23);
            this.btn_B.TabIndex = 0;
            this.btn_B.Text = "Bill ";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.Btn_B_Click);
            // 
            // btn_A
            // 
            this.btn_A.Location = new System.Drawing.Point(71, 49);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(75, 23);
            this.btn_A.TabIndex = 0;
            this.btn_A.Text = "Account";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.Btn_A_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(502, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 266);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bank";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(78, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Servises";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_check
            // 
            this.lbl_check.AutoSize = true;
            this.lbl_check.Location = new System.Drawing.Point(53, 369);
            this.lbl_check.Name = "lbl_check";
            this.lbl_check.Size = new System.Drawing.Size(0, 13);
            this.lbl_check.TabIndex = 1;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(499, 369);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(0, 13);
            this.lbl_user.TabIndex = 1;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_check);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bank";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_check;
        private System.Windows.Forms.Label lbl_user;
    }
}

