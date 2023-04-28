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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCategory form1 = new FormCategory();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.Show();
        }
    }
}
