using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Calendariotest2
{
    public partial class UserControlDays : UserControl
    {

        public static string static_days;
        String connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\dbcalendario.accdb";
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbldays.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_days = lbldays.Text;
            timer1.Start();
            eventform eventform = new eventform();
            eventform.Show();


        }
        private void displayevents()
        {
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            String sql = "SELECT * FROM tbl_calendario where datee=?";
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("datee", Form1.static_year+"-"+Form1.static_month+"-"+ lbldays.Text);
            OleDbDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                lblevent.Text = reader["event"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayevents();
        }
    }
}
