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
    public partial class Form7 : Form
    {
        public static string sonuc = "Hata";
        public Form7()
        {
            InitializeComponent();
            textBox1.Text = Form6.sorun1;
            textBox2.Text = Form6.sorun12;
            textBox3.Text = Form6.id;
            comboBox2.SelectedIndex = 0;
            ara();
            this.Icon = new Icon(Path.GetDirectoryName(Application.ExecutablePath) + "\\igdir.ico");
            this.Text = "Arıza Talep Takip";
        }

        public void ara()
        {
            string stm = "select mail  FROM user WHERE kadro LIKE 'IT' or kadro LIKE 'ADMIN' " ;
          
            var con = new SQLiteConnection(data.cs);
            SQLiteDataReader dr;
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox3.Items.Add(dr.GetValue(0));
            }
            con.Close();
            comboBox3.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text;
            string oncelik = comboBox2.SelectedItem.ToString();
            string teknik = comboBox3.SelectedItem.ToString();
            data.arizaupdate(oncelik, teknik, id);

            if (sonuc == "Hata")
            {
                MessageBox.Show("Sorun Var. Tekrar deneyin.");
            }
            else
            {
                MessageBox.Show("Kayıt Yapıldı.");
                this.Close();
            }

        }
    }
}
