using WinFormsApp4.data;
namespace WinFormsApp4
{
    partial class Login_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        AppDbContext db = AppDbContext.Instance ; 
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            PassBox = new TextBox();
            UserLabel = new Label();
            PassLabel = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            EnsureCon = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(270, 108);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 48);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // PassBox
            // 
            PassBox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            PassBox.Location = new Point(270, 217);
            PassBox.Multiline = true;
            PassBox.Name = "textBox2";
            PassBox.PasswordChar = '*';
            PassBox.Size = new Size(251, 48);
            PassBox.TabIndex = 1;
            PassBox.TextAlign = HorizontalAlignment.Center;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            UserLabel.Location = new Point(318, 68);
            UserLabel.Name = "label1";
            UserLabel.Size = new Size(158, 37);
            UserLabel.TabIndex = 2;
            UserLabel.Text = "User Name";
            // 
            // label2
            // 
            PassLabel.AutoSize = true;
            PassLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            PassLabel.Location = new Point(318, 177);
            PassLabel.Name = "label2";
            PassLabel.Size = new Size(139, 37);
            PassLabel.TabIndex = 3;
            PassLabel.Text = "Password";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(338, 311);
            button1.Name = "button1";
            button1.Size = new Size(119, 37);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(307, 379);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(179, 21);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Do not have account ?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            EnsureCon.BackColor = SystemColors.ControlDarkDark;
            EnsureCon.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            EnsureCon.ForeColor = SystemColors.ButtonHighlight;
            EnsureCon.Location = new Point(567, 401);
            EnsureCon.Name = "button2";
            EnsureCon.Size = new Size(221, 37);
            EnsureCon.TabIndex = 6;
            EnsureCon.Text = "Check Connection";
            EnsureCon.UseVisualStyleBackColor = false;
            EnsureCon.Click += EnsureCon_Click;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EnsureCon);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(PassLabel);
            Controls.Add(UserLabel);
            Controls.Add(PassBox);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in";
            Load += Login_Page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox PassBox;
        private Label UserLabel;
        private Label PassLabel;
        private Button button1;
        private LinkLabel linkLabel1;
        private Button EnsureCon;
    }
}
