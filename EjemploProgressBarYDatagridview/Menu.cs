using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploProgressBarYDatagridview
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpcionDatagridView opcionDatagridView = new OpcionDatagridView();
            opcionDatagridView.Show();
            this.Hide();
        }

        private void btnusogroupbox_Click(object sender, EventArgs e)
        {
            OpcionGroupBox opcionGroupBox = new OpcionGroupBox();
            opcionGroupBox.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
