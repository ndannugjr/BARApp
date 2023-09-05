namespace BARApp.Views
{
    partial class Activities
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
            tlpBg = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            lblReminder = new Label();
            panel2 = new Panel();
            tlpActivities = new TableLayoutPanel();
            timer = new System.Windows.Forms.Timer(components);
            tlpBg.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tlpBg
            // 
            tlpBg.AutoScroll = true;
            tlpBg.ColumnCount = 1;
            tlpBg.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBg.Controls.Add(panel1, 0, 0);
            tlpBg.Controls.Add(panel2, 0, 1);
            tlpBg.Dock = DockStyle.Fill;
            tlpBg.Location = new Point(0, 0);
            tlpBg.Name = "tlpBg";
            tlpBg.RowCount = 2;
            tlpBg.RowStyles.Add(new RowStyle());
            tlpBg.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBg.Size = new Size(1106, 757);
            tlpBg.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 137);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(lblReminder, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1098, 135);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(1092, 68);
            label2.TabIndex = 1;
            label2.Text = "Make sure you're all set before taking an activity. Bring your water and snacks. Good luck!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReminder
            // 
            lblReminder.AutoSize = true;
            lblReminder.Dock = DockStyle.Fill;
            lblReminder.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblReminder.ForeColor = Color.Red;
            lblReminder.Location = new Point(3, 0);
            lblReminder.Name = "lblReminder";
            lblReminder.Size = new Size(1092, 67);
            lblReminder.TabIndex = 0;
            lblReminder.Text = "REMINDER!";
            lblReminder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(tlpActivities);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 608);
            panel2.TabIndex = 1;
            // 
            // tlpActivities
            // 
            tlpActivities.BackColor = Color.White;
            tlpActivities.ColumnCount = 1;
            tlpActivities.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpActivities.Dock = DockStyle.Fill;
            tlpActivities.Location = new Point(0, 0);
            tlpActivities.Name = "tlpActivities";
            tlpActivities.RowCount = 1;
            tlpActivities.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpActivities.Size = new Size(1100, 608);
            tlpActivities.TabIndex = 0;
            // 
            // timer
            // 
            timer.Interval = 500;
            timer.Tick += timer_Tick;
            // 
            // Activities
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1106, 757);
            Controls.Add(tlpBg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Activities";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Activities";
            tlpBg.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label lblReminder;
        private System.Windows.Forms.Timer timer;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tlpBg;
        private Panel panel2;
        private TableLayoutPanel tlpActivities;
    }
}