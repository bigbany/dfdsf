using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            양식_설명 양식_설명 = new 양식_설명();
            양식_설명.Show();
            Era Era = new Era();
            Era.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Game_Form Game_Form = new Game_Form();
            Game_Form.Show();
        }
    }
}
