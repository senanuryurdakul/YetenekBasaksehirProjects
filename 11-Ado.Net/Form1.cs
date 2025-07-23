using Microsoft.Data.SqlClient;
using System.Data;

namespace _11_Ado.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void UrunleriGetir()
        {
            SqlConnection cn = null;
            try
            {
                lstListe.Items.Clear();
                //Ürünleri Getir
                cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Northwnd; Integrated Security=true; TrustServerCertificate=true");

                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Products", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int urunID = Convert.ToInt32(dr["ProductID"]);
                    string urunAdi = dr["ProductName"].ToString();
                    lstListe.Items.Add($"{urunID}-{urunAdi}");
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

        SqlConnection cn = null;
        string cnString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Northwnd; Integrated Security=true; TrustServerCertificate=true";

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(cnString);
                SqlCommand cmd = new SqlCommand("Select * from Categories", cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                lstListe.DisplayMember = "CategoryName";
                lstListe.ValueMember = "CategoryID";
                lstListe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(cnString);
                cn.Open();

                SqlCommand cmdEkle = new SqlCommand("Insert into Products (ProductName,UnitPrice,UnitsInStock,Discontinued) values (@name,@price,@stock,@disc)");
                cmdEkle.Connection = cn;

                cmdEkle.Parameters.AddWithValue("@name", "HP Laptop");
                cmdEkle.Parameters.AddWithValue("@price", 98560.44);
                cmdEkle.Parameters.AddWithValue("@stock", 400);
                cmdEkle.Parameters.AddWithValue("@disc", true);

                int etkilenenSatir = cmdEkle.ExecuteNonQuery();
                if (etkilenenSatir != 0)
                {
                    MessageBox.Show("Ekleme iþlemi baþarýlý.");
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(cnString);
                cn.Open();
                SqlCommand cmdSil = new SqlCommand("Delete from Products where ProductID=@id", cn);
                cmdSil.Parameters.AddWithValue("@id", 1079);

                int etkilenenSatir = cmdSil.ExecuteNonQuery();

                string mesaj = etkilenenSatir == 1 ? "Ýþlem Baþarýlý." : "Silme iþleminde bir hata oluþtu.";
                MessageBox.Show(mesaj);

                //if (etkilenenSatir==1)
                //{
                //    mesaj = "Ýþlem Baþarýlý";
                //}
                //else
                //{
                //    mesaj = "Bir Hata Oluþtu.";
                //}
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(cnString);
                cn.Open();
                SqlCommand cmdUpdate = new SqlCommand("Update Products set ProductName=@pname where ProductID=@id", cn);
                cmdUpdate.Parameters.AddWithValue("@pname", "Samsung HD TV");
                cmdUpdate.Parameters.AddWithValue("@id", 78);

                cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Ýslem Baþarýlý.");
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

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunAdi.TextLength >= 3)
            {
                string aramaKelimesi = txtUrunAdi.Text;

                AramaBaslat(aramaKelimesi);
            }
            else
            {
                UrunleriGetir();
            }
        }

        private void AramaBaslat(string aramaKelimesi)
        {
            //baðlan
            //doðru sorguyu oluþtur
            //datayý çek
            //listeyi doldur

            try
            {
                lstListe.Items.Clear();
                cn = new SqlConnection(cnString);
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Products where ProductName like @aramametin", cn);
                cmd.Parameters.AddWithValue("@aramametin", "%" + aramaKelimesi + "%");

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lstListe.Items.Add($"{dr["ProductID"]}-{dr["ProductName"]}");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
