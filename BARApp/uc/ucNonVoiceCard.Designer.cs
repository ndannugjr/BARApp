namespace BARApp.uc
{
    partial class ucNonVoiceCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNonVoiceCard));
            tableLayoutPanel1 = new TableLayoutPanel();
            txtAnswer = new ucTextBox();
            lblAnswer = new Label();
            lblItem = new Label();
            ucSpeechControl = new ucSpeechControl();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.625F));
            tableLayoutPanel1.Controls.Add(txtAnswer, 1, 1);
            tableLayoutPanel1.Controls.Add(lblAnswer, 0, 1);
            tableLayoutPanel1.Controls.Add(lblItem, 0, 0);
            tableLayoutPanel1.Controls.Add(ucSpeechControl, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 105);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtAnswer
            // 
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
            txtAnswer.Margin = new Padding(4, 5, 150, 5);
            txtAnswer.Multiline = false;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Padding = new Padding(4);
            txtAnswer.PasswordChar = false;
            txtAnswer.Size = new Size(350, 37);
            txtAnswer.TabIndex = 2;
            txtAnswer.Texts = "";
            txtAnswer.UnderlinedStyle = false;
            txtAnswer._TextChanged += txtAnswer_TextChanged;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Dock = DockStyle.Fill;
            lblAnswer.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswer.ForeColor = Color.DimGray;
            lblAnswer.Location = new Point(3, 55);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(165, 50);
            lblAnswer.TabIndex = 1;
            lblAnswer.Text = "Answer:";
            lblAnswer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Dock = DockStyle.Fill;
            lblItem.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblItem.ForeColor = Color.DimGray;
            lblItem.Location = new Point(3, 0);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(165, 55);
            lblItem.TabIndex = 0;
            lblItem.Text = "Item #1";
            lblItem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ucSpeechControl
            // 
            ucSpeechControl.IsMaleVoice = false;
            ucSpeechControl.Location = new Point(171, 0);
            ucSpeechControl.Margin = new Padding(0);
            ucSpeechControl.Name = "ucSpeechControl";
            ucSpeechControl.Size = new Size(299, 55);
            ucSpeechControl.TabIndex = 3;
            ucSpeechControl.TextList = (List<string>)resources.GetObject("ucSpeechControl.TextList");
            // 
            // ucNonVoiceCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "ucNonVoiceCard";
            Size = new Size(800, 105);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label lblItem;
        private ucTextBox txtAnswer;
        private ucSpeechControl ucSpeechControl;
        private Label lblAnswer;
    }
}