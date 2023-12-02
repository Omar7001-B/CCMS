using WinFormsApp4;
using WinFormsApp4.data;
namespace WinFormsApp4
{
    partial class program_main_form
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
            Button FindSTU_btn;
            Button StudentOut;
            Button History;
            Log_out_btn = new Button();
            emp_name = new Label();
            FindSTU_btn = new Button();
            StudentOut = new Button();
            History = new Button();
            SuspendLayout();
            // 
            // FindSTU_btn
            // 
            FindSTU_btn.BackColor = SystemColors.ControlDarkDark;
            FindSTU_btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            FindSTU_btn.ForeColor = SystemColors.ButtonHighlight;
            FindSTU_btn.Location = new Point(12, 73);
            FindSTU_btn.Name = "FindSTU_btn";
            FindSTU_btn.Size = new Size(166, 46);
            FindSTU_btn.TabIndex = 1;
            FindSTU_btn.Text = "Stuedent In";
            FindSTU_btn.UseVisualStyleBackColor = false;
            // 
            // StudentOut
            // 
            StudentOut.BackColor = SystemColors.ControlDarkDark;
            StudentOut.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            StudentOut.ForeColor = SystemColors.ButtonHighlight;
            StudentOut.Location = new Point(12, 125);
            StudentOut.Name = "StudentOut";
            StudentOut.Size = new Size(166, 46);
            StudentOut.TabIndex = 2;
            StudentOut.Text = "Stuedent Out";
            StudentOut.UseVisualStyleBackColor = false;
            // 
            // History
            // 
            History.BackColor = SystemColors.ControlDarkDark;
            History.Cursor = Cursors.SizeAll;
            History.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            History.ForeColor = SystemColors.ButtonHighlight;
            History.Location = new Point(12, 177);
            History.Name = "History";
            History.Size = new Size(166, 46);
            History.TabIndex = 3;
            History.Text = "History";
            History.UseVisualStyleBackColor = false;
            History.Click += History_Click;
            // 
            // Log_out_btn
            // 
            Log_out_btn.BackColor = SystemColors.ControlDarkDark;
            Log_out_btn.FlatStyle = FlatStyle.Popup;
            Log_out_btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Log_out_btn.ForeColor = SystemColors.ButtonHighlight;
            Log_out_btn.Location = new Point(668, 391);
            Log_out_btn.Name = "Log_out_btn";
            Log_out_btn.Size = new Size(110, 47);
            Log_out_btn.TabIndex = 0;
            Log_out_btn.Text = "Log out";
            Log_out_btn.UseVisualStyleBackColor = false;
            Log_out_btn.Click += Log_out_btn_Click;
            // 
            // emp_name
            // 
            emp_name.AutoSize = true;
            emp_name.BackColor = Color.DarkSlateBlue;
            emp_name.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            emp_name.ForeColor = SystemColors.ButtonHighlight;
            emp_name.Location = new Point(22, 32);
            emp_name.Name = "emp_name";
            emp_name.Size = new Size(0, 25);
            emp_name.TabIndex = 4;
            emp_name.Text = name_label_text; 
            // 
            // program_main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(emp_name);
            Controls.Add(History);
            Controls.Add(StudentOut);
            Controls.Add(FindSTU_btn);
            Controls.Add(Log_out_btn);
            Name = "program_main_form";
            Text = "program_main_form";
            Load += program_main_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Log_out_btn;
        private Button FindSTU_btn;
        private Label emp_name;
        private string employee_n_id;
        private string name_label_text;
    }

}