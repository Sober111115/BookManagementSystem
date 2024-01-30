using System;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace 图书管理系统
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        // Login
        const string nameLinmit = @"^[a-zA-Z0-9]*$";
        const string passwordLinmit = @"^[a-zA-Z0-9]*$";
        private string name;
        private string password;
        // Register
        const string nameLimit = @"^[a-zA-Z0-9]*$";
        const string passwordLimit = @"^[a-zA-Z0-9]*$";
        const string phoneNumberLimit = @"^(13[0-9]|14[579]|15[0-3,5-9]|16[6]|17[0135678]|18[0-9]|19[89])\d{8}$";
        private string CustomerID;
        private string CustomerName;
        private int Age;
        private string Telephone;
        private int sex;
        private int character;
        private string workUnit;
        private string Address;

        DataBaseConection dataBaseConection = new DataBaseConection();
        public string CommonName_Login { get { return name; } }
        public string Password { get { return password; } }
        public string CommonName_Register { get { return CustomerID; } }
        public string Password_Register { get { return CustomerName; } }
        public int Sex { get { return sex; } }

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme( Primary.Grey500, Primary.Grey800, Primary.Grey100, Accent.Pink200, TextShade.WHITE);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void LoginInfo()
        {
            if (UserName.Text == String.Empty || PasswordText.Text == String.Empty)
            {
                MessageBox.Show("用户名称或用户密码不能为空", "登录提示");
                Clear();
                return;
            }
            if ((!Regex.IsMatch(UserName.Text, nameLinmit)) || (!Regex.IsMatch(PasswordText.Text, passwordLinmit)))
            {
                MessageBox.Show("用户名称和用户密码只能由字母和数字组成", "登录提示");
                Clear();
                return;
            }
            else
            {
                name = UserName.Text;
                password = PasswordText.Text;
                int IsAdmin;

                if (StudentRBtn.Checked) IsAdmin = 0;
                else if (FacultyRBtn.Checked) IsAdmin = 1;
                else IsAdmin = 2;

                AdminFrom admin = new AdminFrom(this, name);
                UserForm userForm = new UserForm(this, name);

                if (dataBaseConection.Login(CommonName_Login, password, IsAdmin))
                {
                    dataBaseConection.LoginRecord(CommonName_Login, DateTime.Now.ToString("F"));

                    if (IsUserClassManage()==2)
                    {
                        MessageBox.Show("欢迎您登录本系统", "消息提示");
                        admin.Show();
                        this.Hide();
                        userForm.Close();
                    }
                    else
                    {
                        MessageBox.Show("欢迎您登录本系统", "消息提示");
                        userForm.Show();
                        this.Hide();
                        admin.Close();
                    }
                }
                else
                    MessageBox.Show("您的用户名或密码有误", "登录失败");
                Clear();
            }
        }
        public void Clear()
        {
            UserName.Clear();
            PasswordText.Clear();
            PasswordText.Focus();
        }
        public void Clear_changePassword()
        {
            nameTB.Clear();
            passwordTextB.Clear();
            passwordTextB.Focus();
        }
        public int IsUserClassManage()
        {
            if (StudentRBtn.Checked == true)
                return 0;
            else if (FacultyRBtn.Checked == true)
                return 1;
            else
                return 2;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginInfo();
        }

        private void signInButtom_Click(object sender, EventArgs e)
        {
            hintClear();
            SignInfo();
        }
        public void hintClear()
        {
            hintConfirmPasswordLabel.Text = "";
            hintPasswordLabel.Text = "";
            hintWorkUnitLabel.Text = "";
            hintPhoneNumberLabel.Text = "";
            hintNameLabel.Text = "";
        }

        public void SignInfo()
        {
            if (UserNameTextBox.Text == String.Empty)
            {
                hintNameLabel.Text = "用户名不能为空";
            }
            if (!Regex.IsMatch(UserNameTextBox.Text, nameLimit))
            {
                hintNameLabel.Text = "用户名应由字母或数字组成";
                UserNameTextBox.Clear();
                UserNameTextBox.Focus();
                return;
            }
            if (TelephoneTextBox.Text == String.Empty)
            {
                hintPhoneNumberLabel.Text = "联系手机不能为空";
            }
            if (!Regex.IsMatch(TelephoneTextBox.Text, phoneNumberLimit))
            {
                hintPhoneNumberLabel.Text = "请输入正确手机号码";
                TelephoneTextBox.Clear();
                TelephoneTextBox.Focus();
                return;
            }
            if (passwordTextBox.Text == String.Empty)
            {
                hintPasswordLabel.Text = "用户密码不能为空";

            }
            if (!Regex.IsMatch(passwordTextBox.Text, passwordLimit))
            {
                hintPasswordLabel.Text = "用户密码只能由字母和数字组成";
                passwordTextBox.Clear();
                passwordTextBox.Focus();
                return;
            }
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                hintConfirmPasswordLabel.Text = "前后密码不相同";
                passwordTextBox.Clear();
                confirmPasswordTextBox.Clear();
                passwordTextBox.Focus();
                return;
            }
            else
            {
                CustomerName = UserNameTextBox.Text;
                Telephone = TelephoneTextBox.Text;
                Age = (int)(AgeNUD.Value);
                workUnit = CompanyTextBox.Text;
                sex = manRadioButton.Checked == true ? 1 : 0;
                Address = AddressTextBox.Text;
                if (studentRadioButton.Checked) character = 0;
                else if (teacherRadioButton.Checked) character = 1;
                else character = 2;

                if (dataBaseConection.userAdd(CustomerName, workUnit, Sex, Age, Address, Telephone, workUnit, character))
                    MessageBox.Show("注册成功", "消息提示");
                else
                    MessageBox.Show("用户已经存在", "注册终止");
                Clear();
            }
        }
        private void confirmButtom_Click(object sender, EventArgs e)
        {
            infoConfirm();
        }
        public void infoConfirm()
        {
            if (nameTextBox.Text == String.Empty || pwdTextBox.Text == String.Empty)
            {
                hintLabel.Text = "用户名称或用户密码不能为空";
                Clear();
                return;
            }
            else if (!Regex.IsMatch(nameTextBox.Text, nameLinmit) ||
                !Regex.IsMatch(pwdTextBox.Text, passwordLinmit))
            {
                hintLabel.Text = "用户名称和用户密码只能由字母和数字组成";
                Clear();
                return;
            }
            else
            {
                name = nameTextBox.Text;
                password = pwdTextBox.Text;
                if (dataBaseConection.userLogout(name, password))
                    MessageBox.Show("您已成功注销本账户，感谢您的使用", "注销成功");
                else
                    MessageBox.Show("没有这个账户或者账户信息有误", "操作失败");
            }
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            PwdModificationInfo();
        }
        public void PwdModificationInfo()
        {
            if (nameTB.Text == String.Empty || passwordTextB.Text == String.Empty)
            {
                hintLabel2.Text = "用户名称或用户密码不能为空";
                Clear_changePassword();
                return;
            }
            if (!Regex.IsMatch(nameTB.Text, nameLinmit) ||
                !Regex.IsMatch(passwordTextB.Text, passwordLimit))
            {
                hintLabel2.Text = "用户名称和用户密码只能由字母和数字组成";
                Clear_changePassword();
                return;
            }
            if (npwdTB.Text == String.Empty ||
                !Regex.IsMatch(npwdTB.Text, passwordLimit))
            {
                hintLabel.Text = "新密码不能够为空，且密码又数字和字母组成";
                npwdTB.Clear();
                cpwdTB.Clear();
                return;
            }
            if (npwdTB.Text != cpwdTB.Text)
            {
                hintLabel.Text = "新密码前后不同";
                npwdTB.Clear();
                cpwdTB.Clear();
                return;
            }
            else
            {
                if (dataBaseConection.passwordChange(nameTB.Text, passwordTextB.Text, npwdTB.Text))
                {
                    MessageBox.Show("密码更改成功，下次登陆系统请使用新密码", "更改成功");
                }
                else
                    MessageBox.Show("密码更改失败,可能是密码错误或者账户不存在", "更改终止");
            }
        }
    }
}
