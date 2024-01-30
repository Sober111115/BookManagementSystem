using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace 图书管理系统
{
    public partial class UserForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        Form form;
        string userName;

        DataBaseConection dataBaseConection = new DataBaseConection();

        public UserForm(Form form, string userName)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey500, Primary.Grey800, Primary.Grey100, Accent.Pink200, TextShade.WHITE);
            this.form = form;
            this.userName = userName;
            showBook();
            showRecord();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        /*-------------------------------------------------------图书信息部分-------------------------------------------------------*/
        public void showBook() 
        {
            booksDGV.DefaultCellStyle.ForeColor = Color.Blue;
            booksDGV.DefaultCellStyle.BackColor = Color.Beige;
            booksDGV.DataSource = dataBaseConection.showBook();
        }
        private void searchBookButtom_Click(object sender, EventArgs e)
        {
            string selectType = selectClassComboBox.SelectedItem.ToString();
            string bookName = bookTextBox.Text;

            if (dataBaseConection.seekBookByName(bookName, selectType).Rows.Count == 0)
                MessageBox.Show("查无此书", "查询结果");
            else
                booksDGV.DataSource = dataBaseConection.seekBookByName(bookName, selectType);

            booksDGV.DefaultCellStyle.ForeColor = Color.Blue;
            booksDGV.DefaultCellStyle.BackColor = Color.Beige;
        }

        private void booksDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBookInfo();
        }
        public void updateBookInfo()
        {
            string bookName = booksDGV.CurrentRow.Cells[0].Value.ToString();
            string[] bookinfos = dataBaseConection.bookinfos(bookName);
            bookDigestTextBox.Text = bookinfos[8];
        }

        private void borrowButtoon_Click(object sender, EventArgs e)
        {
            string bookName = booksDGV.CurrentRow.Cells[0].Value.ToString();
            string ISBN = booksDGV.CurrentRow.Cells[3].Value.ToString();
            string bookNumber = booksDGV.CurrentRow.Cells[2].Value.ToString();
            string name = userName;
            string borrowTime = DateTime.Now.ToString();

            if (booksDGV.CurrentRow.Cells[8].Value.ToString() == "0")
            {
                MessageBox.Show("此图书在本馆藏量为0!!", "借书失败");
            }
            else
            {
                if (dataBaseConection.borrowAdd(bookName, ISBN, name, borrowTime, bookNumber))
                {
                    MessageBox.Show("您已成功借到此书，请在一个月内归还", "借书成功");
                    showBook();
                }
                else
                    MessageBox.Show("您已借过该书且未归还", "借书终止");
            }
        }
        /*-------------------------------------------------------图书信息部分-------------------------------------------------------*/
        /*-------------------------------------------------------借还部分-------------------------------------------------------*/
        public void showRecord()
        {
            libraryRecordDGV.DefaultCellStyle.ForeColor = Color.Blue;
            libraryRecordDGV.DefaultCellStyle.BackColor = Color.Beige;
            libraryRecordDGV.DataSource = dataBaseConection.loanRecord(userName);
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            showRecord();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            if (libraryRecordDGV.Rows.Count != 0)
            {
                string bookName = libraryRecordDGV.CurrentRow.Cells[1].Value.ToString();
                string bookNumber = libraryRecordDGV.CurrentRow.Cells[0].Value.ToString();
                string returnTime = DateTime.Now.ToString();
                string borrowtime = libraryRecordDGV.CurrentRow.Cells[3].Value.ToString();
                string Username = userName;
                bool[] flag = dataBaseConection.returnBook(bookName, bookNumber, returnTime, borrowtime, Username);
                if (!flag[0] && flag[1] && !flag[2] && !flag[3] && !flag[4])
                    MessageBox.Show("您已经成功归还本书，谢谢使用", "提示");
                else if (!flag[0] && flag[1] && (flag[2] || flag[3] || flag[4]))
                    MessageBox.Show("您还未支付罚款，请联系管理员！", "提示");
                else if (flag[0])
                    MessageBox.Show("本书归还过了", "提示");
                showRecord();
            }
            else
                MessageBox.Show("当前没有选中要还的书或者没有借书记录");
        }
        private void brokenButton_Click(object sender, EventArgs e)
        {
            if (libraryRecordDGV.Rows.Count != 0)
            {
                string bookName = libraryRecordDGV.CurrentRow.Cells[1].Value.ToString();
                string bookNumber = libraryRecordDGV.CurrentRow.Cells[0].Value.ToString();
                string returnTime = DateTime.Now.ToString();
                string borrowtime = libraryRecordDGV.CurrentRow.Cells[3].Value.ToString();
                string Username = userName;
                bool[] flag = dataBaseConection.brokenBook(bookName, bookNumber, returnTime, borrowtime, Username);
                if (!flag[0] && flag[1] && (!flag[2] && !flag[3]))
                    MessageBox.Show("已为您办理书本损坏手续(1*书本原价)，请联系管理员交款！", "提示");
                else if (!flag[0] && flag[1] && (flag[2] || flag[3]))
                    MessageBox.Show("您已经办理过相关手续了！", "提示");
                else if (flag[0])
                    MessageBox.Show("本书归还过了", "提示");
                showRecord();
            }
            else
                MessageBox.Show("当前没有选中的书或者没有借书记录");
        }
        private void lostButton_Click(object sender, EventArgs e)
        {
            if (libraryRecordDGV.Rows.Count != 0)
            {
                string bookName = libraryRecordDGV.CurrentRow.Cells[1].Value.ToString();
                string bookNumber = libraryRecordDGV.CurrentRow.Cells[0].Value.ToString();
                string borrowtime = libraryRecordDGV.CurrentRow.Cells[3].Value.ToString();
                string Username = userName;
                bool[] flag = dataBaseConection.lostBook(bookName, bookNumber, borrowtime, Username);
                if (!flag[0] && flag[1] && !flag[3])
                    MessageBox.Show("已为您办理书本丢失手续(2*书本原价)，请联系管理员交款！", "提示");
                else if (!flag[0] && flag[1] && flag[3])
                    MessageBox.Show("您已经办理过相关手续了！", "提示");
                else if (flag[0])
                    MessageBox.Show("本书归还过了", "提示");
                showRecord();
            }
            else
                MessageBox.Show("当前没有选中的书或者没有借书记录");
        }
        /*-------------------------------------------------------借还部分-------------------------------------------------------*/
    }
}
