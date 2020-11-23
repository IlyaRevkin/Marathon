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
    public partial class RegMarathon : Form
    {
        public RegMarathon()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 100;
            timer2.Enabled = true;
            timer2.Interval = 100;
        }
        private void RegMarathon_Load_1(object sender, EventArgs e)
        {
            try
            {
                //Connection.connection.Open();
                {
                    string SqlExp = "SELECT [CharityName] FROM [dbo].[Charity]";
                    SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader[0]);
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.connection.Close();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Connection.userLogin = "";
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.GetForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            DateTime dateTime2 = new DateTime(2020, 12, 24, 6, 0, 0);
            TimeSpan dateTime3 = dateTime2 - dateTime1;
            ДоСтарата.Text = string.Format("{0} дней {1} часов и {2} минут, до старта марафона!", dateTime3.Days, dateTime3.Hours, dateTime3.Minutes);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MenuRunner menuRunner = new MenuRunner();
            menuRunner.Show();
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            MenuRunner menuRunner = new MenuRunner();
            menuRunner.Show();
            this.Close();
        }

        private void button_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                {
                    MessageBox.Show("Выбирите хотя бы 1 вид марафона");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int sum = 0;
            if (checkBox1.Checked)
            {
                sum += 145;
            }
            if (checkBox2.Checked)
            {
                sum += 75;
            }
            if (checkBox3.Checked)
            {
                sum += 20;
            }
            if (radioButton1.Checked)
            {
                sum += 0;
            }
            if (radioButton2.Checked)
            {
                sum += 20;
            }
            if (radioButton3.Checked)
            {
                sum += 45;
            }
            label_Itog.Text = ("$ ") + sum.ToString();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.connection.Open();
                {
                    string sqlExp = "select [CharityDescription] from [Charity] where [CharityName]=@charity";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    cmd.Parameters.AddWithValue("@charity", comboBox1.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show((string)reader[0]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали организацию");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.connection.Close();
        }

        private void textBox_sumVznosa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 && num != 44)
            {
                e.Handled = true;
            }
        }
    }
}
