namespace ExpensesVisualizer
{
    partial class Menu
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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(105, 137, 150);
            button1.ForeColor = Color.White;
            button1.Location = new Point(235, 62);
            button1.Name = "button1";
            button1.Size = new Size(321, 62);
            button1.TabIndex = 0;
            button1.Text = "Enter Expenses Information";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(105, 137, 150);
            button3.ForeColor = Color.White;
            button3.Location = new Point(235, 176);
            button3.Name = "button3";
            button3.Size = new Size(321, 62);
            button3.TabIndex = 2;
            button3.Text = "Edit Expenses";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(105, 137, 150);
            button4.ForeColor = Color.White;
            button4.Location = new Point(235, 296);
            button4.Name = "button4";
            button4.Size = new Size(321, 62);
            button4.TabIndex = 3;
            button4.Text = "View Chart";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}