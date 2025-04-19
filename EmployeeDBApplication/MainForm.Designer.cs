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
        this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
        this.buttonAdd = new System.Windows.Forms.Button();
        this.buttonEdit = new System.Windows.Forms.Button();
        this.buttonDelete = new System.Windows.Forms.Button();
        this.buttonRefresh = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
        this.SuspendLayout();

        // dataGridViewEmployees
        this.dataGridViewEmployees.AllowUserToAddRows = false;
        this.dataGridViewEmployees.AllowUserToDeleteRows = false;
        this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewEmployees.Location = new System.Drawing.Point(12, 12);
        this.dataGridViewEmployees.Name = "dataGridViewEmployees";
        this.dataGridViewEmployees.ReadOnly = true;
        this.dataGridViewEmployees.Size = new System.Drawing.Size(760, 400);
        this.dataGridViewEmployees.TabIndex = 0;

        // buttonAdd
        this.buttonAdd.Location = new System.Drawing.Point(12, 418);
        this.buttonAdd.Name = "buttonAdd";
        this.buttonAdd.Size = new System.Drawing.Size(100, 30);
        this.buttonAdd.TabIndex = 1;
        this.buttonAdd.Text = "Add";
        this.buttonAdd.UseVisualStyleBackColor = true;
        this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

        // buttonEdit
        this.buttonEdit.Location = new System.Drawing.Point(118, 418);
        this.buttonEdit.Name = "buttonEdit";
        this.buttonEdit.Size = new System.Drawing.Size(100, 30);
        this.buttonEdit.TabIndex = 2;
        this.buttonEdit.Text = "Edit";
        this.buttonEdit.UseVisualStyleBackColor = true;
        this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);

        // buttonDelete
        this.buttonDelete.Location = new System.Drawing.Point(224, 418);
        this.buttonDelete.Name = "buttonDelete";
        this.buttonDelete.Size = new System.Drawing.Size(100, 30);
        this.buttonDelete.TabIndex = 3;
        this.buttonDelete.Text = "Delete";
        this.buttonDelete.UseVisualStyleBackColor = true;
        this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

        // buttonRefresh
        this.buttonRefresh.Location = new System.Drawing.Point(672, 418);
        this.buttonRefresh.Name = "buttonRefresh";
        this.buttonRefresh.Size = new System.Drawing.Size(100, 30);
        this.buttonRefresh.TabIndex = 4;
        this.buttonRefresh.Text = "Refresh";
        this.buttonRefresh.UseVisualStyleBackColor = true;
        this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);

        // MainForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(784, 461);
        this.Controls.Add(this.buttonRefresh);
        this.Controls.Add(this.buttonDelete);
        this.Controls.Add(this.buttonEdit);
        this.Controls.Add(this.buttonAdd);
        this.Controls.Add(this.dataGridViewEmployees);
        this.Name = "MainForm";
        this.Text = "Employee Management System";
        this.ResumeLayout(false);
    }
}