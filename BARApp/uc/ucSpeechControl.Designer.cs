namespace BARApp.uc
{
    partial class ucSpeechControl
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
            tableLayoutPanel3 = new TableLayoutPanel();
            btnPause = new Button();
            btnPlay = new Button();
            btnStop = new Button();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(btnPause, 1, 0);
            tableLayoutPanel3.Controls.Add(btnPlay, 2, 0);
            tableLayoutPanel3.Controls.Add(btnStop, 4, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(300, 50);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // btnPause
            // 
            btnPause.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnPause.BackColor = Color.Transparent;
            btnPause.Enabled = false;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPause.ForeColor = Color.DimGray;
            btnPause.Location = new Point(3, 3);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(94, 44);
            btnPause.TabIndex = 0;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // btnPlay
            // 
            btnPlay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnPlay.BackColor = Color.Transparent;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlay.ForeColor = Color.DimGray;
            btnPlay.Location = new Point(103, 3);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(94, 44);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Hear";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnStop
            // 
            btnStop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnStop.BackColor = Color.Transparent;
            btnStop.Enabled = false;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnStop.ForeColor = Color.DimGray;
            btnStop.Location = new Point(203, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 44);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // ucSpeechControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel3);
            Name = "ucSpeechControl";
            Size = new Size(300, 50);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Button btnPause;
        private Button btnPlay;
        private Button btnStop;
    }
}