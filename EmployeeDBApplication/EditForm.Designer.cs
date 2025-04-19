using System.Windows.Forms;

namespace EmployeeDBApplication;

partial class EditForm
{
    private System.ComponentModel.IContainer components = null;

    private Label lblFirstName;
    private TextBox txtFirstName;
    private Label lblLastName;
    private TextBox txtLastName;
    private Label lblEmail;
    private TextBox txtEmail;
    private Label lblDateOfBirth;
    private DateTimePicker dtpDateOfBirth;
    private Label lblSalary;
    private NumericUpDown numSalary;
    private Button buttonSave;
    private Button buttonCancel;

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
        this.lblFirstName = new System.Windows.Forms.Label();
        this.txtFirstName = new System.Windows.Forms.TextBox();
        this.lblLastName = new System.Windows.Forms.Label();
        this.txtLastName = new System.Windows.Forms.TextBox();
        this.lblEmail = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblDateOfBirth = new System.Windows.Forms.Label();
        this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
        this.lblSalary = new System.Windows.Forms.Label();
        this.numSalary = new System.Windows.Forms.NumericUpDown();
        this.buttonSave = new System.Windows.Forms.Button();
        this.buttonCancel = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
        this.SuspendLayout();

        // lblFirstName
        this.lblFirstName.AutoSize = true;
        this.lblFirstName.Location = new System.Drawing.Point(12, 15);
        this.lblFirstName.Name = "lblFirstName";
        this.lblFirstName.Size = new System.Drawing.Size(60, 13);
        this.lblFirstName.TabIndex = 0;
        this.lblFirstName.Text = "First Name:";

        // txtFirstName
        this.txtFirstName.Location = new System.Drawing.Point(120, 12);
        this.txtFirstName.Name = "txtFirstName";
        this.txtFirstName.Size = new System.Drawing.Size(200, 20);
        this.txtFirstName.TabIndex = 1;

        // lblLastName
        this.lblLastName.AutoSize = true;
        this.lblLastName.Location = new System.Drawing.Point(12, 41);
        this.lblLastName.Name = "lblLastName";
        this.lblLastName.Size = new System.Drawing.Size(61, 13);
        this.lblLastName.TabIndex = 2;
        this.lblLastName.Text = "Last Name:";

        // txtLastName
        this.txtLastName.Location = new System.Drawing.Point(120, 38);
        this.txtLastName.Name = "txtLastName";
        this.txtLastName.Size = new System.Drawing.Size(200, 20);
        this.txtLastName.TabIndex = 3;

        // lblEmail
        this.lblEmail.AutoSize = true;
        this.lblEmail.Location = new System.Drawing.Point(12, 67);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(35, 13);
        this.lblEmail.TabIndex = 4;
        this.lblEmail.Text = "Email:";

        // txtEmail
        this.txtEmail.Location = new System.Drawing.Point(120, 64);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(200, 20);
        this.txtEmail.TabIndex = 5;

        // lblDateOfBirth
        this.lblDateOfBirth.AutoSize = true;
        this.lblDateOfBirth.Location = new System.Drawing.Point(12, 93);
        this.lblDateOfBirth.Name = "lblDateOfBirth";
        this.lblDateOfBirth.Size = new System.Drawing.Size(69, 13);
        this.lblDateOfBirth.TabIndex = 6;
        this.lblDateOfBirth.Text = "Date of Birth:";

        // dtpDateOfBirth
        this.dtpDateOfBirth.Location = new System.Drawing.Point(120, 90);
        this.dtpDateOfBirth.Name = "dtpDateOfBirth";
        this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
        this.dtpDateOfBirth.TabIndex = 7;

        // lblSalary
        this.lblSalary.AutoSize = true;
        this.lblSalary.Location = new System.Drawing.Point(12, 119);
        this.lblSalary.Name = "lblSalary";
        this.lblSalary.Size = new System.Drawing.Size(39, 13);
        this.lblSalary.TabIndex = 8;
        this.lblSalary.Text = "Salary:";

        // numSalary
        this.numSalary.DecimalPlaces = 2;
        this.numSalary.Location = new System.Drawing.Point(120, 117);
        this.numSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
        this.numSalary.Name = "numSalary";
        this.numSalary.Size = new System.Drawing.Size(120, 20);
        this.numSalary.TabIndex = 9;
        this.numSalary.ThousandsSeparator = true;

        // buttonSave
        this.buttonSave.Location = new System.Drawing.Point(164, 150);
        this.buttonSave.Name = "buttonSave";
        this.buttonSave.Size = new System.Drawing.Size(75, 23);
        this.buttonSave.TabIndex = 10;
        this.buttonSave.Text = "Save";
        this.buttonSave.UseVisualStyleBackColor = true;
        this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

        // buttonCancel
        this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.buttonCancel.Location = new System.Drawing.Point(245, 150);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new System.Drawing.Size(75, 23);
        this.buttonCancel.TabIndex = 11;
        this.buttonCancel.Text = "Cancel";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

        // AddEditForm
        this.AcceptButton = this.buttonSave;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.buttonCancel;
        this.ClientSize = new System.Drawing.Size(332, 185);
        this.Controls.Add(this.buttonCancel);
        this.Controls.Add(this.buttonSave);
        this.Controls.Add(this.numSalary);
        this.Controls.Add(this.lblSalary);
        this.Controls.Add(this.dtpDateOfBirth);
        this.Controls.Add(this.lblDateOfBirth);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.txtLastName);
        this.Controls.Add(this.lblLastName);
        this.Controls.Add(this.txtFirstName);
        this.Controls.Add(this.lblFirstName);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "AddEditForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Add/Edit Employee";
        ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}