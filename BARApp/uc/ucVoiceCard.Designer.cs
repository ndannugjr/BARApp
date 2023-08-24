namespace BARApp.uc
{
    partial class ucVoiceCard
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblItem = new Label();
            btnRecord = new Button();
            btnRetry = new Button();
            btnPlay = new Button();
            lblTimer = new Label();
            lblQuestion = new Label();
            timer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lblItem, 0, 0);
            tableLayoutPanel1.Controls.Add(btnRecord, 1, 1);
            tableLayoutPanel1.Controls.Add(btnRetry, 4, 1);
            tableLayoutPanel1.Controls.Add(btnPlay, 3, 1);
            tableLayoutPanel1.Controls.Add(lblTimer, 2, 1);
            tableLayoutPanel1.Controls.Add(lblQuestion, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 105);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Dock = DockStyle.Fill;
            lblItem.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItem.ForeColor = Color.DimGray;
            lblItem.Location = new Point(3, 0);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(154, 52);
            lblItem.TabIndex = 0;
            lblItem.Text = "Item #1";
            lblItem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnRecord
            // 
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecord.ForeColor = Color.DimGray;
            btnRecord.Location = new Point(163, 55);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(108, 39);
            btnRecord.TabIndex = 1;
            btnRecord.Text = "Record";
            btnRecord.UseVisualStyleBackColor = true;
            btnRecord.Click += btnRecord_Click;
            // 
            // btnRetry
            // 
            btnRetry.FlatStyle = FlatStyle.Flat;
            btnRetry.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetry.ForeColor = Color.DimGray;
            btnRetry.Location = new Point(643, 55);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(108, 39);
            btnRetry.TabIndex = 3;
            btnRetry.Text = "Submit";
            btnRetry.UseVisualStyleBackColor = true;
            btnRetry.Visible = false;
            btnRetry.Click += btnSubmit_Click;
            // 
            // btnPlay
            // 
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlay.ForeColor = Color.DimGray;
            btnPlay.Location = new Point(483, 55);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(108, 39);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Dock = DockStyle.Fill;
            lblTimer.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.ForeColor = Color.DimGray;
            lblTimer.Location = new Point(323, 52);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(154, 53);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "00:00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblQuestion, 4);
            lblQuestion.Dock = DockStyle.Fill;
            lblQuestion.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestion.ForeColor = Color.DimGray;
            lblQuestion.Location = new Point(163, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(634, 52);
            lblQuestion.TabIndex = 5;
            lblQuestion.Text = "This is a sample text to read";
            lblQuestion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // ucVoiceCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ucVoiceCard";
            Size = new Size(800, 105);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblItem;
        private Button btnRecord;
        private Button btnPlay;
        private Button btnRetry;
        private Label lblTimer;
        private Label lblQuestion;
        private System.Windows.Forms.Timer timer;
    }
}