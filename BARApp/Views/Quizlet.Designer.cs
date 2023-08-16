namespace BARApp.Views
{
    partial class Quizlet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quizlet));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            panel4 = new Panel();
            rtbVoice = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            rtbNonVoice = new RichTextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel5 = new Panel();
            rtbReadingCompre = new RichTextBox();
            label4 = new Label();
            btnMultipleChoice = new Button();
            btnIdentification = new Button();
            pnlReadingCompre = new Panel();
            tlpQuestions = new TableLayoutPanel();
            txtTitle1 = new uc.ucTextBox();
            ucSpeechControlNonVoice1 = new uc.ucSpeechControl();
            ucSpeechControlVoice1 = new uc.ucSpeechControl();
            ucSpeechControlReadingCompre1 = new uc.ucSpeechControl();
            tableLayoutPanel5 = new TableLayoutPanel();
            button4 = new Button();
            btnSave = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            label5 = new Label();
            cbType = new ComboBox();
            label6 = new Label();
            cbGrade = new ComboBox();
            label7 = new Label();
            cbSchoolYear = new ComboBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            button6 = new Button();
            button7 = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            pnlReadingCompre.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.Teal;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1206, 1102);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 110);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1206, 881);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label3, 0, 4);
            tableLayoutPanel2.Controls.Add(panel4, 0, 3);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 5);
            tableLayoutPanel2.Controls.Add(ucSpeechControlNonVoice1, 1, 0);
            tableLayoutPanel2.Controls.Add(ucSpeechControlVoice1, 1, 2);
            tableLayoutPanel2.Controls.Add(ucSpeechControlReadingCompre1, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5, 0, 5, 0);
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1204, 879);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 617);
            label3.Margin = new Padding(0, 5, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(350, 50);
            label3.TabIndex = 4;
            label3.Text = "READING COMPREHENSION";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel2.SetColumnSpan(panel4, 2);
            panel4.Controls.Add(rtbVoice);
            panel4.Location = new Point(5, 362);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(1173, 250);
            panel4.TabIndex = 3;
            // 
            // rtbVoice
            // 
            rtbVoice.BorderStyle = BorderStyle.None;
            rtbVoice.Dock = DockStyle.Fill;
            rtbVoice.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbVoice.Location = new Point(10, 10);
            rtbVoice.Margin = new Padding(0);
            rtbVoice.Name = "rtbVoice";
            rtbVoice.Size = new Size(1151, 228);
            rtbVoice.TabIndex = 1;
            rtbVoice.Text = "";
            rtbVoice.TextChanged += rtbVoice_TextChanged;
            rtbVoice.Enter += rtbVoice_Enter;
            rtbVoice.Leave += rtbVoice_Leave;
            // 
            // label2
            // 
            label2.BackColor = Color.Teal;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 311);
            label2.Margin = new Padding(0, 5, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(350, 50);
            label2.TabIndex = 2;
            label2.Text = "VOICE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 5);
            label1.Margin = new Padding(0, 5, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 50);
            label1.TabIndex = 0;
            label1.Text = "NON-VOICE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel2.SetColumnSpan(panel3, 2);
            panel3.Controls.Add(rtbNonVoice);
            panel3.Location = new Point(5, 56);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(1173, 250);
            panel3.TabIndex = 1;
            // 
            // rtbNonVoice
            // 
            rtbNonVoice.BorderStyle = BorderStyle.None;
            rtbNonVoice.Dock = DockStyle.Fill;
            rtbNonVoice.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbNonVoice.Location = new Point(10, 10);
            rtbNonVoice.Margin = new Padding(0);
            rtbNonVoice.Name = "rtbNonVoice";
            rtbNonVoice.Size = new Size(1151, 228);
            rtbNonVoice.TabIndex = 0;
            rtbNonVoice.Text = "";
            rtbNonVoice.TextChanged += rtbNonVoice_TextChanged;
            rtbNonVoice.Enter += rtbNonVoice_Enter;
            rtbNonVoice.Leave += rtbNonVoice_Leave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 2);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(panel5, 0, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(btnMultipleChoice, 0, 2);
            tableLayoutPanel3.Controls.Add(btnIdentification, 1, 2);
            tableLayoutPanel3.Controls.Add(pnlReadingCompre, 0, 4);
            tableLayoutPanel3.Controls.Add(txtTitle1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(5, 668);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 400F));
            tableLayoutPanel3.Size = new Size(1173, 600);
            tableLayoutPanel3.TabIndex = 12;
            tableLayoutPanel3.Tag = "tlp3";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel3.SetColumnSpan(panel5, 2);
            panel5.Controls.Add(rtbReadingCompre);
            panel5.Location = new Point(0, 47);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(1173, 250);
            panel5.TabIndex = 4;
            // 
            // rtbReadingCompre
            // 
            rtbReadingCompre.BorderStyle = BorderStyle.None;
            rtbReadingCompre.Dock = DockStyle.Fill;
            rtbReadingCompre.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbReadingCompre.Location = new Point(10, 10);
            rtbReadingCompre.Margin = new Padding(0);
            rtbReadingCompre.Name = "rtbReadingCompre";
            rtbReadingCompre.Size = new Size(1151, 228);
            rtbReadingCompre.TabIndex = 1;
            rtbReadingCompre.Text = "";
            rtbReadingCompre.TextChanged += rtbReadingCompre_TextChanged;
            rtbReadingCompre.Enter += rtbReadingCompre_Enter;
            rtbReadingCompre.Leave += rtbReadingCompre_Leave;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(580, 47);
            label4.TabIndex = 1;
            label4.Text = "Title: ";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnMultipleChoice
            // 
            btnMultipleChoice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnMultipleChoice.BackColor = Color.FromArgb(192, 255, 255);
            btnMultipleChoice.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultipleChoice.ForeColor = Color.DimGray;
            btnMultipleChoice.Location = new Point(233, 300);
            btnMultipleChoice.Name = "btnMultipleChoice";
            btnMultipleChoice.Size = new Size(350, 50);
            btnMultipleChoice.TabIndex = 5;
            btnMultipleChoice.Text = "ADD MULTIPLE CHOICE(+)";
            btnMultipleChoice.UseVisualStyleBackColor = false;
            btnMultipleChoice.Click += btnMultipleChoice_Click;
            // 
            // btnIdentification
            // 
            btnIdentification.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnIdentification.BackColor = Color.FromArgb(192, 255, 255);
            btnIdentification.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIdentification.ForeColor = Color.DimGray;
            btnIdentification.Location = new Point(589, 300);
            btnIdentification.Name = "btnIdentification";
            btnIdentification.Size = new Size(350, 50);
            btnIdentification.TabIndex = 6;
            btnIdentification.Text = "ADD IDENTIFICATION(+)";
            btnIdentification.UseVisualStyleBackColor = false;
            btnIdentification.Click += btnIdentification_Click;
            // 
            // pnlReadingCompre
            // 
            pnlReadingCompre.BackColor = Color.FromArgb(255, 192, 192);
            tableLayoutPanel3.SetColumnSpan(pnlReadingCompre, 2);
            pnlReadingCompre.Controls.Add(tlpQuestions);
            pnlReadingCompre.Dock = DockStyle.Fill;
            pnlReadingCompre.Location = new Point(0, 353);
            pnlReadingCompre.Margin = new Padding(0);
            pnlReadingCompre.Name = "pnlReadingCompre";
            pnlReadingCompre.Size = new Size(1173, 400);
            pnlReadingCompre.TabIndex = 7;
            // 
            // tlpQuestions
            // 
            tlpQuestions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpQuestions.BackColor = Color.White;
            tlpQuestions.ColumnCount = 2;
            tlpQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpQuestions.Location = new Point(0, 0);
            tlpQuestions.Margin = new Padding(0);
            tlpQuestions.Name = "tlpQuestions";
            tlpQuestions.RowCount = 1;
            tlpQuestions.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpQuestions.Size = new Size(1173, 400);
            tlpQuestions.TabIndex = 8;
            tlpQuestions.Tag = "tlpQ";
            tlpQuestions.ControlAdded += tlpQuestions_ControlAdded;
            tlpQuestions.ControlRemoved += tlpQuestions_ControlRemoved;
            // 
            // txtTitle1
            // 
            txtTitle1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle1.BackColor = SystemColors.Window;
            txtTitle1.BorderColor = Color.FromArgb(118, 113, 113);
            txtTitle1.BorderFocusColor = Color.FromArgb(52, 139, 95);
            txtTitle1.BorderSize = 2;
            txtTitle1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle1.ForeColor = Color.DimGray;
            txtTitle1.IsAlphabet = false;
            txtTitle1.IsAlphaDash = false;
            txtTitle1.IsAlphaNumeric = false;
            txtTitle1.IsAlphaNumericDash = false;
            txtTitle1.Location = new Point(590, 5);
            txtTitle1.Margin = new Padding(4, 5, 4, 5);
            txtTitle1.Multiline = false;
            txtTitle1.Name = "txtTitle1";
            txtTitle1.Padding = new Padding(4);
            txtTitle1.PasswordChar = false;
            txtTitle1.Size = new Size(579, 37);
            txtTitle1.TabIndex = 8;
            txtTitle1.Texts = "";
            txtTitle1.UnderlinedStyle = false;
            txtTitle1._TextChanged += txtTitle_TextChanged;
            // 
            // ucSpeechControlNonVoice1
            // 
            ucSpeechControlNonVoice1.Dock = DockStyle.Fill;
            ucSpeechControlNonVoice1.Location = new Point(358, 3);
            ucSpeechControlNonVoice1.Name = "ucSpeechControlNonVoice1";
            ucSpeechControlNonVoice1.Size = new Size(817, 50);
            ucSpeechControlNonVoice1.TabIndex = 13;
            ucSpeechControlNonVoice1.TextList = (List<string>)resources.GetObject("ucSpeechControlNonVoice1.TextList");
            // 
            // ucSpeechControlVoice1
            // 
            ucSpeechControlVoice1.Dock = DockStyle.Fill;
            ucSpeechControlVoice1.Location = new Point(358, 309);
            ucSpeechControlVoice1.Name = "ucSpeechControlVoice1";
            ucSpeechControlVoice1.Size = new Size(817, 50);
            ucSpeechControlVoice1.TabIndex = 14;
            ucSpeechControlVoice1.TextList = (List<string>)resources.GetObject("ucSpeechControlVoice1.TextList");
            // 
            // ucSpeechControlReadingCompre1
            // 
            ucSpeechControlReadingCompre1.Dock = DockStyle.Fill;
            ucSpeechControlReadingCompre1.Location = new Point(358, 615);
            ucSpeechControlReadingCompre1.Name = "ucSpeechControlReadingCompre1";
            ucSpeechControlReadingCompre1.Size = new Size(817, 50);
            ucSpeechControlReadingCompre1.TabIndex = 15;
            ucSpeechControlReadingCompre1.TextList = (List<string>)resources.GetObject("ucSpeechControlReadingCompre1.TextList");
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.White;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(button4, 0, 0);
            tableLayoutPanel5.Controls.Add(btnSave, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 991);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(20, 10, 20, 0);
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1206, 111);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(192, 255, 255);
            button4.FlatAppearance.BorderColor = Color.FromArgb(68, 114, 196);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.DimGray;
            button4.Location = new Point(606, 15);
            button4.Margin = new Padding(3, 5, 3, 0);
            button4.Name = "button4";
            button4.Size = new Size(577, 50);
            button4.TabIndex = 8;
            button4.Text = "CANCEL";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(192, 255, 255);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(68, 114, 196);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.DimGray;
            btnSave.Location = new Point(23, 15);
            btnSave.Margin = new Padding(3, 5, 3, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(577, 50);
            btnSave.TabIndex = 7;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 8;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label5, 1, 1);
            tableLayoutPanel8.Controls.Add(cbType, 2, 1);
            tableLayoutPanel8.Controls.Add(label6, 3, 1);
            tableLayoutPanel8.Controls.Add(cbGrade, 4, 1);
            tableLayoutPanel8.Controls.Add(label7, 5, 1);
            tableLayoutPanel8.Controls.Add(cbSchoolYear, 6, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.Size = new Size(1200, 104);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(158, 36);
            label5.Margin = new Padding(3, 5, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 0;
            label5.Text = "Prepare";
            // 
            // cbType
            // 
            cbType.BackColor = Color.White;
            cbType.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbType.ForeColor = Color.DimGray;
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(249, 34);
            cbType.Name = "cbType";
            cbType.Size = new Size(315, 36);
            cbType.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(570, 36);
            label6.Margin = new Padding(3, 5, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 28);
            label6.TabIndex = 2;
            label6.Text = "For grade";
            // 
            // cbGrade
            // 
            cbGrade.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGrade.ForeColor = Color.DimGray;
            cbGrade.FormattingEnabled = true;
            cbGrade.Location = new Point(681, 34);
            cbGrade.Name = "cbGrade";
            cbGrade.Size = new Size(151, 36);
            cbGrade.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(838, 36);
            label7.Margin = new Padding(3, 5, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 28);
            label7.TabIndex = 4;
            label7.Text = "S.Y.";
            // 
            // cbSchoolYear
            // 
            cbSchoolYear.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSchoolYear.ForeColor = Color.DimGray;
            cbSchoolYear.FormattingEnabled = true;
            cbSchoolYear.Location = new Point(891, 34);
            cbSchoolYear.Name = "cbSchoolYear";
            cbSchoolYear.Size = new Size(151, 36);
            cbSchoolYear.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(button1, 1, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(103, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 94);
            button1.TabIndex = 0;
            button1.Text = "Pause";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 192, 192);
            button2.Location = new Point(103, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 94);
            button2.TabIndex = 1;
            button2.Text = "Hear";
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(button6, 1, 0);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button6.Enabled = false;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(0, 192, 192);
            button6.Location = new Point(103, 3);
            button6.Name = "button6";
            button6.Size = new Size(94, 94);
            button6.TabIndex = 0;
            button6.Text = "Pause";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(0, 192, 192);
            button7.Location = new Point(103, 3);
            button7.Name = "button7";
            button7.Size = new Size(94, 94);
            button7.TabIndex = 1;
            button7.Text = "Hear";
            button7.UseVisualStyleBackColor = true;
            // 
            // Quizlet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 1102);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Quizlet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quizlet";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            pnlReadingCompre.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Panel panel3;
        private Panel panel6;
        private Label label3;
        private Panel panel4;
        private Label label2;
        private RichTextBox rtbNonVoice;
        private RichTextBox rtbVoice;
        private TableLayoutPanel tblQuestions;
        private Button btnPause;
        private Button btnPlay;
        private Button btnStop;
        private TableLayoutPanel tableLayoutPanel4;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button6;
        private Button button7;
        private uc.ucSpeechControl ucSpeechControlNonVoice1;
        private uc.ucSpeechControl ucSpeechControlVoice1;
        private uc.ucSpeechControl ucSpeechControlReadingCompre1;
        private uc.ucSpeechControl ucSpeechControlNonVoice;
        private uc.ucSpeechControl ucSpeechControlReadingCompre;
        private uc.ucTextBox txtTitle;
        private Panel panel5;
        private RichTextBox rtbReadingCompre;
        private Button btnLogin;
        private Button btnMultipleChoice;
        private RichTextBox richTextBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnSave;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnIdentification;
        private Label label4;
        private TableLayoutPanel tlpQuestions;
        private Panel pnlReadingCompre;
        private uc.ucSpeechControl ucSpeechControlVoice;
        private uc.ucTextBox txtTitle1;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label5;
        private ComboBox cbType;
        private Label label6;
        private ComboBox cbGrade;
        private Label label7;
        private ComboBox cbSchoolYear;
    }
}