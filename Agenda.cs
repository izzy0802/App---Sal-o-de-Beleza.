using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int month, year;
        private void Agenda_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private  void displayDays()
        {
            DateTime now  = DateTime.Now;
            month= now.Month;
            year= now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for(int i =1; i < dayoftheweek; i++)
            {
                UserControl1 userControl= new UserControl1();
                daycontainer.Controls.Add(userControl);
            }
            for (int i = 1; i<= days; i++)
            {
                UserControl2day ucdays = new UserControl2day();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month--;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 userControl = new UserControl1();
                daycontainer.Controls.Add(userControl);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2day ucdays = new UserControl2day();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month++;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label8.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) ;

            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControl1 userControl = new UserControl1();
                daycontainer.Controls.Add(userControl);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl2day ucdays = new UserControl2day();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
