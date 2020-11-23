namespace WindowsFormsApp2
{
    partial class LoginMenuRunner
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
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ДоСтарата = new System.Windows.Forms.Label();
            this.LoginRunner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.RepeatPassword = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PhotoFile = new System.Windows.Forms.Label();
            this.DateOfBirthday = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.button_Reg = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.Viewing = new System.Windows.Forms.Button();
            this.dateTimePicker_DateOfBirthday = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_PhotoFile = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_RepeatPassword = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 40);
            this.panel1.TabIndex = 0;
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
            this.label1.TabIndex = 23;
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
            this.Back.TabIndex = 24;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.ДоСтарата);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 40);
            this.panel2.TabIndex = 1;
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
            this.ДоСтарата.TabIndex = 8;
            this.ДоСтарата.Text = "{0} дней {1} часов и {2} минут, до старта марафона!";
            this.ДоСтарата.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginRunner
            // 
            this.LoginRunner.AutoSize = true;
            this.LoginRunner.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginRunner.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginRunner.Location = new System.Drawing.Point(308, 50);
            this.LoginRunner.Name = "LoginRunner";
            this.LoginRunner.Size = new System.Drawing.Size(184, 22);
            this.LoginRunner.TabIndex = 5;
            this.LoginRunner.Text = "Регистрация бегуна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(130, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрировать в качестве \r\nбегуна";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(108, 155);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(38, 15);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(95, 190);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(51, 15);
            this.Password.TabIndex = 8;
            this.Password.Text = "Пароль:";
            // 
            // RepeatPassword
            // 
            this.RepeatPassword.AutoSize = true;
            this.RepeatPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatPassword.Location = new System.Drawing.Point(35, 225);
            this.RepeatPassword.Name = "RepeatPassword";
            this.RepeatPassword.Size = new System.Drawing.Size(111, 15);
            this.RepeatPassword.TabIndex = 9;
            this.RepeatPassword.Text = "Повторите пароль:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(112, 257);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(34, 15);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Имя:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(85, 288);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 15);
            this.LastName.TabIndex = 11;
            this.LastName.Text = "Фамилия:";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender.Location = new System.Drawing.Point(114, 318);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(32, 15);
            this.Gender.TabIndex = 12;
            this.Gender.Text = "Пол:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(620, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 120);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // PhotoFile
            // 
            this.PhotoFile.AutoSize = true;
            this.PhotoFile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhotoFile.Location = new System.Drawing.Point(451, 228);
            this.PhotoFile.Name = "PhotoFile";
            this.PhotoFile.Size = new System.Drawing.Size(70, 15);
            this.PhotoFile.TabIndex = 14;
            this.PhotoFile.Text = "Фото файл:";
            // 
            // DateOfBirthday
            // 
            this.DateOfBirthday.AutoSize = true;
            this.DateOfBirthday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthday.Location = new System.Drawing.Point(451, 318);
            this.DateOfBirthday.Name = "DateOfBirthday";
            this.DateOfBirthday.Size = new System.Drawing.Size(94, 15);
            this.DateOfBirthday.TabIndex = 15;
            this.DateOfBirthday.Text = "Дата рождения:";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Country.Location = new System.Drawing.Point(496, 288);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(49, 15);
            this.Country.TabIndex = 16;
            this.Country.Text = "Страна:";
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Location = new System.Drawing.Point(152, 312);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(112, 21);
            this.comboBox_Gender.TabIndex = 17;
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(551, 286);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(196, 21);
            this.comboBox_Country.TabIndex = 18;
            // 
            // button_Reg
            // 
            this.button_Reg.Location = new System.Drawing.Point(260, 345);
            this.button_Reg.Name = "button_Reg";
            this.button_Reg.Size = new System.Drawing.Size(140, 30);
            this.button_Reg.TabIndex = 19;
            this.button_Reg.Text = "Registration";
            this.button_Reg.UseVisualStyleBackColor = true;
            this.button_Reg.Click += new System.EventHandler(this.button_Reg_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(405, 345);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(140, 30);
            this.button_Cancel.TabIndex = 20;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Viewing
            // 
            this.Viewing.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Viewing.Location = new System.Drawing.Point(607, 249);
            this.Viewing.Name = "Viewing";
            this.Viewing.Size = new System.Drawing.Size(140, 30);
            this.Viewing.TabIndex = 21;
            this.Viewing.Text = "Просмотр";
            this.Viewing.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_DateOfBirthday
            // 
            this.dateTimePicker_DateOfBirthday.Location = new System.Drawing.Point(551, 313);
            this.dateTimePicker_DateOfBirthday.Name = "dateTimePicker_DateOfBirthday";
            this.dateTimePicker_DateOfBirthday.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker_DateOfBirthday.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_PhotoFile
            // 
            this.textBox_PhotoFile.Location = new System.Drawing.Point(454, 255);
            this.textBox_PhotoFile.Name = "textBox_PhotoFile";
            this.textBox_PhotoFile.Size = new System.Drawing.Size(147, 20);
            this.textBox_PhotoFile.TabIndex = 23;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(152, 153);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(313, 20);
            this.textBox_Email.TabIndex = 24;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(152, 188);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(248, 20);
            this.textBox_Password.TabIndex = 25;
            // 
            // textBox_RepeatPassword
            // 
            this.textBox_RepeatPassword.Location = new System.Drawing.Point(152, 223);
            this.textBox_RepeatPassword.Name = "textBox_RepeatPassword";
            this.textBox_RepeatPassword.Size = new System.Drawing.Size(248, 20);
            this.textBox_RepeatPassword.TabIndex = 26;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(152, 255);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(248, 20);
            this.textBox_Name.TabIndex = 27;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(152, 286);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(248, 20);
            this.textBox_LastName.TabIndex = 28;
            // 
            // LoginMenuRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_RepeatPassword);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_PhotoFile);
            this.Controls.Add(this.dateTimePicker_DateOfBirthday);
            this.Controls.Add(this.Viewing);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Reg);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginRunner);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginMenuRunner";
            this.Text = "LoginMenuRunner";
            this.Load += new System.EventHandler(this.LoginMenuRunner_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label LoginRunner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label RepeatPassword;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PhotoFile;
        private System.Windows.Forms.Label DateOfBirthday;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.Button button_Reg;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button Viewing;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOfBirthday;
        private System.Windows.Forms.Label ДоСтарата;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_PhotoFile;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_RepeatPassword;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_LastName;
    }
}