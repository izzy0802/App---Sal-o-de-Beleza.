using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Cadastro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        string strconn = "server=127.0.0.1; port=3306; UID=root; pwd=1234; database=cadastro;";


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.White;
            panel3.BackColor = System.Drawing.Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor= Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Splash splash = new Splash();
                splash.Show();
 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();


                MySqlCommand cmd = new MySqlCommand("select * from clientes  where nome = '" + textBox1.Text+"'", conn);
                MySqlDataReader reader = cmd.ExecuteReader();

         
                while (reader.Read())
                {
                    if (textBox1.Text == reader.GetString("nome"))
                    {
                        if (textBox2.Text == reader.GetString("senha"))
                        {
                            string nome = reader.GetString("nome");
                            string senha = reader.GetString("senha");
                            string cpf = reader.GetString("cpf");
                            string rg = reader.GetString("rg");
                            string id = reader.GetString("id");
                            MessageBox.Show("Bem-Víndo "+nome+".");
                            this.Hide();
                            Perfil perfil= new Perfil(nome, senha, cpf, rg, id);
                            perfil.Show();
                            
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta");
                        }
                    }
                }
                


                conn.Close();

            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

       
    }
}
