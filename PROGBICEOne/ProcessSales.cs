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
    public partial class ProcessSales : Form
    {

        public ProcessSales()
        {
            InitializeComponent();
            initSales();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void initSales()
        {
            try
            {
                var products = Inventory.Products;

                dvgProcess.Columns.Clear();
                dvgProcess.DataSource = null;

                dvgProcess.Columns.Add("Id", "Id");
                dvgProcess.Columns.Add("Name", "Name");
                dvgProcess.Columns.Add("Category", "Category");
                dvgProcess.Columns.Add("Price", "Price");
                dvgProcess.Columns.Add("Quantity", "Quantity");

                dvgProcess.Columns["Id"].Visible = false;

                DataGridViewButtonColumn approveButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "ProcessSale",
                    HeaderText = "Process Sale",
                    Text = "Process",
                    UseColumnTextForButtonValue = true
                };

                dvgProcess.Columns.Add(approveButtonColumn);

                foreach (var request in products)
                {
                    dvgProcess.Rows.Add(request.ProductID, request.Name, request.Category, request.Price, request.StockQuantity);
                }

                dvgProcess.CellClick += dgv_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var productId = (Guid)dvgProcess.Rows[e.RowIndex].Cells["Id"].Value;

                var product = Inventory.Products.FirstOrDefault(r => r.ProductID == productId);


                if (dvgProcess.Columns[e.ColumnIndex].Name == "ProcessSale")
                {
                    if (product == null) throw new Exception("Product not found.");

                    string message = Inventory.ProcessSale(product, 1);
                    MessageBox.Show(message);
                }

                initSales();
            }
        }

    }
}
