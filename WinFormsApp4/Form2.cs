using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Text;
using WinFormsApp4;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsApp4.data;
using System.ComponentModel;

namespace WinFormsApp4
{
    public partial class Sign_up_form : Form
    {



        public Sign_up_form()
        {
             InitializeComponent();
            // default photo on pt3
            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\user.jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            EmployeeTable emp = new EmployeeTable
            {
                name = this.name_txtbox.Text,
                employee_n_id = this.National_id_txtbox.Text,
                password = this.password_txtbox.Text,
                email = this.email_txtbox.Text,
                user_name = this.user_txtbox.Text,
                phone_number = this.phone_num_txtbox.Text,
                photo_path = this.pictureBox1.ImageLocation
            };


            List<string> empty_ent = new List<string>();

            if (string.IsNullOrEmpty(emp.name) && string.IsNullOrWhiteSpace(emp.name))
                empty_ent.Add("Name");

            if (string.IsNullOrEmpty(emp.employee_n_id) && string.IsNullOrWhiteSpace(emp.employee_n_id))
                empty_ent.Add("National id");

            if (string.IsNullOrEmpty(emp.phone_number) && string.IsNullOrWhiteSpace(emp.phone_number))
                empty_ent.Add("Phone Number");

            if (string.IsNullOrEmpty(emp.email) && string.IsNullOrWhiteSpace(emp.email))
                empty_ent.Add("Email");
            if (string.IsNullOrEmpty(emp.user_name) && string.IsNullOrWhiteSpace(emp.user_name))
                empty_ent.Add("User Name");
            if (string.IsNullOrEmpty(emp.password) && string.IsNullOrWhiteSpace(emp.password))
                empty_ent.Add("Password");

            if (empty_ent.Count > 0)
            {
                StringBuilder empty_fields = new StringBuilder();
                foreach (string field in empty_ent)
                {
                    empty_fields.Append(field);
                    empty_fields.Append("\n");
                }
                MessageBox.Show($"These Fields can not be empty\n{empty_fields.ToString()}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string confirmed_pass = this.cpass_txtbox.Text;
                if (emp.password == confirmed_pass)
                {
                    db.employees.Add(emp);
                    db.SaveChanges();
                    Application.OpenForms[0].Show();
                    this.Close();


                    MessageBox.Show("Done", "Registration complete", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Regeister not complete, please check that password is the same as comfirmed passwoard"
                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }


            // MessageBox.Show(emp.email);
        }

        private void Sign_up_form_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                openFileDialog1.Title = "Select your personal photo";
                openFileDialog1.ShowDialog();
                imagelocation = openFileDialog1.FileName;
                pictureBox1.ImageLocation = imagelocation;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
