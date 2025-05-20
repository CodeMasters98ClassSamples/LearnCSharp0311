using BaseBackend.Dtos;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;

namespace LearnCSharp0311;

public partial class LoginForm : Form
{
    public List<LoginDto> validLogins;
    public LoginForm()
    {
        InitializeComponent();
        string jsonDataStrFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            "Data",
            "LoginUsers.json");

        string jsonDataStr = File.ReadAllText(jsonDataStrFilePath);
        validLogins = JsonConvert.DeserializeObject<List<LoginDto>>(jsonDataStr);
    }

    private void addStudentButton_Click(object sender, EventArgs e)
    {
        string username = usernameTextBox.Text;
        string password = passwordTextBox.Text;
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show(text: "Please enter valid username or password!", caption: "Invalid Login information");
            ResetLoginForm();
            return;
        }

        //List -> Item
        //Before C# Version 2
        //foreach (var login in validLogins)
        //{
        //    if (username.ToLower() == login.Username.ToLower() && password == login.Password)
        //    {
        //        //Login Successfully -> Redirect
        //        PanelLayoutForm panelLayoutForm = new PanelLayoutForm();
        //        panelLayoutForm.ShowDialog();
        //        return;
        //    }
        //}

        //LoginDto loginDto = validLogins.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
        //if (loginDto is not null)
        //{
        //    PanelLayoutForm panelLayoutForm = new PanelLayoutForm();
        //    panelLayoutForm.ShowDialog();
        //}
        //else
        //{
        //    MessageBox.Show(text: "Please enter valid username or password!", caption: "Invalid Login information");
        //    ResetLoginForm();
        //}

        //After C# Version 3
        if (validLogins.Any(x => x.Username == username && x.Password == password))
        {
            PanelLayoutForm panelLayoutForm = new PanelLayoutForm();
            panelLayoutForm.ShowDialog();
        }
        else
        {
            MessageBox.Show(text: "Please enter valid username or password!", caption: "Invalid Login information");
            ResetLoginForm();
        }

    }

    private void ResetLoginForm()
    {
        usernameTextBox.Text = string.Empty;
        passwordTextBox.Text = string.Empty;

    }
}
