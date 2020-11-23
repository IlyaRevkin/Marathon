namespace WindowsFormsApp2
{
    partial class EditRunner
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ДоСтарата = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_RepeatPassword = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_PhotoFile = new System.Windows.Forms.TextBox();
            this.dateTimePicker_DateOfBirthday = new System.Windows.Forms.DateTimePicker();
            this.Viewing = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.Country = new System.Windows.Forms.Label();
            this.DateOfBirthday = new System.Windows.Forms.Label();
            this.PhotoFile = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gender = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.RepeatPassword = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.EditProfilRunner = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.ДоСтарата);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 40);
            this.panel1.TabIndex = 0;
            // 
            // ДоСтарата
            // 
            this.ДоСтарата.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ДоСтарата.AutoSize = true;
            this.ДоСтарата.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ДоСтарата.ForeColor = System.Drawing.SystemColors.Window;
            this.ДоСтарата.Location = new System.Drawing.Point(37, 5);
            this.ДоСтарата.Name = "ДоСтарата";
            this.ДоСтарата.Size = new System.Drawing.Size(711, 31);
            this.ДоСтарата.TabIndex = 9;
            this.ДоСтарата.Text = "{0} дней {1} часов и {2} минут, до старта марафона!";
            this.ДоСтарата.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 40);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(199, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "MARATHON SKILLS 2020";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(5, 5);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(62, 30);
            this.Back.TabIndex = 26;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.ДоСтарата_Click);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(156, 179);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(248, 20);
            this.textBox_LastName.TabIndex = 52;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(156, 148);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(248, 20);
            this.textBox_Name.TabIndex = 51;
            // 
            // textBox_RepeatPassword
            // 
            this.textBox_RepeatPassword.Location = new System.Drawing.Point(609, 314);
            this.textBox_RepeatPassword.Name = "textBox_RepeatPassword";
            this.textBox_RepeatPassword.Size = new System.Drawing.Size(165, 20);
            this.textBox_RepeatPassword.TabIndex = 50;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(609, 288);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(165, 20);
            this.textBox_Password.TabIndex = 49;
            // 
            // textBox_PhotoFile
            // 
            this.textBox_PhotoFile.Location = new System.Drawing.Point(481, 181);
            this.textBox_PhotoFile.Name = "textBox_PhotoFile";
            this.textBox_PhotoFile.Size = new System.Drawing.Size(147, 20);
            this.textBox_PhotoFile.TabIndex = 47;
            // 
            // dateTimePicker_DateOfBirthday
            // 
            this.dateTimePicker_DateOfBirthday.Location = new System.Drawing.Point(156, 232);
            this.dateTimePicker_DateOfBirthday.Name = "dateTimePicker_DateOfBirthday";
            this.dateTimePicker_DateOfBirthday.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker_DateOfBirthday.TabIndex = 46;
            // 
            // Viewing
            // 
            this.Viewing.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Viewing.Location = new System.Drawing.Point(634, 175);
            this.Viewing.Name = "Viewing";
            this.Viewing.Size = new System.Drawing.Size(140, 30);
            this.Viewing.TabIndex = 45;
            this.Viewing.Text = "Просмотр";
            this.Viewing.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Location = new System.Drawing.Point(406, 343);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(140, 30);
            this.button_Cancel.TabIndex = 44;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(261, 343);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(140, 30);
            this.button_Save.TabIndex = 43;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(155, 258);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(196, 21);
            this.comboBox_Country.TabIndex = 42;
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Location = new System.Drawing.Point(156, 205);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(112, 21);
            this.comboBox_Gender.TabIndex = 41;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Country.Location = new System.Drawing.Point(100, 260);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(49, 15);
            this.Country.TabIndex = 40;
            this.Country.Text = "Страна:";
            // 
            // DateOfBirthday
            // 
            this.DateOfBirthday.AutoSize = true;
            this.DateOfBirthday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthday.Location = new System.Drawing.Point(56, 237);
            this.DateOfBirthday.Name = "DateOfBirthday";
            this.DateOfBirthday.Size = new System.Drawing.Size(94, 15);
            this.DateOfBirthday.TabIndex = 39;
            this.DateOfBirthday.Text = "Дата рождения:";
            // 
            // PhotoFile
            // 
            this.PhotoFile.AutoSize = true;
            this.PhotoFile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhotoFile.Location = new System.Drawing.Point(478, 154);
            this.PhotoFile.Name = "PhotoFile";
            this.PhotoFile.Size = new System.Drawing.Size(70, 15);
            this.PhotoFile.TabIndex = 38;
            this.PhotoFile.Text = "Фото файл:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(647, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 120);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender.Location = new System.Drawing.Point(118, 211);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(32, 15);
            this.Gender.TabIndex = 36;
            this.Gender.Text = "Пол:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(89, 181);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 15);
            this.LastName.TabIndex = 35;
            this.LastName.Text = "Фамилия:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(116, 150);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(34, 15);
            this.lbName.TabIndex = 34;
            this.lbName.Text = "Имя:";
            // 
            // RepeatPassword
            // 
            this.RepeatPassword.AutoSize = true;
            this.RepeatPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPassword.Location = new System.Drawing.Point(492, 316);
            this.RepeatPassword.Name = "RepeatPassword";
            this.RepeatPassword.Size = new System.Drawing.Size(111, 15);
            this.RepeatPassword.TabIndex = 33;
            this.RepeatPassword.Text = "Повторите пароль:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(552, 290);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(51, 15);
            this.Password.TabIndex = 32;
            this.Password.Text = "Пароль:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(112, 124);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(38, 15);
            this.Email.TabIndex = 31;
            this.Email.Text = "Email:";
            // 
            // EditProfilRunner
            // 
            this.EditProfilRunner.AutoSize = true;
            this.EditProfilRunner.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditProfilRunner.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EditProfilRunner.Location = new System.Drawing.Point(134, 64);
            this.EditProfilRunner.Name = "EditProfilRunner";
            this.EditProfilRunner.Size = new System.Drawing.Size(234, 22);
            this.EditProfilRunner.TabIndex = 29;
            this.EditProfilRunner.Text = "Редактирование профиля";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Email.Location = new System.Drawing.Point(153, 124);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(38, 15);
            this.label_Email.TabIndex = 53;
            this.label_Email.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(575, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Смена пароля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(539, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 30);
            this.label3.TabIndex = 55;
            this.label3.Text = "Оставти эти поля, незаполненными, \r\nесли вы не хотите изменять пароль.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditRunner
            // 
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_RepeatPassword);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_PhotoFile);
            this.Controls.Add(this.dateTimePicker_DateOfBirthday);
            this.Controls.Add(this.Viewing);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.DateOfBirthday);
            this.Controls.Add(this.PhotoFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.RepeatPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EditProfilRunner);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditRunner";
            this.Load += new System.EventHandler(this.EditRunner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label ДоСтарата;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_RepeatPassword;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_PhotoFile;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfBirthday;
        private System.Windows.Forms.Button Viewing;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label DateOfBirthday;
        private System.Windows.Forms.Label PhotoFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label RepeatPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label EditProfilRunner;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}