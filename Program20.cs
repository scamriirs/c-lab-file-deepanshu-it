// 20. Prepare a login form, which will accept unique username, password of alphanumeric type, re-type
//  password, date of birth, and text to remember password. And put all necessary validation. If user does
//  not fill the complete form it should show valid error message. Also if user is new then there should be
//  option for creating new Login and a checkbox to remember on computer. [Windows application].

using System;
using System.Windows.Forms;

public class LoginForm : Form
{
    TextBox usernameBox = new TextBox();
    TextBox passwordBox = new TextBox { PasswordChar = '*' };
    Button loginButton = new Button { Text = "Login" };

    public LoginForm()
    {
        usernameBox.PlaceholderText = "Username";
        passwordBox.PlaceholderText = "Password";

        loginButton.Click += ValidateLogin;

        var layout = new FlowLayoutPanel { Dock = DockStyle.Fill };
        layout.Controls.Add(usernameBox);
        layout.Controls.Add(passwordBox);
        layout.Controls.Add(loginButton);

        Controls.Add(layout);
    }

    private void ValidateLogin(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(usernameBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            MessageBox.Show("All fields are required!", "Validation Error");
        else
            MessageBox.Show("Login successful!", "Success");
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new LoginForm());
    }
}
