using WinFormsApp4.data;
using System.Windows.Forms;
namespace funcs
{
  public static class ValidationMethods
  {

    public static List<string> Employee(EmployeeTable emp)
    {
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
      return empty_ent;
    }
    public static void password(EmployeeTable emp, string confirmed_pass,Form form){
        if (emp.password == confirmed_pass)
        {
          DataBaseMethods.addEmployee(emp);
          MessageBox.Show("Done", "Registration complete", MessageBoxButtons.OK,
          MessageBoxIcon.Information);
        }
        else
        {
          MessageBox.Show("Regeister not complete, please check that password is the same as comfirmed passwoard"
              , "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
  }
  public static class DataBaseMethods
  {
    static AppDbContext db = AppDbContext.Instance;
    public static void AddEmployee(EmployeeTable emp)
    {
      {
        db.employees.Add(emp);
        db.SaveChanges();
      }
    }
  }
}
