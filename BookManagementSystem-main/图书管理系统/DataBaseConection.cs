using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;


namespace 图书管理系统
{
    class DataBaseConection
    {
        string connectionString = "server=localhost;port=3306;user=root;password=Resegar$8d;database=library;";

        /***********************************************************登录相关***********************************************************/
        public bool Login(string userName, string password, int IsAdmin)
        {

            bool LoginResult = true;
            string CommandText = string.Format("select * from user_info where UserName='{0}'", userName);
            string AdminCommandText = string.Format("select * from admin where AdminName='{0}'", userName);
            string FinallyCommand;

            if (IsAdmin == 2)
                FinallyCommand = AdminCommandText;
            else
                FinallyCommand = CommandText;

            using (MySqlConnection libaryConnection = new MySqlConnection(connectionString))
            {
                libaryConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(FinallyCommand, libaryConnection);
                MySqlDataReader nameReader = mySqlCommand.ExecuteReader();
                if (nameReader.Read())
                {
                    string passwordRead = nameReader.GetString(nameReader.GetOrdinal("Password"));
                    if (IsAdmin < 2)
                    {
                        if (password == passwordRead && ("100" == nameReader.GetString(nameReader.GetOrdinal("Cha")) || "2" == nameReader.GetString(nameReader.GetOrdinal("Cha")) || "" + IsAdmin == nameReader.GetString(nameReader.GetOrdinal("Cha"))))
                            LoginResult = true;
                        else
                            LoginResult = false;
                    }
                    else
                    {
                        if (password == passwordRead)
                            LoginResult = true;
                        else
                            LoginResult = false;
                    }
                }
                else
                    LoginResult = false;
            }
            return LoginResult;
        }
        public void LoginRecord(string name, string LoginTime)
        {
            string LoginRecordCommandText = string.Format("insert into loginrecord(UserName,LoginTime) values('{0}','{1}')", name, LoginTime);

            using (MySqlConnection loginRecords = new MySqlConnection(connectionString))
            {
                loginRecords.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(LoginRecordCommandText, loginRecords);
                mySqlCommand.ExecuteNonQuery();
            }
        }
        /***********************************************************登录相关***********************************************************/
        
        /***********************************************************注册相关***********************************************************/
        public bool userAdd(string UserName, string Password, int sex, int Age, string Address, string Telephone, string workUnit, int character)
        {
            bool IsUserAdd;
            string userAddCommand = string.Format("insert into user_info(UserName, Password, Age, Sex, Address, Telephone, Department, Cha) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", UserName, Password, sex, Age, Address, Telephone, workUnit, character);
            string seekUserCommand = string.Format("select * from user_info where UserName='{0}';", UserName);
            string adminAddCommand = string.Format("insert into admin(AdminName, Password) values('{0}', '{1}');", UserName, Password);
            string seekAdminCommand = string.Format("select * from admin where AdminName='{0}';", UserName);

            using (MySqlConnection userAddConnection = new MySqlConnection(connectionString))
            {
                userAddConnection.Open();
                MySqlCommand AddCommand = new MySqlCommand(userAddCommand, userAddConnection);
                MySqlCommand SeekCommand = new MySqlCommand(seekUserCommand, userAddConnection);

                using (MySqlDataReader mySqlDataReader = SeekCommand.ExecuteReader())
                {
                    if (mySqlDataReader.Read()) IsUserAdd = false;
                    else IsUserAdd = true;
                    userAddConnection.Close();

                    userAddConnection.Open();
                    if (IsUserAdd) AddCommand.ExecuteNonQuery();
                }
                userAddConnection.Close();

                userAddConnection.Open();
                MySqlCommand AddAdminCommand = new MySqlCommand(adminAddCommand, userAddConnection);
                MySqlCommand SeekAdminCommand = new MySqlCommand(seekAdminCommand, userAddConnection);
                using (MySqlDataReader mySqlDataReader = SeekAdminCommand.ExecuteReader())
                {
                    if (character == 2)
                    {
                        if (mySqlDataReader.Read()) IsUserAdd = false;
                        else IsUserAdd = true;
                        userAddConnection.Close();

                        userAddConnection.Open();
                        if (IsUserAdd) AddAdminCommand.ExecuteNonQuery();
                    }
                }
            }
            return IsUserAdd;
        }
        /***********************************************************注册相关***********************************************************/

