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

namespace TeknolojiMagazasi
{
    public partial class Kampanya : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        public Kampanya()
        {
            InitializeComponent();
        }
        void KampanyaGetir()
        {
            conn = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI");
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM tbl_Kampanya", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewKampanya.DataSource = dt;
            conn.Close();
        }

        private void Kampanya_Load(object sender, EventArgs e)
        {
            KampanyaGetir();
            txtTarih1.Text = DateTime.Now.ToString();
        }

        private void dataGridViewKampanya_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewKampanya.Rows[e.RowIndex];
            txtKampanyaID.Text = dataGridViewKampanya.CurrentRow.Cells[0].Value.ToString();
            txtKampanyaAd.Text = dataGridViewKampanya.CurrentRow.Cells[1].Value.ToString();
            txtMinTutar.Text = dataGridViewKampanya.CurrentRow.Cells[2].Value.ToString();
            txtTarih1.Text = dataGridViewKampanya.CurrentRow.Cells[3].Value.ToString();
            txtTarih2.Text = dataGridViewKampanya.CurrentRow.Cells[4].Value.ToString();
            txtIndirimOran.Text = dataGridViewKampanya.CurrentRow.Cells[5].Value.ToString();
        }
        private void Temizle()
        {
            txtKampanyaID.Text = "";
            txtKampanyaAd.Text = "";
            txtMinTutar.Text = "";
            txtTarih1.Text = "";
            txtTarih2.Text = "";
            txtIndirimOran.Text = "";
        }

        private void btnKampanyaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = new SqlConnection("server=.; Initial Catalog=dbTeknolojiMagaza; Integrated Security=SSPI"))
                {
                    using (cmd = new SqlCommand("INSERT INTO tbl_Kampanya(KampyaAd,MinTutar,BitisTar,IndirimOran) VALUES (@KampyaAd,@MinTutar,@BitisTar,@IndirimOran)", conn))
                    {
                        cmd.Parameters.AddWithValue("@KampyaAd", txtKampanyaAd.Text);
                        cmd.Parameters.AddWithValue("@MinTutar", txtMinTutar.Text);
                        cmd.Parameters.AddWithValue("@BitisTar", txtTarih2.Text);
                        cmd.Parameters.AddWithValue("@IndirimOran", Convert.ToDecimal(txtIndirimOran.Text));


                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                KampanyaGetir();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnKampanyaSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM tbl_Kampanya WHERE KampanyaID=@KampanyaID";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@KampanyaID", Convert.ToInt32(txtKampanyaID.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            KampanyaGetir();
            Temizle();
        }

        private void txtTarih1_TextChanged(object sender, EventArgs e)
        {
            txtTarih1.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
    }
}
