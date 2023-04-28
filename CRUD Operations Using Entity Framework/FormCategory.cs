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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }
        EFProductDBEntities db= new EFProductDBEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            DgvCategories.DataSource = db.Category.ToList();
        }
        private void BtList_Click(object sender, EventArgs e)
        {
            DgvCategories.DataSource =db.Category.ToList();
        }

        private void BtInsert_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name=TbxCategoryName.Text;
            db.Category.Add(category);
            db.SaveChanges();
            DgvCategories.DataSource = db.Category.ToList();
            MessageBox.Show("Category Has Been Inserted","Category",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ClearCursors();
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var category = db.Category.Find(Convert.ToInt32(TbxCategoryId.Text));
                category.Name = TbxCategoryName.Text;
                db.SaveChanges();
                DgvCategories.DataSource = db.Category.ToList();
                MessageBox.Show("Category Has Been Updated", "Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearCursors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var category = db.Category.Find(Convert.ToInt32(TbxCategoryId.Text));
                db.Category.Remove(category);
                db.SaveChanges();
                DgvCategories.DataSource = db.Category.ToList();
                MessageBox.Show("Category Has Been Deleted", "Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearCursors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TbxCategoryId.Text = DgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
            TbxCategoryName.Text = DgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        public void ClearCursors()
        {
            TbxCategoryId.Text = "";
            TbxCategoryName.Text = "";
        }
    }
}
