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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox1.Text = Form1.data1;
            textBox2.Text = Form1.data2;
            this.Icon = new Icon(Path.GetDirectoryName(Application.ExecutablePath) + "\\igdir.ico");
            this.Text = "Arıza Talep Takip";
        }
    }
}
