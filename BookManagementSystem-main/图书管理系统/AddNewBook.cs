using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace 图书管理系统
{
    public partial class AddNewBook : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        DataBaseConection dataBaseConection = new DataBaseConection();

        private string bookName;
        private string bookClass;
        private string language;
        private string oldName;
        private string bookNumber;
        private string price;
        private string author;
        private string iSBN;
        private string translator;
        private string publish;
        private string press;
        private string content;

        public string BookName { get { return bookName; } }
        public string BookClass { get { return bookClass; } }
        public string Language { get { return language; } }
        public string OldName { get { return oldName; } }
        public string BookNumber { get { return bookNumber; } }
        public string Price { get { return price; } }
        public string Author { get { return author; } }
        public string ISBN { get { return iSBN; } }
        public string Translator { get { return translator; } }
        public string Publish { get { return publish; } }
        public string Press { get { return press; } }
        public string Content { get { return content; } }

        public AddNewBook()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey500, Primary.Grey800, Primary.Grey100, Accent.Pink200, TextShade.WHITE);

            DataTable dt = dataBaseConection.getPress();

            foreach(DataRow dr in dt.Rows)
            {
                presscomboBox.Items.Add(dr[0].ToString());
            }
            presscomboBox.Text = presscomboBox.Items[0].ToString();

            dt = dataBaseConection.getBookType();

            foreach (DataRow dr in dt.Rows)
            {
                bookClassComboBox.Items.Add(dr[0].ToString());
            }
            presscomboBox.Text = presscomboBox.Items[0].ToString();
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            getInfos();
            if (bookNameTextBox.Text == String.Empty || bookClassComboBox.Text == String.Empty
                || languageTextBox.Text == String.Empty || oldNameTextBox.Text == String.Empty ||
                bookNumberTextBox.Text == String.Empty || bookPriceTextBox.Text == String.Empty ||
                authorTextBox.Text == String.Empty || ISBNTextBox.Text == String.Empty ||
                translatorTextBox.Text == String.Empty || publishDateTimePicker.Text == String.Empty ||
                presscomboBox.Text == String.Empty || contentTextBox.Text == String.Empty)
                MessageBox.Show("所有资料不能留空", "提示");
            else
            {
                if (dataBaseConection.addNewBook(BookName, BookClass, Language, OldName,
                   BookNumber, Price, Author, ISBN, Translator, Publish, Press, Content))
                    MessageBox.Show("你已经成功添加这本书", "添加成功");
                else
                    MessageBox.Show("这本书已经存在，无需添加", "添加失败");
            }
        }
        public void getInfos()
        {
            bookName = bookNameTextBox.Text;
            bookClass = bookClassComboBox.Text;
            language = languageTextBox.Text;
            oldName = oldNameTextBox.Text;
            bookNumber = bookNumberTextBox.Text;
            price = bookPriceTextBox.Text;
            author = authorTextBox.Text;
            iSBN = ISBNTextBox.Text;
            translator = translatorTextBox.Text;
            publish = publishDateTimePicker.Text;
            press = presscomboBox.Text;
            content = contentTextBox.Text;
        }
    }
}
