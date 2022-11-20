using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MiniMart.Models;

namespace MiniMart
{
    public partial class MainForm : MaterialForm
    {

        List<Product> products = new();
        Product selectedProduct = new();

        public MainForm()
        {
            InitializeComponent();

            init();

            //DataAccess db = new DataAccess();
            //var products = db.GetProducts();

        }

        private void init()
        {

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            // Populate Product Type Combo Box
            cbbProType.Items.AddRange(Product.Categories.ToArray());

            updateProcductDGV();

            // Binding to product form on first load
            dgvPro.CellClick += dgvPro_CellClick;
            dgvPro_CellClick(null, null);
            inpProName.DataBindings.Add("Text", products, "Name", false, DataSourceUpdateMode.Never);
            inpProSalePrice.DataBindings.Add("Text", products, "SalePrice");
        }

        private void dgvPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                Product p = dgvPro.Rows[e?.RowIndex ?? 0].DataBoundItem as Product;
                cbbProType.SelectedIndex = cbbProType.FindStringExact(p.Category.Trim());
                cbbProType.Refresh();
                selectedProduct = p;
            }
            catch (IndexOutOfRangeException) { }
            catch (ArgumentOutOfRangeException) { }
        }

        private void updateProcductDGV()
        {
            DataAccess db = new();
            products = db.GetProducts();

            dgvPro.DataSource = products;
        }

        // Product button click
        private void btnProAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new();
                db.InsertProduct(inpProName.Text, cbbProType.Text, float.Parse(inpProSalePrice.Text));
                updateProcductDGV();

                MessageBox.Show("Successfully added.", "Product record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to add a product.", "Product record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new();
                db.UpdateProduct(selectedProduct.ID, inpProName.Text, cbbProType.Text, float.Parse(inpProSalePrice.Text));
                updateProcductDGV();

                MessageBox.Show("Successfully updated.", "Product record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to update a product.", "Product record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new();
                db.DeleteProduct(selectedProduct.ID);
                updateProcductDGV();

                MessageBox.Show("Successfully deleted.", "Product record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to delete a product.", "Product record", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
