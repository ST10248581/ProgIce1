namespace PROGBICEOne
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductTypeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.CreateBTN = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            this.ClothingSizeLabel = new System.Windows.Forms.Label();
            this.ClothingSizeCB = new System.Windows.Forms.ComboBox();
            this.ClothingMaterialLabel = new System.Windows.Forms.Label();
            this.ClothingMaterialTB = new System.Windows.Forms.TextBox();
            this.ElectronicWarentyPeriodLabel = new System.Windows.Forms.Label();
            this.WarentyTB = new System.Windows.Forms.TextBox();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.ExpirationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Type";
            // 
            // ProductTypeCB
            // 
            this.ProductTypeCB.FormattingEnabled = true;
            this.ProductTypeCB.Items.AddRange(new object[] {
            "Electronics",
            "Grocery",
            "Clothing"});
            this.ProductTypeCB.Location = new System.Drawing.Point(96, 100);
            this.ProductTypeCB.Name = "ProductTypeCB";
            this.ProductTypeCB.Size = new System.Drawing.Size(121, 21);
            this.ProductTypeCB.TabIndex = 2;
            this.ProductTypeCB.SelectedIndexChanged += new System.EventHandler(this.ProductTypeCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(59, 143);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(158, 20);
            this.NameTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(53, 193);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(158, 20);
            this.PriceTB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Qauntity";
            // 
            // QuantityTB
            // 
            this.QuantityTB.Location = new System.Drawing.Point(69, 239);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(158, 20);
            this.QuantityTB.TabIndex = 8;
            // 
            // CreateBTN
            // 
            this.CreateBTN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CreateBTN.Location = new System.Drawing.Point(269, 336);
            this.CreateBTN.Name = "CreateBTN";
            this.CreateBTN.Size = new System.Drawing.Size(103, 46);
            this.CreateBTN.TabIndex = 9;
            this.CreateBTN.Text = "Create New Product";
            this.CreateBTN.UseVisualStyleBackColor = false;
            this.CreateBTN.Click += new System.EventHandler(this.CreateBTN_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackBTN.Location = new System.Drawing.Point(160, 336);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(103, 46);
            this.BackBTN.TabIndex = 10;
            this.BackBTN.Text = "Back To Menu";
            this.BackBTN.UseVisualStyleBackColor = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // ClothingSizeLabel
            // 
            this.ClothingSizeLabel.AutoSize = true;
            this.ClothingSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClothingSizeLabel.Location = new System.Drawing.Point(254, 101);
            this.ClothingSizeLabel.Name = "ClothingSizeLabel";
            this.ClothingSizeLabel.Size = new System.Drawing.Size(79, 15);
            this.ClothingSizeLabel.TabIndex = 11;
            this.ClothingSizeLabel.Text = "Clothing Size";
            this.ClothingSizeLabel.Visible = false;
            // 
            // ClothingSizeCB
            // 
            this.ClothingSizeCB.FormattingEnabled = true;
            this.ClothingSizeCB.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL"});
            this.ClothingSizeCB.Location = new System.Drawing.Point(339, 100);
            this.ClothingSizeCB.Name = "ClothingSizeCB";
            this.ClothingSizeCB.Size = new System.Drawing.Size(121, 21);
            this.ClothingSizeCB.TabIndex = 12;
            this.ClothingSizeCB.Visible = false;
            // 
            // ClothingMaterialLabel
            // 
            this.ClothingMaterialLabel.AutoSize = true;
            this.ClothingMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClothingMaterialLabel.Location = new System.Drawing.Point(254, 144);
            this.ClothingMaterialLabel.Name = "ClothingMaterialLabel";
            this.ClothingMaterialLabel.Size = new System.Drawing.Size(52, 15);
            this.ClothingMaterialLabel.TabIndex = 13;
            this.ClothingMaterialLabel.Text = "Material";
            this.ClothingMaterialLabel.Visible = false;
            // 
            // ClothingMaterialTB
            // 
            this.ClothingMaterialTB.Location = new System.Drawing.Point(312, 143);
            this.ClothingMaterialTB.Name = "ClothingMaterialTB";
            this.ClothingMaterialTB.Size = new System.Drawing.Size(158, 20);
            this.ClothingMaterialTB.TabIndex = 14;
            this.ClothingMaterialTB.Visible = false;
            // 
            // ElectronicWarentyPeriodLabel
            // 
            this.ElectronicWarentyPeriodLabel.AutoSize = true;
            this.ElectronicWarentyPeriodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElectronicWarentyPeriodLabel.Location = new System.Drawing.Point(254, 194);
            this.ElectronicWarentyPeriodLabel.Name = "ElectronicWarentyPeriodLabel";
            this.ElectronicWarentyPeriodLabel.Size = new System.Drawing.Size(91, 15);
            this.ElectronicWarentyPeriodLabel.TabIndex = 15;
            this.ElectronicWarentyPeriodLabel.Text = "WarrentyPeriod";
            this.ElectronicWarentyPeriodLabel.Visible = false;
            // 
            // WarentyTB
            // 
            this.WarentyTB.Location = new System.Drawing.Point(351, 193);
            this.WarentyTB.Name = "WarentyTB";
            this.WarentyTB.Size = new System.Drawing.Size(158, 20);
            this.WarentyTB.TabIndex = 16;
            this.WarentyTB.Visible = false;
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.AutoSize = true;
            this.ExpirationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateLabel.Location = new System.Drawing.Point(254, 240);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(88, 15);
            this.ExpirationDateLabel.TabIndex = 17;
            this.ExpirationDateLabel.Text = "ExpirationDate";
            this.ExpirationDateLabel.Visible = false;
            // 
            // ExpirationDateTimePicker
            // 
            this.ExpirationDateTimePicker.Location = new System.Drawing.Point(348, 240);
            this.ExpirationDateTimePicker.Name = "ExpirationDateTimePicker";
            this.ExpirationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ExpirationDateTimePicker.TabIndex = 19;
            this.ExpirationDateTimePicker.Visible = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.ExpirationDateTimePicker);
            this.Controls.Add(this.ExpirationDateLabel);
            this.Controls.Add(this.WarentyTB);
            this.Controls.Add(this.ElectronicWarentyPeriodLabel);
            this.Controls.Add(this.ClothingMaterialTB);
            this.Controls.Add(this.ClothingMaterialLabel);
            this.Controls.Add(this.ClothingSizeCB);
            this.Controls.Add(this.ClothingSizeLabel);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.CreateBTN);
            this.Controls.Add(this.QuantityTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductTypeCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProductTypeCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.Button CreateBTN;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Label ClothingSizeLabel;
        private System.Windows.Forms.ComboBox ClothingSizeCB;
        private System.Windows.Forms.Label ClothingMaterialLabel;
        private System.Windows.Forms.TextBox ClothingMaterialTB;
        private System.Windows.Forms.Label ElectronicWarentyPeriodLabel;
        private System.Windows.Forms.TextBox WarentyTB;
        private System.Windows.Forms.Label ExpirationDateLabel;
        private System.Windows.Forms.DateTimePicker ExpirationDateTimePicker;
    }
}