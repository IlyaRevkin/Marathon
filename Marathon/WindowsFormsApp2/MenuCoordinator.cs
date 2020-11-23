using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MenuCoordinator : Form
    {
        public MenuCoordinator()
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

        private void LogOut_Click(object sender, EventArgs e)
        {
            Connection.userLogin = "";
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.GetForm();
        }
    }
}
