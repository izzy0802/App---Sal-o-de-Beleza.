using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;


namespace Cadastro
{
    
    public partial class Perfil : Form
    {

        
        public Perfil(string nome, string senha, string cpf, string rg, string id)
        {
            InitializeComponent();

            textBox4.Text = nome;
            textBox1.Text = cpf;
            textBox2.Text = rg;
            textBox3.Text = senha;
            textBox5.Text = id;
            textBox5.Hide();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath forma = new GraphicsPath();          
            forma.AddEllipse(0, 0, button1.Width, button1.Height);
            button1.Region = new Region(forma);
            
        }
        private void Perfil_Load(object sender, EventArgs e)
        {

         
        }
       

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                textBox4.Text = "";

                textBox4.ForeColor = Color.FromArgb(41, 128, 185);
            }
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox2.Text = "";

                textBox2.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                textBox3.Text = "";

                textBox3.ForeColor = Color.FromArgb(41, 128, 185);
            }
        }
        string strconn = "server=127.0.0.1; port=3306; UID=root; pwd=1234; database=cadastro;";
        int id;
        private void button2_Click(object sender, EventArgs e)
        {
            
            try {
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("update clientes set nome='" + textBox4.Text + "', cpf='"+ textBox1.Text +"', rg='"+ textBox2.Text +"', senha='"+ textBox3.Text +"' where id='"+textBox5.Text+"'", conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Atualizados com sucesso!");

                conn.Close();
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn =  new MySqlConnection(strconn);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("delete from clientes where id = '" + textBox5.Text + "'", conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Conta excluida com sucesso!");

            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login= new Login();
            login.Show();
        }

       
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Agenda agenda = new Agenda();
            agenda.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            
            Compromissos compromissos = new Compromissos() ;
            compromissos.Show();
        }
    }
    }
