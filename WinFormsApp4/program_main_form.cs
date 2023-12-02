using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormsApp4.data;

namespace WinFormsApp4
{
    public partial class program_main_form : Form
    {
        public program_main_form(string employee_n_id)
        {
            this.employee_n_id = employee_n_id;
            name_label_text = db.employees
                .Where((x) => x.employee_n_id == employee_n_id).FirstOrDefault().name;
            InitializeComponent();
        }

        private void Log_out_btn_Click(object sender, EventArgs e)
        {





            MessageBox.Show("Are you sure ?", "LOG OUT",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void program_main_form_Load(object sender, EventArgs e)
        {

        }

        private void History_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
