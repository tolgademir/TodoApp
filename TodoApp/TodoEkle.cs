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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TodoApp
{
    public partial class TodoEkle : Form
    {
        public TodoEkle()
        {
            InitializeComponent();
        }
        private void TodoEkle_Load(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Data Source=TolgaDemirVBM\\SQLEXPRESS;Initial Catalog=TodoAppDB;Integrated Security=True;");
        public void temizle() // Tüm textboxları temizler.
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        public void VeriListele() // SQL Veritabanındaki verileri dataGridView'da listeler.
        {
            string DatabaseConnection = "Data Source=TolgaDemirVBM\\SQLEXPRESS;Initial Catalog=TodoAppDB;Integrated Security=True;";

            string VeriListeleSorgu = "SELECT * FROM TodoAppDB";

            using (SqlConnection baglanti = new SqlConnection(DatabaseConnection))
            {
                try
                {
                    baglanti.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(VeriListeleSorgu, baglanti);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void btnTodoEkle_Click(object sender, EventArgs e)
        {
            string TodoDurumSecim = null;

            try
            {
                if (txtTodoAdi.Text == "" || richTextBoxTodoAciklamasi.Text == "")
                {
                    MessageBox.Show("Todo Adı veya Todo Açıklaması boş bırakılamaz.");
                    return;
                }

                baglanti.Open();
                SqlCommand VeriEkleSorgu = new SqlCommand("INSERT INTO TodoAppDB ([Todo Adı], [Todo Açıklaması], [Todo Durumu], [Todo Tarih], [Todo Kategori]) VALUES (@parametre1, @parametre2, @parametre3, @parametre4, @parametre5)", baglanti);
                VeriEkleSorgu.Parameters.AddWithValue("@parametre1", txtTodoAdi.Text.ToString());
                VeriEkleSorgu.Parameters.AddWithValue("@parametre2", richTextBoxTodoAciklamasi.Text.ToString());
                VeriEkleSorgu.Parameters.AddWithValue("@parametre4", dateTimeTodoTarih.Value.Date);

                // Todo durum seçimi

                if (radioButtonTamamlandı.Checked)
                {
                    TodoDurumSecim = radioButtonTamamlandı.Text;
                }
                else if (radioButtonDevamEdiyor.Checked)
                {
                    TodoDurumSecim = radioButtonDevamEdiyor.Text;
                }
                else if (radioButtonTamamlanmadı.Checked)
                {
                    TodoDurumSecim = radioButtonTamamlanmadı.Text;
                }

                if (TodoDurumSecim != null)
                {
                    VeriEkleSorgu.Parameters.AddWithValue("@parametre3", TodoDurumSecim);
                }
                else
                {
                    MessageBox.Show("Lütfen Todo Durumunu seçiniz.");
                }

                // Todo durum seçimi

                // Todo kategori seçimi

                if (string.IsNullOrWhiteSpace(comboBoxTodoKategori.Text))
                {
                    MessageBox.Show("Kategori alanı boş.");
                    temizle();
                }
                else if (comboBoxTodoKategori.SelectedIndex == -1)
                {
                    MessageBox.Show("Kategori seçilemedi.");
                    temizle();
                }
                else
                {
                    VeriEkleSorgu.Parameters.AddWithValue("@parametre5", comboBoxTodoKategori.Text);
                    MessageBox.Show("Kategori eklendi.");
                }

                // Todo kategori seçimi

                VeriEkleSorgu.ExecuteNonQuery();
                temizle();
                MessageBox.Show("Todo başarılı bir şekilde eklendi.");
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Todo eklenemedi, hata: " + ex.Message);
            }
        }
        private void btnTodoKategoriEkle_Click(object sender, EventArgs e)
        {
            string Kategori = txtKategoriEkle.Text.Trim();

            try
            {
                if (Kategori == "")
                {
                    MessageBox.Show("Kategori ekleme alanı boş bırakılamaz.");
                }

                else if (comboBoxTodoKategori.Items.Contains(Kategori))
                {
                    MessageBox.Show("Aynı isimle sadece 1 kere kategori ekleyebilirsiniz.");
                }

                else
                {
                    comboBoxTodoKategori.Items.Add(Kategori);
                    MessageBox.Show("Kategori ekleme alanına kategori başarıyla eklendi.");
                }

                txtKategoriEkle.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori ekleme alanına kategori eklenemedi, hata: " + ex.Message);
            }
        }
    }
}