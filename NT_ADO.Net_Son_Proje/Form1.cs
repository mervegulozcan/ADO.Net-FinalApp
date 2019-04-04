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
using System.Data;

namespace NT_ADO.Net_Son_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(Tools.Connectionstring);
        SqlCommand cmd;

        private void grpBoxGuncelle_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtEkleAd.Text != string.Empty || txtEkleFiyat.Text != string.Empty || txtEkleStok.Text != string.Empty)
            {
                cmd = new SqlCommand("insert into Products(ProductName,UnitPrice,UnitsInStock) values (@ad,@fiyat,@stok)", con);
                cmd.Parameters.AddWithValue("@ad", txtEkleAd.Text);
                cmd.Parameters.AddWithValue("@fiyat", txtEkleFiyat.Text);
                cmd.Parameters.AddWithValue("@stok", txtEkleStok.Text);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Ürünler listelensin mi?", "Kayıt işlemi başarılı", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        lstUrun.Items.Clear();
                        btnListele_Click(sender, e);
                    }

                }
                con.Close();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstUrun.Items.Clear();
            cmd = new SqlCommand("select ProductName,UnitPrice,UnitsInStock,ProductID from Products", con);
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem item = new ListViewItem(rdr["ProductName"].ToString());
                item.SubItems.Add(rdr["UnitPrice"].ToString());
                item.SubItems.Add(rdr["UnitsInStock"].ToString());
                item.SubItems.Add(rdr["ProductID"].ToString());

                lstUrun.Items.Add(item);
            }
            con.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGuncelleAd.Text != string.Empty || txtGuncelleFiyat.Text != string.Empty || txtGuncelleStok.Text != string.Empty)
                {
                    cmd = new SqlCommand("update Products set ProductName=@ad,UnitPrice=@fiyat,UnitsInStock=@stok where ProductID=@ID", con);
                    cmd.Parameters.AddWithValue("@ad", txtGuncelleAd.Text);
                    cmd.Parameters.AddWithValue("@fiyat", Convert.ToDouble(txtGuncelleFiyat.Text));
                    cmd.Parameters.AddWithValue("@stok", Convert.ToDouble(txtGuncelleStok.Text));
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(lblID.Text));

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("Ürünler listelensin mi?", "Güncelleme işlemi başarılı", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lstUrun.Items.Clear();
                            btnListele_Click(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "Güncelleme işlemi başarısız.");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAra.Text != string.Empty)
                {
                    lstUrun.Items.Clear();
                    cmd = new SqlCommand("select ProductName,UnitPrice,UnitsInStock from Products where ProductName like '%" + txtAra.Text + "%'", con);
                    //cmd.Parameters.AddWithValue("@ad", txtAra.Text.ToString());

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        ListViewItem item = new ListViewItem(rdr["ProductName"].ToString());
                        item.SubItems.Add(rdr["UnitPrice"].ToString());
                        item.SubItems.Add(rdr["UnitsInStock"].ToString());

                        lstUrun.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            con.Close();
        }

        private void lstUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrun.SelectedItems.Count > 0)
            {
                ListViewItem item = lstUrun.SelectedItems[0];
                txtGuncelleAd.Text = item.SubItems[0].Text;
                txtGuncelleFiyat.Text = item.SubItems[1].Text;
                txtGuncelleStok.Text = item.SubItems[2].Text;
                lblID.Text = item.SubItems[3].Text;

            }
            else
            {
                txtGuncelleAd.Text = string.Empty;
                txtGuncelleFiyat.Text = string.Empty;
                txtGuncelleStok.Text = string.Empty;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEkleAd.Text != string.Empty || txtEkleFiyat.Text != string.Empty || txtEkleStok.Text != string.Empty)
                {
                    cmd = new SqlCommand("delete from Products where ProductID=@ID", con);
                    cmd.Parameters.AddWithValue("@ID", lblID.Text);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Silme işlemi başarılı.");
                        txtGuncelleAd.Text = string.Empty;
                        txtGuncelleFiyat.Text = string.Empty;
                        txtGuncelleStok.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Silme işleminde hata oluştu.");
            }
            finally
            {
                
                con.Close();
            }

        }
    }
}
