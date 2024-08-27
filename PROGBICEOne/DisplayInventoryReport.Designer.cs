namespace PROGBICEOne
{
    partial class DisplayInventoryReport
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
            this.ReportTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBTN = new System.Windows.Forms.Button();
            this.DisplayBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReportTB
            // 
            this.ReportTB.Location = new System.Drawing.Point(12, 60);
            this.ReportTB.Multiline = true;
            this.ReportTB.Name = "ReportTB";
            this.ReportTB.Size = new System.Drawing.Size(381, 225);
            this.ReportTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Display Summary Report";
            // 
            // BackBTN
            // 
            this.BackBTN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackBTN.Location = new System.Drawing.Point(94, 291);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(103, 46);
            this.BackBTN.TabIndex = 32;
            this.BackBTN.Text = "Back To Menu";
            this.BackBTN.UseVisualStyleBackColor = false;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // DisplayBTN
            // 
            this.DisplayBTN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DisplayBTN.Location = new System.Drawing.Point(203, 291);
            this.DisplayBTN.Name = "DisplayBTN";
            this.DisplayBTN.Size = new System.Drawing.Size(103, 46);
            this.DisplayBTN.TabIndex = 31;
            this.DisplayBTN.Text = "Display Report";
            this.DisplayBTN.UseVisualStyleBackColor = false;
            this.DisplayBTN.Click += new System.EventHandler(this.DisplayBTN_Click);
            // 
            // DisplayInventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 368);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.DisplayBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReportTB);
            this.Name = "DisplayInventoryReport";
            this.Text = "DisplayInventoryReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReportTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.Button DisplayBTN;
    }
}