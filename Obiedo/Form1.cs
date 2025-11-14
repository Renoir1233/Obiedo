using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Obiedo
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(
              @"Server=(localdb)\MSSQLLocalDB; Database=DB_Inventory_Obiedo_IT13; Integrated Security=True;"
        );

        public Form1()
        {
            InitializeComponent();
            LoadRecords();
        }

        private void LoadRecords()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewProducts.DataSource = dt;
                con.Close();

                toolStripStatusLabel2.Text = "Total Records: " + dt.Rows.Count;
                toolStripStatusLabel3.Text = "Last Updated: " + DateTime.Now.ToLongTimeString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "" || txtPrice.Text == "" || txtQuantity.Text == "")
                {
                    MessageBox.Show("Fill required fields.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Products (ProductName, Category, Description, Price, Quantity, Supplier, DateAdded) " +
                    "VALUES (@name, @category, @desc, @price, @qty, @supplier, GETDATE())",
                    con
                );

                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@supplier", txtSupplier.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product Added.");
                ClearFields();
                LoadRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text == "")
                {
                    MessageBox.Show("Select a record first.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Products SET ProductName=@name, Category=@category, Description=@desc, " +
                    "Price=@price, Quantity=@qty, Supplier=@supplier WHERE ProductID=@id",
                    con
                );

                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@supplier", txtSupplier.Text);
                cmd.Parameters.AddWithValue("@id", txtProductID.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product Updated.");
                ClearFields();
                LoadRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text == "")
                {
                    MessageBox.Show("Select a record first.");
                    return;
                }

                if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID=@id", con);
                cmd.Parameters.AddWithValue("@id", txtProductID.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product Deleted.");
                ClearFields();
                LoadRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchNow();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            SearchNow();
        }

        private void SearchNow()
        {
            if (cmbSearchBy.Text == "")
            {
                MessageBox.Show("Choose search filter.");
                return;
            }

            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Products WHERE " + cmbSearchBy.Text + " LIKE @search",
                    con
                );

                da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewProducts.DataSource = dt;
                con.Close();

                toolStripStatusLabel2.Text = "Total Records: " + dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProductID.Text = dataGridViewProducts.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtProductName.Text = dataGridViewProducts.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                cmbCategory.Text = dataGridViewProducts.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                txtDescription.Text = dataGridViewProducts.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                txtPrice.Text = dataGridViewProducts.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                txtQuantity.Text = dataGridViewProducts.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                txtSupplier.Text = dataGridViewProducts.Rows[e.RowIndex].Cells["Supplier"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtSupplier.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
