namespace BARApp.Views.ActivityPages
{
    partial class ReadingCompre
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
            panel1 = new Panel();
            tlpContent = new TableLayoutPanel();
            lblContent = new Label();
            panel1.SuspendLayout();
            tlpContent.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tlpContent);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 750);
            panel1.TabIndex = 1;
            // 
            // tlpContent
            // 
            tlpContent.AutoScroll = true;
            tlpContent.ColumnCount = 1;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContent.Controls.Add(lblContent, 0, 0);
            tlpContent.Dock = DockStyle.Fill;
            tlpContent.Location = new Point(0, 0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 2;
            tlpContent.RowStyles.Add(new RowStyle());
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            tlpContent.Size = new Size(945, 750);
            tlpContent.TabIndex = 1;
            // 
            // lblContent
            // 
            lblContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContent.ForeColor = Color.DimGray;
            lblContent.Location = new Point(3, 0);
            lblContent.Margin = new Padding(3, 0, 3, 20);
            lblContent.Name = "lblContent";
            lblContent.Padding = new Padding(0, 20, 0, 0);
            lblContent.Size = new Size(939, 104);
            lblContent.TabIndex = 0;
            lblContent.Text = "This is a samplte title\r\n\r\nThis is a sample content";
            lblContent.TextAlign = ContentAlignment.TopCenter;
            // 
            // ReadingCompre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 750);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReadingCompre";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "Reading Comprehension";
            Text = "ReadingCompre";
            panel1.ResumeLayout(false);
            tlpContent.ResumeLayout(false);
            tlpContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tlpContent;
        private Label lblContent;
    }
}