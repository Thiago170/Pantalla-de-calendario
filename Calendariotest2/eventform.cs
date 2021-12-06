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
    public partial class eventform : Form
    {
        String connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\dbcalendario.accdb";
        public eventform()
        {
            InitializeComponent();
        }

        private void eventform_Load(object sender, EventArgs e)
        {
            txtdate.Text = Form1.static_month+"/" + UserControlDays.static_days + "/" + Form1.static_year;  
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            String sql = "INSERT Into tbl_calendario(datee,event) values(?,?)";
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("datee",txtdate.Text);
            cmd.Parameters.AddWithValue("event", txtevent.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("guardado");
            cmd.Dispose();
            conn.Close();
        }
    }
}
