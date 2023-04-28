using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Operations_Using_Entity_Framework
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        EFProductDBEntities db = new EFProductDBEntities();
        private void FormProduct_Load(object sender, EventArgs e)
        {
            DgvProducts.DataSource = db.Product.ToList();
            var categories = (from x in db.Category
                              select new
                              {
                                  x.Id,
                                  x.Name
                              }).ToList();
            CbxCategory.ValueMember = "Id";
            CbxCategory.DisplayMember = "Name";
            CbxCategory.DataSource = categories;
        }

        private void BtList_Click(object sender, EventArgs e)
        {
            DgvProducts.DataSource = db.Product.ToList();
            ClearCursors();
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            var product = db.Product.Find(Convert.ToInt32(TbxProductId.Text));
            if (product != null) 
            {
                db.Product.Remove(product); 
            }
            db.SaveChanges();
            DgvProducts.DataSource = db.Product.ToList();
            MessageBox.Show("Product Has Been Deleted", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearCursors();
        }

        private void BtInsert_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.ProductName = TbxProductName.Text;
            product.Brand = TbxBrand.Text;
            product.Stock = short.Parse(TbxStock.Text);
            product.Price = Decimal.Parse(TbxPrice.Text);
            product.State = true;
            product.CategoryId = int.Parse(CbxCategory.SelectedValue.ToString());
           
            db.Product.Add(product);
            db.SaveChanges();
            DgvProducts.DataSource = db.Product.ToList();
            MessageBox.Show("Product Has Been Inserted", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearCursors();
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            Product product = db.Product.Find(Convert.ToInt32(TbxProductId.Text));

            product.ProductName = TbxProductName.Text;
            product.Brand = TbxBrand.Text;
            product.Stock = short.Parse(TbxStock.Text);
            db.SaveChanges();

            DgvProducts.DataSource = db.Product.ToList();
            MessageBox.Show("Product Has Been Updated", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearCursors();
        }
        public void ClearCursors()
        {
            TbxProductId.Text = "";
            TbxProductName.Text = "";
            TbxBrand.Text = "";
            TbxStock.Text = "";
            TbxPrice.Text = "";
            TbxState.Text = "";
            CbxCategory.Text = "";
        }

        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TbxProductId.Text = DgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
            TbxProductName.Text = DgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            TbxBrand.Text = DgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
            TbxStock.Text = DgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
            TbxPrice.Text = DgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
            TbxState.Text = DgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
            CbxCategory.Text = (db.Category.Find(Convert.ToInt32(DgvProducts.Rows[e.RowIndex].Cells[6].Value)).Name).ToString();
        }
    }
}
