using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TicketIt
{
    public partial class Form2 : Form
    {
        public static string sonuc = "Hata";
        public Form2()
        {
            InitializeComponent(); 
            comboBox1.SelectedIndex = 0;


            this.Icon = new Icon(Path.GetDirectoryName(Application.ExecutablePath) + "\\igdir.ico");
            this.Text = "Arıza Talep Takip";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ip = "";
            ip = ipadresi();
            string comp = "";
            comp = namehost();
            string name = "";
            name = nameuser();
            string ping = "";
            ping = updown();

            string text1 = "";
            string text2 = "";
            string combo1 = "";

            text1 = textBox1.Text;
            text2 = textBox2.Text;
            combo1 = comboBox1.SelectedItem.ToString();

            string katalog = combo1;
            string sorun = text1;
            string sorun2 = text2;
            string tarih1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") ;
            string oncelik = "-";
            string user = Form1.mail;
            data.arizaekle(katalog, sorun, sorun2, tarih1, oncelik, ip, comp, user);

            if (sonuc == "Hata")
            {
                MessageBox.Show("Sorun Var. Tekrar deneyin.");
            }
            else
            {
                MessageBox.Show("Kayıt Yapıldı.");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedIndex = 0;
                sonuc = "Hata";
            }


        }



        public static string ipadresi()
        {
            var host = System.Net.Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public static String namehost()
        {
           
            string name = "";
            name = Environment.MachineName.ToString();
            return name;
        }

        public static String nameuser()
        {
            string domain = "";
            domain = Environment.UserName.ToString();
            return domain;
        }

        public static string updown()
        {
            string updown = "";
            Ping ping = new Ping();
            PingReply cevap = ping.Send("www.google.com");
            if (cevap.Status == IPStatus.Success)
            {
                updown = "Success";
                return updown;
            }
            else
            {
                updown = "Fail";
                return updown;
            }

            return updown;
        }



    }
}
