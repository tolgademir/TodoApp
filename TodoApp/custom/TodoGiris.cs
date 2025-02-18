using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp.custom
{
    public partial class TodoGiris: Form
    {
        public TodoGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=TolgaDemirVBM\\SQLEXPRESS;Initial Catalog=TodoAppDB;Integrated Security=True;");
        public void temizle() // Tüm textboxları temizler.
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
        private void TodoGiris_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre alanı boş olamaz!");
                return;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre doğru, giriş yapılacak.");
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From TodoAppYonetici where KullaniciAdi=@p1 and KullaniciSifre=@p2", baglanti);
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    AnaSayfa anaSayfa = new AnaSayfa();
                    this.Hide();
                    anaSayfa.ShowDialog();
                    Application.Exit();

                }
                else
                {
                    MessageBox.Show("Giriş yapılamadı. Kullanıcı adı veya şifre hatalı.");
                }
                baglanti.Close();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş yapılırken hata alındı, hata: " + ex.Message);
                baglanti.Close();
                temizle();
            }
        }
    }
}
