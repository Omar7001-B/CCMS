using System.Collections.Specialized;
using WinFormsApp4.data;
using WinFormsApp4;

namespace WinFormsApp4
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
            //emp_name.Text = db.employees.Where((x) => x.employee_n_id == employee_n_id) .FirstOrDefault() .name; 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_up_form frm2 = new Sign_up_form();
            frm2.ShowDialog();
            //this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           //MessageBox.Show(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
            string user_name_in = textBox1.Text;
            string password_in = textBox2.Text;
            if (!string.IsNullOrWhiteSpace(user_name_in) &&
                !string.IsNullOrWhiteSpace(password_in))
            {
                var emp = db.employees.
                   Where(a => a.user_name == user_name_in && a.password == password_in).FirstOrDefault();
                if (emp != null)
                {
                    MessageBox.Show("Welcome" , emp.name , MessageBoxButtons.OK,MessageBoxIcon.Information);
                    program_main_form frm = new program_main_form(emp.employee_n_id);
                    frm.Show();
                    this.Hide();
                } 
                else
                {
                    MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("please enter user name and password");
            }
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
 
            if (db.Database.EnsureCreated())
            {
                MessageBox.Show("connection doen");
            }
            else
            {
                MessageBox.Show("connection is already done");
            }
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {

        }
    }
}