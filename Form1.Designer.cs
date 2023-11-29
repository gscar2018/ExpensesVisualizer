namespace ExpensesVisualizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 75);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "LOG IN ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(114, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 1);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(114, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 1);
            panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(114, 130);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 3;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(114, 214);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(130, 331);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "LOG IN ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(130, 373);
            button2.Name = "button2";
            button2.Size = new Size(75, 24);
            button2.TabIndex = 6;
            button2.Text = "SIGN UP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 434);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 7;
            label2.Text = "EXIT";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 480);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}
