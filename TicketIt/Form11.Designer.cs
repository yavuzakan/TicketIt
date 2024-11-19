
namespace TicketIt
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kadro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katalog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorun2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncelik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teknik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cozum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degerlendirme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 61);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(168, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(90, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 31);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 31);
            this.textBox1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 621);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ad,
            this.kadro,
            this.statu,
            this.katalog,
            this.sorun,
            this.sorun2,
            this.depart,
            this.tarih1,
            this.oncelik,
            this.teknik,
            this.cozum,
            this.tarih2,
            this.degerlendirme});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1221, 621);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // ad
            // 
            this.ad.HeaderText = "Ad-Soyad";
            this.ad.Name = "ad";
            // 
            // kadro
            // 
            this.kadro.HeaderText = "Kadro";
            this.kadro.Name = "kadro";
            // 
            // statu
            // 
            this.statu.HeaderText = "Statü";
            this.statu.Name = "statu";
            // 
            // katalog
            // 
            this.katalog.HeaderText = "Talep Kataloğu";
            this.katalog.Name = "katalog";
            // 
            // sorun
            // 
            this.sorun.HeaderText = "Sorun";
            this.sorun.Name = "sorun";
            // 
            // sorun2
            // 
            this.sorun2.HeaderText = "Sorun Açıklama";
            this.sorun2.Name = "sorun2";
            // 
            // depart
            // 
            this.depart.HeaderText = "Departman";
            this.depart.Name = "depart";
            // 
            // tarih1
            // 
            this.tarih1.HeaderText = "Açılış Tarihi";
            this.tarih1.Name = "tarih1";
            // 
            // oncelik
            // 
            this.oncelik.HeaderText = "Öncelik";
            this.oncelik.Name = "oncelik";
            // 
            // teknik
            // 
            this.teknik.HeaderText = "Teknip Ekip";
            this.teknik.Name = "teknik";
            // 
            // cozum
            // 
            this.cozum.HeaderText = "Çözüm Açıklama";
            this.cozum.Name = "cozum";
            // 
            // tarih2
            // 
            this.tarih2.HeaderText = "Kapatma Tarihi";
            this.tarih2.Name = "tarih2";
            // 
            // degerlendirme
            // 
            this.degerlendirme.HeaderText = "Talep Değerlendirme";
            this.degerlendirme.Name = "degerlendirme";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1111, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(998, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Kopya";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form11";
            this.Text = "Form11";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadro;
        private System.Windows.Forms.DataGridViewTextBoxColumn statu;
        private System.Windows.Forms.DataGridViewTextBoxColumn katalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorun;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorun2;
        private System.Windows.Forms.DataGridViewTextBoxColumn depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncelik;
        private System.Windows.Forms.DataGridViewTextBoxColumn teknik;
        private System.Windows.Forms.DataGridViewTextBoxColumn cozum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih2;
        private System.Windows.Forms.DataGridViewTextBoxColumn degerlendirme;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}