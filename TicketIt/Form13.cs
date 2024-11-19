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
    public partial class Form13 : Form
    {
        public static string id = "";
        public static string sorun1 = "";
        public static string sorun12 = "";

        public Form13()
        {
            InitializeComponent();

            this.Text = "Arıza Talep Takip";
            this.Icon = new Icon(Path.GetDirectoryName(Application.ExecutablePath) + "\\igdir.ico");
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersVisible = false;

            ara();
        }
        public void ara()
        {
            string stm = "select id, tarih1, sorun , sorun2  FROM sorun WHERE user LIKE '" + Form1.mail + "' AND cozum IS NOT NULL AND degerlendirme IS NULL";



            dataGridView1.Rows.Clear();
            var con = new SQLiteConnection(data.cs);
            SQLiteDataReader dr;
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString());
            }
            con.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ara();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];


                id = dataGridViewRow.Cells["id1"].Value.ToString();
                sorun1 = dataGridViewRow.Cells["sorun"].Value.ToString();
                sorun12 = dataGridViewRow.Cells["sorun2"].Value.ToString();

                Form14 form14 = new Form14();
                form14.Show();
            }
        }
    }
}
