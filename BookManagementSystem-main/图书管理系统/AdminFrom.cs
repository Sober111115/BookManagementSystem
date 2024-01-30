using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace 图书管理系统
{
    public partial class AdminFrom : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        Form form;
        string adminUserName;
        DataBaseConection dataBaseConection = new DataBaseConection();
        private string bookID;
        public string BookID { get { return bookID; } }

        /*-------------------------------------------------------窗体部分-------------------------------------------------------*/
        public AdminFrom(Form form, string adminUserName)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey500, Primary.Grey800, Primary.Grey100, Accent.Pink200, TextShade.WHITE);
            this.form = form;
            this.adminUserName = adminUserName;
            showUsers();
            showBook();
            showPress();
            showBookType();
            showAllLoginRecord();
            showAllLoanRecord();

            DataTable dt = dataBaseConection.getPress();

            foreach (DataRow dr in dt.Rows)
            {
                pressCBX.Items.Add(dr[0].ToString());
            }
            pressCBX.Text = pressCBX.Items[0].ToString();
        }
        private void AdminFrom_Load(object sender, EventArgs e)
        {

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
        private void materialExpansionPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /*-------------------------------------------------------窗体部分-------------------------------------------------------*/

        /*-------------------------------------------------------用户管理部分-------------------------------------------------------*/
        private void seekUserButtom_Click(object sender, EventArgs e)
        {
            string userClass = "";
            string value = "";

            if (usersClassComboBox.SelectedItem.ToString() == "用户名")
            {
                userClass = "UserName";
                value = userNameTextBox.Text;
            }
            if (usersClassComboBox.SelectedItem.ToString() == "性别")
            {
                userClass = "Sex";
                value = sexTextBox.Text;
            }
            if (usersClassComboBox.SelectedItem.ToString() == "学院")
            {
                userClass = "Company";
                value = workUnitTextBox.Text;
            }
            if (value != "")
                usersDGV.DataSource = dataBaseConection.seekUser(userClass, value);
            else
                showUsers();
        }
        public void showUsers()
        {
            usersDGV.DefaultCellStyle.ForeColor = Color.Blue;
            usersDGV.DefaultCellStyle.BackColor = Color.Beige;
            usersDGV.DataSource = dataBaseConection.commonUser();
        }
        private void setStudentButton_Click(object sender, EventArgs e)
        {
            string name = usersDGV.CurrentRow.Cells[1].Value.ToString();
            if (usersDGV.CurrentRow.Cells[8].Value.ToString() == "0")
                MessageBox.Show("用户" + usersDGV.CurrentRow.Cells[1].Value.ToString() + "的身份已是学生", "注意哦");
            else if(usersDGV.CurrentRow.Cells[8].Value.ToString() == "1")
            {
                dataBaseConection.setStudent(name);
                MessageBox.Show("用户" + usersDGV.CurrentRow.Cells[1].Value.ToString() + "的身份已设置为学生", "操作成功");
            }
            else if(adminUserName != "root")
            {
                MessageBox.Show("你不可以修改管理员的权限！", "操作失败");
            }
            else
            {
                dataBaseConection.setStudent(name);
                MessageBox.Show("用户" + usersDGV.CurrentRow.Cells[1].Value.ToString() + "的身份已设置为学生", "操作成功");
            }
            showUsers();
        }
        private void setTeacherButton_Click(object sender, EventArgs e)
        {
            string name = usersDGV.CurrentRow.Cells[1].Value.ToString();
            if (usersDGV.CurrentRow.Cells[8].Value.ToString() == "1")
                MessageBox.Show("用户" + usersDGV.CurrentRow.Cells[1].Value.ToString() + "的身份已是教师", "注意哦");
            else if (usersDGV.CurrentRow.Cells[8].Value.ToString() == "0")
            {
                dataBaseConection.setTeacher(name);
                MessageBox.Show("用户" + usersDGV.CurrentRow.Cells[1].Value.ToString() + "的身份已设置为教师", "操作成功");
            }
            else if (adminUserName != "root")
            {
                MessageBox.Show("你不可以修改管理员的权限！", "操作失败");
            }
            else
            {
                dataBaseConection.setTeacher(name);
                MessageBox.Show("用户" + usersDGV.CurrentRow.Cells[1].Value.ToString() + "的身份已设置为学生", "操作成功");
            }
            showUsers();
        }
        private void userDelteButton_Click(object sender, EventArgs e)
        {
            string name = usersDGV.CurrentRow.Cells[1].Value.ToString();
            if (name == "root")
            {
                MessageBox.Show("你无权删除超级管理员", "警告");
            }
            else if (name == adminUserName)
            {
                MessageBox.Show("你无权删除自己的信息", "警告");
            }
            else
            {
                dataBaseConection.deleteUser(name);
                MessageBox.Show("用户删除成功", "操作成功");
                showUsers();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = usersDGV.CurrentRow.Cells[1].Value.ToString();
            if(usersDGV.CurrentRow.Cells[1].Value.ToString() == adminUserName) MessageBox.Show("你不能管理自己的权限！");
            else if (usersDGV.CurrentRow.Cells[8].Value.ToString() == "100") MessageBox.Show("你无权管理超级管理员的权限！");
            else if (!dataBaseConection.rollGRANT(name)) MessageBox.Show("用户" + usersDGV.CurrentRow.Cells[1].Value.ToString() + "还不是管理员", "注意哦");
            else MessageBox.Show("收回用户" + usersDGV.CurrentRow.Cells[1].Value.ToString() + "管理权限", "权限收回");
            showUsers();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string name = usersDGV.CurrentRow.Cells[1].Value.ToString();
            if (usersDGV.CurrentRow.Cells[1].Value.ToString() == adminUserName) MessageBox.Show("你不能管理自己的权限！");
            else if (usersDGV.CurrentRow.Cells[8].Value.ToString() == "100") MessageBox.Show("你无权管理超级管理员的权限！");
            else if (dataBaseConection.GRANT(name)) MessageBox.Show("已经授予过用户" + usersDGV.CurrentRow.Cells[1].Value.ToString() + "管理权限了", "注意哦");
            else MessageBox.Show("授予用户" + usersDGV.CurrentRow.Cells[1].Value.ToString() + "管理权限", "权限授予");
            showUsers();
        }
        /*-------------------------------------------------------用户管理部分-------------------------------------------------------*/
        
        /*-------------------------------------------------------图书管理部分-------------------------------------------------------*/
        private void searchBookButtom_Click(object sender, EventArgs e)
        {
            string selectType = selectClassComboBox.SelectedItem.ToString();
            string bookName = bookTextBox.Text;
            if (bookName == "")
                showBook();
            else
            {
                if (dataBaseConection.seekBookByName(bookName, selectType).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    booksDGV.DataSource = dataBaseConection.seekBookByName(bookName, selectType);
            }
            booksDGV.DefaultCellStyle.ForeColor = Color.Blue;
            booksDGV.DefaultCellStyle.BackColor = Color.Beige;
        }
        private void booksDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBookInfo();
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            showBook();
        }
        public void updateBookInfo()
        {
            string bookName = booksDGV.CurrentRow.Cells[0].Value.ToString();
            string[] bookinfos = dataBaseConection.bookinfos(bookName);
            bookID = bookinfos[6];
            bookNameText.Text = bookinfos[0];
            bookKindText.Text = bookinfos[2];
            pressCBX.Text = bookinfos[3];
            authorText.Text = bookinfos[4];
            publishTimeText.Text = bookinfos[5];
            bookCountText.Text = bookinfos[7];
            bookDigestTextBox.Text = bookinfos[8];
        }
        public void showBook()
        {
            booksDGV.DefaultCellStyle.ForeColor = Color.Blue;
            booksDGV.DefaultCellStyle.BackColor = Color.Beige;
            booksDGV.DataSource = dataBaseConection.showBook();
        }
        private void changeRowBtn_Click(object sender, EventArgs e)
        {
            if (bookDigestTextBox.Text == String.Empty || bookNameText.Text == String.Empty || bookKindText.Text == String.Empty
                || pressCBX.Text == String.Empty || authorText.Text == String.Empty || publishTimeText.Text == String.Empty)
            {
                MessageBox.Show("所有项目数据不应该为空", "修改失败");
                return;
            }
            else
            {
                dataBaseConection.bookInfoChange(BookID, bookNameText.Text, bookKindText.Text,
                   pressCBX.Text, authorText.Text, bookCountText.Text, publishTimeText.Text, bookDigestTextBox.Text);
                showBook();
                MessageBox.Show("修改成功", "修改结果");
            }
        }
        private void bookAddButton_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook();
            addNewBook.Show();
        }
        private void deleteBookBtn_Click(object sender, EventArgs e)
        {
            string ISBN = booksDGV.CurrentRow.Cells[3].Value.ToString();
            dataBaseConection.bookDelete(ISBN);
            showBook();
            MessageBox.Show("书籍删除成功", "消息提示");
        }
        /*-------------------------------------------------------图书管理部分-------------------------------------------------------*/

        /*-------------------------------------------------------出版社&类别管理部分-------------------------------------------------------*/
        public void loadPressAndBookType()
        {

        }
        public void showPress()
        {
            pressDGV.DefaultCellStyle.ForeColor = Color.Blue;
            pressDGV.DefaultCellStyle.BackColor = Color.Beige;
            pressDGV.DataSource = dataBaseConection.showPress();
        }
        public void showBookType()
        {
            bookTypeDGV.DefaultCellStyle.ForeColor = Color.Blue;
            bookTypeDGV.DefaultCellStyle.BackColor = Color.Beige;
            bookTypeDGV.DataSource = dataBaseConection.showBookType();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (newPressTextBox.Text == String.Empty || pressDGV.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("数据不应该为空", "修改失败");
                return;
            }
            else
            {
                dataBaseConection.pressInfoChange(pressDGV.CurrentRow.Cells[0].Value.ToString(), newPressTextBox.Text);
                showPress();
                MessageBox.Show("修改成功", "修改结果");
            }
        }
        private void updateBookTypeBtn_Click(object sender, EventArgs e)
        {
            if (newBookTypeTextBox.Text == String.Empty || bookTypeDGV.CurrentRow.Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("数据不应该为空", "修改失败");
                return;
            }
            else
            {
                dataBaseConection.bookTypeInfoChange(bookTypeDGV.CurrentRow.Cells[0].Value.ToString(), newBookTypeTextBox.Text);
                showBookType();
                MessageBox.Show("修改成功", "修改结果");
            }
        }
        public void updatePressInfo()
        {
            string pressName = pressDGV.CurrentRow.Cells[0].Value.ToString();
            newPressTextBox.Text = pressName;
        }
        private void pressDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updatePressInfo();
        }
        public void updateBookTypeInfo()
        {
            string bookTypeName = bookTypeDGV.CurrentRow.Cells[0].Value.ToString();
            newBookTypeTextBox.Text = bookTypeName;
        }
        private void bookTypeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBookTypeInfo();
        }
        private void addPressBtn_Click(object sender, EventArgs e)
        {
            string pressName = newPressTextBox.Text;
            bool isAdded = dataBaseConection.pressAdd(pressName);
            if (isAdded)
            {
                showPress();
                MessageBox.Show("出版社添加成功", "消息提示");
            }
            else
            {
                MessageBox.Show("出版社添加失败", "消息提示");
            }
            showPress();
        }
        private void deletePressBtn_Click(object sender, EventArgs e)
        {
            string pressName = pressDGV.CurrentRow.Cells[0].Value.ToString();
            bool isDeleted = dataBaseConection.pressDelete(pressName);
            if (isDeleted)
            {
                showPress();
                newPressTextBox.Text = "";
                MessageBox.Show("出版社删除成功", "消息提示");
            }
            else
            {
                MessageBox.Show("出版社仍被引用", "消息提示");
            }
            showPress();
        }

        private void addBookTypeBtn_Click(object sender, EventArgs e)
        {
            string bookTypeName = newBookTypeTextBox.Text;
            bool isAdded = dataBaseConection.bookTypeAdd(bookTypeName);
            if (isAdded)
            {
                showPress();
                MessageBox.Show("类别添加成功", "消息提示");
            }
            else
            {
                MessageBox.Show("类别添加失败", "消息提示");
            }
            showBookType();
        }

        private void deleteBookTypeBtn_Click(object sender, EventArgs e)
        {
            string bookTypeName = bookTypeDGV.CurrentRow.Cells[0].Value.ToString();
            bool isDeleted = dataBaseConection.bookTypeDelete(bookTypeName);
            if (isDeleted)
            {
                showPress();
                newBookTypeTextBox.Text = "";
                MessageBox.Show("类别删除成功", "消息提示");
            }
            else
            {
                MessageBox.Show("类别仍被引用", "消息提示");
            }
            showBookType();
        }
        /*-------------------------------------------------------出版社&类别管理部分-------------------------------------------------------*/

        /*-------------------------------------------------------登录记录管理部分-------------------------------------------------------*/
        public void showAllLoginRecord()
        {
            loginDGV.DefaultCellStyle.ForeColor = Color.Blue;
            loginDGV.DefaultCellStyle.BackColor = Color.Beige;
            loginDGV.DataSource = dataBaseConection.showAllLoginRecord();
        }

        private void seekUserButton_Click(object sender, EventArgs e)
        {
            string userClass = "";
            string value = selectRecordTextBox.Text;

            if (usersClassComboBox.SelectedItem.ToString() == "用户名")
            {
                userClass = "UserName";
            }
            if (usersClassComboBox.SelectedItem.ToString() == "性别")
            {
                userClass = "Sex";
            }
            if (usersClassComboBox.SelectedItem.ToString() == "学院")
            {
                userClass = "Department";
            }
            if (value == "")
                showAllLoginRecord();
            else
                loginDGV.DataSource = dataBaseConection.seekLoginData(userClass, value);
        }
        /*-------------------------------------------------------登录记录管理部分-------------------------------------------------------*/

        /*-------------------------------------------------------借阅记录管理部分-------------------------------------------------------*/
        public void showAllLoanRecord()
        {
            loanDGV.DefaultCellStyle.ForeColor = Color.Blue;
            loanDGV.DefaultCellStyle.BackColor = Color.Beige;
            loanDGV.DataSource = dataBaseConection.showAllLoanRecord();
        }
        /*-------------------------------------------------------借阅记录管理部分-------------------------------------------------------*/
        private void selectLoanBtn_Click(object sender, EventArgs e)
        {
            string selectType = selectClassCBX.Text;
            if (selectType == "书名")
                selectType = "BookName";
            else
                selectType = "Borrower";
            if (selectClassTBX.Text == string.Empty)
                showAllLoginRecord();
            else
            {
                if (dataBaseConection.seekLoanRecord(selectType, selectClassTBX.Text).Rows.Count == 0)
                    MessageBox.Show("查无相关记录", "查询结果");
                else
                    loanDGV.DataSource = dataBaseConection.seekLoanRecord(selectType, selectClassTBX.Text);
                loanDGV.DefaultCellStyle.ForeColor = Color.Blue;
                loanDGV.DefaultCellStyle.BackColor = Color.Beige;
            }
        }
        private void deleteLoanBtn_Click(object sender, EventArgs e)
        {
            string borrowTime = loanDGV.CurrentRow.Cells[3].Value.ToString();
            dataBaseConection.loanDelete(borrowTime);
            showAllLoanRecord();
            MessageBox.Show("记录删除成功", "消息提示");
        }
        private void finePaidBtn_Click(object sender, EventArgs e)
        {
            if (loanDGV.CurrentRow.Cells[5].Value.ToString() == "是")
                MessageBox.Show("该借阅记录已经处理完成了", "消息提示");
            else
            {
                string borrowTime = loanDGV.CurrentRow.Cells[3].Value.ToString();
                dataBaseConection.loanFineProgress(borrowTime);
                showAllLoanRecord();
                MessageBox.Show("罚款处理成功", "消息提示");
            }
            showAllLoanRecord();
        }
        private void borrowBtn_Click(object sender, EventArgs e)
        {
            string bookName = bookNameTB.Text;
            string bookNumber = bookNumTB.Text;
            string name = borrowerTB.Text;
            string borrowTime = DateTime.Now.ToString();
            string ISBN = ISBNTB.Text;

            if (bookName == string.Empty || bookNumber == string.Empty || name == string.Empty || ISBN == string.Empty)
                MessageBox.Show("请输入完整信息！", "提示");
            else
            {
                if (dataBaseConection.borrowAdd(bookName, ISBN, name, borrowTime, bookNumber))
                {
                    MessageBox.Show("您已成功为该用户借书", "借书成功");
                    showBook();
                }
                else
                    MessageBox.Show("该用户借过这本书了！", "借书终止");
            }
            showAllLoanRecord();
        }
    }
}
