using System;
using System.CodeDom;
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
    public partial class DisplayInventoryReport : Form
    {
        public DisplayInventoryReport()
        {
            InitializeComponent();
        }

        private void DisplayBTN_Click(object sender, EventArgs e)
        {
            try
            {
               var report = Inventory.GenerateInventorySummary();

                ReportTB.Text = report;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
    }
}