        /***********************************************************改密相关***********************************************************/
        public bool passwordChange(string name, string password, string newPassword)
        {
            bool IsPasswordChange;

            string passwordChangeCommand = string.Format("update user_info set Password='{0}' where UserName='{1}'", newPassword, name);
            string IsPasswordCommand = string.Format("select * from user_info where UserName='{0}'", name);

            using (MySqlConnection passwordChangeConnection = new MySqlConnection(connectionString))
            {
                passwordChangeConnection.Open();
                MySqlCommand isPassword = new MySqlCommand(IsPasswordCommand, passwordChangeConnection);
                MySqlCommand passwordChange = new MySqlCommand(passwordChangeCommand, passwordChangeConnection);
                using (MySqlDataReader mySqlDataReader = isPassword.ExecuteReader())
                {
                    if (mySqlDataReader.Read())
                    {
                        string passwordRead = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Password"));
                        if (password == passwordRead)
                        {
                            IsPasswordChange = true;
                        }
                        else
                            IsPasswordChange = false;
                        if (mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Cha")) == "2" || mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Password")) == "100")
                        {
                            string changeAdminPassword = string.Format("update admin set Password='{0}' where AdminName='{1}'", newPassword, name);
                            using (MySqlConnection adminChangeConnection = new MySqlConnection(connectionString))
                            {
                                adminChangeConnection.Open();
                                MySqlCommand adminChange = new MySqlCommand(changeAdminPassword, adminChangeConnection);
                                adminChange.ExecuteNonQuery();
                                adminChangeConnection.Close();
                            }
                        }
                    }
                    else
                        IsPasswordChange = false;
                }
                if (IsPasswordChange)
                    passwordChange.ExecuteNonQuery();
            }
            return IsPasswordChange;
        }
        /***********************************************************改密相关***********************************************************/

        /***********************************************************注销相关***********************************************************/
        public void deleteUser(string name)
        {
            string deleteUserCommand = string.Format("delete from user_info where UserName='{0}'", name);
            using (MySqlConnection deletUserConnection = new MySqlConnection(connectionString))
            {
                deletUserConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(deleteUserCommand, deletUserConnection);
                mySqlCommand.ExecuteNonQuery();
            }
        }
        public bool userLogout(string name, string password)
        {
            bool IsDelete;

            string userLogoutCommand = string.Format("delete from user_info where UserName='{0}'", name);
            string seekUserCommand = string.Format("select * from user_info where UserName='{0}'", name);
            using (MySqlConnection userLogoutConnection = new MySqlConnection(connectionString))
            {
                userLogoutConnection.Open();
                MySqlCommand logoutCommand = new MySqlCommand(userLogoutCommand, userLogoutConnection);
                MySqlCommand seekCommad = new MySqlCommand(seekUserCommand, userLogoutConnection);
                using (MySqlDataReader mySqlDataReader = seekCommad.ExecuteReader())
                {
                    if (mySqlDataReader.Read())
                    {
                        string passwordRead = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Password"));
                        if (password == passwordRead && mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Cha")) != "2" && mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("Cha")) != "100")
                        {
                            IsDelete = true;
                        }
                        else
                            IsDelete = false;
                    }
                    else
                        IsDelete = false;
                }
                if (IsDelete)
                    logoutCommand.ExecuteNonQuery();
            }
            return IsDelete;
        }
        /***********************************************************注销相关***********************************************************/

        /***********************************************************书本相关***********************************************************/
        public DataTable showBook()
        {
            DataTable books;
            string showBookCommandText = string.Format("select BookName,BookType,BookNum,ISBN,Author,PressTime,Press,Abstract,ExistNum,Price from booksinfo");

            using (MySqlConnection showBookConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showBookCommandText, showBookConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                books = dataTable;
            }
            books.Columns[0].ColumnName = "书名";
            books.Columns[1].ColumnName = "类别";
            books.Columns[2].ColumnName = "编号";
            books.Columns[3].ColumnName = "ISBN号";
            books.Columns[4].ColumnName = "作者";
            books.Columns[5].ColumnName = "出版时间";
            books.Columns[6].ColumnName = "出版社";
            books.Columns[7].ColumnName = "摘要";
            books.Columns[8].ColumnName = "存量";
            books.Columns[9].ColumnName = "价格";
            return books;
        }
        public DataTable seekBookByName(string bookName, string selectType)
        {
            switch (selectType)
            {
                case "书名":
                    selectType = "BookName";
                    break;
                case "ISBN号":
                    selectType = "ISBN";
                    break;
                case "类别":
                    selectType = "BookType";
                    break;
                case "编号":
                    selectType = "BookNum";
                    break;
                case "作者":
                    selectType = "Author";
                    break;
                case "译者":
                    selectType = "Translator";
                    break;
                case "出版社":
                    selectType = "Press";
                    break;
                case "存量":
                    selectType = "ExistNum";
                    break;
            }

            string seekBookByNameCommand = string.Format("select BookName,BookType,Language,OriginName,BookNum,Author,ISBN,Translator,PressTime,Press,Price from booksinfo where {0} like '%{1}%'", selectType, bookName);
            DataTable bookData;

            using (MySqlConnection seekBookByNameConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekBookByNameCommand, seekBookByNameConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                bookData = dataTable;
            }

            bookData.Columns[0].ColumnName = "书名";
            bookData.Columns[1].ColumnName = "类别";
            bookData.Columns[2].ColumnName = "语种";
            bookData.Columns[3].ColumnName = "原名";
            bookData.Columns[4].ColumnName = "编号";
            bookData.Columns[5].ColumnName = "作者";
            bookData.Columns[6].ColumnName = "ISBN号";
            bookData.Columns[7].ColumnName = "译者";
            bookData.Columns[8].ColumnName = "出版时间";
            bookData.Columns[8].ColumnName = "出版社";
            bookData.Columns[9].ColumnName = "价格";
            return bookData;
        }
        public string[] bookinfos(string bookName)
        {
            string bookDigestCommand = string.Format("select * from booksinfo where BookName='{0}'", bookName);
            string[] bookinfos = new string[9];

            using (MySqlConnection bookDigestConnection = new MySqlConnection(connectionString))
            {
                bookDigestConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(bookDigestCommand, bookDigestConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    bookinfos[0] = mySqlDataReader["BookName"].ToString();
                    bookinfos[1] = mySqlDataReader["ISBN"].ToString();
                    bookinfos[2] = mySqlDataReader["BookType"].ToString();
                    bookinfos[3] = mySqlDataReader["Press"].ToString();
                    bookinfos[4] = mySqlDataReader["Author"].ToString();
                    bookinfos[5] = mySqlDataReader["PressTime"].ToString();
                    bookinfos[6] = mySqlDataReader["BookNum"].ToString();
                    bookinfos[7] = mySqlDataReader["ExistNum"].ToString();
                    bookinfos[8] = mySqlDataReader["Abstract"].ToString();
                }
            }
            return bookinfos;
        }
        public bool addNewBook(string bookName, string bookClass, string language, string oldName,
            string bookNumber, string price, string author, string iSBN, string translator,
           string publish, string press, string content)
        {
            bool IsBookAdd;
            string addNewBookCommandText = string.Format("insert into booksinfo(BookName,BookType,Language,OriginName,BookNum,Price,Author,ISBN,Translator,PressTime,Press,Abstract) value('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}','{11}')", bookName, bookClass, language, oldName, bookNumber, price, author, iSBN, translator, publish, press, content);
            string IsBookEixstedCommandText = string.Format("select * from booksinfo where BookName='{0}'", bookName);
            using (MySqlConnection addNewBookConnection = new MySqlConnection(connectionString))
            {
                addNewBookConnection.Open();
                MySqlCommand AddCommand = new MySqlCommand(addNewBookCommandText, addNewBookConnection);
                MySqlCommand IsExistedCommand = new MySqlCommand(IsBookEixstedCommandText, addNewBookConnection);
                using (MySqlDataReader IsExistedReader = IsExistedCommand.ExecuteReader())
                {
                    if (IsExistedReader.Read())
                        IsBookAdd = false;
                    else
                        IsBookAdd = true;
                }
                if (IsBookAdd)
                    AddCommand.ExecuteNonQuery();
            }
            return IsBookAdd;
        }
        public void bookInfoChange(string bookNumber, string bookName, string bookClass, string press, string author, string bookCount, string publishTime, string digestText)
        {
            string bookInfoChangeCommandText = string.Format("update booksinfo set BookName='{0}',BookType='{1}',Press='{2}'," + "Author='{3}',PressTime='{4}',ExistNum={5}, Abstract='{6}' where BookNum='{7}'", bookName, bookClass, press, author, publishTime, bookCount, digestText, bookNumber);

            using (MySqlConnection bookInfoChangeConnection = new MySqlConnection(connectionString))
            {
                bookInfoChangeConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(bookInfoChangeCommandText, bookInfoChangeConnection);
                mySqlCommand.ExecuteNonQuery();
            }
        }
        public void bookDelete(string ISBN)
        {
            string bookDeleteCommand = string.Format("delete from booksinfo where ISBN='{0}'", ISBN);
            string foreign_key_checks_false = "SET foreign_key_checks = 0;";
            string foreign_key_checks = "SET foreign_key_checks = 1;";
            using (MySqlConnection bookDeleteConnection = new MySqlConnection(connectionString))
            {
                bookDeleteConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(bookDeleteCommand, bookDeleteConnection);
                MySqlCommand foreign_key_checks_falseCommand = new MySqlCommand(foreign_key_checks_false, bookDeleteConnection);
                MySqlCommand foreign_key_checksCommand = new MySqlCommand(foreign_key_checks, bookDeleteConnection);
                foreign_key_checks_falseCommand.ExecuteNonQuery();
                mySqlCommand.ExecuteNonQuery();
                foreign_key_checksCommand.ExecuteNonQuery();
                bookDeleteConnection.Close();
            }
        }
        public DataTable getBookType()
        {
            DataTable bookType;

            string seekType = string.Format("select * from book_type_info");

            using (MySqlConnection seekTypeConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekType, seekTypeConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                bookType = dataTable;
            }
            return bookType;
        }
        public DataTable showBookType()
        {
            DataTable bookType;
            string showBookTypeCommandText = string.Format("select BookType from book_type_info");

            using (MySqlConnection showBookTypeConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showBookTypeCommandText, showBookTypeConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                bookType = dataTable;
            }
            bookType.Columns[0].ColumnName = "类别";
            return bookType;
        }
        public bool bookTypeDelete(string bookTypeName)
        {
            bool isDeleted;
            string selectbookTypeString = string.Format("select * from booksinfo where BookType='{0}'", bookTypeName);
            using (MySqlConnection selectbookTypeConnection = new MySqlConnection(connectionString))
            {
                selectbookTypeConnection.Open();
                MySqlCommand selectbookTypeCommand = new MySqlCommand(selectbookTypeString, selectbookTypeConnection);
                MySqlDataReader bookTypeReader = selectbookTypeCommand.ExecuteReader();
                if (!bookTypeReader.Read())
                {
                    string bookTypeDeleteCommand = string.Format("delete from book_type_info where BookType='{0}'", bookTypeName);
                    using (MySqlConnection bookTypeDeleteConnection = new MySqlConnection(connectionString))
                    {
                        bookTypeDeleteConnection.Open();
                        MySqlCommand mySqlCommand = new MySqlCommand(bookTypeDeleteCommand, bookTypeDeleteConnection);
                        mySqlCommand.ExecuteNonQuery();
                        bookTypeDeleteConnection.Close();
                        isDeleted = true;
                    }
                }
                else
                {
                    isDeleted = false;
                }
                selectbookTypeConnection.Close();
            }
            return isDeleted;
        }
        public bool bookTypeAdd(string bookTypeName)
        {
            bool isAdded;

            string addbookTypeString = string.Format("insert into book_type_info(BookType) values('{0}') ", bookTypeName);

            using (MySqlConnection addbookTypeConnection = new MySqlConnection(connectionString))
            {
                addbookTypeConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(addbookTypeString, addbookTypeConnection);
                isAdded = mySqlCommand.ExecuteNonQuery() > 0 ? true : false;
                addbookTypeConnection.Close();
            }
            return isAdded;
        }
        public bool bookTypeInfoChange(string oldBookType, string newBookType)
        {
            bool isChanged;

            string selectbookTypeString = string.Format("select * from booksinfo where BookType='{0}'", oldBookType);
            using (MySqlConnection selectbookTypeConnection = new MySqlConnection(connectionString))
            {
                selectbookTypeConnection.Open();
                MySqlCommand selectbookTypeCommand = new MySqlCommand(selectbookTypeString, selectbookTypeConnection);
                MySqlDataReader bookTypeReader = selectbookTypeCommand.ExecuteReader();
                if (!bookTypeReader.Read())
                {
                    string changeBookTypeString = string.Format("update book_type_info set BookType='{1}' where BookType='{0}'", oldBookType, newBookType);
                    using (MySqlConnection changeBookTypeConnection = new MySqlConnection(connectionString))
                    {
                        changeBookTypeConnection.Open();
                        MySqlCommand mySqlCommand = new MySqlCommand(changeBookTypeString, changeBookTypeConnection);
                        isChanged = mySqlCommand.ExecuteNonQuery() > 0 ? true : false;
                        changeBookTypeConnection.Close();
                    }
                }
                else
                {
                    isChanged = false;
                }
                selectbookTypeConnection.Close();
            }
            return isChanged;
        }
        /***********************************************************书本相关***********************************************************/

        /***********************************************************归还丢失损坏相关***********************************************************/
        public bool[] returnBook(string bookName, string bookNumber, string returnTime, string borrowTime, string userName)
        {
            bool isBorrow = false;
            bool IsReturn = false;
            bool IsBroken = false;
            bool IsLost = false;
            bool IsOverTime = false;
            bool[] flag = new bool[5];
            string returnCommandText = string.Format("update loaninfo set IsReturn='是',ReturnTime='{0}' where BorrowTime='{1}'" + " and Borrower='{2}'", returnTime, borrowTime, userName);
            string IsReturnCommandText = string.Format("select * from loaninfo where BorrowTime='{0}'", borrowTime);
            string updateBookCommandText = string.Format("update booksinfo set ExistNum=ExistNum+1 where BookName='{0}' and BookNum='{1}'", bookName, bookNumber);

            using (MySqlConnection returnBookConnection = new MySqlConnection(connectionString))
            {
                returnBookConnection.Open();
                MySqlCommand returnCommand = returnBookConnection.CreateCommand();
                MySqlCommand IsReturnCommand = returnBookConnection.CreateCommand();
                MySqlCommand UpdateCommand = returnBookConnection.CreateCommand();
                MySqlTransaction transaction;

                //启动事务
                transaction = returnBookConnection.BeginTransaction();

                //设定SqlCommand的事务和连接对象
                returnCommand.Connection = returnBookConnection;
                returnCommand.Transaction = transaction;

                IsReturnCommand.Connection = returnBookConnection;
                IsReturnCommand.Transaction = transaction;

                UpdateCommand.Connection = returnBookConnection;
                UpdateCommand.Transaction = transaction;

                // 开始执行操作
                try
                {
                    returnCommand.CommandText = returnCommandText;
                    IsReturnCommand.CommandText = IsReturnCommandText;
                    UpdateCommand.CommandText = updateBookCommandText;

                    using (MySqlDataReader IsReturnRead = IsReturnCommand.ExecuteReader())
                    {
                        if (IsReturnRead.Read())
                        {
                            if (IsReturnRead["IsReturn"].ToString() == "是") IsReturn = true;
                            else IsReturn = false;
                            if (IsReturnRead["IsBroken"].ToString() == "是") IsBroken = true;
                            else IsBroken = false;
                            if (IsReturnRead["IsLost"].ToString() == "是") IsLost = true;
                            else IsLost = false;
                            if (IsReturnRead["IsOverTime"].ToString() == "是") IsOverTime = true;
                            else IsOverTime = false;
                            DateTime dt = DateTime.Parse(IsReturnRead["ShouldReturnTime"].ToString());
                            if (dt < DateTime.Now) IsOverTime = true;
                            else IsOverTime = false;
                            isBorrow = true;
                        }
                        else isBorrow = false;
                    }
                    if (!IsReturn && isBorrow && (!IsBroken && !IsLost && !IsOverTime))
                    {
                        returnCommand.ExecuteNonQuery();
                        UpdateCommand.ExecuteNonQuery();
                    }

                    // 完成提交
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    //数据回滚
                    transaction.Rollback();
                }
            }
            flag[0] = IsReturn;
            flag[1] = isBorrow;
            flag[2] = IsBroken;
            flag[3] = IsLost;
            flag[4] = IsOverTime;
            return flag;
        }
        public bool[] brokenBook(string bookName, string bookNumber, string returnTime, string borrowTime, string userName)
        {
            bool isBorrow = false;
            bool IsReturn = false;
            bool IsBroken = false;
            bool IsLost = false;
            bool IsOverTime = false;
            bool[] flag = new bool[5];
            string price = "";

            string selectBookCommandText = string.Format("select Price from booksinfo where BookName='{0}' and BookNum='{1}'", bookName, bookNumber);
            using (MySqlConnection selectBookConnection = new MySqlConnection(connectionString))
            {
                selectBookConnection.Open();
                MySqlCommand SelectCommand = selectBookConnection.CreateCommand();
                SelectCommand.Connection = selectBookConnection;
                SelectCommand.CommandText = selectBookCommandText;
                using (MySqlDataReader selectRead = SelectCommand.ExecuteReader())
                {
                    if (selectRead.Read())
                        price = selectRead["Price"].ToString();
                }
                selectBookConnection.Close();
            }

            string brokenCommandText = string.Format("update loaninfo set IsBroken='是',Punishment={0} where BorrowTime='{1}' and Borrower='{2}'", price, borrowTime, userName);
            string IsBrokenCommandText = string.Format("select * from loaninfo where BorrowTime='{0}'", borrowTime);

            using (MySqlConnection brokenBookConnection = new MySqlConnection(connectionString))
            {
                brokenBookConnection.Open();
                MySqlCommand brokenCommand = brokenBookConnection.CreateCommand();
                MySqlCommand IsBrokenCommand = brokenBookConnection.CreateCommand();
                MySqlTransaction transaction;

                //启动事务
                transaction = brokenBookConnection.BeginTransaction();

                //设定SqlCommand的事务和连接对象
                brokenCommand.Connection = brokenBookConnection;
                brokenCommand.Transaction = transaction;

                IsBrokenCommand.Connection = brokenBookConnection;
                IsBrokenCommand.Transaction = transaction;

                // 开始执行操作
                try
                {
                    brokenCommand.CommandText = brokenCommandText;
                    IsBrokenCommand.CommandText = IsBrokenCommandText;

                    using (MySqlDataReader IsBrokenRead = IsBrokenCommand.ExecuteReader())
                    {
                        if (IsBrokenRead.Read())
                        {
                            if (IsBrokenRead["IsReturn"].ToString() == "是") IsReturn = true;
                            else IsReturn = false;
                            if (IsBrokenRead["IsBroken"].ToString() == "是") IsBroken = true;
                            else IsBroken = false;
                            if (IsBrokenRead["IsLost"].ToString() == "是") IsLost = true;
                            else IsLost = false;
                            DateTime dt = DateTime.Parse(IsBrokenRead["ShouldReturnTime"].ToString());
                            if (dt < DateTime.Now) IsOverTime = true;
                            else IsOverTime = false;
                            isBorrow = true;
                        }
                        else isBorrow = false;
                    }
                    if (!IsReturn && isBorrow && (!IsBroken && !IsLost))
                        brokenCommand.ExecuteNonQuery();

                    // 完成提交
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    //数据回滚
                    transaction.Rollback();
                }
            }
            flag[0] = IsReturn;
            flag[1] = isBorrow;
            flag[2] = IsBroken;
            flag[3] = IsLost;
            flag[4] = IsOverTime;
            return flag;
        }
        public bool[] lostBook(string bookName, string bookNumber, string borrowTime, string userName)
        {
            bool isBorrow = false;
            bool IsReturn = false;
            bool IsBroken = false;
            bool IsLost = false;
            bool IsOverTime = false;
            bool[] flag = new bool[5];
            string price = "";

            string selectBookCommandText = string.Format("select Price from booksinfo where BookName='{0}' and BookNum='{1}'", bookName, bookNumber);
            using (MySqlConnection selectBookConnection = new MySqlConnection(connectionString))
            {
                selectBookConnection.Open();
                MySqlCommand SelectCommand = selectBookConnection.CreateCommand();
                SelectCommand.Connection = selectBookConnection;
                SelectCommand.CommandText = selectBookCommandText;
                using (MySqlDataReader selectRead = SelectCommand.ExecuteReader())
                {
                    if (selectRead.Read())
                        price = selectRead["Price"].ToString();
                }
                selectBookConnection.Close();
            }

            string lostCommandText = string.Format("update loaninfo set IsLost='是',Punishment=2*{0} where BorrowTime='{1}' and Borrower='{2}'", price, borrowTime, userName);
            string IsLostCommandText = string.Format("select * from loaninfo where BorrowTime='{0}'", borrowTime);

            using (MySqlConnection lostBookConnection = new MySqlConnection(connectionString))
            {
                lostBookConnection.Open();
                MySqlCommand lostCommand = lostBookConnection.CreateCommand();
                MySqlCommand IsLostCommand = lostBookConnection.CreateCommand();
                MySqlTransaction transaction;

                //启动事务
                transaction = lostBookConnection.BeginTransaction();

                //设定SqlCommand的事务和连接对象
                lostCommand.Connection = lostBookConnection;
                lostCommand.Transaction = transaction;

                IsLostCommand.Connection = lostBookConnection;
                IsLostCommand.Transaction = transaction;

                // 开始执行操作
                try
                {
                    lostCommand.CommandText = lostCommandText;
                    IsLostCommand.CommandText = IsLostCommandText;

                    using (MySqlDataReader IsLostRead = IsLostCommand.ExecuteReader())
                    {
                        if (IsLostRead.Read())
                        {
                            if (IsLostRead["IsReturn"].ToString() == "是") IsReturn = true;
                            else IsReturn = false;
                            if (IsLostRead["IsBroken"].ToString() == "是") IsBroken = true;
                            else IsBroken = false;
                            if (IsLostRead["IsLost"].ToString() == "是") IsLost = true;
                            else IsLost = false;
                            DateTime dt = DateTime.Parse(IsLostRead["ShouldReturnTime"].ToString());
                            if (dt < DateTime.Now) IsOverTime = true;
                            else IsOverTime = false;
                            isBorrow = true;
                        }
                        else isBorrow = false;
                    }
                    if (!IsReturn && isBorrow && !IsLost)
                    {
                        lostCommand.ExecuteNonQuery();
                    }

                    // 完成提交
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    //数据回滚
                    transaction.Rollback();
                }
            }
            flag[0] = IsReturn;
            flag[1] = isBorrow;
            flag[2] = IsBroken;
            flag[3] = IsLost;
            flag[4] = IsOverTime;
            return flag;
        }
        /***********************************************************归还丢失损坏相关***********************************************************/

        /***********************************************************借阅相关***********************************************************/
        public DataTable loanRecord(string name)
        {
            DataTable loanRecord;

            string CommandText = string.Format("select BookNum,BookName,Borrower,BorrowTime,ShouldReturnTime,IsReturn,ReturnTime,IsBroken,IsLost,IsOverTime,Punishment from loaninfo where Borrower='{0}'", name);

            using (MySqlConnection loanRecordConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(CommandText, connectionString);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                loanRecord = dataTable;
            }
            loanRecord.Columns[0].ColumnName = "编号";
            loanRecord.Columns[1].ColumnName = "书名";
            loanRecord.Columns[2].ColumnName = "借阅人";
            loanRecord.Columns[3].ColumnName = "借阅时间";
            loanRecord.Columns[4].ColumnName = "应还时间";
            loanRecord.Columns[5].ColumnName = "是否归还";
            loanRecord.Columns[6].ColumnName = "归还时间";
            loanRecord.Columns[7].ColumnName = "是否破损";
            loanRecord.Columns[8].ColumnName = "是否丢失";
            loanRecord.Columns[9].ColumnName = "是否超时";
            loanRecord.Columns[10].ColumnName = "罚款金额";
            return loanRecord;
        }
        public bool borrowAdd(string bookName, string ISBN, string name, string borrowTime, string bookNumber)
        {
            bool IsborrowAdd = false;
            string shouldReturnTime = DateTime.Now.AddMonths(1).ToString();
            string borrowBookCommand = string.Format("insert into loaninfo(BookNum,BookName,Borrower,BorrowTime,ShouldReturnTime,IsReturn,IsBroken,IsLost,IsOverTime) values('{0}','{1}','{2}','{3}','{4}','否','否','否','否')", bookNumber, bookName, name, borrowTime, shouldReturnTime);
            string seekBookCommand = string.Format("select * from loaninfo where BookName='{0}'" + " and Borrower='{1}' and IsReturn='否'", bookName, name);
            string updateBookCommand = string.Format("update booksinfo set ExistNum=ExistNum-1 where ISBN='{0}'", ISBN);

            using (MySqlConnection userAddConnection = new MySqlConnection(connectionString))
            {
                userAddConnection.Open();
                MySqlCommand AddCommand = userAddConnection.CreateCommand();
                MySqlCommand SeekCommand = userAddConnection.CreateCommand();
                MySqlCommand UpdateCommand = userAddConnection.CreateCommand();
                MySqlTransaction transaction;

                //启动事务
                transaction = userAddConnection.BeginTransaction();

                //设定SqlCommand的事务和连接对象
                AddCommand.Connection = userAddConnection;
                AddCommand.Transaction = transaction;

                SeekCommand.Connection = userAddConnection;
                SeekCommand.Transaction = transaction;

                UpdateCommand.Connection = userAddConnection;
                UpdateCommand.Transaction = transaction;

                // 开始执行操作
                try
                {
                    AddCommand.CommandText = borrowBookCommand;
                    SeekCommand.CommandText = seekBookCommand;
                    UpdateCommand.CommandText = updateBookCommand;

                    using (MySqlDataReader mySqlDataReader = SeekCommand.ExecuteReader())
                    {
                        if (mySqlDataReader.Read())
                        {
                            if (mySqlDataReader["IsReturn"].ToString() == "否")
                            {
                                IsborrowAdd = false;
                            }
                            else
                            {
                                IsborrowAdd = true;
                            }
                        }
                        else IsborrowAdd = true;
                    }
                    if (IsborrowAdd)
                    {
                        AddCommand.ExecuteNonQuery();
                        UpdateCommand.ExecuteNonQuery();
                    }

                    // 完成提交
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    //数据回滚
                    transaction.Rollback();
                }
            }
            return IsborrowAdd;
        }
        public DataTable showAllLoanRecord()
        {
            DataTable loanRecord;
            string CommandText = string.Format("select * from loaninfo");
            using (MySqlConnection loanRecordConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(CommandText, connectionString);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                loanRecord = dataTable;
            }
            loanRecord.Columns[0].ColumnName = "编号";
            loanRecord.Columns[1].ColumnName = "书名";
            loanRecord.Columns[2].ColumnName = "借阅人";
            loanRecord.Columns[3].ColumnName = "借阅时间";
            loanRecord.Columns[4].ColumnName = "应还时间";
            loanRecord.Columns[5].ColumnName = "是否归还";
            loanRecord.Columns[6].ColumnName = "归还时间";
            loanRecord.Columns[7].ColumnName = "是否破损";
            loanRecord.Columns[8].ColumnName = "是否丢失";
            loanRecord.Columns[9].ColumnName = "是否超时";
            loanRecord.Columns[10].ColumnName = "罚款金额";
            return loanRecord;
        }
        public DataTable seekLoanRecord(string selectType, string name)
        {
            DataTable loanRecord;
            string CommandText = string.Format("select BookNum,BookName,Borrower,BorrowTime,ShouldReturnTime,IsReturn,ReturnTime,IsBroken,IsLost,IsOverTime,Punishment from loaninfo where {0} like '%{1}%'", selectType, name);
            using (MySqlConnection loanRecordConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(CommandText, connectionString);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                loanRecord = dataTable;
            }
            loanRecord.Columns[0].ColumnName = "编号";
            loanRecord.Columns[1].ColumnName = "书名";
            loanRecord.Columns[2].ColumnName = "借阅人";
            loanRecord.Columns[3].ColumnName = "借阅时间";
            loanRecord.Columns[4].ColumnName = "应还时间";
            loanRecord.Columns[5].ColumnName = "是否归还";
            loanRecord.Columns[6].ColumnName = "归还时间";
            loanRecord.Columns[7].ColumnName = "是否破损";
            loanRecord.Columns[8].ColumnName = "是否丢失";
            loanRecord.Columns[9].ColumnName = "是否超时";
            loanRecord.Columns[10].ColumnName = "罚款金额";
            return loanRecord;
        }
        public void loanDelete(string borrowTime)
        {
            string CommandText = string.Format("delete from loaninfo where BorrowTime='{0}'", borrowTime);
            using (MySqlConnection deleteConnection = new MySqlConnection(connectionString))
            {
                deleteConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(CommandText, deleteConnection);
                mySqlCommand.ExecuteNonQuery();
                deleteConnection.Close();
            }
        }
        public void loanFineProgress(string borrowTime)
        {
            string CommandText = string.Format("update loaninfo set isReturn='是' where BorrowTime='{0}'", borrowTime);
            using (MySqlConnection deleteConnection = new MySqlConnection(connectionString))
            {
                deleteConnection.Open();
                MySqlTransaction transaction;
                //启动事务
                transaction = deleteConnection.BeginTransaction();
                MySqlCommand loanCommand = deleteConnection.CreateCommand();
                //设定SqlCommand的事务和连接对象
                loanCommand.Connection = deleteConnection;
                loanCommand.Transaction = transaction;
                // 开始执行操作
                try
                {
                    loanCommand.CommandText = CommandText;
                    loanCommand.ExecuteNonQuery();
                    // 完成提交
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    //数据回滚
                    transaction.Rollback();
                }
                deleteConnection.Close();
            }
        }
        /***********************************************************借阅相关***********************************************************/

        /***********************************************************权限相关***********************************************************/
        //收回权限
        public bool rollGRANT(string name)
        {
            string getAdmin = string.Format("select * from admin where AdminName='{0}'", name);
            using (MySqlConnection rollGRANTConnection = new MySqlConnection(connectionString))
            {
                bool getAdminData = false;
                rollGRANTConnection.Open();
                MySqlCommand getAdminCommand = new MySqlCommand(getAdmin, rollGRANTConnection);
                string rollGRANT = string.Format("delete from admin where AdminName='{0}'", name);
                MySqlCommand rollGRANTCommand = new MySqlCommand(rollGRANT, rollGRANTConnection);
                string setUserPower = string.Format("update user_info set Cha=0 where UserName='{0}'", name);
                MySqlCommand setUserPowerCommand = new MySqlCommand(setUserPower, rollGRANTConnection);
                using (MySqlDataReader getAdminDataReader = getAdminCommand.ExecuteReader())
                {
                    if (getAdminDataReader.Read()) getAdminData = true;
                    else getAdminData = false;
                    getAdminDataReader.Close();
                }
                if (!getAdminData) return getAdminData;
                else
                {
                    rollGRANTCommand.ExecuteNonQuery();
                    setUserPowerCommand.ExecuteNonQuery();
                    return getAdminData;
                }
            }
        }
        public bool GRANT(string name)
        {
            string getAdmin = string.Format("select * from admin where AdminName='{0}'", name);
            string getUserPassword = string.Format("select * from user_info where UserName='{0}'", name);
            string grantUserCommand = "";
            using (MySqlConnection GRANTConnection = new MySqlConnection(connectionString))
            {
                bool isAdminData = false;
                GRANTConnection.Open();
                //读取是否在管理员下
                MySqlCommand getAdminCommand = new MySqlCommand(getAdmin, GRANTConnection);
                using (MySqlDataReader getAdminDataReader = getAdminCommand.ExecuteReader())
                {
                    if (getAdminDataReader.Read()) isAdminData = true;
                    else isAdminData = false;
                    getAdminDataReader.Close();
                }
                //读取密码
                MySqlCommand getUserPasswordCommand = new MySqlCommand(getUserPassword, GRANTConnection);
                using (MySqlDataReader getUserPasswordDataReader = getUserPasswordCommand.ExecuteReader())
                {
                    if (getUserPasswordDataReader.Read())
                    {
                        grantUserCommand = string.Format("insert into admin(AdminName,Password) values('{0}','{1}')", name, getUserPasswordDataReader["Password"].ToString());
                        getUserPasswordDataReader.Close();
                    }
                }
                MySqlCommand mySqlgetUserCommand = new MySqlCommand(grantUserCommand, GRANTConnection);
                string setPowerList = string.Format("update user_info set Cha=2 where UserName='{0}'", name);
                MySqlCommand setPowerListCommand = new MySqlCommand(setPowerList, GRANTConnection);
                if (isAdminData) return isAdminData;
                else
                {
                    mySqlgetUserCommand.ExecuteNonQuery();
                    setPowerListCommand.ExecuteNonQuery();
                    return isAdminData;
                }
            }
        }
        public bool setStudent(string UserName)
        {
            bool setStudentSuccess = false;
            using (MySqlConnection setStudentConnection = new MySqlConnection(connectionString))
            {
                setStudentConnection.Open();
                string setChaStudent = string.Format("update user_info set Cha=0 where UserName='{0}'", UserName);
                MySqlCommand setChaStudentCommand = new MySqlCommand(setChaStudent, setStudentConnection);
                if (setChaStudentCommand.ExecuteNonQuery() > 0) setStudentSuccess = true;
                else setStudentSuccess = false;
                setStudentConnection.Close();
            }
            return setStudentSuccess;
        }
        public bool setTeacher(string UserName)
        {
            bool setTeacherSuccess = false;
            using (MySqlConnection setTeacherConnection = new MySqlConnection(connectionString))
            {
                setTeacherConnection.Open();
                string setChaTeacher = string.Format("update user_info set Cha=1 where UserName='{0}'", UserName);
                MySqlCommand setChaTeacherCommand = new MySqlCommand(setChaTeacher, setTeacherConnection);
                if (setChaTeacherCommand.ExecuteNonQuery() > 0) setTeacherSuccess = true;
                else setTeacherSuccess = false;
                setTeacherConnection.Close();
            }
            return setTeacherSuccess;
        }
        /***********************************************************权限相关***********************************************************/

        /***********************************************************出版社相关***********************************************************/
        public DataTable getPress()
        {
            DataTable press;
            string seekPresses = string.Format("select * from pressinfo");
            using (MySqlConnection seekPressConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekPresses, seekPressConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                press = dataTable;
            }
            return press;
        }
        public DataTable showPress()
        {
            DataTable press;
            string showPressCommandText = string.Format("select Press from pressinfo");
            using (MySqlConnection showPressConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showPressCommandText, showPressConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                press = dataTable;
            }
            press.Columns[0].ColumnName = "出版社";
            return press;
        }
        public bool pressDelete(string pressName)
        {
            bool isDeleted;
            string selectPressString = string.Format("select * from booksinfo where Press='{0}'", pressName);
            using (MySqlConnection selectPressConnection = new MySqlConnection(connectionString))
            {
                selectPressConnection.Open();
                MySqlCommand selectPressCommand = new MySqlCommand(selectPressString, selectPressConnection);
                MySqlDataReader pressReader = selectPressCommand.ExecuteReader();
                if (!pressReader.Read())
                {
                    string pressDeleteCommand = string.Format("delete from pressinfo where Press='{0}'", pressName);
                    using (MySqlConnection pressDeleteConnection = new MySqlConnection(connectionString))
                    {
                        pressDeleteConnection.Open();
                        MySqlCommand mySqlCommand = new MySqlCommand(pressDeleteCommand, pressDeleteConnection);
                        mySqlCommand.ExecuteNonQuery();
                        pressDeleteConnection.Close();
                        isDeleted = true;
                    }
                }
                else
                {
                    isDeleted = false;
                }
                selectPressConnection.Close();
            }
            return isDeleted;
        }
        public bool pressAdd(string pressName)
        {
            bool isAdded;
            string addPressString = string.Format("insert into pressinfo(Press) values('{0}') ", pressName);
            using (MySqlConnection addPressConnection = new MySqlConnection(connectionString))
            {
                addPressConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(addPressString, addPressConnection);
                isAdded = mySqlCommand.ExecuteNonQuery() > 0 ? true : false;
                addPressConnection.Close();
            }
            return isAdded;
        }
        public bool pressInfoChange(string oldPress, string newPress)
        {
            bool isChanged;
            string selectPressString = string.Format("select * from booksinfo where Press='{0}'", oldPress);
            using (MySqlConnection selectPressConnection = new MySqlConnection(connectionString))
            {
                selectPressConnection.Open();
                MySqlCommand selectPressCommand = new MySqlCommand(selectPressString, selectPressConnection);
                MySqlDataReader pressReader = selectPressCommand.ExecuteReader();
                if (!pressReader.Read())
                {
                    string changePressString = string.Format("update pressinfo set Press='{1}' where Press='{0}'", oldPress, newPress);
                    using (MySqlConnection changePressConnection = new MySqlConnection(connectionString))
                    {
                        changePressConnection.Open();
                        MySqlCommand mySqlCommand = new MySqlCommand(changePressString, changePressConnection);
                        isChanged = mySqlCommand.ExecuteNonQuery() > 0 ? true : false;
                        changePressConnection.Close();
                    }
                }
                else
                {
                    isChanged = false;
                }
                selectPressConnection.Close();
            }
            return isChanged;
        }
        /***********************************************************出版社相关***********************************************************/

        /***********************************************************用户相关***********************************************************/
        public DataTable commonUser()
        {
            DataTable commonUser;
            string CommonUserCommandText = "select * from user_info";
            using (MySqlConnection commonUserConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(CommonUserCommandText, commonUserConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                commonUser = dataTable;
            }
            commonUser.Columns[0].ColumnName = "用户ID";
            commonUser.Columns[1].ColumnName = "用户名";
            commonUser.Columns[2].ColumnName = "密码";
            commonUser.Columns[3].ColumnName = "年龄";
            commonUser.Columns[4].ColumnName = "性别";
            commonUser.Columns[5].ColumnName = "地址";
            commonUser.Columns[6].ColumnName = "手机号码";
            commonUser.Columns[7].ColumnName = "部门";
            commonUser.Columns[8].ColumnName = "权限";
            return commonUser;
        }
        public DataTable seekUser(string userClass, string value)
        {
            switch (userClass)
            {
                case "用户名":
                    userClass = "UserName";
                    break;
                case "年龄":
                    userClass = "Age";
                    break;
                case "性别":
                    userClass = "Sex";
                    break;
                case "手机号码":
                    userClass = "Telephone";
                    break;
                case "学院":
                    userClass = "Department";
                    break;
            }
            string seekUserByClassCommandText = string.Format("select * from user_info where {0} like '%{1}%'", userClass, value);
            string seekUserAllCommandText = string.Format("select * from user_info");
            DataTable seekUsers;
            if (value != "")
            {
                using (MySqlConnection seekUserConnection = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekUserByClassCommandText, seekUserConnection);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    seekUsers = dataTable;
                }
            }
            else
            {
                using (MySqlConnection seekUserConnection = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekUserAllCommandText, seekUserConnection);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    seekUsers = dataTable;
                }
            }
            seekUsers.Columns[0].ColumnName = "用户ID";
            seekUsers.Columns[1].ColumnName = "用户名";
            seekUsers.Columns[2].ColumnName = "密码";
            seekUsers.Columns[3].ColumnName = "年龄";
            seekUsers.Columns[4].ColumnName = "性别";
            seekUsers.Columns[5].ColumnName = "地址";
            seekUsers.Columns[6].ColumnName = "手机号码";
            seekUsers.Columns[7].ColumnName = "部门";
            seekUsers.Columns[8].ColumnName = "权限";
            return seekUsers;
        }
        /***********************************************************用户相关***********************************************************/

        /***********************************************************登录记录相关***********************************************************/
        public DataTable seekLoginData(string userClass, string value)
        {
            string seekLoginDataByClassCommandText = string.Format("select loginrecord.UserName,loginrecord.LoginTime from user_info,loginrecord where user_info.{0} like '%{1}%' and user_info.UserName=loginrecord.UserName", userClass, value);
            DataTable seekUsers;
            using (MySqlConnection seekLoginDataConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekLoginDataByClassCommandText, seekLoginDataConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                seekUsers = dataTable;
            }
            seekUsers.Columns[0].ColumnName = "用户名";
            seekUsers.Columns[1].ColumnName = "登录时间";
            return seekUsers;
        }
        public DataTable showAllLoginRecord()
        {
            string seekLoginDataByClassCommandText = string.Format("select * from loginrecord");
            DataTable seekUsers;
            using (MySqlConnection seekLoginDataConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(seekLoginDataByClassCommandText, seekLoginDataConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                seekUsers = dataTable;
            }
            return seekUsers;
        }
        /***********************************************************登录记录相关***********************************************************/
    }
}
