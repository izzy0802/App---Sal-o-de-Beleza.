using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml;

namespace Cadastro
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
            axWindowsMediaPlayer1.URL = @"C:\Users\ISIS\Downloads\B.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();

            
        }
        int progress = 0;


        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                progress++;
                progressBar1.Value = progress;

                if (progress == 15)
                {
                    panel4.Hide();
                }

                if (progress == 100)
                {
                    this.Hide();
                    timer2.Enabled = false;
                    Login login = new Login();
                    login.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
