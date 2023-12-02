using WinFormsApp4.data;
namespace WinFormsApp4
{
    partial class Sign_up_form
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
        AppDbContext db = AppDbContext.Instance;
        private void InitializeComponent()
        {
            label1 = new Label();
            name_txtbox = new TextBox();
            label2 = new Label();
            phone_num_txtbox = new TextBox();
            label3 = new Label();
            password_txtbox = new TextBox();
            label4 = new Label();
            email_txtbox = new TextBox();
            label5 = new Label();
            cpass_txtbox = new TextBox();
            label6 = new Label();
            National_id_txtbox = new TextBox();
            label7 = new Label();
            user_txtbox = new TextBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(403, 49);
            label1.Name = "label1";
            label1.Size = new Size(93, 37);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // name_txtbox
            // 
            name_txtbox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            name_txtbox.Location = new Point(335, 89);
            name_txtbox.Multiline = true;
            name_txtbox.Name = "name_txtbox";
            name_txtbox.Size = new Size(251, 48);
            name_txtbox.TabIndex = 3;
            name_txtbox.TextAlign = HorizontalAlignment.Center;
            name_txtbox.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(694, 155);
            label2.Name = "label2";
            label2.Size = new Size(139, 37);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // phone_num_txtbox
            // 
            phone_num_txtbox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            phone_num_txtbox.Location = new Point(335, 310);
            phone_num_txtbox.Multiline = true;
            phone_num_txtbox.Name = "phone_num_txtbox";
            phone_num_txtbox.Size = new Size(251, 48);
            phone_num_txtbox.TabIndex = 5;
            phone_num_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(410, 373);
            label3.Name = "label3";
            label3.Size = new Size(87, 37);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // password_txtbox
            // 
            password_txtbox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            password_txtbox.Location = new Point(648, 195);
            password_txtbox.Multiline = true;
            password_txtbox.Name = "password_txtbox";
            password_txtbox.PasswordChar = '*';
            password_txtbox.Size = new Size(251, 48);
            password_txtbox.TabIndex = 7;
            password_txtbox.TextAlign = HorizontalAlignment.Center;
            password_txtbox.TextChanged += password_txtbox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(379, 155);
            label4.Name = "label4";
            label4.Size = new Size(160, 37);
            label4.TabIndex = 10;
            label4.Text = "National id";
            // 
            // email_txtbox
            // 
            email_txtbox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            email_txtbox.Location = new Point(335, 413);
            email_txtbox.Multiline = true;
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Size = new Size(251, 48);
            email_txtbox.TabIndex = 9;
            email_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(648, 270);
            label5.Name = "label5";
            label5.Size = new Size(251, 37);
            label5.TabIndex = 12;
            label5.Text = "Confirm password";
            // 
            // cpass_txtbox
            // 
            cpass_txtbox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            cpass_txtbox.Location = new Point(648, 310);
            cpass_txtbox.Multiline = true;
            cpass_txtbox.Name = "cpass_txtbox";
            cpass_txtbox.PasswordChar = '*';
            cpass_txtbox.Size = new Size(251, 48);
            cpass_txtbox.TabIndex = 11;
            cpass_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(694, 49);
            label6.Name = "label6";
            label6.Size = new Size(158, 37);
            label6.TabIndex = 14;
            label6.Text = "User Name";
            // 
            // National_id_txtbox
            // 
            National_id_txtbox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            National_id_txtbox.Location = new Point(335, 195);
            National_id_txtbox.Multiline = true;
            National_id_txtbox.Name = "National_id_txtbox";
            National_id_txtbox.Size = new Size(251, 48);
            National_id_txtbox.TabIndex = 13;
            National_id_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(358, 270);
            label7.Name = "label7";
            label7.Size = new Size(210, 37);
            label7.TabIndex = 16;
            label7.Text = "Phone Number";
            // 
            // user_txtbox
            // 
            user_txtbox.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            user_txtbox.Location = new Point(648, 89);
            user_txtbox.Multiline = true;
            user_txtbox.Name = "user_txtbox";
            user_txtbox.Size = new Size(251, 48);
            user_txtbox.TabIndex = 15;
            user_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(48, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(59, 310);
            button2.Name = "button2";
            button2.Size = new Size(181, 30);
            button2.TabIndex = 18;
            button2.Text = "Select photo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowFrame;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(648, 413);
            button1.Name = "button1";
            button1.Size = new Size(251, 48);
            button1.TabIndex = 0;
            button1.Text = "Regisiter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Sign_up_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 486);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(user_txtbox);
            Controls.Add(label6);
            Controls.Add(National_id_txtbox);
            Controls.Add(label5);
            Controls.Add(cpass_txtbox);
            Controls.Add(label4);
            Controls.Add(email_txtbox);
            Controls.Add(label3);
            Controls.Add(password_txtbox);
            Controls.Add(label2);
            Controls.Add(phone_num_txtbox);
            Controls.Add(label1);
            Controls.Add(name_txtbox);
            Controls.Add(button1);
            Name = "Sign_up_form";
            Text = "Sign up ";
            Load += Sign_up_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox name_txtbox;
        private Label label2;
        private TextBox phone_num_txtbox;
        private Label label3;
        private TextBox password_txtbox;
        private Label label4;
        private TextBox email_txtbox;
        private Label label5;
        private TextBox cpass_txtbox;
        private Label label6;
        private TextBox National_id_txtbox;
        private Label label7;
        private TextBox user_txtbox;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private Button button1;
    }
}