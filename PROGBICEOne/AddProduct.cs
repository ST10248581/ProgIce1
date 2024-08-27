using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGBICEOne
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
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

                        var electronicProduct = new ElectronicProduct()
                        {
                            ProductID = Guid.NewGuid(),
                            Name = String.IsNullOrEmpty(NameTB.Text) ? "Product" : NameTB.Text,
                            Category = "Electronics",
                            Price = decimal.Parse(PriceTB.Text),
                            StockQuantity = int.Parse(QuantityTB.Text),
                            WarrantyPeriod = int.Parse(WarentyTB.Text)
                        };

                        Inventory.AddProduct(electronicProduct);

                        MessageBox.Show("Product Added Successfully");
                        break;

                    case "Grocery":

                        var groceryProduct = new GroceryProduct()
                        {
                            ProductID = Guid.NewGuid(),
                            Name = String.IsNullOrEmpty(NameTB.Text) ? "Product" : NameTB.Text,
                            Category = "Grocery",
                            Price = decimal.Parse(PriceTB.Text),
                            StockQuantity = int.Parse(QuantityTB.Text),
                            ExpirationDate = ExpirationDateTimePicker.Value,
                        };

                        Inventory.AddProduct(groceryProduct);

                        MessageBox.Show("Product Added Successfully");

                        break;

                    case "Clothing":

                        var clothingProduct = new ClothingProduct()
                        {
                            ProductID = Guid.NewGuid(),
                            Name = String.IsNullOrEmpty(NameTB.Text) ? "Product" : NameTB.Text,
                            Category = "Clothing",
                            Price = decimal.Parse(PriceTB.Text),
                            StockQuantity = int.Parse(QuantityTB.Text),
                            Material = ClothingMaterialTB.Text,
                            Size = ClothingSizeCB.SelectedItem.ToString(),
                        };

                        Inventory.AddProduct(clothingProduct);

                        MessageBox.Show("Product Added Successfully");

                        break;

                    default:
                        var product = new Product()
                        {
                            ProductID = Guid.NewGuid(),
                            Name = String.IsNullOrEmpty(NameTB.Text) ? "Product" : NameTB.Text,
                            Category = "Default",
                            Price = decimal.Parse(PriceTB.Text),
                            StockQuantity = int.Parse(QuantityTB.Text)
                        };

                        Inventory.AddProduct(product);

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
