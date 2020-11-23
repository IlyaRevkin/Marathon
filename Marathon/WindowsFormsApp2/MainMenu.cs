using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ГлавноеМеню : Form
    {
        public ГлавноеМеню()
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
            ДатаСейчас.Text = string.Format("{0}",DateTime.Now.ToString("D"));
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Form login = new LoginMenu();
            login.Show();
        }

        private void BecomeARunner_Click(object sender, EventArgs e)
        {
            Form LoginOrNot = new LoginOrNot();
            LoginOrNot.Show();
        }
    }
}
