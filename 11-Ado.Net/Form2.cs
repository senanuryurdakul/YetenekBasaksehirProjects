using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace _11_Ado.Net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //kategorileri doldur

            DataTable dt = GetAllData("Select * from Categories");

            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.DataSource = dt;
        }

        private DataTable GetAllData(string sorgu)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
                SqlCommand cmd = new SqlCommand(sorgu, cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ürün listesi doldur
        }

        private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //siparis detaylarını doldur
        }
    }
}
