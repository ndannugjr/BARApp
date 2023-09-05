namespace BARApp.uc
{
    partial class ucMultipleChoice
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
            lblChoiceD = new Label();
            lblChoiceC = new Label();
            lblChoiceB = new Label();
            lblChoiceA = new Label();
            lblQuestion = new Label();
            lblQuestionNumber = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(lblChoiceD, 1, 5);
            tableLayoutPanel1.Controls.Add(lblChoiceC, 1, 4);
            tableLayoutPanel1.Controls.Add(lblChoiceB, 1, 3);
            tableLayoutPanel1.Controls.Add(lblChoiceA, 1, 2);
            tableLayoutPanel1.Controls.Add(lblQuestion, 1, 1);
            tableLayoutPanel1.Controls.Add(lblQuestionNumber, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEdit, 2, 1);
            tableLayoutPanel1.Controls.Add(btnDelete, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1200, 250);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblChoiceD
            // 
            lblChoiceD.AutoSize = true;
            lblChoiceD.Dock = DockStyle.Fill;
            lblChoiceD.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblChoiceD.ForeColor = Color.DimGray;
            lblChoiceD.Location = new Point(188, 168);
            lblChoiceD.Name = "lblChoiceD";
            lblChoiceD.Size = new Size(919, 32);
            lblChoiceD.TabIndex = 21;
            lblChoiceD.Text = "This is a sample answer";
            lblChoiceD.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChoiceC
            // 
            lblChoiceC.AutoSize = true;
            lblChoiceC.Dock = DockStyle.Fill;
            lblChoiceC.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblChoiceC.ForeColor = Color.DimGray;
            lblChoiceC.Location = new Point(188, 136);
            lblChoiceC.Name = "lblChoiceC";
            lblChoiceC.Size = new Size(919, 32);
            lblChoiceC.TabIndex = 20;
            lblChoiceC.Text = "This is a sample answer";
            lblChoiceC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChoiceB
            // 
            lblChoiceB.AutoSize = true;
            lblChoiceB.Dock = DockStyle.Fill;
            lblChoiceB.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblChoiceB.ForeColor = Color.DimGray;
            lblChoiceB.Location = new Point(188, 104);
            lblChoiceB.Name = "lblChoiceB";
            lblChoiceB.Size = new Size(919, 32);
            lblChoiceB.TabIndex = 19;
            lblChoiceB.Text = "This is a sample answer";
            lblChoiceB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblChoiceA
            // 
            lblChoiceA.AutoSize = true;
            lblChoiceA.Dock = DockStyle.Fill;
            lblChoiceA.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblChoiceA.ForeColor = Color.DimGray;
            lblChoiceA.Location = new Point(188, 72);
            lblChoiceA.Name = "lblChoiceA";
            lblChoiceA.Size = new Size(919, 32);
            lblChoiceA.TabIndex = 18;
            lblChoiceA.Text = "This is a sample answer";
            lblChoiceA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Dock = DockStyle.Fill;
            lblQuestion.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestion.ForeColor = Color.DimGray;
            lblQuestion.Location = new Point(188, 37);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(919, 35);
            lblQuestion.TabIndex = 17;
            lblQuestion.Text = "This is a sample question ";
            lblQuestion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.Dock = DockStyle.Fill;
            lblQuestionNumber.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestionNumber.ForeColor = Color.Black;
            lblQuestionNumber.Location = new Point(188, 0);
            lblQuestionNumber.Margin = new Padding(3, 0, 3, 5);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(919, 32);
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
            label5.Location = new Point(3, 168);
            label5.Name = "label5";
            label5.Size = new Size(179, 32);
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
            label3.Location = new Point(3, 136);
            label3.Name = "label3";
            label3.Size = new Size(179, 32);
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
            label2.Location = new Point(3, 104);
            label2.Name = "label2";
            label2.Size = new Size(179, 32);
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
            label1.Location = new Point(3, 72);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
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
            label4.Location = new Point(3, 37);
            label4.Name = "label4";
            label4.Size = new Size(179, 35);
            label4.TabIndex = 5;
            label4.Text = "Question:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Gold;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1113, 40);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(38, 29);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "✏️";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1157, 40);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(40, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "❌";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // ucMultipleChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucMultipleChoice";
            Size = new Size(1200, 250);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblChoiceD;
        private Label lblChoiceC;
        private Label lblChoiceB;
        private Label lblChoiceA;
        private Label lblQuestion;
        private Label lblQuestionNumber;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnEdit;
        private Button btnDelete;
    }
}