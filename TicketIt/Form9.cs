using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketIt
{
    public partial class Form9 : Form
    {
        public static string id = "";
        public static string sorun1 = "";
        public static string sorun12 = "";
        public Form9()
        {
            InitializeComponent();
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersVisible = false;
            ara();
            this.Icon = new Icon(Path.GetDirectoryName(Application.ExecutablePath) + "\\igdir.ico");
            this.Text = "Arıza Talep Takip";
        }
        public void ara()
        {
            string stm = "select id,tarih1,user, sorun , sorun2,oncelik,ip,comp  FROM sorun WHERE teknik LIKE '"+Form1.mail+ "' and tarih2 IS NULL";
            dataGridView1.Rows.Clear();
            var con = new SQLiteConnection(data.cs);
            SQLiteDataReader dr;
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString(), dr.GetValue(6).ToString(), dr.GetValue(7).ToString());
            }
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ara();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];


                id = dataGridViewRow.Cells["id1"].Value.ToString();
                sorun1 = dataGridViewRow.Cells["sorun"].Value.ToString();
                sorun12 = dataGridViewRow.Cells["sorun2"].Value.ToString();

                Form10 form10 = new Form10();
                form10.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ara();
        }
    }
}
