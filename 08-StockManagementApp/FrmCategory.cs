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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        DbStockEntities dbStockEntities = new DbStockEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            
            dgvCategories.DataSource = dbStockEntities.Categories.ToList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = tbxCategoryName.Text;

            dbStockEntities.Categories.Add(category);
            dbStockEntities.SaveChanges();

            btnList_Click(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(tbxCategoryID.Text);
            Category category = dbStockEntities.Categories.Find(categoryID);

            dbStockEntities.Categories.Remove(category);
            dbStockEntities.SaveChanges();

            btnList_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int categoryID = Convert.ToInt32(tbxCategoryID.Text);
            Category category = dbStockEntities.Categories.Find(categoryID);
            
            category.Name = tbxCategoryName.Text;
            dbStockEntities.SaveChanges();

            btnList_Click(sender, e);
        }
    }
}
