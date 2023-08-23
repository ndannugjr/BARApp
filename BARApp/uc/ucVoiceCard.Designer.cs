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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucVoiceCard));
            tableLayoutPanel1 = new TableLayoutPanel();
            lblItem = new Label();
            label2 = new Label();
            txtAnswer = new ucTextBox();
            ucSpeechControl1 = new ucSpeechControl();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.625F));
            tableLayoutPanel1.Controls.Add(txtAnswer, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblItem, 0, 0);
            tableLayoutPanel1.Controls.Add(ucSpeechControl1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 105);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Dock = DockStyle.Fill;
            lblItem.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblItem.Location = new Point(3, 0);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(165, 55);
            lblItem.TabIndex = 0;
            lblItem.Text = "Item #1";
            lblItem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(165, 50);
            label2.TabIndex = 1;
            label2.Text = "Answer:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAnswer
            // 
            txtAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAnswer.BackColor = SystemColors.Window;
            txtAnswer.BorderColor = Color.FromArgb(118, 113, 113);
            txtAnswer.BorderFocusColor = Color.FromArgb(52, 139, 95);
            txtAnswer.BorderSize = 2;
            txtAnswer.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnswer.ForeColor = Color.DimGray;
            txtAnswer.IsAlphabet = false;
            txtAnswer.IsAlphaDash = false;
            txtAnswer.IsAlphaNumeric = false;
            txtAnswer.IsAlphaNumericDash = false;
            txtAnswer.Location = new Point(175, 60);
            txtAnswer.Margin = new Padding(4, 5, 25, 5);
            txtAnswer.Multiline = false;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Padding = new Padding(4);
            txtAnswer.PasswordChar = false;
            txtAnswer.Size = new Size(600, 37);
            txtAnswer.TabIndex = 2;
            txtAnswer.Texts = "";
            txtAnswer.UnderlinedStyle = false;
            // 
            // ucSpeechControl1
            // 
            ucSpeechControl1.Location = new Point(171, 0);
            ucSpeechControl1.Margin = new Padding(0);
            ucSpeechControl1.Name = "ucSpeechControl1";
            ucSpeechControl1.Size = new Size(299, 55);
            ucSpeechControl1.TabIndex = 3;
            ucSpeechControl1.TextList = (List<string>)resources.GetObject("ucSpeechControl1.TextList");
            // 
            // ucVoiceCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 105);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ucVoiceCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ucVoiceCard";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label lblItem;
        private ucTextBox txtAnswer;
        private ucSpeechControl ucSpeechControl1;
    }
}