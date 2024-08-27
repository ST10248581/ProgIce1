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
    public partial class UpdateExistingProduct : Form
    {


        public UpdateExistingProduct()
        {
            InitializeComponent();
            initComboBox();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            try
            {


                switch (ProductTypeCB.SelectedItem)
                {
                    case "Electronics":
                        ElectronicProduct electronicProduct = (ElectronicProduct) Inventory.Products.FirstOrDefault(p => p.Name == productCB.SelectedItem.ToString());

                        electronicProduct.Name = String.IsNullOrEmpty(NameTB.Text) ? "Product" : NameTB.Text;
                        electronicProduct.Category = "Electronics";
                        electronicProduct.Price = decimal.Parse(PriceTB.Text);
                        electronicProduct.StockQuantity = int.Parse(QuantityTB.Text);
                        electronicProduct.WarrantyPeriod = int.Parse(WarentyTB.Text);
 
                        MessageBox.Show("Product Added Successfully");
                        break;

                    case "Grocery":


                        var groceryProduct = (GroceryProduct)Inventory.Products.FirstOrDefault(p => p.Name == productCB.SelectedItem.ToString());

                        groceryProduct.Name = String.IsNullOrEmpty(NameTB.Text) ? "Product" : NameTB.Text;
                        groceryProduct.Category = "Grocery";
                        groceryProduct.Price = decimal.Parse(PriceTB.Text);
                        groceryProduct.StockQuantity = int.Parse(QuantityTB.Text);
                        groceryProduct.ExpirationDate = ExpirationDateTimePicker.Value;

                        MessageBox.Show("Product Added Successfully");
                        break;

                    case "Clothing":

                        var clothingProduct = (ClothingProduct) Inventory.Products.FirstOrDefault(p => p.Name == productCB.SelectedItem.ToString());

                        clothingProduct.Name = String.IsNullOrEmpty(NameTB.Text) ? "Product" : NameTB.Text;
                        clothingProduct.Category = "Clothing";
                        clothingProduct.Price = decimal.Parse(PriceTB.Text);
                        clothingProduct.StockQuantity = int.Parse(QuantityTB.Text);
                        clothingProduct.Material = ClothingMaterialTB.Text;
                        clothingProduct.Size = ClothingSizeCB.SelectedItem.ToString();

                        MessageBox.Show("Product Added Successfully");
                        break;

                    default:
                        var deafualtProduct = Inventory.Products.FirstOrDefault(p => p.Name == productCB.SelectedItem.ToString());

                        deafualtProduct.Name = String.IsNullOrEmpty(NameTB.Text) ? "Product" : NameTB.Text;
                        deafualtProduct.Category = "Default";
                        deafualtProduct.Price = decimal.Parse(PriceTB.Text);
                        deafualtProduct.StockQuantity = int.Parse(QuantityTB.Text);

                        MessageBox.Show("Product Added Successfully");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                NameTB.Clear();
                PriceTB.Clear();
                QuantityTB.Clear();
                WarentyTB.Clear();
                ClothingMaterialTB.Clear();
            }
        }

        private void productCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void initComboBox()
        {
            try
            {
                var iventoryProducts = Inventory.Products;

                foreach (var inventoryProduct in iventoryProducts)
                {
                    productCB.Items.Add(inventoryProduct.Name);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void ProductTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ElectronicWarentyPeriodLabel.Hide();
            WarentyTB.Hide();
            ExpirationDateLabel.Hide();
            ExpirationDateTimePicker.Hide();
            ClothingSizeLabel.Hide();
            ClothingSizeCB.Hide();
            ClothingMaterialLabel.Hide();
            ClothingMaterialTB.Hide();

            switch (ProductTypeCB.SelectedItem)
            {
                case "Electronics":
                    ElectronicWarentyPeriodLabel.Show();
                    WarentyTB.Show();
                    break;
                case "Grocery":
                    ExpirationDateLabel.Show();
                    ExpirationDateTimePicker.Show();
                    break;
                case "Clothing":
                    ClothingSizeLabel.Show();
                    ClothingSizeCB.Show();
                    ClothingMaterialLabel.Show();
                    ClothingMaterialTB.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
