using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_AdoNet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = GetAllData("Select CategoryID,CategoryName from Categories");

            if (dt != null)
            {
                cmbKategori.ValueMember = "CategoryID";
                cmbKategori.DisplayMember = "CategoryName";
                cmbKategori.DataSource = dt;
            }
        }

        private DataTable GetAllData(string query)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
            SqlCommand sqlCommand = new SqlCommand(query, cn);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
                return null;
            }
        }

        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenID = lstListe.SelectedValue.ToString();
            string sorgu = $"Select ProductName,od.UnitPrice,od.Quantity,Discount from Products p inner join [Order Details] od on p.ProductID = od.ProductID where p.ProductID={secilenID}";

            DataTable dt = GetAllData(sorgu);

            if (dt!=null)
            {
                dgwListe.DataSource = dt;
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenID = cmbKategori.SelectedValue.ToString();
            string sorgu = $"Select ProductID,ProductName from Products where CategoryID={secilenID}";

            DataTable dt = GetAllData(sorgu);

            if (dt != null)
            {
                lstListe.DisplayMember = "ProductName";
                lstListe.ValueMember = "ProductID";
                lstListe.DataSource = dt;
            }
        }
    }
}
