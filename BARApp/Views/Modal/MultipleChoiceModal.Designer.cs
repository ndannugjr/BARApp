namespace BARApp.Views.Modal
{
    partial class MultipleChoiceModal
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
            label6 = new Label();
            lblQuestionNumber = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtQuestion = new uc.ucTextBox();
            txtChoiceA = new uc.ucTextBox();
            txtChoiceB = new uc.ucTextBox();
            txtChoiceC = new uc.ucTextBox();
            txtChoiceD = new uc.ucTextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            txtAnswer = new uc.ucTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Snow;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label6, 0, 6);
            tableLayoutPanel1.Controls.Add(lblQuestionNumber, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(txtQuestion, 1, 1);
            tableLayoutPanel1.Controls.Add(txtChoiceA, 1, 2);
            tableLayoutPanel1.Controls.Add(txtChoiceB, 1, 3);
            tableLayoutPanel1.Controls.Add(txtChoiceC, 1, 4);
            tableLayoutPanel1.Controls.Add(txtChoiceD, 1, 5);
            tableLayoutPanel1.Controls.Add(btnAdd, 1, 7);
            tableLayoutPanel1.Controls.Add(btnCancel, 2, 7);
            tableLayoutPanel1.Controls.Add(txtAnswer, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(772, 373);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(3, 267);
            label6.Name = "label6";
            label6.Size = new Size(121, 47);
            label6.TabIndex = 28;
            label6.Text = "Answer:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblQuestionNumber, 2);
            lblQuestionNumber.Dock = DockStyle.Fill;
            lblQuestionNumber.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestionNumber.ForeColor = Color.DimGray;
            lblQuestionNumber.Location = new Point(130, 0);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(639, 32);
            lblQuestionNumber.TabIndex = 16;
            lblQuestionNumber.Text = "Question #1";
            lblQuestionNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(3, 220);
            label5.Name = "label5";
            label5.Size = new Size(121, 47);
            label5.TabIndex = 13;
            label5.Text = "d.";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(3, 173);
            label3.Name = "label3";
            label3.Size = new Size(121, 47);
            label3.TabIndex = 11;
            label3.Text = "c.";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(3, 126);
            label2.Name = "label2";
            label2.Size = new Size(121, 47);
            label2.TabIndex = 9;
            label2.Text = "b.";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(3, 79);
            label1.Name = "label1";
            label1.Size = new Size(121, 47);
            label1.TabIndex = 7;
            label1.Text = "a.";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(3, 32);
            label4.Name = "label4";
            label4.Size = new Size(121, 47);
            label4.TabIndex = 5;
            label4.Text = "Question:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtQuestion
            // 
            txtQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuestion.BackColor = SystemColors.Window;
            txtQuestion.BorderColor = Color.FromArgb(118, 113, 113);
            txtQuestion.BorderFocusColor = Color.FromArgb(52, 139, 95);
            txtQuestion.BorderSize = 2;
            tableLayoutPanel1.SetColumnSpan(txtQuestion, 2);
            txtQuestion.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuestion.ForeColor = Color.DimGray;
            txtQuestion.IsAlphabet = false;
            txtQuestion.IsAlphaDash = false;
            txtQuestion.IsAlphaNumeric = false;
            txtQuestion.IsAlphaNumericDash = false;
            txtQuestion.Location = new Point(131, 37);
            txtQuestion.Margin = new Padding(4, 5, 4, 5);
            txtQuestion.Multiline = false;
            txtQuestion.Name = "txtQuestion";
            txtQuestion.Padding = new Padding(4);
            txtQuestion.PasswordChar = false;
            txtQuestion.Size = new Size(637, 37);
            txtQuestion.TabIndex = 0;
            txtQuestion.Texts = "";
            txtQuestion.UnderlinedStyle = false;
            // 
            // txtChoiceA
            // 
            txtChoiceA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChoiceA.BackColor = SystemColors.Window;
            txtChoiceA.BorderColor = Color.FromArgb(118, 113, 113);
            txtChoiceA.BorderFocusColor = Color.FromArgb(52, 139, 95);
            txtChoiceA.BorderSize = 2;
            tableLayoutPanel1.SetColumnSpan(txtChoiceA, 2);
            txtChoiceA.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChoiceA.ForeColor = Color.DimGray;
            txtChoiceA.IsAlphabet = false;
            txtChoiceA.IsAlphaDash = false;
            txtChoiceA.IsAlphaNumeric = false;
            txtChoiceA.IsAlphaNumericDash = false;
            txtChoiceA.Location = new Point(131, 84);
            txtChoiceA.Margin = new Padding(4, 5, 4, 5);
            txtChoiceA.Multiline = false;
            txtChoiceA.Name = "txtChoiceA";
            txtChoiceA.Padding = new Padding(4);
            txtChoiceA.PasswordChar = false;
            txtChoiceA.Size = new Size(637, 37);
            txtChoiceA.TabIndex = 1;
            txtChoiceA.Texts = "";
            txtChoiceA.UnderlinedStyle = false;
            // 
            // txtChoiceB
            // 
            txtChoiceB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChoiceB.BackColor = SystemColors.Window;
            txtChoiceB.BorderColor = Color.FromArgb(118, 113, 113);
            txtChoiceB.BorderFocusColor = Color.FromArgb(52, 139, 95);
            txtChoiceB.BorderSize = 2;
            tableLayoutPanel1.SetColumnSpan(txtChoiceB, 2);
            txtChoiceB.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChoiceB.ForeColor = Color.DimGray;
            txtChoiceB.IsAlphabet = false;
            txtChoiceB.IsAlphaDash = false;
            txtChoiceB.IsAlphaNumeric = false;
            txtChoiceB.IsAlphaNumericDash = false;
            txtChoiceB.Location = new Point(131, 131);
            txtChoiceB.Margin = new Padding(4, 5, 4, 5);
            txtChoiceB.Multiline = false;
            txtChoiceB.Name = "txtChoiceB";
            txtChoiceB.Padding = new Padding(4);
            txtChoiceB.PasswordChar = false;
            txtChoiceB.Size = new Size(637, 37);
            txtChoiceB.TabIndex = 2;
            txtChoiceB.Texts = "";
            txtChoiceB.UnderlinedStyle = false;
            // 
            // txtChoiceC
            // 
            txtChoiceC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChoiceC.BackColor = SystemColors.Window;
            txtChoiceC.BorderColor = Color.FromArgb(118, 113, 113);
            txtChoiceC.BorderFocusColor = Color.FromArgb(52, 139, 95);
            txtChoiceC.BorderSize = 2;
            tableLayoutPanel1.SetColumnSpan(txtChoiceC, 2);
            txtChoiceC.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChoiceC.ForeColor = Color.DimGray;
            txtChoiceC.IsAlphabet = false;
            txtChoiceC.IsAlphaDash = false;
            txtChoiceC.IsAlphaNumeric = false;
            txtChoiceC.IsAlphaNumericDash = false;
            txtChoiceC.Location = new Point(131, 178);
            txtChoiceC.Margin = new Padding(4, 5, 4, 5);
            txtChoiceC.Multiline = false;
            txtChoiceC.Name = "txtChoiceC";
            txtChoiceC.Padding = new Padding(4);
            txtChoiceC.PasswordChar = false;
            txtChoiceC.Size = new Size(637, 37);
            txtChoiceC.TabIndex = 3;
            txtChoiceC.Texts = "";
            txtChoiceC.UnderlinedStyle = false;
            // 
            // txtChoiceD
            // 
            txtChoiceD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChoiceD.BackColor = SystemColors.Window;
            txtChoiceD.BorderColor = Color.FromArgb(118, 113, 113);
            txtChoiceD.BorderFocusColor = Color.FromArgb(52, 139, 95);
            txtChoiceD.BorderSize = 2;
            tableLayoutPanel1.SetColumnSpan(txtChoiceD, 2);
            txtChoiceD.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtChoiceD.ForeColor = Color.DimGray;
            txtChoiceD.IsAlphabet = false;
            txtChoiceD.IsAlphaDash = false;
            txtChoiceD.IsAlphaNumeric = false;
            txtChoiceD.IsAlphaNumericDash = false;
            txtChoiceD.Location = new Point(131, 225);
            txtChoiceD.Margin = new Padding(4, 5, 4, 5);
            txtChoiceD.Multiline = false;
            txtChoiceD.Name = "txtChoiceD";
            txtChoiceD.Padding = new Padding(4);
            txtChoiceD.PasswordChar = false;
            txtChoiceD.Size = new Size(637, 37);
            txtChoiceD.TabIndex = 4;
            txtChoiceD.Texts = "";
            txtChoiceD.UnderlinedStyle = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(192, 255, 255);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(68, 114, 196);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.DimGray;
            btnAdd.Location = new Point(130, 319);
            btnAdd.Margin = new Padding(3, 5, 3, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(316, 49);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD (+)";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(192, 255, 255);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(68, 114, 196);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.DimGray;
            btnCancel.Location = new Point(452, 319);
            btnCancel.Margin = new Padding(3, 5, 3, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(317, 49);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtAnswer
            // 
            txtAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAnswer.BackColor = SystemColors.Window;
            txtAnswer.BorderColor = Color.FromArgb(118, 113, 113);
            txtAnswer.BorderFocusColor = Color.FromArgb(52, 139, 95);
            txtAnswer.BorderSize = 2;
            tableLayoutPanel1.SetColumnSpan(txtAnswer, 2);
            txtAnswer.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer.ForeColor = Color.DimGray;
            txtAnswer.IsAlphabet = false;
            txtAnswer.IsAlphaDash = false;
            txtAnswer.IsAlphaNumeric = false;
            txtAnswer.IsAlphaNumericDash = false;
            txtAnswer.Location = new Point(131, 272);
            txtAnswer.Margin = new Padding(4, 5, 4, 5);
            txtAnswer.Multiline = false;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Padding = new Padding(4);
            txtAnswer.PasswordChar = false;
            txtAnswer.Size = new Size(637, 37);
            txtAnswer.TabIndex = 5;
            txtAnswer.Texts = "";
            txtAnswer.UnderlinedStyle = false;
            // 
            // MultipleChoiceModal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 373);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MultipleChoiceModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multiple Choice";
            Load += MultipleChoiceModal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblQuestionNumber;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnAdd;

        private Button btnCancel;
        private uc.ucTextBox txtQuestion;
        private uc.ucTextBox txtChoiceA;
        private uc.ucTextBox txtChoiceB;
        private uc.ucTextBox txtChoiceC;
        private uc.ucTextBox txtChoiceD;
        private Label label6;
        private uc.ucTextBox txtAnswer;
    }
}