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
    public partial class Form10 : Form
    {
        public static string sonuc = "Hata";
        public Form10()
        {
            InitializeComponent();
            textBox1.Text = Form9.sorun1;
            textBox2.Text = Form9.sorun12;
            textBox4.Text = Form9.id;
            
            this.Icon = new Icon(Path.GetDirectoryName(Application.ExecutablePath) + "\\igdir.ico");
            this.Text = "Arıza Talep Takip";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cozum = textBox3.Text;
            string id = textBox4.Text;
            

            data.arizaupdate2( cozum,  id);

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
