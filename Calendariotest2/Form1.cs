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

namespace Calendariotest2
{
    public partial class Form1 : Form
    {
        int month, year;    

        public static int static_month, static_year;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displadays();
        }
        private void displadays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBLDATE.Text = monthname+ ""+ year;

            static_month = month;
            static_year = year;
            //primer dia del mes

            DateTime startofthemonth = new DateTime(year, month,1);
            //tener la cuenta de los dias del mes
            int days = DateTime.DaysInMonth(year,month);
            // convertir el inicio del mes en int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) +1;
            for (int i=1;i<dayoftheweek;i++ )
            {
                UserControlBlanks ucblank = new UserControlBlanks();
                daycontainer.Controls.Add(ucblank);
            }
            for(int i=1;i<= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBLDATE.Text = monthname + "" + year;
            DateTime now = DateTime.Now;
            //primer dia del mes
            DateTime startofthemonth = new DateTime(year, month, 1);
            //tener la cuenta de los dias del mes
            int days = DateTime.DaysInMonth(year, month);
            // convertir el inicio del mes en int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlanks ucblank = new UserControlBlanks();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();
           month++;
            static_month = month;
            static_year = year;
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBLDATE.Text = monthname + "" + year;
            DateTime now = DateTime.Now;
            //primer dia del mes
            DateTime startofthemonth = new DateTime(year, month, 1);
            //tener la cuenta de los dias del mes
            int days = DateTime.DaysInMonth(year, month);
            // convertir el inicio del mes en int
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlanks ucblank = new UserControlBlanks();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
