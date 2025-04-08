// 13. Create one admission enquiry form. 

using System;
using System.Windows.Forms;

public class AdmissionForm : Form
{
    TextBox txtName, txtEmail, txtPhone, txtCourse;
    Button btnSubmit;

    public AdmissionForm()
    {
        this.Text = "Admission Enquiry Form";
        this.Size = new System.Drawing.Size(300, 300);

        Label lblName = new Label() { Text = "Name", Top = 20, Left = 20 };
        txtName = new TextBox() { Top = 20, Left = 100 };

        Label lblEmail = new Label() { Text = "Email", Top = 50, Left = 20 };
        txtEmail = new TextBox() { Top = 50, Left = 100 };

        Label lblPhone = new Label() { Text = "Phone", Top = 80, Left = 20 };
        txtPhone = new TextBox() { Top = 80, Left = 100 };

        Label lblCourse = new Label() { Text = "Course", Top = 110, Left = 20 };
        txtCourse = new TextBox() { Top = 110, Left = 100 };

        btnSubmit = new Button() { Text = "Submit", Top = 150, Left = 100 };
        btnSubmit.Click += new EventHandler(SubmitForm);

        this.Controls.Add(lblName);
        this.Controls.Add(txtName);
        this.Controls.Add(lblEmail);
        this.Controls.Add(txtEmail);
        this.Controls.Add(lblPhone);
        this.Controls.Add(txtPhone);
        this.Controls.Add(lblCourse);
        this.Controls.Add(txtCourse);
        this.Controls.Add(btnSubmit);
    }

    private void SubmitForm(object sender, EventArgs e)
    {
        MessageBox.Show($"Name: {txtName.Text}\nEmail: {txtEmail.Text}\nPhone: {txtPhone.Text}\nCourse: {txtCourse.Text}", "Enquiry Submitted");
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new AdmissionForm());
    }
}
