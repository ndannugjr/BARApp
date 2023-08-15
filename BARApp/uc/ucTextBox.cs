using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BARApp.uc
{
    [DefaultEvent("_TextChanged")]
    public partial class ucTextBox : UserControl
    {
        private Color borderColor = Color.FromArgb(118, 113, 113);
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.FromArgb(52, 139, 95);
        private bool isFocused = false;
        private static string alphaNumericDash = "[^0-9a-zA-Z -]";
        private static string alphaNumeric = "[^0-9a-zA-Z ]";
        private static string alphaDash = "[^a-zA-Z -]";
        private static string alpha = "[^a-zA-Z ]";
        private bool isAlphabet = false;
        private bool isAlphaNumeric = false;
        private bool isAlphaNumericDash = false;
        private TextBox textBox1;
        private bool isAlphaDash = false;

        public bool IsAlphaNumeric { get { return isAlphaNumeric; } set { isAlphaNumeric = value; if (isAlphaNumeric) { IsAlphaNumericDash = false; IsAlphaDash = false; isAlphabet = false; } } }
        public bool IsAlphaNumericDash { get { return isAlphaNumericDash; } set { isAlphaNumericDash = value; if (isAlphaNumericDash) { IsAlphaNumeric = false; IsAlphaDash = false; isAlphabet = false; } } }
        public bool IsAlphaDash { get { return isAlphaDash; } set { isAlphaDash = value; if (isAlphaDash) { IsAlphaNumeric = false; isAlphaNumericDash = false; isAlphabet = false; } } }

        public bool IsAlphabet { get { return isAlphabet; } set { isAlphabet = value; if (isAlphabet) { IsAlphaNumericDash = false; IsAlphaDash = false; isAlphaNumeric = false; } } }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set { underlinedStyle = value; this.Invalidate(); }
        }

        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        [DefaultValue(32767)]
        [Localizable(true)]
        [Description("TextBoxMaxLengthDescr")]
        public int MaxLength
        {
            get
            {
                return textBox1.MaxLength;
            }
            set
            {
                textBox1.MaxLength = value;
            }
        }

        [DefaultValue(CharacterCasing.Normal)]
        [Description("TextBoxCharacterCasingDescr")]
        public CharacterCasing CharacterCasing
        {
            get
            {
                return textBox1.CharacterCasing;
            }
            set
            {
                textBox1.CharacterCasing = value;
            }
        }

        public event EventHandler _TextChanged;
        public ucTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused) penBorder.Color = borderFocusColor;

                if (underlinedStyle) //Line Style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else //Normal Style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                if (IsAlphaNumeric || isAlphaNumericDash || IsAlphaDash || IsAlphabet)
                {
                    string regex;
                    if (IsAlphaDash)
                        regex = alphaDash;
                    else if (IsAlphaNumeric)
                        regex = alphaNumeric;
                    else if (IsAlphabet)
                        regex = alpha;
                    else
                        regex = alphaNumericDash;

                    var textboxSender = (TextBox)sender;
                    var cursorPosition = textboxSender.SelectionStart;
                    textboxSender.Text = Regex.Replace(textboxSender.Text, regex, "");
                    textboxSender.SelectionStart = cursorPosition;
                }

                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 1;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyDown += textBox1_KeyDown;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            textBox1.MouseEnter += textBox1_MouseEnter;
            textBox1.MouseLeave += textBox1_MouseLeave;
            // 
            // ucTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(textBox1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ucTextBox";
            Padding = new Padding(4);
            Size = new Size(250, 36);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
