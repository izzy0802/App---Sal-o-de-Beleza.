using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class UserControl2day : UserControl
    {
        public UserControl2day()
        {
            InitializeComponent();
        }


        private void UserControl2day_Load(object sender, EventArgs e)
        {

        }

        public void days(int mumday)
        {
            label1.Text = mumday + "";
        }
    }
}
