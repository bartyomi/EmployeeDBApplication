using EmployeeDBLibrary;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EmployeeDBLibrary;


namespace EmployeeDBApplication;

public partial class MainForm : Form
{
    private EmployeeManagement _management;
    private DataTable _employeesTable;

    public MainForm()
    {
        InitializeComponent();

        _management = new EmployeeManagement(new EmployeeContext());

        InitializeDataGridView();
        LoadEmployees();
    }

    private void InitializeDatabase()
    {
        _management = new EmployeeManagement(new EmployeeContext());
    }

    private void InitializeDataGridView()
    {
        _employeesTable = new DataTable();
        _employeesTable.Columns.Add("ID", typeof(int));
        _employeesTable.Columns.Add("First Name", typeof(string));
        _employeesTable.Columns.Add("Last Name", typeof(string));
        _employeesTable.Columns.Add("Email", typeof(string));
        _employeesTable.Columns.Add("Date of Birth", typeof(DateTime));
        _employeesTable.Columns.Add("Salary", typeof(decimal));

        dataGridViewEmployees.DataSource = _employeesTable;
        dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewEmployees.ReadOnly = true;
    }

    private async void LoadEmployees()
    {
        _employeesTable.Rows.Clear();
        var employees = await _management.GetAll();

        foreach (var emp in employees)
        {
            _employeesTable.Rows.Add(emp.EmployeeID, emp.FirstName, emp.LastName,
                                   emp.Email, emp.DateOfBirth, emp.Salary);
        }
    }

    private async void buttonAdd_Click(object sender, EventArgs e)
    {
        var addForm = new EditForm();
        if (addForm.ShowDialog() == DialogResult.OK)
        {

            await _management.Add(addForm.Employee);
            LoadEmployees();
        }
    }

    private async void buttonEdit_Click(object sender, EventArgs e)
    {
        if (dataGridViewEmployees.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select an employee to edit.", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int selectedId = (int)dataGridViewEmployees.SelectedRows[0].Cells["ID"].Value;
        var employeeToEdit = await _management.GetById(selectedId);

        var editForm = new EditForm(employeeToEdit);
        if (editForm.ShowDialog() == DialogResult.OK)
        {
            var employee = editForm.Employee;
            await _management.Update(selectedId, employee.FirstName, employee.LastName, employee.Email, employee.DateOfBirth, employee.Salary);
            LoadEmployees();
        }
    }

    private async void buttonDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewEmployees.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select an employee to delete.", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int selectedId = (int)dataGridViewEmployees.SelectedRows[0].Cells["ID"].Value;
        var employeeToDelete = await _management.GetById(selectedId);

        var result = MessageBox.Show($"Are you sure you want to delete {employeeToDelete.FirstName} {employeeToDelete.LastName}?",
                                   "Confirm Delete",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            await _management.Delete(selectedId);
            LoadEmployees();
        }
    }

    private void buttonRefresh_Click(object sender, EventArgs e)
    {
        LoadEmployees();
    }
}
