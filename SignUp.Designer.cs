namespace ExpensesVisualizer
{
    partial class SignUp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            button1 = new Button();
            cancel = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 32, 31);
            label1.Location = new Point(115, 28);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(29, 32, 31);
            label2.Location = new Point(65, 110);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(29, 32, 31);
            label3.Location = new Point(65, 200);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(29, 32, 31);
            label4.Location = new Point(65, 280);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(65, 130);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(250, 40);
            txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(65, 220);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 40);
            txtPassword.TabIndex = 5;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(65, 300);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(250, 40);
            txtConfirmPassword.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(105, 137, 150);
            button1.ForeColor = Color.White;
            button1.Location = new Point(130, 360);
            button1.Name = "button1";
            button1.Size = new Size(120, 50);
            button1.TabIndex = 7;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cancel
            // 
            cancel.AutoSize = true;
            cancel.ForeColor = Color.FromArgb(29, 32, 31);
            cancel.Location = new Point(170, 416);
            cancel.Name = "cancel";
            cancel.Size = new Size(43, 15);
            cancel.TabIndex = 8;
            cancel.Text = "Cancel";
            cancel.Click += cancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 32, 31);
            panel1.Location = new Point(170, 430);
            panel1.Name = "panel1";
            panel1.Size = new Size(45, 1);
            panel1.TabIndex = 9;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 511);
            Controls.Add(panel1);
            Controls.Add(cancel);
            Controls.Add(button1);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button button1;
        private Label cancel;
        private Panel panel1;
    }
}