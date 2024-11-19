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
    public partial class Form4 : Form
    {
        public static string sonuc = "Hata";
        public Form4()
        {
            InitializeComponent();
            label1.Text = "Mail*";
            label2.Text = "Sifre";
            label3.Text = "Ad Soyad";
            label4.Text = "Kimlik No";
            label5.Text = "Kadro";
            label6.Text = "Statü";
            label7.Text = "Departman";
            this.Icon = new Icon(Path.GetDirectoryName(Application.ExecutablePath) + "\\igdir.ico");
            this.Text = "Arıza Talep Takip";
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersVisible = false;

            textBox9.Visible = false;
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mail=textBox2.Text; 
            string sifre = textBox3.Text;
            string ad = textBox4.Text;
            string kimlikno = textBox5.Text; 
            string kadro = textBox6.Text; 
            string statu = textBox7.Text; 
            string depart = textBox8.Text; 
            string id = textBox9.Text;

            data.userupdate(mail, sifre, ad, kimlikno, kadro, statu, depart, id);
            if (sonuc == "Hata")
            {
                MessageBox.Show("Sorun Var. Tekrar deneyin.");
            }
            else
            {
                MessageBox.Show("Kayıt Yapıldı.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                sonuc = "Hata";
                ara();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ara();
        }
        public void ara()
        {
            string stm = "select * FROM user WHERE Ad LIKE '%" + textBox1.Text + "%'";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
   
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[e.RowIndex];

                    textBox9.Text = dataGridViewRow.Cells["id"].Value.ToString();

                textBox2.Text = dataGridViewRow.Cells["mail"].Value.ToString();
                textBox3.Text = dataGridViewRow.Cells["sifre"].Value.ToString();
                textBox4.Text = dataGridViewRow.Cells["ad"].Value.ToString();
                textBox5.Text = dataGridViewRow.Cells["kimlikno"].Value.ToString();
                textBox6.Text = dataGridViewRow.Cells["kadro"].Value.ToString();
                textBox7.Text = dataGridViewRow.Cells["statu"].Value.ToString();
                textBox8.Text = dataGridViewRow.Cells["departman"].Value.ToString();
                

            }

        }
    }
}
