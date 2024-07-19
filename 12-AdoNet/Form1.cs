using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _12_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        private void UrunleriListele()
        {
            lstListe.Items.Clear();

            SqlConnection cn = null;
            try
            {
                //SqlConnection sınıfından bir örnek (instance) alındı. 
                cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;";

                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Products", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string urunAdi = dr["ProductName"].ToString();
                    int id = Convert.ToInt32(dr["ProductID"]);
                    decimal fiyat = Convert.ToDecimal(dr["UnitPrice"]);

                    lstListe.Items.Add($"{id}.{urunAdi}-{fiyat}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);

                SqlCommand cmd = new SqlCommand("Select CategoryID,CategoryName,Description from Categories", cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                lstListe.DataSource = dt;
                lstListe.DisplayMember = "CategoryName";
                lstListe.ValueMember = "CategoryID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string conn = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(conn);

                cn.Open();
                SqlCommand cmdEkle = new SqlCommand("Insert into Products (ProductName,UnitPrice,Discontinued) values (@name,@price,@dsc)", cn);

                cmdEkle.Parameters.AddWithValue("@name", "Hp Laptop");
                cmdEkle.Parameters.AddWithValue("@price", 65000);
                cmdEkle.Parameters.AddWithValue("@dsc", true);

                //ExecuteNonQuery() geriye etkilenen satır sayısını döner.
                int sonuc = cmdEkle.ExecuteNonQuery();

                if (sonuc > 0)
                {
                    MessageBox.Show("Ekleme işlemi başarılı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(conn);
                cn.Open();
                SqlCommand cmdDelete = new SqlCommand("Delete from Products where ProductID=@id", cn);
                cmdDelete.Parameters.AddWithValue("@id", txtUrunID.Text);

                int etkilenenSatir = cmdDelete.ExecuteNonQuery();

                string mesaj = etkilenenSatir == 1 ? "İşlem başarılı." : "Silme işleminde bir hata oluştu.";

                MessageBox.Show(mesaj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(conn);
                cn.Open();

                SqlCommand cmdUpdate = new SqlCommand("Update Products set ProductName=@name where ProductID=@id", cn);
                cmdUpdate.Parameters.AddWithValue("@name", txtUrunAdi.Text);
                cmdUpdate.Parameters.AddWithValue("@id", txtUrunID.Text);

                int islem = cmdUpdate.ExecuteNonQuery();

                if (islem != 0)
                {
                    MessageBox.Show("Güncelleme Başarılı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.TextLength >= 3)
            {
                string aramaKelimesi = txtSearch.Text;
                AramaBaslat(aramaKelimesi);

            }
            else if (txtSearch.TextLength==0)
            {
                UrunleriListele();
            }
        }

        private void AramaBaslat(string aramaKelimesi)
        {
            lstListe.Items.Clear();

            SqlConnection cn = null;
            try
            {
                cn = new SqlConnection(conn);
                cn.Open();

                //SqlCommand cmd = new SqlCommand("Select * from Products where ProductName like '%" + aramaKelimesi+"%'",cn);

                SqlCommand cmd = new SqlCommand($"Select * from Products where ProductName like '%{aramaKelimesi}%'", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lstListe.Items.Add($"{dr["ProductID"]}.{dr["ProductName"]}-{dr["UnitPrice"]}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
        }
    }
}
