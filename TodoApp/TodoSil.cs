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
    public partial class TodoSil : Form
    {
        public TodoSil()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=TolgaDemirVBM\\SQLEXPRESS;Initial Catalog=TodoAppDB;Integrated Security=True;");
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
        private void TodoSil_Load(object sender, EventArgs e)
        {
            VeriListele();
        }
        private void btnTodoSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["TodoID"].Value == null || string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["TodoID"].Value.ToString()))
            {
                MessageBox.Show("Seçilen kayıt boş olduğu için silme işlemi yapılamaz.");
                return;
            }

            try
            {
                baglanti.Open();
                string query = "DELETE FROM TodoAppDB WHERE [TodoID] = @TodoID"; SqlCommand todosil = new SqlCommand(query, baglanti);
                todosil.Parameters.AddWithValue("@TodoID", dataGridView1.CurrentRow.Cells["TodoID"].Value.ToString());
                todosil.ExecuteNonQuery();
                VeriListele();
                MessageBox.Show("Todo başarılı bir şekilde silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt silinemedi, hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();

                }
            }
        }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            VeriListele();
        }
    }
}
