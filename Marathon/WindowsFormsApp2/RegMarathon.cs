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
        List<string> RaceKitOptionId = new List<string>();
        List<string> EventType = new List<string>();
        decimal[] cost_options = new decimal[3];
        decimal[] cost_marathone = new decimal[3];
        private void Rb_KitOptions()
        {
            try
            {
                Connection.connection.Open();
                string sqlExp = "select * from [dbo].[RaceKitOption]";

                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader rd = cmd.ExecuteReader();
                int i = 0;
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        RaceKitOptionId.Add(string.Format($"{(string)rd[0]} ({(decimal)rd[2]:f2}) : {(string)rd[1]}"));
                        cost_options[i] = (decimal)rd[2];
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Нет данных");
                }
                rd.Close();

                Connection.connection.Close();
                radioButton1.Text = "Вариант " + RaceKitOptionId[0];
                radioButton2.Text = "Вариант " + RaceKitOptionId[1];
                radioButton3.Text = "Вариант " + RaceKitOptionId[2];
            }
            catch(SqlException Exp)
            {
                MessageBox.Show(Exp.Message);
            }
        }

        private void Event_Marathon()
        {
            try
            {
                Connection.connection.Open();
                string sqlExp = "select [Cost], [EventName] from [dbo].[Event] e inner join [dbo].[Marathon] m on e.[MarathonId] =m.[MarathonId] where m.YearHeld=YEAR(GETDATE())";

                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                SqlDataReader rd = cmd.ExecuteReader();
                int i = 0;
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        EventType.Add(string.Format($"{(string)rd[1]} ({(decimal)rd[0]:f2})"));
                        cost_marathone[i] = (decimal)rd[0];
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Нет данных");
                }
                rd.Close();

                Connection.connection.Close();
                checkBox1.Text = EventType[0];
                checkBox2.Text = EventType[1];
                checkBox3.Text = EventType[2];
            }
            catch (SqlException Exp)
            {
                MessageBox.Show(Exp.Message);
            }
        }

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
            Rb_KitOptions();
            Event_Marathon();
            try
            {
                Connection.connection.Open();
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
                    label8.Text = Connection.userLogin;
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
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Вы не выбрали организацию для пожертвования");
                    if (textBox_sumVznosa.Text == "")
                    {
                        MessageBox.Show("Вы не ввели сумму пожертвования");
                    }
                }
                if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                {
                    MessageBox.Show("Выбирите хотя бы 1 вид марафона");
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    MessageBox.Show("Выбирите комплект");
                }
                else
                {
                    Connection.connection.Open();
                    {
                        string SqlExpRunnerId = "select [RunnerId] from [Runner] where [Email]=@email";
                        SqlCommand cmdRunnerId = new SqlCommand(SqlExpRunnerId, Connection.connection);
                        cmdRunnerId.Parameters.AddWithValue("@email", Connection.userLogin);
                        /**/int runnerid = (int)cmdRunnerId.ExecuteScalar();

                        string SqlExpCharity = "select [CharityId] from [dbo].[Charity] where [CharityName]=@charityname";
                        SqlCommand cmdCharity = new SqlCommand(SqlExpCharity, Connection.connection);
                        cmdCharity.Parameters.AddWithValue("@charityname", comboBox1.Text);
                        int charityid = (int)cmdCharity.ExecuteScalar();

                        string SqlExp = "insert into [dbo].[Registration] ([RunnerId], [RegistrationDateTimer], [RaceKitOptionId], [RegistrationStatusId], [Cost], [CharityId], [SponsorshipTarget]) " +
                            "VALUES (@runnerid, getdate(), @rkoid, '1', @cost, @charityid, @sponsorship)";
                        SqlCommand cmd = new SqlCommand(SqlExp, Connection.connection);

                        char rkoid='0';
                        if (radioButton1.Checked)
                        {
                            rkoid = RaceKitOptionId[0].ToCharArray()[0];
                        }
                        if (radioButton2.Checked)
                        {
                            rkoid = RaceKitOptionId[1].ToCharArray()[0];
                        }
                        if (radioButton3.Checked)
                        {
                            rkoid = RaceKitOptionId[2].ToCharArray()[0];
                        }

                        decimal sum = 0;
                        if (checkBox1.Checked)
                        {
                            sum = EventType[0].ToString()[0];
                        }
                        if (checkBox2.Checked)
                        {
                            sum = EventType[1].ToString()[0];
                        }
                        if (checkBox3.Checked)
                        {
                            sum = EventType[2].ToString()[0];
                        }

                        cmd.Parameters.AddWithValue("@runnerid", runnerid);
                        cmd.Parameters.AddWithValue("@rkoid", rkoid);
                        cmd.Parameters.AddWithValue("@cost", sum);
                        cmd.Parameters.AddWithValue("@charityid", charityid);
                        cmd.Parameters.AddWithValue("@sponsorship", textBox_sumVznosa.Text);

                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("Данные были внесены");
                            Connection.connection.Close();
                            MenuRunner MR = new MenuRunner();
                            MR.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Connection.connection.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            decimal sum = 0;
            if (checkBox1.Checked)
            {
                sum += cost_marathone[0];
            }
            if (checkBox2.Checked)
            {
                sum += cost_marathone[1];
            }
            if (checkBox3.Checked)
            {
                sum += cost_marathone[2];
            }
            if (radioButton1.Checked)
            {
                sum += cost_options[0];
            }
            if (radioButton2.Checked)
            {
                sum += cost_options[1];
            }
            if (radioButton3.Checked)
            {
                sum += cost_options[2];
            }
            label_Itog.Text = sum.ToString();
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
