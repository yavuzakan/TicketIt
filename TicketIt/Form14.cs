using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketIt
{
    public partial class Form14 : Form
    {
        public static string sonuc = "Hata";
        public Form14()
        {
            InitializeComponent();
            textBox1.Text = Form13.sorun1;
            textBox2.Text = Form13.sorun12;
            textBox4.Text = Form13.id;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.SelectedIndex = 2;
            this.Icon = new Icon(Path.GetDirectoryName(Application.ExecutablePath) + "\\igdir.ico");
            this.Text = "Arıza Talep Takip";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cozum = textBox3.Text;
            string id = textBox4.Text;
            string degerlendirme = comboBox1.SelectedItem.ToString();

            data.arizaupdate22(id, degerlendirme);

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
