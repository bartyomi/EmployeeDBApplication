using System;
using System.Windows.Forms;
using EmployeeDBLibrary;

namespace EmployeeDBApplication;

public partial class EditForm : Form
{
    public Employee Employee { get; private set; }

    public EditForm()
    {
        InitializeComponent();
        Employee = new Employee();
        Text = "Add New Employee";
    }

    public EditForm (Employee employeeToEdit)
    {
        InitializeComponent();
        Employee = employeeToEdit;
        Text = "Edit Employee";
        PopulateFields();
    }

    private void PopulateFields()
    {
        txtFirstName.Text = Employee.FirstName;
        txtLastName.Text = Employee.LastName;
        txtEmail.Text = Employee.Email;
        dtpDateOfBirth.Value = Employee.DateOfBirth.ToDateTime(TimeOnly.MinValue);
        numSalary.Value = Employee.Salary;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        if (ValidateForm())
        {
            Employee.FirstName = txtFirstName.Text;
            Employee.LastName = txtLastName.Text;
            Employee.Email = txtEmail.Text;
            Employee.DateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
            Employee.Salary = numSalary.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }

    private bool ValidateForm()
    {
        if (string.IsNullOrWhiteSpace(txtFirstName.Text))
        {
            MessageBox.Show("First name is required.", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtLastName.Text))
        {
            MessageBox.Show("Last name is required.", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
        {
            MessageBox.Show("Valid email is required.", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (dtpDateOfBirth.Value > DateTime.Now.AddYears(-14))
        {
            MessageBox.Show("Employee must be at least 14 years old.", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (numSalary.Value <= 0)
        {
            MessageBox.Show("Salary must be greater than 0.", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
