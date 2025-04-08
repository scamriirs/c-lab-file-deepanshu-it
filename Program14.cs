// 14. Create a windows form with registration number, name, age, class and other details. 

[12:28, 08/04/2025] Akash MR: using System;
using System.Windows.Forms;

public class RegistrationForm : Form
{
    TextBox txtRegNo, txtName, txtAge, txtClass;
    Button btnRegister;

    public RegistrationForm()
    {
        this.Text = "Student Registration Form";
        this.Size = new System.Drawing.Size(350, 300);

        Label lblRegNo = new Label() { Text = "Registration No:", Top = 20, Left = 20 };
        txtRegNo = new TextBox() { Top = 20, Left = 150 };

        Label lblName = new Label() { Text = "Name:", Top = 50, Left = 20 };
        txtName = new TextBox() { Top = 50, Left = 150 };

        Label lblAge = new Label() { Text = "Age:", Top = 80, Left = 20 };
        txtAge = new TextBox() { Top = 80, Left = 150 };

        Label lblClass = new Label() { Text = "Class:…
[12:28, 08/04/2025] Akash MR: using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

public class XmlReaderForm : Form
{
    public XmlReaderForm()
    {
        TextBox textBox = new TextBox { Multiline = true, Dock = DockStyle.Fill, ReadOnly = true };
        Controls.Add(textBox);
        LoadXmlData(textBox);
    }

    private void LoadXmlData(TextBox textBox)
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("data.xml"); // Ensure data.xml exists
        textBox.Text = doc.OuterXml;
    }
    
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new XmlReaderForm());
    }
}
