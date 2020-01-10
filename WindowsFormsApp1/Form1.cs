using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView_Telefonok.ColumnCount = 4;
            dataGridView_Telefonok.Columns[0].Name = "id";
            dataGridView_Telefonok.Columns[1].Name = "marka";
            dataGridView_Telefonok.Columns[2].Name = "tipus";
            dataGridView_Telefonok.Columns[3].Name = "ar";
            dataGridView_Telefonok.Columns[1].HeaderText = "Márka";
            dataGridView_Telefonok.Columns[2].HeaderText = "Típus";
            dataGridView_Telefonok.Columns[3].HeaderText = "Ár";
            DataGridVieW_Telefonok_Update();
        }

        private void DataGridVieW_Telefonok_Update()
        {
            dataGridView_Telefonok.Rows.Clear();
            Program.sql.CommandText = "SELECT  `id`, `marka`, `tipus`, `ar` FROM telefon";
            try
            {
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int sor_index = dataGridView_Telefonok.Rows.Add();
                        dataGridView_Telefonok.Rows[sor_index].Cells["id"].Value = dr.GetInt32("id");
                        dataGridView_Telefonok.Rows[sor_index].Cells["Marka"].Value = dr.GetString("marka");
                        dataGridView_Telefonok.Rows[sor_index].Cells["Tipus"].Value = dr.GetString("tipus");
                        dataGridView_Telefonok.Rows[sor_index].Cells["ar"].Value = dr.GetInt32("ar");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void telefon_felvetel_Click(object sender, EventArgs e)
        {
            Program.sql.CommandText = "INSERT INTO `telefon` (`id`, `marka`, `tipus`, `ar`) VALUES (null, @marka, @tipus, @ar)";
            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@marka", tb_marka.Text);
            Program.sql.Parameters.AddWithValue("@tipus", tb_tipus.Text);
            Program.sql.Parameters.AddWithValue("@ar", nud_ar.Text);
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            DataGridVieW_Telefonok_Update();
        }
    }
}
