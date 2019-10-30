namespace EatFast_Project
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
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnProductImage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.picBoxProduct = new System.Windows.Forms.PictureBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(248, 219);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(79, 22);
            this.textBoxPrice.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(67, 281);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 17);
            this.label20.TabIndex = 34;
            this.label20.Text = "Product description :";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(248, 278);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(350, 73);
            this.textBoxDescription.TabIndex = 30;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Enabled = false;
            this.btnAddProduct.Location = new System.Drawing.Point(290, 635);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 28);
            this.btnAddProduct.TabIndex = 32;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnProductImage
            // 
            this.btnProductImage.Location = new System.Drawing.Point(248, 380);
            this.btnProductImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductImage.Name = "btnProductImage";
            this.btnProductImage.Size = new System.Drawing.Size(100, 28);
            this.btnProductImage.TabIndex = 29;
            this.btnProductImage.Text = "Choose file";
            this.btnProductImage.UseVisualStyleBackColor = true;
            this.btnProductImage.Click += new System.EventHandler(this.btnProductImageClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 386);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Product picture :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Product price (in CHF) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Product name :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(248, 157);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 22);
            this.textBoxName.TabIndex = 26;
            this.textBoxName.TextChanged += new System.EventHandler(this.CheckProductInfo);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "- Select category -",
            "Starters",
            "Main Dished",
            "Desserts",
            "Drinks"});
            this.comboBoxCategory.Location = new System.Drawing.Point(70, 95);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCategory.TabIndex = 24;
            this.comboBoxCategory.Text = "- Select category -";
            // 
            // picBoxProduct
            // 
            this.picBoxProduct.Location = new System.Drawing.Point(209, 457);
            this.picBoxProduct.Name = "picBoxProduct";
            this.picBoxProduct.Size = new System.Drawing.Size(251, 135);
            this.picBoxProduct.TabIndex = 35;
            this.picBoxProduct.TabStop = false;
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(356, 386);
            this.labelFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(69, 17);
            this.labelFilename.TabIndex = 36;
            this.labelFilename.Text = "File name";
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(13, 9);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(677, 58);
            this.label28.TabIndex = 47;
            this.label28.Text = "Add product";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 704);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.picBoxProduct);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnProductImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "AddProduct";
            this.Text = "Add product";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnProductImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.PictureBox picBoxProduct;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Label label28;
    }
}