using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_StockManagementApp
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        DbStockEntities dbStockEntities = new DbStockEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = (from c in dbStockEntities.Products
                                      select new
                                      {
                                          c.ID,
                                          c.Name,
                                          c.Brand,
                                          c.Price,
                                          c.Category,
                                          c.Status
                                      }).ToList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = tbxName.Text;
            product.Brand = tbxBrand.Text;
            product.Quantity = Convert.ToInt16(tbxQuantity.Text);
            product.Price = Convert.ToDecimal(nupPrice.Value);
            product.Status = Convert.ToBoolean(tbxStatus.Text);
            product.CategoryID = cmbCategory.SelectedIndex;

            dbStockEntities.Products.Add(product);
            dbStockEntities.SaveChanges();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);
            Product product = dbStockEntities.Products.Find(id);

            dbStockEntities.Products.Remove(product);
            dbStockEntities.SaveChanges();

            btnList_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxID.Text);
            Product product = dbStockEntities.Products.Find(id);

            product.Name = tbxName.Text;
            product.Brand = tbxBrand.Text;
            product.Quantity = Convert.ToInt16(tbxQuantity.Text);
            product.Price = Convert.ToDecimal(nupPrice.Value);
            product.Status = Convert.ToBoolean(tbxStatus.Text);
            product.CategoryID = cmbCategory.SelectedIndex;

            dbStockEntities.SaveChanges();

            btnList_Click(sender, e);
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var categories = (from c in dbStockEntities.Categories
                              select new
                              {
                                  c.ID,
                                  c.Name
                              }).ToList();

            cmbCategory.ValueMember = "ID";
            cmbCategory.DisplayMember = "Name";
            cmbCategory.DataSource = categories;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
