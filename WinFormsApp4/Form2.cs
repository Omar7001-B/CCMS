using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.Windows.Forms;
using WinFormsApp4.data;
using System.ComponentModel;
using funcs;

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
      List<string> empty_ent = ValidationMethods.Employee(emp);

      if (empty_ent.Count > 0)
      {
        MessageBox.Show($"These Fields can not be empty\n{string.Join("\n", empty_ent)}", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      else
      {
        string confirmed_pass = this.cpass_txtbox.Text;
        if(ValidationMethods.password(emp,confirmed_pass,this)){
          DataBaseMethods.AddEmployee(emp);
          Application.OpenForms[0].Show();
          this.Close();
        }
      }


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
