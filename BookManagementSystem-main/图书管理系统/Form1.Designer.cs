using MaterialSkin;

namespace 图书管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LoginButton = new MaterialSkin.Controls.MaterialButton();
            this.AdminRBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.FacultyRBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.StudentRBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.PasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.UserNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordText = new MaterialSkin.Controls.MaterialTextBox();
            this.UserName = new MaterialSkin.Controls.MaterialTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hintConfirmPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.hintPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.hintWorkUnitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.hintPhoneNumberLabel = new MaterialSkin.Controls.MaterialLabel();
            this.hintNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AgeNUD = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.teacherRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.studentRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.womanRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.manRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.signInButtom = new MaterialSkin.Controls.MaterialButton();
            this.confirmPasswordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.AddressTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.TelephoneTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.CompanyTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.UserNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label8 = new MaterialSkin.Controls.MaterialLabel();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hintLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.confirmButtom = new MaterialSkin.Controls.MaterialButton();
            this.pwdTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.nameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.hintLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cpwdTB = new MaterialSkin.Controls.MaterialTextBox();
            this.npwdTB = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordTextB = new MaterialSkin.Controls.MaterialTextBox();
            this.nameTB = new MaterialSkin.Controls.MaterialTextBox();
            this.okButton = new MaterialSkin.Controls.MaterialButton();
            this.hintLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.nameTextB = new MaterialSkin.Controls.MaterialTextBox();
            this.pwdTB = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNUD)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1000, 533);
            this.materialTabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.LoginButton);
            this.tabPage1.Controls.Add(this.AdminRBtn);
            this.tabPage1.Controls.Add(this.FacultyRBtn);
            this.tabPage1.Controls.Add(this.StudentRBtn);
            this.tabPage1.Controls.Add(this.PasswordLabel);
            this.tabPage1.Controls.Add(this.UserNameLabel);
            this.tabPage1.Controls.Add(this.PasswordText);
            this.tabPage1.Controls.Add(this.UserName);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(26, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(970, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "▶Login";
            // 
            // LoginButton
            // 
            this.LoginButton.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.LoginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoginButton.Depth = 0;
            this.LoginButton.HighEmphasis = true;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(476, 384);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LoginButton.Size = new System.Drawing.Size(66, 36);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // AdminRBtn
            // 
            this.AdminRBtn.AutoSize = true;
            this.AdminRBtn.Depth = 0;
            this.AdminRBtn.Location = new System.Drawing.Point(619, 311);
            this.AdminRBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AdminRBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AdminRBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminRBtn.Name = "AdminRBtn";
            this.AdminRBtn.Ripple = true;
            this.AdminRBtn.Size = new System.Drawing.Size(85, 37);
            this.AdminRBtn.TabIndex = 6;
            this.AdminRBtn.TabStop = true;
            this.AdminRBtn.Text = "Admin";
            this.AdminRBtn.UseVisualStyleBackColor = true;
            // 
            // FacultyRBtn
            // 
            this.FacultyRBtn.AutoSize = true;
            this.FacultyRBtn.Depth = 0;
            this.FacultyRBtn.Location = new System.Drawing.Point(461, 311);
            this.FacultyRBtn.Margin = new System.Windows.Forms.Padding(0);
            this.FacultyRBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FacultyRBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.FacultyRBtn.Name = "FacultyRBtn";
            this.FacultyRBtn.Ripple = true;
            this.FacultyRBtn.Size = new System.Drawing.Size(91, 37);
            this.FacultyRBtn.TabIndex = 5;
            this.FacultyRBtn.TabStop = true;
            this.FacultyRBtn.Text = "Faculty";
            this.FacultyRBtn.UseVisualStyleBackColor = true;
            // 
            // StudentRBtn
            // 
            this.StudentRBtn.AutoSize = true;
            this.StudentRBtn.Checked = true;
            this.StudentRBtn.Depth = 0;
            this.StudentRBtn.Location = new System.Drawing.Point(298, 311);
            this.StudentRBtn.Margin = new System.Windows.Forms.Padding(0);
            this.StudentRBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.StudentRBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.StudentRBtn.Name = "StudentRBtn";
            this.StudentRBtn.Ripple = true;
            this.StudentRBtn.Size = new System.Drawing.Size(96, 37);
            this.StudentRBtn.TabIndex = 4;
            this.StudentRBtn.TabStop = true;
            this.StudentRBtn.Text = "Student";
            this.StudentRBtn.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Depth = 0;
            this.PasswordLabel.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordLabel.Location = new System.Drawing.Point(256, 222);
            this.PasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 23);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Depth = 0;
            this.UserNameLabel.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserNameLabel.Location = new System.Drawing.Point(256, 107);
            this.UserNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(82, 23);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "UserName";
            // 
            // PasswordText
            // 
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordText.Depth = 0;
            this.PasswordText.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordText.LeadingIcon = null;
            this.PasswordText.Location = new System.Drawing.Point(360, 210);
            this.PasswordText.MaxLength = 50;
            this.PasswordText.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordText.Multiline = false;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Password = true;
            this.PasswordText.Size = new System.Drawing.Size(357, 50);
            this.PasswordText.TabIndex = 1;
            this.PasswordText.Text = "";
            this.PasswordText.TrailingIcon = null;
            // 
            // UserName
            // 
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName.Depth = 0;
            this.UserName.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserName.LeadingIcon = null;
            this.UserName.Location = new System.Drawing.Point(360, 93);
            this.UserName.MaxLength = 50;
            this.UserName.MouseState = MaterialSkin.MouseState.OUT;
            this.UserName.Multiline = false;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(357, 50);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "";
            this.UserName.TrailingIcon = null;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.hintConfirmPasswordLabel);
            this.tabPage2.Controls.Add(this.hintPasswordLabel);
            this.tabPage2.Controls.Add(this.hintWorkUnitLabel);
            this.tabPage2.Controls.Add(this.hintPhoneNumberLabel);
            this.tabPage2.Controls.Add(this.hintNameLabel);
            this.tabPage2.Controls.Add(this.AgeNUD);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.signInButtom);
            this.tabPage2.Controls.Add(this.confirmPasswordTextBox);
            this.tabPage2.Controls.Add(this.passwordTextBox);
            this.tabPage2.Controls.Add(this.AddressTextBox);
            this.tabPage2.Controls.Add(this.TelephoneTextBox);
            this.tabPage2.Controls.Add(this.CompanyTextBox);
            this.tabPage2.Controls.Add(this.UserNameTextBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.materialLabel8);
            this.tabPage2.Controls.Add(this.materialLabel7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(26, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(970, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "❓Register";
            // 
            // hintConfirmPasswordLabel
            // 
            this.hintConfirmPasswordLabel.AutoSize = true;
            this.hintConfirmPasswordLabel.Depth = 0;
            this.hintConfirmPasswordLabel.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hintConfirmPasswordLabel.Location = new System.Drawing.Point(638, 386);
            this.hintConfirmPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hintConfirmPasswordLabel.Name = "hintConfirmPasswordLabel";
            this.hintConfirmPasswordLabel.Size = new System.Drawing.Size(1, 0);
            this.hintConfirmPasswordLabel.TabIndex = 24;
            // 
            // hintPasswordLabel
            // 
            this.hintPasswordLabel.AutoSize = true;
            this.hintPasswordLabel.Depth = 0;
            this.hintPasswordLabel.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hintPasswordLabel.Location = new System.Drawing.Point(675, 209);
            this.hintPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hintPasswordLabel.Name = "hintPasswordLabel";
            this.hintPasswordLabel.Size = new System.Drawing.Size(1, 0);
            this.hintPasswordLabel.TabIndex = 23;
            // 
            // hintWorkUnitLabel
            // 
            this.hintWorkUnitLabel.AutoSize = true;
            this.hintWorkUnitLabel.Depth = 0;
            this.hintWorkUnitLabel.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hintWorkUnitLabel.Location = new System.Drawing.Point(675, 121);
            this.hintWorkUnitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hintWorkUnitLabel.Name = "hintWorkUnitLabel";
            this.hintWorkUnitLabel.Size = new System.Drawing.Size(1, 0);
            this.hintWorkUnitLabel.TabIndex = 22;
            // 
            // hintPhoneNumberLabel
            // 
            this.hintPhoneNumberLabel.AutoSize = true;
            this.hintPhoneNumberLabel.Depth = 0;
            this.hintPhoneNumberLabel.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hintPhoneNumberLabel.Location = new System.Drawing.Point(243, 121);
            this.hintPhoneNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hintPhoneNumberLabel.Name = "hintPhoneNumberLabel";
            this.hintPhoneNumberLabel.Size = new System.Drawing.Size(1, 0);
            this.hintPhoneNumberLabel.TabIndex = 21;
            // 
            // hintNameLabel
            // 
            this.hintNameLabel.AutoSize = true;
            this.hintNameLabel.Depth = 0;
            this.hintNameLabel.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hintNameLabel.Location = new System.Drawing.Point(655, 7);
            this.hintNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hintNameLabel.Name = "hintNameLabel";
            this.hintNameLabel.Size = new System.Drawing.Size(1, 0);
            this.hintNameLabel.TabIndex = 20;
            // 
            // AgeNUD
            // 
            this.AgeNUD.BackColor = System.Drawing.Color.Gray;
            this.AgeNUD.Font = new System.Drawing.Font("等线", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AgeNUD.ForeColor = System.Drawing.Color.White;
            this.AgeNUD.Location = new System.Drawing.Point(247, 423);
            this.AgeNUD.Name = "AgeNUD";
            this.AgeNUD.Size = new System.Drawing.Size(236, 26);
            this.AgeNUD.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adminRadioButton);
            this.panel2.Controls.Add(this.teacherRadioButton);
            this.panel2.Controls.Add(this.studentRadioButton);
            this.panel2.Location = new System.Drawing.Point(642, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 60);
            this.panel2.TabIndex = 18;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Depth = 0;
            this.adminRadioButton.Location = new System.Drawing.Point(206, 13);
            this.adminRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.adminRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.adminRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Ripple = true;
            this.adminRadioButton.Size = new System.Drawing.Size(84, 37);
            this.adminRadioButton.TabIndex = 2;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // teacherRadioButton
            // 
            this.teacherRadioButton.AutoSize = true;
            this.teacherRadioButton.Depth = 0;
            this.teacherRadioButton.Location = new System.Drawing.Point(112, 13);
            this.teacherRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.teacherRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.teacherRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.teacherRadioButton.Name = "teacherRadioButton";
            this.teacherRadioButton.Ripple = true;
            this.teacherRadioButton.Size = new System.Drawing.Size(88, 37);
            this.teacherRadioButton.TabIndex = 1;
            this.teacherRadioButton.TabStop = true;
            this.teacherRadioButton.Text = "faculty";
            this.teacherRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Checked = true;
            this.studentRadioButton.Depth = 0;
            this.studentRadioButton.Location = new System.Drawing.Point(12, 13);
            this.studentRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.studentRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.studentRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Ripple = true;
            this.studentRadioButton.Size = new System.Drawing.Size(94, 37);
            this.studentRadioButton.TabIndex = 0;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.womanRadioButton);
            this.panel1.Controls.Add(this.manRadioButton);
            this.panel1.Location = new System.Drawing.Point(247, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 60);
            this.panel1.TabIndex = 17;
            // 
            // womanRadioButton
            // 
            this.womanRadioButton.AutoSize = true;
            this.womanRadioButton.Depth = 0;
            this.womanRadioButton.Location = new System.Drawing.Point(129, 13);
            this.womanRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.womanRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.womanRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.womanRadioButton.Name = "womanRadioButton";
            this.womanRadioButton.Ripple = true;
            this.womanRadioButton.Size = new System.Drawing.Size(88, 37);
            this.womanRadioButton.TabIndex = 1;
            this.womanRadioButton.TabStop = true;
            this.womanRadioButton.Text = "female";
            this.womanRadioButton.UseVisualStyleBackColor = true;
            // 
            // manRadioButton
            // 
            this.manRadioButton.AutoSize = true;
            this.manRadioButton.Checked = true;
            this.manRadioButton.Depth = 0;
            this.manRadioButton.Location = new System.Drawing.Point(17, 13);
            this.manRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.manRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.manRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.manRadioButton.Name = "manRadioButton";
            this.manRadioButton.Ripple = true;
            this.manRadioButton.Size = new System.Drawing.Size(73, 37);
            this.manRadioButton.TabIndex = 0;
            this.manRadioButton.TabStop = true;
            this.manRadioButton.Text = "male";
            this.manRadioButton.UseVisualStyleBackColor = true;
            // 
            // signInButtom
            // 
            this.signInButtom.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.signInButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signInButtom.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.signInButtom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.signInButtom.Depth = 0;
            this.signInButtom.HighEmphasis = true;
            this.signInButtom.Icon = null;
            this.signInButtom.Location = new System.Drawing.Point(656, 415);
            this.signInButtom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.signInButtom.MouseState = MaterialSkin.MouseState.HOVER;
            this.signInButtom.Name = "signInButtom";
            this.signInButtom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.signInButtom.Size = new System.Drawing.Size(92, 36);
            this.signInButtom.TabIndex = 15;
            this.signInButtom.Text = "Register";
            this.signInButtom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.signInButtom.UseAccentColor = false;
            this.signInButtom.UseVisualStyleBackColor = true;
            this.signInButtom.Click += new System.EventHandler(this.signInButtom_Click);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordTextBox.Depth = 0;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.confirmPasswordTextBox.LeadingIcon = null;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(679, 238);
            this.confirmPasswordTextBox.MaxLength = 50;
            this.confirmPasswordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.confirmPasswordTextBox.Multiline = false;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Password = true;
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(236, 50);
            this.confirmPasswordTextBox.TabIndex = 14;
            this.confirmPasswordTextBox.Text = "";
            this.confirmPasswordTextBox.TrailingIcon = null;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.LeadingIcon = null;
            this.passwordTextBox.Location = new System.Drawing.Point(247, 238);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Password = true;
            this.passwordTextBox.Size = new System.Drawing.Size(236, 50);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.Text = "";
            this.passwordTextBox.TrailingIcon = null;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressTextBox.Depth = 0;
            this.AddressTextBox.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AddressTextBox.LeadingIcon = null;
            this.AddressTextBox.Location = new System.Drawing.Point(679, 147);
            this.AddressTextBox.MaxLength = 50;
            this.AddressTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AddressTextBox.Multiline = false;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(236, 50);
            this.AddressTextBox.TabIndex = 12;
            this.AddressTextBox.Text = "";
            this.AddressTextBox.TrailingIcon = null;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelephoneTextBox.Depth = 0;
            this.TelephoneTextBox.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TelephoneTextBox.LeadingIcon = null;
            this.TelephoneTextBox.Location = new System.Drawing.Point(247, 147);
            this.TelephoneTextBox.MaxLength = 50;
            this.TelephoneTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TelephoneTextBox.Multiline = false;
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(236, 50);
            this.TelephoneTextBox.TabIndex = 11;
            this.TelephoneTextBox.Text = "";
            this.TelephoneTextBox.TrailingIcon = null;
            // 
            // CompanyTextBox
            // 
            this.CompanyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyTextBox.Depth = 0;
            this.CompanyTextBox.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CompanyTextBox.LeadingIcon = null;
            this.CompanyTextBox.Location = new System.Drawing.Point(679, 54);
            this.CompanyTextBox.MaxLength = 50;
            this.CompanyTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.CompanyTextBox.Multiline = false;
            this.CompanyTextBox.Name = "CompanyTextBox";
            this.CompanyTextBox.Size = new System.Drawing.Size(236, 50);
            this.CompanyTextBox.TabIndex = 10;
            this.CompanyTextBox.Text = "";
            this.CompanyTextBox.TrailingIcon = null;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTextBox.Depth = 0;
            this.UserNameTextBox.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserNameTextBox.LeadingIcon = null;
            this.UserNameTextBox.Location = new System.Drawing.Point(247, 54);
            this.UserNameTextBox.MaxLength = 50;
            this.UserNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.UserNameTextBox.Multiline = false;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(236, 50);
            this.UserNameTextBox.TabIndex = 9;
            this.UserNameTextBox.Text = "";
            this.UserNameTextBox.TrailingIcon = null;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Depth = 0;
            this.label9.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(123, 421);
            this.label9.MouseState = MaterialSkin.MouseState.HOVER;
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Age";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(519, 332);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(76, 23);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Character";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(123, 332);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(28, 23);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Depth = 0;
            this.label6.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(519, 243);
            this.label6.MouseState = MaterialSkin.MouseState.HOVER;
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(123, 243);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Depth = 0;
            this.label8.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(519, 154);
            this.label8.MouseState = MaterialSkin.MouseState.HOVER;
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(123, 154);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "PhoneNumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Depth = 0;
            this.label5.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(519, 65);
            this.label5.MouseState = MaterialSkin.MouseState.HOVER;
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(123, 65);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gray;
            this.tabPage3.Controls.Add(this.hintLabel);
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Controls.Add(this.confirmButtom);
            this.tabPage3.Controls.Add(this.pwdTextBox);
            this.tabPage3.Controls.Add(this.nameTextBox);
            this.tabPage3.Controls.Add(this.materialLabel2);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Location = new System.Drawing.Point(26, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(970, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "❗Unsubscribe";
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Depth = 0;
            this.hintLabel.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hintLabel.Location = new System.Drawing.Point(380, 318);
            this.hintLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(1, 0);
            this.hintLabel.TabIndex = 6;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Gray;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.Red;
            this.materialLabel3.Location = new System.Drawing.Point(266, 287);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(419, 23);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "WARNING: Your password will be permanently deleted";
            // 
            // confirmButtom
            // 
            this.confirmButtom.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.confirmButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirmButtom.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.confirmButtom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.confirmButtom.Depth = 0;
            this.confirmButtom.HighEmphasis = true;
            this.confirmButtom.Icon = null;
            this.confirmButtom.Location = new System.Drawing.Point(372, 350);
            this.confirmButtom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.confirmButtom.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirmButtom.Name = "confirmButtom";
            this.confirmButtom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.confirmButtom.Size = new System.Drawing.Size(214, 36);
            this.confirmButtom.TabIndex = 4;
            this.confirmButtom.Text = "I\'m sure to unsubscribe";
            this.confirmButtom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.confirmButtom.UseAccentColor = false;
            this.confirmButtom.UseVisualStyleBackColor = true;
            this.confirmButtom.Click += new System.EventHandler(this.confirmButtom_Click);
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwdTextBox.Depth = 0;
            this.pwdTextBox.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pwdTextBox.LeadingIcon = null;
            this.pwdTextBox.Location = new System.Drawing.Point(399, 188);
            this.pwdTextBox.MaxLength = 50;
            this.pwdTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.pwdTextBox.Multiline = false;
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Password = true;
            this.pwdTextBox.Size = new System.Drawing.Size(286, 50);
            this.pwdTextBox.TabIndex = 3;
            this.pwdTextBox.Text = "";
            this.pwdTextBox.TrailingIcon = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.LeadingIcon = null;
            this.nameTextBox.Location = new System.Drawing.Point(399, 119);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(286, 50);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Text = "";
            this.nameTextBox.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(248, 199);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(76, 23);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(248, 131);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 23);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "UserName";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gray;
            this.tabPage4.Controls.Add(this.hintLabel2);
            this.tabPage4.Controls.Add(this.materialLabel9);
            this.tabPage4.Controls.Add(this.materialLabel6);
            this.tabPage4.Controls.Add(this.materialLabel5);
            this.tabPage4.Controls.Add(this.materialLabel4);
            this.tabPage4.Controls.Add(this.cpwdTB);
            this.tabPage4.Controls.Add(this.npwdTB);
            this.tabPage4.Controls.Add(this.passwordTextB);
            this.tabPage4.Controls.Add(this.nameTB);
            this.tabPage4.Controls.Add(this.okButton);
            this.tabPage4.Location = new System.Drawing.Point(26, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(970, 525);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "⚙ChangePwd";
            // 
            // hintLabel2
            // 
            this.hintLabel2.AutoSize = true;
            this.hintLabel2.Depth = 0;
            this.hintLabel2.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hintLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hintLabel2.Location = new System.Drawing.Point(346, 360);
            this.hintLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.hintLabel2.Name = "hintLabel2";
            this.hintLabel2.Size = new System.Drawing.Size(1, 0);
            this.hintLabel2.TabIndex = 9;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(312, 229);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(68, 23);
            this.materialLabel9.TabIndex = 8;
            this.materialLabel9.Text = "NewPwd";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(312, 310);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(97, 23);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "ConfirmPwd";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(312, 148);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(82, 23);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "OriginPwd";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(312, 67);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(82, 23);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "UserName";
            // 
            // cpwdTB
            // 
            this.cpwdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpwdTB.Depth = 0;
            this.cpwdTB.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cpwdTB.LeadingIcon = null;
            this.cpwdTB.Location = new System.Drawing.Point(485, 294);
            this.cpwdTB.MaxLength = 50;
            this.cpwdTB.MouseState = MaterialSkin.MouseState.OUT;
            this.cpwdTB.Multiline = false;
            this.cpwdTB.Name = "cpwdTB";
            this.cpwdTB.Password = true;
            this.cpwdTB.Size = new System.Drawing.Size(173, 50);
            this.cpwdTB.TabIndex = 4;
            this.cpwdTB.Text = "";
            this.cpwdTB.TrailingIcon = null;
            // 
            // npwdTB
            // 
            this.npwdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.npwdTB.Depth = 0;
            this.npwdTB.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.npwdTB.LeadingIcon = null;
            this.npwdTB.Location = new System.Drawing.Point(485, 215);
            this.npwdTB.MaxLength = 50;
            this.npwdTB.MouseState = MaterialSkin.MouseState.OUT;
            this.npwdTB.Multiline = false;
            this.npwdTB.Name = "npwdTB";
            this.npwdTB.Password = true;
            this.npwdTB.Size = new System.Drawing.Size(173, 50);
            this.npwdTB.TabIndex = 3;
            this.npwdTB.Text = "";
            this.npwdTB.TrailingIcon = null;
            // 
            // passwordTextB
            // 
            this.passwordTextB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextB.Depth = 0;
            this.passwordTextB.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextB.LeadingIcon = null;
            this.passwordTextB.Location = new System.Drawing.Point(485, 136);
            this.passwordTextB.MaxLength = 50;
            this.passwordTextB.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextB.Multiline = false;
            this.passwordTextB.Name = "passwordTextB";
            this.passwordTextB.Password = true;
            this.passwordTextB.Size = new System.Drawing.Size(173, 50);
            this.passwordTextB.TabIndex = 2;
            this.passwordTextB.Text = "";
            this.passwordTextB.TrailingIcon = null;
            // 
            // nameTB
            // 
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTB.Depth = 0;
            this.nameTB.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTB.LeadingIcon = null;
            this.nameTB.Location = new System.Drawing.Point(485, 57);
            this.nameTB.MaxLength = 50;
            this.nameTB.MouseState = MaterialSkin.MouseState.OUT;
            this.nameTB.Multiline = false;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(173, 50);
            this.nameTB.TabIndex = 1;
            this.nameTB.Text = "";
            this.nameTB.TrailingIcon = null;
            // 
            // okButton
            // 
            this.okButton.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.okButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.okButton.Depth = 0;
            this.okButton.HighEmphasis = true;
            this.okButton.Icon = null;
            this.okButton.Location = new System.Drawing.Point(392, 395);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.okButton.Name = "okButton";
            this.okButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.okButton.Size = new System.Drawing.Size(171, 36);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "I\'m sure to change";
            this.okButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.okButton.UseAccentColor = false;
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // hintLabel4
            // 
            this.hintLabel4.AutoSize = true;
            this.hintLabel4.Depth = 0;
            this.hintLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hintLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hintLabel4.Location = new System.Drawing.Point(346, 360);
            this.hintLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.hintLabel4.Name = "hintLabel4";
            this.hintLabel4.Size = new System.Drawing.Size(1, 0);
            this.hintLabel4.TabIndex = 9;
            // 
            // nameTextB
            // 
            this.nameTextB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextB.Depth = 0;
            this.nameTextB.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextB.LeadingIcon = null;
            this.nameTextB.Location = new System.Drawing.Point(485, 57);
            this.nameTextB.MaxLength = 50;
            this.nameTextB.MouseState = MaterialSkin.MouseState.OUT;
            this.nameTextB.Multiline = false;
            this.nameTextB.Name = "nameTextB";
            this.nameTextB.Size = new System.Drawing.Size(173, 50);
            this.nameTextB.TabIndex = 1;
            this.nameTextB.Text = "";
            this.nameTextB.TrailingIcon = null;
            // 
            // pwdTB
            // 
            this.pwdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwdTB.Depth = 0;
            this.pwdTB.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pwdTB.LeadingIcon = null;
            this.pwdTB.Location = new System.Drawing.Point(485, 136);
            this.pwdTB.MaxLength = 50;
            this.pwdTB.MouseState = MaterialSkin.MouseState.OUT;
            this.pwdTB.Multiline = false;
            this.pwdTB.Name = "pwdTB";
            this.pwdTB.Size = new System.Drawing.Size(173, 50);
            this.pwdTB.TabIndex = 2;
            this.pwdTB.Text = "";
            this.pwdTB.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(485, 215);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(173, 50);
            this.materialTextBox3.TabIndex = 3;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("思源黑体 CN Regular", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(485, 294);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(173, 50);
            this.materialTextBox4.TabIndex = 4;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(392, 395);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(171, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "I\'m sure to change";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理系统(Copyright @Sober 2023 All Rights Reserved)";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNUD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTextBox PasswordText;
        private MaterialSkin.Controls.MaterialTextBox UserName;
        private MaterialSkin.Controls.MaterialLabel PasswordLabel;
        private MaterialSkin.Controls.MaterialLabel UserNameLabel;
        private MaterialSkin.Controls.MaterialRadioButton AdminRBtn;
        private MaterialSkin.Controls.MaterialRadioButton FacultyRBtn;
        private MaterialSkin.Controls.MaterialRadioButton StudentRBtn;
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialLabel label9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel label6;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel label8;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialLabel label5;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialTextBox confirmPasswordTextBox;
        private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
        private MaterialSkin.Controls.MaterialTextBox AddressTextBox;
        private MaterialSkin.Controls.MaterialTextBox TelephoneTextBox;
        private MaterialSkin.Controls.MaterialTextBox CompanyTextBox;
        private MaterialSkin.Controls.MaterialTextBox UserNameTextBox;
        private MaterialSkin.Controls.MaterialButton signInButtom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown AgeNUD;
        private MaterialSkin.Controls.MaterialRadioButton womanRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton manRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton adminRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton teacherRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton studentRadioButton;
        private MaterialSkin.Controls.MaterialLabel hintPasswordLabel;
        private MaterialSkin.Controls.MaterialLabel hintWorkUnitLabel;
        private MaterialSkin.Controls.MaterialLabel hintPhoneNumberLabel;
        private MaterialSkin.Controls.MaterialLabel hintNameLabel;
        private MaterialSkin.Controls.MaterialLabel hintConfirmPasswordLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton confirmButtom;
        private MaterialSkin.Controls.MaterialTextBox pwdTextBox;
        private MaterialSkin.Controls.MaterialTextBox nameTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel hintLabel;
        private MaterialSkin.Controls.MaterialButton okButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox cpwdTB;
        private MaterialSkin.Controls.MaterialTextBox npwdTB;
        private MaterialSkin.Controls.MaterialTextBox passwordTextB;
        private MaterialSkin.Controls.MaterialTextBox nameTB;
        private MaterialSkin.Controls.MaterialLabel hintLabel2;
        private MaterialSkin.Controls.MaterialLabel hintLabel4;
        private MaterialSkin.Controls.MaterialTextBox nameTextB;
        private MaterialSkin.Controls.MaterialTextBox pwdTB;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}

