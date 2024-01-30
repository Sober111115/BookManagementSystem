namespace 图书管理系统
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialExpansionPanel4 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.borrowButtoon = new MaterialSkin.Controls.MaterialButton();
            this.bookDigestTextBox = new System.Windows.Forms.TextBox();
            this.materialExpansionPanel3 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.searchBookButtom = new MaterialSkin.Controls.MaterialButton();
            this.bookTextBox = new System.Windows.Forms.TextBox();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.booksDGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialExpansionPanel5 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.lostButton = new MaterialSkin.Controls.MaterialButton();
            this.brokenButton = new MaterialSkin.Controls.MaterialButton();
            this.materialExpansionPanel2 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.returnButton = new MaterialSkin.Controls.MaterialButton();
            this.materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.updateButton = new MaterialSkin.Controls.MaterialButton();
            this.libraryRecordDGV = new System.Windows.Forms.DataGridView();
            this.exitButton = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialExpansionPanel4.SuspendLayout();
            this.materialExpansionPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.materialExpansionPanel5.SuspendLayout();
            this.materialExpansionPanel2.SuspendLayout();
            this.materialExpansionPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryRecordDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1200, 553);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.materialExpansionPanel4);
            this.tabPage1.Controls.Add(this.bookDigestTextBox);
            this.tabPage1.Controls.Add(this.materialExpansionPanel3);
            this.tabPage1.Location = new System.Drawing.Point(26, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1170, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "📚图书查询&借阅";
            // 
            // materialExpansionPanel4
            // 
            this.materialExpansionPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel4.CancelButtonText = "";
            this.materialExpansionPanel4.Controls.Add(this.borrowButtoon);
            this.materialExpansionPanel4.Depth = 0;
            this.materialExpansionPanel4.Description = "CLICK TO BORROW";
            this.materialExpansionPanel4.ExpandHeight = 200;
            this.materialExpansionPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel4.Location = new System.Drawing.Point(397, 321);
            this.materialExpansionPanel4.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.materialExpansionPanel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel4.Name = "materialExpansionPanel4";
            this.materialExpansionPanel4.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel4.Size = new System.Drawing.Size(777, 200);
            this.materialExpansionPanel4.TabIndex = 41;
            this.materialExpansionPanel4.Title = "BORROW";
            this.materialExpansionPanel4.ValidationButtonText = "";
            // 
            // borrowButtoon
            // 
            this.borrowButtoon.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.borrowButtoon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.borrowButtoon.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.borrowButtoon.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.borrowButtoon.Depth = 0;
            this.borrowButtoon.HighEmphasis = true;
            this.borrowButtoon.Icon = null;
            this.borrowButtoon.Location = new System.Drawing.Point(278, 89);
            this.borrowButtoon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.borrowButtoon.MouseState = MaterialSkin.MouseState.HOVER;
            this.borrowButtoon.Name = "borrowButtoon";
            this.borrowButtoon.NoAccentTextColor = System.Drawing.Color.Empty;
            this.borrowButtoon.Size = new System.Drawing.Size(198, 36);
            this.borrowButtoon.TabIndex = 2;
            this.borrowButtoon.Text = "click to borrow now!";
            this.borrowButtoon.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.borrowButtoon.UseAccentColor = false;
            this.borrowButtoon.UseVisualStyleBackColor = true;
            this.borrowButtoon.Click += new System.EventHandler(this.borrowButtoon_Click);
            // 
            // bookDigestTextBox
            // 
            this.bookDigestTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.bookDigestTextBox.Location = new System.Drawing.Point(67, 321);
            this.bookDigestTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookDigestTextBox.Multiline = true;
            this.bookDigestTextBox.Name = "bookDigestTextBox";
            this.bookDigestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bookDigestTextBox.Size = new System.Drawing.Size(323, 200);
            this.bookDigestTextBox.TabIndex = 40;
            // 
            // materialExpansionPanel3
            // 
            this.materialExpansionPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel3.CancelButtonText = "";
            this.materialExpansionPanel3.Controls.Add(this.searchBookButtom);
            this.materialExpansionPanel3.Controls.Add(this.bookTextBox);
            this.materialExpansionPanel3.Controls.Add(this.selectClassComboBox);
            this.materialExpansionPanel3.Controls.Add(this.materialLabel1);
            this.materialExpansionPanel3.Controls.Add(this.booksDGV);
            this.materialExpansionPanel3.Depth = 0;
            this.materialExpansionPanel3.Description = "";
            this.materialExpansionPanel3.ExpandHeight = 285;
            this.materialExpansionPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel3.Location = new System.Drawing.Point(67, 16);
            this.materialExpansionPanel3.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.materialExpansionPanel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel3.Name = "materialExpansionPanel3";
            this.materialExpansionPanel3.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel3.Size = new System.Drawing.Size(1107, 285);
            this.materialExpansionPanel3.TabIndex = 39;
            this.materialExpansionPanel3.Title = "BOOKINFO";
            this.materialExpansionPanel3.ValidationButtonText = "";
            // 
            // searchBookButtom
            // 
            this.searchBookButtom.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.searchBookButtom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBookButtom.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.searchBookButtom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchBookButtom.Depth = 0;
            this.searchBookButtom.HighEmphasis = true;
            this.searchBookButtom.Icon = null;
            this.searchBookButtom.Location = new System.Drawing.Point(781, 15);
            this.searchBookButtom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchBookButtom.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchBookButtom.Name = "searchBookButtom";
            this.searchBookButtom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchBookButtom.Size = new System.Drawing.Size(75, 36);
            this.searchBookButtom.TabIndex = 55;
            this.searchBookButtom.Text = "SELECT";
            this.searchBookButtom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchBookButtom.UseAccentColor = false;
            this.searchBookButtom.UseVisualStyleBackColor = true;
            this.searchBookButtom.Click += new System.EventHandler(this.searchBookButtom_Click);
            // 
            // bookTextBox
            // 
            this.bookTextBox.Location = new System.Drawing.Point(408, 20);
            this.bookTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookTextBox.Name = "bookTextBox";
            this.bookTextBox.Size = new System.Drawing.Size(335, 26);
            this.bookTextBox.TabIndex = 54;
            // 
            // selectClassComboBox
            // 
            this.selectClassComboBox.FormattingEnabled = true;
            this.selectClassComboBox.Items.AddRange(new object[] {
            "书名",
            "ISBN号",
            "类别",
            "编号",
            "作者",
            "译者",
            "出版社",
            "存量"});
            this.selectClassComboBox.Location = new System.Drawing.Point(238, 19);
            this.selectClassComboBox.Name = "selectClassComboBox";
            this.selectClassComboBox.Size = new System.Drawing.Size(140, 28);
            this.selectClassComboBox.TabIndex = 53;
            this.selectClassComboBox.Text = "书名";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("思源黑体 CN Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(136, 21);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 23);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "SELECT BY";
            // 
            // booksDGV
            // 
            this.booksDGV.AllowUserToAddRows = false;
            this.booksDGV.AllowUserToDeleteRows = false;
            this.booksDGV.AllowUserToResizeColumns = false;
            this.booksDGV.AllowUserToResizeRows = false;
            this.booksDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.booksDGV.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.booksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDGV.GridColor = System.Drawing.SystemColors.Control;
            this.booksDGV.Location = new System.Drawing.Point(10, 59);
            this.booksDGV.Margin = new System.Windows.Forms.Padding(4);
            this.booksDGV.Name = "booksDGV";
            this.booksDGV.ReadOnly = true;
            this.booksDGV.RowHeadersVisible = false;
            this.booksDGV.RowHeadersWidth = 82;
            this.booksDGV.RowTemplate.Height = 23;
            this.booksDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDGV.Size = new System.Drawing.Size(1084, 176);
            this.booksDGV.TabIndex = 31;
            this.booksDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDGV_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.materialExpansionPanel5);
            this.tabPage2.Controls.Add(this.materialExpansionPanel2);
            this.tabPage2.Controls.Add(this.materialExpansionPanel1);
            this.tabPage2.Location = new System.Drawing.Point(26, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1170, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "🔄图书归还&挂失";
            // 
            // materialExpansionPanel5
            // 
            this.materialExpansionPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel5.CancelButtonText = "";
            this.materialExpansionPanel5.Controls.Add(this.lostButton);
            this.materialExpansionPanel5.Controls.Add(this.brokenButton);
            this.materialExpansionPanel5.Depth = 0;
            this.materialExpansionPanel5.Description = "";
            this.materialExpansionPanel5.ExpandHeight = 221;
            this.materialExpansionPanel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel5.Location = new System.Drawing.Point(543, 305);
            this.materialExpansionPanel5.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.materialExpansionPanel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel5.Name = "materialExpansionPanel5";
            this.materialExpansionPanel5.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel5.Size = new System.Drawing.Size(631, 221);
            this.materialExpansionPanel5.TabIndex = 42;
            this.materialExpansionPanel5.Title = "LOST?";
            this.materialExpansionPanel5.ValidationButtonText = "";
            // 
            // lostButton
            // 
            this.lostButton.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.lostButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lostButton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.lostButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.lostButton.Depth = 0;
            this.lostButton.HighEmphasis = true;
            this.lostButton.Icon = null;
            this.lostButton.Location = new System.Drawing.Point(379, 84);
            this.lostButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lostButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.lostButton.Name = "lostButton";
            this.lostButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.lostButton.Size = new System.Drawing.Size(166, 36);
            this.lostButton.TabIndex = 3;
            this.lostButton.Text = "I\'ve lost the book";
            this.lostButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.lostButton.UseAccentColor = false;
            this.lostButton.UseVisualStyleBackColor = true;
            this.lostButton.Click += new System.EventHandler(this.lostButton_Click);
            // 
            // brokenButton
            // 
            this.brokenButton.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.brokenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.brokenButton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.brokenButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.brokenButton.Depth = 0;
            this.brokenButton.HighEmphasis = true;
            this.brokenButton.Icon = null;
            this.brokenButton.Location = new System.Drawing.Point(68, 84);
            this.brokenButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.brokenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.brokenButton.Name = "brokenButton";
            this.brokenButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.brokenButton.Size = new System.Drawing.Size(233, 36);
            this.brokenButton.TabIndex = 2;
            this.brokenButton.Text = "The book has been broken";
            this.brokenButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.brokenButton.UseAccentColor = false;
            this.brokenButton.UseVisualStyleBackColor = true;
            this.brokenButton.Click += new System.EventHandler(this.brokenButton_Click);
            // 
            // materialExpansionPanel2
            // 
            this.materialExpansionPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel2.CancelButtonText = "";
            this.materialExpansionPanel2.Controls.Add(this.returnButton);
            this.materialExpansionPanel2.Depth = 0;
            this.materialExpansionPanel2.Description = "";
            this.materialExpansionPanel2.ExpandHeight = 221;
            this.materialExpansionPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel2.Location = new System.Drawing.Point(67, 305);
            this.materialExpansionPanel2.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.materialExpansionPanel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel2.Name = "materialExpansionPanel2";
            this.materialExpansionPanel2.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel2.Size = new System.Drawing.Size(470, 221);
            this.materialExpansionPanel2.TabIndex = 41;
            this.materialExpansionPanel2.Title = "RETURN";
            this.materialExpansionPanel2.ValidationButtonText = "";
            // 
            // returnButton
            // 
            this.returnButton.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.returnButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.returnButton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.returnButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.returnButton.Depth = 0;
            this.returnButton.HighEmphasis = true;
            this.returnButton.Icon = null;
            this.returnButton.Location = new System.Drawing.Point(196, 84);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.returnButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.returnButton.Name = "returnButton";
            this.returnButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.returnButton.Size = new System.Drawing.Size(80, 36);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "return";
            this.returnButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.returnButton.UseAccentColor = false;
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // materialExpansionPanel1
            // 
            this.materialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel1.CancelButtonText = "";
            this.materialExpansionPanel1.Controls.Add(this.updateButton);
            this.materialExpansionPanel1.Controls.Add(this.libraryRecordDGV);
            this.materialExpansionPanel1.Depth = 0;
            this.materialExpansionPanel1.Description = "";
            this.materialExpansionPanel1.ExpandHeight = 285;
            this.materialExpansionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel1.Location = new System.Drawing.Point(67, 9);
            this.materialExpansionPanel1.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel1.Name = "materialExpansionPanel1";
            this.materialExpansionPanel1.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel1.Size = new System.Drawing.Size(1107, 285);
            this.materialExpansionPanel1.TabIndex = 40;
            this.materialExpansionPanel1.Title = "HERE\'S YOUR BORROW RECORD";
            this.materialExpansionPanel1.ValidationButtonText = "";
            // 
            // updateButton
            // 
            this.updateButton.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.updateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateButton.Depth = 0;
            this.updateButton.HighEmphasis = true;
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(906, 11);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateButton.Size = new System.Drawing.Size(69, 36);
            this.updateButton.TabIndex = 32;
            this.updateButton.Text = "flush";
            this.updateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateButton.UseAccentColor = false;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // libraryRecordDGV
            // 
            this.libraryRecordDGV.AllowUserToAddRows = false;
            this.libraryRecordDGV.AllowUserToDeleteRows = false;
            this.libraryRecordDGV.AllowUserToResizeColumns = false;
            this.libraryRecordDGV.AllowUserToResizeRows = false;
            this.libraryRecordDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.libraryRecordDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.libraryRecordDGV.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.libraryRecordDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.libraryRecordDGV.GridColor = System.Drawing.SystemColors.Control;
            this.libraryRecordDGV.Location = new System.Drawing.Point(10, 59);
            this.libraryRecordDGV.Margin = new System.Windows.Forms.Padding(4);
            this.libraryRecordDGV.Name = "libraryRecordDGV";
            this.libraryRecordDGV.ReadOnly = true;
            this.libraryRecordDGV.RowHeadersVisible = false;
            this.libraryRecordDGV.RowHeadersWidth = 82;
            this.libraryRecordDGV.RowTemplate.Height = 23;
            this.libraryRecordDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.libraryRecordDGV.Size = new System.Drawing.Size(1084, 176);
            this.libraryRecordDGV.TabIndex = 31;
            // 
            // exitButton
            // 
            this.exitButton.AccentTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.exitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitButton.Depth = 0;
            this.exitButton.HighEmphasis = true;
            this.exitButton.Icon = null;
            this.exitButton.Location = new System.Drawing.Point(1045, 26);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exitButton.Size = new System.Drawing.Size(96, 36);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "📴Logout";
            this.exitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exitButton.UseAccentColor = false;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎登录图书管理系统";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialExpansionPanel4.ResumeLayout(false);
            this.materialExpansionPanel4.PerformLayout();
            this.materialExpansionPanel3.ResumeLayout(false);
            this.materialExpansionPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.materialExpansionPanel5.ResumeLayout(false);
            this.materialExpansionPanel5.PerformLayout();
            this.materialExpansionPanel2.ResumeLayout(false);
            this.materialExpansionPanel2.PerformLayout();
            this.materialExpansionPanel1.ResumeLayout(false);
            this.materialExpansionPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryRecordDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel3;
        private MaterialSkin.Controls.MaterialButton searchBookButtom;
        private System.Windows.Forms.TextBox bookTextBox;
        private System.Windows.Forms.ComboBox selectClassComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView booksDGV;
        private System.Windows.Forms.TextBox bookDigestTextBox;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel4;
        private MaterialSkin.Controls.MaterialButton borrowButtoon;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private System.Windows.Forms.DataGridView libraryRecordDGV;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel5;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel2;
        private MaterialSkin.Controls.MaterialButton lostButton;
        private MaterialSkin.Controls.MaterialButton brokenButton;
        private MaterialSkin.Controls.MaterialButton returnButton;
        private MaterialSkin.Controls.MaterialButton updateButton;
        private MaterialSkin.Controls.MaterialButton exitButton;
    }
}