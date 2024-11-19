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
    public partial class Menu : Form
    {
       

        public Menu()
        {
            InitializeComponent();
            this.Text = "Arıza Talep Takip";
            this.Icon = new Icon(Path.GetDirectoryName(Application.ExecutablePath) + "\\igdir.ico");
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersVisible = false;
            mesaj();
            ara();
            this.Text = "Arıza Talep Takip";


            if (Form1.kadro == "ADMIN")
            {
              
            }
            else 
            {
                button2.Hide();
                button3.Hide();
                button4.Hide();
                button5.Hide();
                button6.Hide();
                button7.Hide();
                button8.Hide();
                
                if (Form1.kadro == "IT")
                {
                    button6.Show();
                  
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        public void mesaj()
        {

            string stm = "";

            if (Form1.kadro == "ADMIN")
            {
               stm = "select user, sorun , id FROM sorun WHERE uyar LIKE '1'";

            }
            if (Form1.kadro == "IT")
            {
               
                stm = "select user, sorun , id FROM sorun WHERE uyar LIKE '" + Form1.mail + "' and tarih2 IS NULL";
            }
            if (Form1.kadro == "IT" || Form1.kadro == "ADMIN")
            { 
            var con = new SQLiteConnection(data.cs);
            SQLiteDataReader dr;
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
                List<string> list = new List<string>();

                int i = 0;
                while (dr.Read())
                    { 

                            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                            notifyIcon1.BalloonTipTitle = dr.GetValue(0).ToString();
                            notifyIcon1.BalloonTipText = dr.GetValue(1).ToString();
                            notifyIcon1.ShowBalloonTip(1000);
                            list.Add(dr.GetValue(1).ToString());
                            i++;
                    }
               

                    con.Close();
  

                for (int j = 0; j < i; j++)
                {
               
                    data.uyari(list[j]);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
        public void ara()
        {
            string stm = "select tarih1, sorun , sorun2  FROM sorun WHERE user LIKE '" + Form1.mail + "' AND cozum IS NULL";
            // stm = "select tarih1, sorun , sorun2   FROM sorun WHERE teknik LIKE '"+Form1.mail+ "' and tarih2 IS NULL";
            if (Form1.kadro == "IT")
            {
                stm = "select tarih1, sorun , sorun2   FROM sorun WHERE teknik LIKE '" + Form1.mail + "' and tarih2 IS NULL";
            }



            dataGridView1.Rows.Clear();
            var con = new SQLiteConnection(data.cs);
            SQLiteDataReader dr;
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0, dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString());
            }
            con.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];

                Form1.data1 = dataGridViewRow.Cells["sorun"].Value.ToString();
                Form1.data2 = dataGridViewRow.Cells["sorun2"].Value.ToString();

                Form5 form5 = new Form5();
                form5.Show();


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ara(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           mesaj();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();

        }
    }
}
