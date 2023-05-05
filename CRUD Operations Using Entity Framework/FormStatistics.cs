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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }
        EFProductDBEntities db =new EFProductDBEntities();

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            LblTotalCategory.Text = db.Category.Count().ToString();
            LblTotalProduct.Text = db.Product.Count().ToString();
            LblActiveCustomer.Text = db.Customer.Count(x => x.State == true).ToString();
            LblPassiveCustomer.Text = db.Customer.Count(x => x.State == false).ToString();
            LblElectronicProduct.Text = db.Product.Count(x => x.CategoryId == 2002).ToString();
            LblTotalStock.Text = db.Product.Sum(x => x.Stock).ToString();
            LblMostExpensiveProduct.Text = (from x in db.Product orderby x.Price descending select x.ProductName).FirstOrDefault();
            LblCheapestProduct.Text = (from x in db.Product orderby x.Price ascending select x.ProductName).FirstOrDefault();
            LblCities.Text = (from x in db.Customer orderby x.City select x.City).Distinct().Count().ToString();
            LblTotalCashInBank.Text = db.Sales.Sum(x => x.Price).ToString();
            LblTheBrandWith.Text = db.GETBRAND().FirstOrDefault();
            LblTotalFridge.Text = db.Product.Count(x => x.ProductName=="Fridge").ToString();
        }
    }
}
