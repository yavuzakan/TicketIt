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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            //dataGridView1.ColumnHeadersVisible = false;
            comboBox1.Items.Add("%");
            comboBox2.Items.Add("%");
            teknik2();
            depart2();
            this.Icon = new Icon(Path.GetDirectoryName(Application.ExecutablePath) + "\\igdir.ico");
            this.Text = "Arıza Talep Takip";
        }

        public void ara()
        {
            string arateknik = comboBox1.SelectedItem.ToString();
            string aradepart = comboBox2.SelectedItem.ToString();
            string stm = "select * FROM sorun WHERE tarih2 IS NOT NULL and teknik LIKE '" + arateknik + "%'";
            dataGridView1.Rows.Clear();
            var con = new SQLiteConnection(data.cs);
            SQLiteDataReader dr;
            con.Open();
            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //dataGridView1.Rows.Insert(0, dr.GetValue(0).ToString(), dr.GetValue(12).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString());
                string aramail = dr.GetValue(12).ToString();
                string stm2 = "select * FROM user WHERE mail LIKE '" + aramail + "' and depart LIKE '"+ aradepart + "'";
                var con2 = new SQLiteConnection(data.cs);
                SQLiteDataReader dr2;
                con2.Open();
                var cmd2 = new SQLiteCommand(stm2, con2);
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    string ad = dr2.GetValue(3).ToString();
                    string kadro = dr2.GetValue(5).ToString();
                    string statu = dr2.GetValue(6).ToString();
                    string depart = dr2.GetValue(7).ToString();
                    dataGridView1.Rows.Insert(0, dr.GetValue(0).ToString(), ad, kadro, statu, depart, dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), depart, dr.GetValue(4).ToString(), dr.GetValue(5).ToString(), dr.GetValue(6).ToString(), dr.GetValue(7).ToString(), dr.GetValue(8).ToString(), dr.GetValue(10).ToString());
                }
            }
            con.Close();

        }
        public void teknik2()
        {
            string stm = "select mail  FROM user WHERE kadro LIKE 'IT' or kadro LIKE 'ADMIN' ";

            var con = new SQLiteConnection(data.cs);
            SQLiteDataReader dr;
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetValue(0));
            }
            con.Close();
            comboBox1.SelectedIndex = 0;

        }
        public void depart2()
        {
            string stm = "select DISTINCT depart  FROM user";

            var con = new SQLiteConnection(data.cs);
            SQLiteDataReader dr;
            con.Open();

            var cmd = new SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox2.Items.Add(dr.GetValue(0));
            }
            con.Close();
            comboBox2.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ara();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
    }
}
