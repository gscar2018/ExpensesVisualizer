namespace ExpensesVisualizer
{
    partial class PieChartGenerator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ThisMonthyExpense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            YearlyExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            yearlyTotalExpensesLabel = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)ThisMonthyExpense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YearlyExpenses).BeginInit();
            SuspendLayout();
            // 
            // ThisMonthyExpense
            // 
            chartArea1.Name = "ChartArea1";
            ThisMonthyExpense.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ThisMonthyExpense.Legends.Add(legend1);
            ThisMonthyExpense.Location = new Point(12, 61);
            ThisMonthyExpense.Name = "ThisMonthyExpense";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ThisMonthyExpense.Series.Add(series1);
            ThisMonthyExpense.Size = new Size(387, 342);
            ThisMonthyExpense.TabIndex = 1;
            ThisMonthyExpense.Text = "chart1";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(105, 137, 150);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // YearlyExpenses
            // 
            chartArea2.Name = "ChartArea1";
            YearlyExpenses.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            YearlyExpenses.Legends.Add(legend2);
            YearlyExpenses.Location = new Point(401, 61);
            YearlyExpenses.Name = "YearlyExpenses";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            YearlyExpenses.Series.Add(series2);
            YearlyExpenses.Size = new Size(387, 342);
            YearlyExpenses.TabIndex = 3;
            YearlyExpenses.Text = "chart2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 37);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 4;
            label1.Text = "Monthly";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(559, 37);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 5;
            label2.Text = "Yearly";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(500, 411);
            label3.Name = "label3";
            label3.Size = new Size(177, 21);
            label3.TabIndex = 6;
            label3.Text = "Yearly Total Expenses:";
            label3.Click += label3_Click;
            // 
            // yearlyTotalExpensesLabel
            // 
            yearlyTotalExpensesLabel.AutoSize = true;
            yearlyTotalExpensesLabel.Location = new Point(710, 416);
            yearlyTotalExpensesLabel.Name = "yearlyTotalExpensesLabel";
            yearlyTotalExpensesLabel.Size = new Size(38, 15);
            yearlyTotalExpensesLabel.TabIndex = 7;
            yearlyTotalExpensesLabel.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(700, 416);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 8;
            label4.Text = "$";
            // 
            // PieChartGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(yearlyTotalExpensesLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(YearlyExpenses);
            Controls.Add(button1);
            Controls.Add(ThisMonthyExpense);
            Name = "PieChartGenerator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PieChartGenerator";
            Load += PieChartGenerator_Load;
            ((System.ComponentModel.ISupportInitialize)ThisMonthyExpense).EndInit();
            ((System.ComponentModel.ISupportInitialize)YearlyExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ThisMonthyExpense;
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart YearlyExpenses;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label yearlyTotalExpensesLabel;
        private Label label4;
    }
}