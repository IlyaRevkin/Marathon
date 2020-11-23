using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class EditRunner : Form
    {
        public EditRunner()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 100;
        }
        private void ДоСтарата_Click(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            DateTime dateTime2 = new DateTime(2020, 12, 24, 6, 0, 0);
            TimeSpan dateTime3 = dateTime2 - dateTime1;
            ДоСтарата.Text = string.Format("{0} дней {1} часов и {2} минут, до старта марафона!", dateTime3.Days, dateTime3.Hours, dateTime3.Minutes);
        }

        private void EditRunner_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();
                {
                    string SqlExpCountry = "SELECT [CountryName] FROM [dbo].[Country]";
                    SqlCommand cmd = new SqlCommand(SqlExpCountry, Connection.connection);
                    SqlDataReader readerCountry = cmd.ExecuteReader();

                    if (readerCountry.HasRows)
                    {
                        while (readerCountry.Read())
                        {
                            comboBox_Country.Items.Add(readerCountry[0]);
                        }
                    }
                    readerCountry.Close();

                    string SqlExpGender = "SELECT [Gender] FROM [dbo].[Gender]";
                    SqlCommand cmd1 = new SqlCommand(SqlExpGender, Connection.connection);
                    SqlDataReader readerGender = cmd1.ExecuteReader();

                    if (readerGender.HasRows)
                    {
                        while (readerGender.Read())
                        {
                            comboBox_Gender.Items.Add(readerGender[0]);
                        }
                    }
                    readerGender.Close();

                    label_Email.Text = Connection.userLogin;
                    string SqlExpEmail = "SELECT [Email] FROM [dbo].[User]";
                    SqlCommand cmdEmail = new SqlCommand(SqlExpEmail, Connection.connection);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
            Connection.connection.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            MenuRunner menuRunner = new MenuRunner();
            menuRunner.Show();
            this.Close();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            MenuRunner menuRunner = new MenuRunner();
            menuRunner.Show();
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();

                if (textBox_LastName.Text != "" && textBox_Name.Text != "" && comboBox_Gender.Text != "" && comboBox_Country.Text != "")
                {
                    /*Возможно работает некорректно*/
                    if (DateTime.Now.Year - dateTimePicker_DateOfBirthday.Value.Year >= 10)
                    {
                        string sqlExpUser = "update [User] set [Firstname]=@firstname, [Lastname]=@lastname where [Email]=@email";
                        SqlCommand cmdUser = new SqlCommand(sqlExpUser, Connection.connection);

                        cmdUser.Parameters.AddWithValue("@email", Connection.userLogin);
                        cmdUser.Parameters.AddWithValue("@firstname", textBox_Name.Text);
                        cmdUser.Parameters.AddWithValue("@lastname", textBox_LastName.Text);

                        string SqlExpCountryCode = @"select [CountryCode] from [Country] where [CountryName]=@countryname";
                        SqlCommand cmdCountryCode = new SqlCommand(SqlExpCountryCode, Connection.connection);
                        cmdCountryCode.Parameters.AddWithValue("@countryname", comboBox_Country.Text);
                        string CountryCode = (string)cmdCountryCode.ExecuteScalar();

                        string sqlExpRunner = "update [Runner] set [Gender]=@gender, [DateOfBirth]=@DateOfBirth, [CountryCode]=@countrycode where [Email]=@email";
                        SqlCommand cmdRunner = new SqlCommand(sqlExpRunner, Connection.connection);

                        cmdRunner.Parameters.AddWithValue("@email", Connection.userLogin);
                        cmdRunner.Parameters.AddWithValue("@gender", comboBox_Gender.Text);
                        cmdRunner.Parameters.AddWithValue("@DateOfBirth", dateTimePicker_DateOfBirthday.Value);
                        cmdRunner.Parameters.AddWithValue("@countrycode", CountryCode);

                        if (textBox_Password.Text == "")
                        {
                            int i = cmdUser.ExecuteNonQuery();
                            if (i == 1)
                            {
                                int j = cmdRunner.ExecuteNonQuery();
                                if (j == 1)
                                {
                                    MessageBox.Show("Данные были изменены");
                                    Connection.connection.Close();
                                    MenuRunner MR = new MenuRunner();
                                    MR.Show();
                                    this.Close();
                                }
                            }
                        }
                        else if (textBox_Password.Text.Length >= 6 && textBox_Password.Text.Any(char.IsUpper) && textBox_Password.Text.Any(char.IsDigit) && textBox_Password.Text.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '^' }) > 0)
                        {
                            if (textBox_Password.Text == textBox_RepeatPassword.Text)
                            {
                                string sqlExpUserPassword = "update [User] set [Password]=@password where [Email]=@email";
                                SqlCommand cmdUserPassword = new SqlCommand(sqlExpUserPassword, Connection.connection);

                                cmdUserPassword.Parameters.AddWithValue("@email", Connection.userLogin);
                                cmdUserPassword.Parameters.AddWithValue("@password", textBox_Password.Text);

                                int i = cmdUser.ExecuteNonQuery();
                                if (i == 1)
                                {
                                    int k = cmdUserPassword.ExecuteNonQuery();
                                    if (k == 1)
                                    {
                                        int j = cmdRunner.ExecuteNonQuery();
                                        if (j == 1)
                                        {
                                            MessageBox.Show("Данные были изменены");
                                            Connection.connection.Close();
                                            MenuRunner MR = new MenuRunner();
                                            MR.Show();
                                            this.Close();
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пароли не совпадают");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пароль должен соответвтвовать следующим параметрам: \n" +
                                "• Минимум 6 символов \n" +
                                "• Минимум 1 прописная буква \n" +
                                "• Минимум 1 цифра \n" +
                                "• По крайней мере один из следующих символов: ! @ # $ % ^ \n");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Для того, чтобы зарегистрироваться, ваш возраст должен быть выше 10 лет");
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.connection.Close();
        }
    }
}
