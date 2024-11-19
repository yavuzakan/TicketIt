using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketIt
{
    class data
    {
        public static SQLiteConnection conn;
        public static SQLiteCommand cmd;
        public static SQLiteDataReader dr;


        public static string path = File.ReadAllText(@"data.txt", Encoding.UTF8);
        public static string cs = @"URI=file:" + path;

        public static string giris(String mail, String sifre)
        {
            string cevap = "0";

            var con = new SQLiteConnection(cs);
            con.Open();


            string stm = "select * FROM user where mail LIKE '" + mail + "' and sifre LIKE'" + sifre + "'";
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                Form1.userid = dr.GetValue(0).ToString();
                Form1.mail = dr.GetValue(1).ToString();
                Form1.sifre = dr.GetValue(2).ToString();
                Form1.kadro = dr.GetValue(5).ToString();
                Form1.ad = dr.GetValue(3).ToString();
                cevap = "1";
            }

            con.Close();

            return cevap;
        }

        public static void useradd(string mail, string sifre, string ad, string kimlikno, string kadro, string statu, string depart)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO user(mail,sifre,ad,kimlikno,kadro,statu,depart) VALUES(@mail,@sifre,@ad,@kimlikno,@kadro,@statu,@depart)";
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@kimlikno", kimlikno);
                cmd.Parameters.AddWithValue("@kadro", kadro);
                cmd.Parameters.AddWithValue("@statu", statu);
                cmd.Parameters.AddWithValue("@depart", depart);

                cmd.ExecuteNonQuery();
                con.Close();
                Form3.sonuc = "OLUMLU";
            }
            catch (Exception e)
            {
                //   MessageBox.Show(e.Message.ToString());
            }
        }

        public static void arizaekle(string katalog, string sorun, string sorun2, string tarih1, string oncelik, string ip, string comp, string user)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "INSERT INTO sorun(katalog,sorun,sorun2,tarih1,oncelik,ip,comp,user,durum,uyar) VALUES(@katalog,@sorun,@sorun2,@tarih1,@oncelik,@ip,@comp,@user,@durum,@uyar)";
                cmd.Parameters.AddWithValue("@katalog", katalog);
                cmd.Parameters.AddWithValue("@sorun", sorun);
                cmd.Parameters.AddWithValue("@sorun2", sorun2);
                cmd.Parameters.AddWithValue("@tarih1", tarih1);
                cmd.Parameters.AddWithValue("@oncelik", oncelik);
                cmd.Parameters.AddWithValue("@ip", ip);
                cmd.Parameters.AddWithValue("@comp", comp);
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@durum", "AÇIK");
                cmd.Parameters.AddWithValue("@uyar", "1");

                cmd.ExecuteNonQuery();
                con.Close();
                Form2.sonuc = "OLUMLU";
            }
            catch (Exception e)
            {
                //   MessageBox.Show(e.Message.ToString());
            }
        }








        public static void userupdate(string mail, string sifre, string ad, string kimlikno, string kadro, string statu, string depart,string id)
        {
            try
            {  
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                string sql = "UPDATE user set mail='" + mail + "' , sifre='"+sifre+ "', ad='" + ad + "' , kimlikno='" + kimlikno + "', kadro='" + kadro + "', statu='" + statu + "', depart='" + depart + "'   where id = " + id;
                cmd.CommandText = sql;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                con.Close();
                Form4.sonuc = "OLUMLU";
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }

        }

        public static void arizaupdate(string oncelik, string teknik , string id)
        {
            try
            {
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                string sql = "UPDATE sorun set oncelik='" + oncelik + "' , teknik='" + teknik + "', uyar='" + teknik + "' where id = " + id;
                cmd.CommandText = sql;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                con.Close();
                Form7.sonuc = "OLUMLU";
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }

        }

        public static void arizaupdate2(string cozum,  string id )
        {
            try
            {
                string tarih2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                string sql = "UPDATE sorun set cozum='" + cozum + "' , tarih2='" + tarih2 + "'    where id = " + id;
                cmd.CommandText = sql;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                con.Close();
                Form10.sonuc = "OLUMLU";
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }
        public static void arizaupdate22( string id, string degerlendirme)
        {
            try
            {
                string tarih2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                string sql = "UPDATE sorun set degerlendirme='" + degerlendirme + "'   where id = " + id;
                cmd.CommandText = sql;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                con.Close();
                Form14.sonuc = "OLUMLU";
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        public static void uyari(string id)
        {
            try
            {
                string asd = "0";
                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);
                string sql = "UPDATE sorun set uyar='" + asd + "'" ;
               
                cmd.CommandText = sql;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }





    }
}
