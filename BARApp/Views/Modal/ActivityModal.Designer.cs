namespace BARApp.Views.Modal
{
    partial class ActivityModal
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
            btnChangeVoice = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            pnlContent = new Panel();
            lblFormTitle = new Label();
            lblPageNo = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(btnChangeVoice, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPrev, 0, 2);
            tableLayoutPanel1.Controls.Add(btnNext, 2, 2);
            tableLayoutPanel1.Controls.Add(pnlContent, 1, 1);
            tableLayoutPanel1.Controls.Add(lblFormTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(lblPageNo, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1182, 753);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnChangeVoice
            // 
            btnChangeVoice.BackColor = Color.FromArgb(192, 255, 255);
            btnChangeVoice.Dock = DockStyle.Fill;
            btnChangeVoice.FlatStyle = FlatStyle.Flat;
            btnChangeVoice.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeVoice.ForeColor = Color.DimGray;
            btnChangeVoice.Location = new Point(3, 3);
            btnChangeVoice.Name = "btnChangeVoice";
            btnChangeVoice.Size = new Size(112, 69);
            btnChangeVoice.TabIndex = 4;
            btnChangeVoice.Text = "Change voice";
            btnChangeVoice.UseVisualStyleBackColor = false;
            btnChangeVoice.Click += btnChangeVoice_Click;
            // 
            // btnPrev
            // 
            btnPrev.Dock = DockStyle.Fill;
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Comic Sans MS", 60F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrev.ForeColor = Color.Teal;
            btnPrev.Location = new Point(3, 303);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(112, 144);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Dock = DockStyle.Fill;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Comic Sans MS", 60F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = Color.Teal;
            btnNext.Location = new Point(1066, 303);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(113, 144);
            btnNext.TabIndex = 1;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pnlContent
            // 
            pnlContent.BorderStyle = BorderStyle.FixedSingle;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(118, 75);
            pnlContent.Margin = new Padding(0, 0, 0, 20);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(0, 10, 0, 0);
            tableLayoutPanel1.SetRowSpan(pnlContent, 4);
            pnlContent.Size = new Size(945, 658);
            pnlContent.TabIndex = 2;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.BackColor = Color.Teal;
            lblFormTitle.Dock = DockStyle.Fill;
            lblFormTitle.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.White;
            lblFormTitle.Location = new Point(118, 0);
            lblFormTitle.Margin = new Padding(0);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(945, 75);
            lblFormTitle.TabIndex = 3;
            lblFormTitle.Text = "NON-VOICE";
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPageNo
            // 
            lblPageNo.AutoSize = true;
            lblPageNo.Dock = DockStyle.Fill;
            lblPageNo.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblPageNo.Location = new Point(1066, 675);
            lblPageNo.Name = "lblPageNo";
            lblPageNo.Size = new Size(113, 78);
            lblPageNo.TabIndex = 5;
            lblPageNo.Text = "Page 1 of 3";
            lblPageNo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ActivityModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 753);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ActivityModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GOOD LUCK!";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnPrev;
        private Button btnNext;
        private Panel pnlContent;
        private Label lblFormTitle;
        private Button btnChangeVoice;
        private Label lblPageNo;
    }
}