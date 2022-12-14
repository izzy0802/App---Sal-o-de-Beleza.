using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro
{
    public partial class Compromissos : Form
    {
        string strconn = "server=127.0.0.1; port=3306; UID=root; pwd=1234; database=cadastro;";
        public Compromissos()
        {
            InitializeComponent();
            
                

                UserCompromisso compromisso= new UserCompromisso();
                flowLayoutPanel1.Controls.Add(compromisso);
               

                
            }
        }


        
    
}
