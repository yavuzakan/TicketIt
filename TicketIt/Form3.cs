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
    public partial class Form3 : Form
    {
        public static string sonuc = "Hata";

        public Form3()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
            string sifre = textBox2.Text;
            string ad = textBox3.Text;
            string kimlikno = textBox4.Text;
            string kadro = textBox5.Text;
            string statu = textBox6.Text;
            string depart = textBox7.Text;

            if (mail.Length > 3 &&  sifre.Length > 3 )
            { 
            data.useradd(mail,sifre,ad,kimlikno,kadro,statu,depart);
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
                }
            }
            else
            {
                MessageBox.Show("Mail ve Şifre Boş geçilmez");
            }


         
        }
    }
}
