using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TodoApp
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
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

                    dataGridView1.DataSource = dataTable;
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            VeriListele();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TodoEkle TodoEkle = new TodoEkle();
            TodoEkle.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            VeriListele();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TodoSil TodoSil = new TodoSil();
            TodoSil.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TodoGuncelle TodoGuncelle = new TodoGuncelle();
            TodoGuncelle.ShowDialog();
        }
    }
}
