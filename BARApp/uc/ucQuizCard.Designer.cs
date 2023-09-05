namespace BARApp.uc
{
    partial class ucQuizCard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnStart = new Button();
            lblActivityType = new Label();
            lblSchoolYear = new Label();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(btnStart, 2, 0);
            tableLayoutPanel1.Controls.Add(lblActivityType, 0, 0);
            tableLayoutPanel1.Controls.Add(lblSchoolYear, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(698, 58);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(192, 255, 255);
            btnStart.Dock = DockStyle.Fill;
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(68, 114, 196);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.DimGray;
            btnStart.Location = new Point(501, 3);
            btnStart.Margin = new Padding(13, 3, 3, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(194, 52);
            btnStart.TabIndex = 5;
            btnStart.Text = "Start!";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblActivityType
            // 
            lblActivityType.Dock = DockStyle.Fill;
            lblActivityType.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblActivityType.ForeColor = Color.White;
            lblActivityType.Location = new Point(3, 0);
            lblActivityType.Name = "lblActivityType";
            lblActivityType.Size = new Size(273, 58);
            lblActivityType.TabIndex = 0;
            lblActivityType.Text = "QUIZ #1";
            lblActivityType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSchoolYear
            // 
            lblSchoolYear.Dock = DockStyle.Fill;
            lblSchoolYear.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSchoolYear.ForeColor = Color.White;
            lblSchoolYear.Location = new Point(282, 0);
            lblSchoolYear.Name = "lblSchoolYear";
            lblSchoolYear.Size = new Size(203, 58);
            lblSchoolYear.TabIndex = 1;
            lblSchoolYear.Text = "SY 22-23";
            lblSchoolYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 60);
            panel1.TabIndex = 1;
            // 
            // ucQuizCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ucQuizCard";
            Size = new Size(700, 60);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblActivityType;
        private Label lblSchoolYear;
        private Button btnStart;
        private Panel panel1;
    }
}