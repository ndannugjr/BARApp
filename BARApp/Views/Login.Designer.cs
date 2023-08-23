namespace BARApp.Views
{
    partial class Login
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            txtUserName = new uc.ucTextBox();
            label2 = new Label();
            txtPassword = new uc.ucTextBox();
            btnLogin = new Button();
            txtErrorMessage = new Label();
            panel1 = new Panel();
            errorProvider = new ErrorProvider(components);
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(0, 192, 192);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.66667F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.7777748F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.555555F));
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(txtUserName, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 3);
            tableLayoutPanel2.Controls.Add(txtPassword, 0, 4);
            tableLayoutPanel2.Controls.Add(btnLogin, 0, 5);
            tableLayoutPanel2.Controls.Add(txtErrorMessage, 0, 6);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(382, 453);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label1, 2);
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 199);
            label1.Margin = new Padding(13, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.BackColor = SystemColors.Window;
            txtUserName.BorderColor = Color.FromArgb(118, 113, 113);
            txtUserName.BorderFocusColor = Color.FromArgb(52, 139, 95);
            txtUserName.BorderSize = 2;
            tableLayoutPanel2.SetColumnSpan(txtUserName, 2);
            txtUserName.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.DimGray;
            txtUserName.IsAlphabet = false;
            txtUserName.IsAlphaDash = false;
            txtUserName.IsAlphaNumeric = false;
            txtUserName.IsAlphaNumericDash = false;
            txtUserName.Location = new Point(13, 236);
            txtUserName.Margin = new Padding(13, 5, 4, 5);
            txtUserName.Multiline = false;
            txtUserName.Name = "txtUserName";
            txtUserName.Padding = new Padding(4);
            txtUserName.PasswordChar = false;
            txtUserName.Size = new Size(343, 37);
            txtUserName.TabIndex = 1;
            txtUserName.Texts = "admin";
            txtUserName.UnderlinedStyle = false;
            txtUserName._TextChanged += txt_TextChanged;
            txtUserName.KeyDown += txtUserName_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(label2, 2);
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 278);
            label2.Margin = new Padding(13, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderColor = Color.FromArgb(118, 113, 113);
            txtPassword.BorderFocusColor = Color.FromArgb(52, 139, 95);
            txtPassword.BorderSize = 2;
            tableLayoutPanel2.SetColumnSpan(txtPassword, 2);
            txtPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.IsAlphabet = false;
            txtPassword.IsAlphaDash = false;
            txtPassword.IsAlphaNumeric = false;
            txtPassword.IsAlphaNumericDash = false;
            txtPassword.Location = new Point(13, 315);
            txtPassword.Margin = new Padding(13, 5, 4, 5);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(4);
            txtPassword.PasswordChar = true;
            txtPassword.Size = new Size(343, 37);
            txtPassword.TabIndex = 3;
            txtPassword.Texts = "123456";
            txtPassword.UnderlinedStyle = false;
            txtPassword._TextChanged += txt_TextChanged;
            txtPassword.KeyDown += txtUserName_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(192, 255, 255);
            tableLayoutPanel2.SetColumnSpan(btnLogin, 2);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(68, 114, 196);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.DimGray;
            btnLogin.Location = new Point(13, 360);
            btnLogin.Margin = new Padding(13, 3, 3, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(344, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtErrorMessage
            // 
            tableLayoutPanel2.SetColumnSpan(txtErrorMessage, 3);
            txtErrorMessage.Dock = DockStyle.Fill;
            txtErrorMessage.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtErrorMessage.ForeColor = Color.Red;
            txtErrorMessage.Location = new Point(3, 403);
            txtErrorMessage.Name = "txtErrorMessage";
            txtErrorMessage.Padding = new Padding(5);
            txtErrorMessage.Size = new Size(376, 50);
            txtErrorMessage.TabIndex = 5;
            txtErrorMessage.Text = "error msg";
            txtErrorMessage.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.BackgroundImage = Properties.Resources.LoginLogo5;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            tableLayoutPanel2.SetColumnSpan(panel1, 3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(3, 3, 3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 196);
            panel1.TabIndex = 6;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 453);
            Controls.Add(tableLayoutPanel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BE A READER!";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private uc.ucTextBox txtUserName;
        private Label label2;
        private uc.ucTextBox txtPassword;
        private Button btnLogin;
        private Label txtErrorMessage;
        private Panel panel1;
        private ErrorProvider errorProvider;
    }
}