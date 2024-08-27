using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGBICEOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddProductBTN_Click(object sender, EventArgs e)
        {
            var addProduct = new AddProduct();
            addProduct.Show();
            this.Hide();
        }

        private void UpdateProductBTN_Click(object sender, EventArgs e)
        {
            var updateProduct = new UpdateExistingProduct();
            updateProduct.Show();   
            this.Hide();
        }

        private void DisplayInventoryBTN_Click(object sender, EventArgs e)
        {
            var inventory = new DisplayInventoryReport();
            inventory.Show();   
            this.Hide();
        }

        private void ProcessSaleBTN_Click(object sender, EventArgs e)
        {
            var processSale = new ProcessSales();
            processSale.Show();
            this.Hide();
        }
    }
}
