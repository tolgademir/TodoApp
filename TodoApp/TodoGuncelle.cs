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

namespace TodoApp
{
    public partial class TodoGuncelle : Form
    {
        public TodoGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=TolgaDemirVBM\\SQLEXPRESS;Initial Catalog=TodoAppDB;Integrated Security=True;");

        string DatabaseConnection = "Data Source=TolgaDemirVBM\\SQLEXPRESS;Initial Catalog=TodoAppDB;Integrated Security=True;";
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

                    dataGridView1.DataSource = dataTable;
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void TodoGuncelle_Load(object sender, EventArgs e)
        {
            VeriListele();
        }

        int i = 0;
        private void btnTodoGuncelle_Click(object sender, EventArgs e) // Veri güncelleme kısmı.
        {
            try
            {
                baglanti.Open();
                SqlCommand todoguncelle = new SqlCommand("UPDATE TodoAppDB SET [Todo Adı] = @parametre1, [Todo Açıklaması] = @parametre2, [Todo Tarih] = @parametre3, [Todo Kategori] = @parametre4, [Todo Durumu] = @parametre5", baglanti);
                todoguncelle.Parameters.AddWithValue("@parametre1", txtTodoAdi.Text);
                todoguncelle.Parameters.AddWithValue("@parametre3", dateTimePicker1.Value.Date);
                todoguncelle.Parameters.AddWithValue("@parametre4", txtTodoKategori.Text);
                todoguncelle.Parameters.AddWithValue("@parametre2", richTextBox1.Text);

                // Todo durum güncelleme işlemi başladı.

                string TodoDurumSecim = null;

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
                    todoguncelle.Parameters.AddWithValue("@parametre5", TodoDurumSecim);
                }
                else
                {
                    MessageBox.Show("Lütfen Todo Durumunu seçiniz.");
                }

                // Todo durum güncelleme işlemi bitti.

                todoguncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Todo başarılı bir şekilde güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Todo güncellenemedi, hata: " + ex.Message);
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) // SQL Veritabanındaki veriler DataGridView'de ilgili alanlarda listelenir.
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["TodoID"].Value == null || string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["TodoID"].Value.ToString()))
            {
                MessageBox.Show("Seçilen kayıt boş olduğu için güncelleme işlemi yapılamaz.");
                return;
            }

            i = e.RowIndex;
            txtTodoAdi.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
            txtTodoKategori.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

            string VeriGuncelleSorgu = "SELECT [Todo Durumu] FROM TodoAppDB";

            using (SqlConnection connection = new SqlConnection(DatabaseConnection))
            {
                SqlCommand cmd = new SqlCommand(VeriGuncelleSorgu, baglanti);

                try
                {
                    baglanti.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string radioButtonValue = reader["Todo Durumu"].ToString();

                        if (radioButtonValue == "Tamamlandı.")
                        {
                            radioButtonTamamlandı.Checked = true;
                        }
                        else if (radioButtonValue == "Devam Ediyor.")
                        {
                            radioButtonDevamEdiyor.Checked = true;
                        }
                        else if (radioButtonValue == "Tamamlanmadı.")
                        {
                            radioButtonTamamlanmadı.Checked = true;
                        }
                    }

                    reader.Close();
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            VeriListele();
        }
    }
}