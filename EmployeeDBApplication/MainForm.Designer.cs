using System.Windows.Forms;

namespace EmployeeDBApplication;
partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    private DataGridView dataGridViewEmployees;
    private Button buttonAdd;
    private Button buttonEdit;
    private Button buttonDelete;
    private Button buttonRefresh;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        dataGridViewEmployees = new DataGridView();
        buttonAdd = new Button();
        buttonEdit = new Button();
        buttonDelete = new Button();
        buttonRefresh = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewEmployees
        // 
        dataGridViewEmployees.AllowUserToAddRows = false;
        dataGridViewEmployees.AllowUserToDeleteRows = false;
        dataGridViewEmployees.BackgroundColor = System.Drawing.SystemColors.Info;
        dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewEmployees.GridColor = System.Drawing.SystemColors.ControlLightLight;
        dataGridViewEmployees.Location = new System.Drawing.Point(16, 18);
        dataGridViewEmployees.Margin = new Padding(4, 5, 4, 5);
        dataGridViewEmployees.Name = "dataGridViewEmployees";
        dataGridViewEmployees.ReadOnly = true;
        dataGridViewEmployees.RowHeadersWidth = 51;
        dataGridViewEmployees.Size = new System.Drawing.Size(1013, 615);
        dataGridViewEmployees.TabIndex = 0;
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new System.Drawing.Point(16, 643);
        buttonAdd.Margin = new Padding(4, 5, 4, 5);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new System.Drawing.Size(133, 46);
        buttonAdd.TabIndex = 1;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonEdit
        // 
        buttonEdit.Location = new System.Drawing.Point(157, 643);
        buttonEdit.Margin = new Padding(4, 5, 4, 5);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new System.Drawing.Size(133, 46);
        buttonEdit.TabIndex = 2;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = true;
        buttonEdit.Click += buttonEdit_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.Location = new System.Drawing.Point(299, 643);
        buttonDelete.Margin = new Padding(4, 5, 4, 5);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new System.Drawing.Size(133, 46);
        buttonDelete.TabIndex = 3;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // buttonRefresh
        // 
        buttonRefresh.Location = new System.Drawing.Point(896, 643);
        buttonRefresh.Margin = new Padding(4, 5, 4, 5);
        buttonRefresh.Name = "buttonRefresh";
        buttonRefresh.Size = new System.Drawing.Size(133, 46);
        buttonRefresh.TabIndex = 4;
        buttonRefresh.Text = "Refresh";
        buttonRefresh.UseVisualStyleBackColor = true;
        buttonRefresh.Click += buttonRefresh_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Highlight;
        ClientSize = new System.Drawing.Size(1045, 709);
        Controls.Add(buttonRefresh);
        Controls.Add(buttonDelete);
        Controls.Add(buttonEdit);
        Controls.Add(buttonAdd);
        Controls.Add(dataGridViewEmployees);
        Margin = new Padding(4, 5, 4, 5);
        Name = "MainForm";
        Text = "Employee Management System";
        ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
        ResumeLayout(false);
    }
}