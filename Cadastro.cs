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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        string strconn = "server=127.0.0.1; port=3306; UID=root; pwd=1234; database=cadastro;";

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if(textBox4.Text == "Full Name")
            {
                textBox4.Text = "";

                textBox4.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Full Name";

                textBox4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "CPF")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "CPF";

                textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "RG")
            {
                textBox2.Text = "";

                textBox2.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "RG";

                textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Senha")
            {
                textBox3.Text = "";

                textBox3.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Senha";

                textBox3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(checkBox1.Checked == true)
                {
                    MySqlConnection conn = new MySqlConnection(strconn);
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("insert into PerfilEmpressarial(nome, senha, cpf, rg) values (@nome,@senha,@cpf,@rg);", conn);
               
                   
                    cmd.Parameters.Add("@nome", MySqlDbType.String).Value = textBox4.Text;
                    cmd.Parameters.Add("@senha", MySqlDbType.String).Value = textBox3.Text;
                    cmd.Parameters.Add("@cpf", MySqlDbType.String).Value = textBox1.Text;
                    cmd.Parameters.Add("@rg", MySqlDbType.String).Value = textBox2.Text;
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    
                    string cpf = textBox1.Text;
                    Compromissos compromissos   =   new Compromissos();

                 

                }
                else
                {
                    MySqlConnection conn = new MySqlConnection(strconn);
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("insert into clientes(nome, senha, cpf, rg) values (@nome,@senha,@cpf,@rg);", conn);
                    cmd.Parameters.Add("@nome", MySqlDbType.String).Value = textBox4.Text;
                    cmd.Parameters.Add("@senha", MySqlDbType.String).Value = textBox3.Text;
                    cmd.Parameters.Add("@cpf", MySqlDbType.String).Value = textBox1.Text;
                    cmd.Parameters.Add("@rg", MySqlDbType.String).Value = textBox2.Text;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login= new Login();
            login.Show();
            
        }

       
    }
}
