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
    public partial class ConfirmationOfReg : Form
    {
        public ConfirmationOfReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button_logout_Click(object sender, EventArgs e)
        {
            Connection.userLogin = "";
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.GetForm();
        }
    }
}
