namespace PROGBICEOne
{
    partial class Form1
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
            this.AddProductBTN = new System.Windows.Forms.Button();
            this.UpdateProductBTN = new System.Windows.Forms.Button();
            this.DisplayInventoryBTN = new System.Windows.Forms.Button();
            this.ProcessSaleBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProductBTN
            // 
            this.AddProductBTN.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddProductBTN.Location = new System.Drawing.Point(43, 77);
            this.AddProductBTN.Name = "AddProductBTN";
            this.AddProductBTN.Size = new System.Drawing.Size(195, 49);
            this.AddProductBTN.TabIndex = 0;
            this.AddProductBTN.Text = "Add New Product";
            this.AddProductBTN.UseVisualStyleBackColor = false;
            this.AddProductBTN.Click += new System.EventHandler(this.AddProductBTN_Click);
            // 
            // UpdateProductBTN
            // 
            this.UpdateProductBTN.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UpdateProductBTN.Location = new System.Drawing.Point(43, 155);
            this.UpdateProductBTN.Name = "UpdateProductBTN";
            this.UpdateProductBTN.Size = new System.Drawing.Size(195, 49);
            this.UpdateProductBTN.TabIndex = 1;
            this.UpdateProductBTN.Text = "Update Exisating Product";
            this.UpdateProductBTN.UseVisualStyleBackColor = false;
            this.UpdateProductBTN.Click += new System.EventHandler(this.UpdateProductBTN_Click);
            // 
            // DisplayInventoryBTN
            // 
            this.DisplayInventoryBTN.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DisplayInventoryBTN.Location = new System.Drawing.Point(43, 232);
            this.DisplayInventoryBTN.Name = "DisplayInventoryBTN";
            this.DisplayInventoryBTN.Size = new System.Drawing.Size(195, 49);
            this.DisplayInventoryBTN.TabIndex = 2;
            this.DisplayInventoryBTN.Text = "Display Inventory Report";
            this.DisplayInventoryBTN.UseVisualStyleBackColor = false;
            this.DisplayInventoryBTN.Click += new System.EventHandler(this.DisplayInventoryBTN_Click);
            // 
            // ProcessSaleBTN
            // 
            this.ProcessSaleBTN.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ProcessSaleBTN.Location = new System.Drawing.Point(43, 311);
            this.ProcessSaleBTN.Name = "ProcessSaleBTN";
            this.ProcessSaleBTN.Size = new System.Drawing.Size(195, 49);
            this.ProcessSaleBTN.TabIndex = 3;
            this.ProcessSaleBTN.Text = "Proccess Sale";
            this.ProcessSaleBTN.UseVisualStyleBackColor = false;
            this.ProcessSaleBTN.Click += new System.EventHandler(this.ProcessSaleBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 450);
            this.Controls.Add(this.ProcessSaleBTN);
            this.Controls.Add(this.DisplayInventoryBTN);
            this.Controls.Add(this.UpdateProductBTN);
            this.Controls.Add(this.AddProductBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddProductBTN;
        private System.Windows.Forms.Button UpdateProductBTN;
        private System.Windows.Forms.Button DisplayInventoryBTN;
        private System.Windows.Forms.Button ProcessSaleBTN;
    }
}

