using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            DateTime dateTime2 = new DateTime(2020, 12, 24, 6, 0, 0);
            TimeSpan dateTime3 = dateTime2 - dateTime1;
            ДоСтарата.Text = string.Format("{0} дней {1} часов и {2} минут, до старта марафона!", dateTime3.Days, dateTime3.Hours, dateTime3.Minutes);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();

                string sqlExp = "select [Email], [Password], [RoleId] from [dbo].[User] where [Email]=@login";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);
                cmd.Parameters.AddWithValue("@login", textBox_email.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    if ((string)reader[1] == textBox_password.Text)
                    {
                        Connection.userLogin = textBox_email.Text;

                        switch ((string)reader[2])
                        {
                            case "R":
                                MenuRunner mr = new MenuRunner();
                                mr.Show();
                                this.Close();
                                break;

                            case "C":
                                MenuCoordinator mc = new MenuCoordinator();
                                mc.Show();
                                this.Close();
                                break;

                            case "A":
                                MenuAdmin ma = new MenuAdmin();
                                ma.Show();
                                this.Close();
                                break;

                            default:
                                MessageBox.Show("Нет такой роли");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин");
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.connection.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenu MM = new MainMenu();
            MM.GetForm();
            this.Close();
        }
    }
}
