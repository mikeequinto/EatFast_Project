using System;
using System.Windows.Forms;

namespace EatFast_Project
{
    partial class Homepage
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
            this.components = new System.ComponentModel.Container();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.tabControlHomepage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelRestaurantInfo = new System.Windows.Forms.Label();
            this.labelRestaurantName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.pro_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToCart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eATFAST_PRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetProducts = new EatFast_Project.DataSetProducts();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelCartTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncreaseProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DecreaseProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelCartQuantity = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oRDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDDELIVERYADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDPAYMENTSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eATFASTORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOrders = new EatFast_Project.DataSetOrders();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.btnSaveAccount = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.eATFAST_PRODUCTTableAdapter = new EatFast_Project.DataSetProductsTableAdapters.EATFAST_PRODUCTTableAdapter();
            this.tableAdapterManager = new EatFast_Project.DataSetProductsTableAdapters.TableAdapterManager();
            this.eATFAST_ORDERTableAdapter = new EatFast_Project.DataSetOrdersTableAdapters.EATFAST_ORDERTableAdapter();
            this.tabControlHomepage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eATFAST_PRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProducts)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eATFASTORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrders)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(1159, 42);
            this.linkLabelLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(52, 17);
            this.linkLabelLogout.TabIndex = 6;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLogoutClicked);
            // 
            // tabControlHomepage
            // 
            this.tabControlHomepage.Controls.Add(this.tabPage1);
            this.tabControlHomepage.Controls.Add(this.tabPage2);
            this.tabControlHomepage.Controls.Add(this.tabPage3);
            this.tabControlHomepage.Controls.Add(this.tabPage4);
            this.tabControlHomepage.Controls.Add(this.tabPage9);
            this.tabControlHomepage.Location = new System.Drawing.Point(69, 62);
            this.tabControlHomepage.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlHomepage.Name = "tabControlHomepage";
            this.tabControlHomepage.SelectedIndex = 0;
            this.tabControlHomepage.Size = new System.Drawing.Size(1148, 591);
            this.tabControlHomepage.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelRestaurantInfo);
            this.tabPage1.Controls.Add(this.labelRestaurantName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1140, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelRestaurantInfo
            // 
            this.labelRestaurantInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestaurantInfo.Location = new System.Drawing.Point(0, 203);
            this.labelRestaurantInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRestaurantInfo.Name = "labelRestaurantInfo";
            this.labelRestaurantInfo.Size = new System.Drawing.Size(1140, 97);
            this.labelRestaurantInfo.TabIndex = 15;
            this.labelRestaurantInfo.Text = "restaurant_info";
            this.labelRestaurantInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRestaurantName
            // 
            this.labelRestaurantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestaurantName.Location = new System.Drawing.Point(0, 18);
            this.labelRestaurantName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRestaurantName.Name = "labelRestaurantName";
            this.labelRestaurantName.Size = new System.Drawing.Size(1138, 94);
            this.labelRestaurantName.TabIndex = 14;
            this.labelRestaurantName.Text = "Welcome to restaurant_name";
            this.labelRestaurantName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.productsDataGridView);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1140, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_id,
            this.pro_name,
            this.pro_description,
            this.pro_price,
            this.pro_category,
            this.AddToCart});
            this.productsDataGridView.DataSource = this.eATFAST_PRODUCTBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(32, 137);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowTemplate.Height = 24;
            this.productsDataGridView.Size = new System.Drawing.Size(1073, 349);
            this.productsDataGridView.TabIndex = 44;
            this.productsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eATFAST_PRODUCTDataGridView_CellContentClick);
            // 
            // pro_id
            // 
            this.pro_id.DataPropertyName = "PRO_ID";
            this.pro_id.HeaderText = "Id";
            this.pro_id.MinimumWidth = 25;
            this.pro_id.Name = "pro_id";
            this.pro_id.ReadOnly = true;
            this.pro_id.Width = 25;
            // 
            // pro_name
            // 
            this.pro_name.DataPropertyName = "PRO_NAME";
            this.pro_name.HeaderText = "Name";
            this.pro_name.Name = "pro_name";
            this.pro_name.ReadOnly = true;
            this.pro_name.Width = 150;
            // 
            // pro_description
            // 
            this.pro_description.DataPropertyName = "PRO_DESCRIPTION";
            this.pro_description.HeaderText = "Description";
            this.pro_description.Name = "pro_description";
            this.pro_description.ReadOnly = true;
            this.pro_description.Width = 250;
            // 
            // pro_price
            // 
            this.pro_price.DataPropertyName = "PRO_PRICE";
            this.pro_price.HeaderText = "Price (CHF)";
            this.pro_price.Name = "pro_price";
            this.pro_price.ReadOnly = true;
            // 
            // pro_category
            // 
            this.pro_category.DataPropertyName = "PRO_CATEGORY";
            this.pro_category.HeaderText = "Category";
            this.pro_category.Name = "pro_category";
            this.pro_category.ReadOnly = true;
            // 
            // AddToCart
            // 
            this.AddToCart.DataPropertyName = "PRO_ID";
            this.AddToCart.HeaderText = "Add to cart";
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.ReadOnly = true;
            this.AddToCart.Text = "Add to cart";
            this.AddToCart.UseColumnTextForButtonValue = true;
            // 
            // eATFAST_PRODUCTBindingSource
            // 
            this.eATFAST_PRODUCTBindingSource.DataMember = "EATFAST_PRODUCT";
            this.eATFAST_PRODUCTBindingSource.DataSource = this.dataSetProducts;
            // 
            // dataSetProducts
            // 
            this.dataSetProducts.DataSetName = "DataSetProducts";
            this.dataSetProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(-4, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1137, 58);
            this.label18.TabIndex = 44;
            this.label18.Text = "All products";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelCartTotal);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.cartDataGridView);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.labelCartQuantity);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1140, 562);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Your cart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelCartTotal
            // 
            this.labelCartTotal.AutoSize = true;
            this.labelCartTotal.Location = new System.Drawing.Point(207, 414);
            this.labelCartTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCartTotal.Name = "labelCartTotal";
            this.labelCartTotal.Size = new System.Drawing.Size(28, 17);
            this.labelCartTotal.TabIndex = 46;
            this.labelCartTotal.Text = "0.0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "Item(s) in your cart :";
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AllowUserToDeleteRows = false;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.ProductName,
            this.ProductPrice,
            this.ProductQuantity,
            this.IncreaseProduct,
            this.DecreaseProduct,
            this.RemoveProduct});
            this.cartDataGridView.Location = new System.Drawing.Point(80, 146);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.ReadOnly = true;
            this.cartDataGridView.RowHeadersWidth = 51;
            this.cartDataGridView.RowTemplate.Height = 24;
            this.cartDataGridView.Size = new System.Drawing.Size(980, 230);
            this.cartDataGridView.TabIndex = 44;
            this.cartDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartDataGridView_CellContentClick);
            // 
            // productId
            // 
            this.productId.HeaderText = "Product id";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 200;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Product price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Width = 75;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.HeaderText = "Product quantity";
            this.ProductQuantity.MinimumWidth = 6;
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.ReadOnly = true;
            this.ProductQuantity.Width = 75;
            // 
            // IncreaseProduct
            // 
            this.IncreaseProduct.HeaderText = "Increase";
            this.IncreaseProduct.MinimumWidth = 6;
            this.IncreaseProduct.Name = "IncreaseProduct";
            this.IncreaseProduct.ReadOnly = true;
            this.IncreaseProduct.Text = "+";
            this.IncreaseProduct.UseColumnTextForButtonValue = true;
            this.IncreaseProduct.Width = 75;
            // 
            // DecreaseProduct
            // 
            this.DecreaseProduct.HeaderText = "Decrease";
            this.DecreaseProduct.MinimumWidth = 6;
            this.DecreaseProduct.Name = "DecreaseProduct";
            this.DecreaseProduct.ReadOnly = true;
            this.DecreaseProduct.Text = "-";
            this.DecreaseProduct.UseColumnTextForButtonValue = true;
            this.DecreaseProduct.Width = 75;
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.HeaderText = "Remove";
            this.RemoveProduct.MinimumWidth = 6;
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.ReadOnly = true;
            this.RemoveProduct.Text = "Remove";
            this.RemoveProduct.UseColumnTextForButtonValue = true;
            this.RemoveProduct.Width = 125;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1137, 58);
            this.label16.TabIndex = 43;
            this.label16.Text = "Your cart";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(952, 407);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 28);
            this.button7.TabIndex = 41;
            this.button7.Text = "Checkout";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.BtnCheckoutClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 414);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Total (CHF) :";
            // 
            // labelCartQuantity
            // 
            this.labelCartQuantity.AutoSize = true;
            this.labelCartQuantity.Location = new System.Drawing.Point(219, 111);
            this.labelCartQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCartQuantity.Name = "labelCartQuantity";
            this.labelCartQuantity.Size = new System.Drawing.Size(16, 17);
            this.labelCartQuantity.TabIndex = 31;
            this.labelCartQuantity.Text = "0";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1140, 562);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Your orders";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(-4, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1137, 58);
            this.label17.TabIndex = 33;
            this.label17.Text = "Your orders";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oRDDATEDataGridViewTextBoxColumn,
            this.oRDSTATUSDataGridViewTextBoxColumn,
            this.oRDDELIVERYADDRESSDataGridViewTextBoxColumn,
            this.oRDTOTALDataGridViewTextBoxColumn,
            this.oRDPAYMENTSTATUSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eATFASTORDERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(105, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(919, 278);
            this.dataGridView1.TabIndex = 3;
            // 
            // oRDDATEDataGridViewTextBoxColumn
            // 
            this.oRDDATEDataGridViewTextBoxColumn.DataPropertyName = "ORD_DATE";
            this.oRDDATEDataGridViewTextBoxColumn.HeaderText = "Date";
            this.oRDDATEDataGridViewTextBoxColumn.Name = "oRDDATEDataGridViewTextBoxColumn";
            this.oRDDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDDATEDataGridViewTextBoxColumn.Width = 150;
            // 
            // oRDSTATUSDataGridViewTextBoxColumn
            // 
            this.oRDSTATUSDataGridViewTextBoxColumn.DataPropertyName = "ORD_STATUS";
            this.oRDSTATUSDataGridViewTextBoxColumn.HeaderText = "Status";
            this.oRDSTATUSDataGridViewTextBoxColumn.Name = "oRDSTATUSDataGridViewTextBoxColumn";
            this.oRDSTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oRDDELIVERYADDRESSDataGridViewTextBoxColumn
            // 
            this.oRDDELIVERYADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ORD_DELIVERYADDRESS";
            this.oRDDELIVERYADDRESSDataGridViewTextBoxColumn.HeaderText = "Delivery Address";
            this.oRDDELIVERYADDRESSDataGridViewTextBoxColumn.Name = "oRDDELIVERYADDRESSDataGridViewTextBoxColumn";
            this.oRDDELIVERYADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDDELIVERYADDRESSDataGridViewTextBoxColumn.Width = 250;
            // 
            // oRDTOTALDataGridViewTextBoxColumn
            // 
            this.oRDTOTALDataGridViewTextBoxColumn.DataPropertyName = "ORD_TOTAL";
            this.oRDTOTALDataGridViewTextBoxColumn.HeaderText = "Total (CHF)";
            this.oRDTOTALDataGridViewTextBoxColumn.Name = "oRDTOTALDataGridViewTextBoxColumn";
            this.oRDTOTALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oRDPAYMENTSTATUSDataGridViewTextBoxColumn
            // 
            this.oRDPAYMENTSTATUSDataGridViewTextBoxColumn.DataPropertyName = "ORD_PAYMENTSTATUS";
            this.oRDPAYMENTSTATUSDataGridViewTextBoxColumn.HeaderText = "Payment Status";
            this.oRDPAYMENTSTATUSDataGridViewTextBoxColumn.Name = "oRDPAYMENTSTATUSDataGridViewTextBoxColumn";
            this.oRDPAYMENTSTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eATFASTORDERBindingSource
            // 
            this.eATFASTORDERBindingSource.DataMember = "EATFAST_ORDER";
            this.eATFASTORDERBindingSource.DataSource = this.dataSetOrdersBindingSource;
            // 
            // dataSetOrdersBindingSource
            // 
            this.dataSetOrdersBindingSource.DataSource = this.dataSetOrders;
            this.dataSetOrdersBindingSource.Position = 0;
            // 
            // dataSetOrders
            // 
            this.dataSetOrders.DataSetName = "DataSetOrders";
            this.dataSetOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.btnSaveAccount);
            this.tabPage9.Controls.Add(this.btnChangePassword);
            this.tabPage9.Controls.Add(this.label19);
            this.tabPage9.Controls.Add(this.textBoxName);
            this.tabPage9.Controls.Add(this.lblUsername);
            this.tabPage9.Controls.Add(this.textBoxAddress);
            this.tabPage9.Controls.Add(this.lblAddress);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1140, 562);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Your account";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.Enabled = false;
            this.btnSaveAccount.Location = new System.Drawing.Point(507, 373);
            this.btnSaveAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(116, 28);
            this.btnSaveAccount.TabIndex = 36;
            this.btnSaveAccount.Text = "Save";
            this.btnSaveAccount.UseVisualStyleBackColor = true;
            this.btnSaveAccount.Click += new System.EventHandler(this.BtnSaveAccountClicked);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(300, 279);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(143, 28);
            this.btnChangePassword.TabIndex = 35;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePasswordClicked);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1, 3);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(1137, 58);
            this.label19.TabIndex = 34;
            this.label19.Text = "Your account";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(448, 130);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(216, 22);
            this.textBoxName.TabIndex = 26;
            this.textBoxName.TextChanged += new System.EventHandler(this.CheckAccountInfo);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(297, 133);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 17);
            this.lblUsername.TabIndex = 25;
            this.lblUsername.Text = "Name :";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(448, 205);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(399, 22);
            this.textBoxAddress.TabIndex = 21;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.CheckAccountInfo);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(297, 208);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(122, 17);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Delivery address :";
            // 
            // eATFAST_PRODUCTTableAdapter
            // 
            this.eATFAST_PRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EATFAST_PRODUCTTableAdapter = this.eATFAST_PRODUCTTableAdapter;
            this.tableAdapterManager.UpdateOrder = EatFast_Project.DataSetProductsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eATFAST_ORDERTableAdapter
            // 
            this.eATFAST_ORDERTableAdapter.ClearBeforeFill = true;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 705);
            this.Controls.Add(this.tabControlHomepage);
            this.Controls.Add(this.linkLabelLogout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Homepage_FormClosing);
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.tabControlHomepage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eATFAST_PRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProducts)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eATFASTORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrders)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private TabControl tabControlHomepage;
        private TabPage tabPage1;
        private Label labelRestaurantInfo;
        private Label labelRestaurantName;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button7;
        private Label label10;
        private Label labelCartQuantity;
        private DataGridView dataGridView1;
        private Label label18;
        private Label label16;
        private Label label17;
        private TabPage tabPage9;
        private Label label19;
        private TextBox textBoxName;
        private Label lblUsername;
        private TextBox textBoxAddress;
        private Label lblAddress;
        private Button btnSaveAccount;
        private DataGridView cartDataGridView;
        private Label labelCartTotal;
        private Label label13;
        private DataSetProducts dataSetProducts;
        private BindingSource eATFAST_PRODUCTBindingSource;
        private DataSetProductsTableAdapters.EATFAST_PRODUCTTableAdapter eATFAST_PRODUCTTableAdapter;
        private DataSetProductsTableAdapters.TableAdapterManager tableAdapterManager;
        private DataGridView productsDataGridView;
        private DataGridViewTextBoxColumn pro_id;
        private DataGridViewTextBoxColumn pro_name;
        private DataGridViewTextBoxColumn pro_description;
        private DataGridViewTextBoxColumn pro_price;
        private DataGridViewTextBoxColumn pro_category;
        private DataGridViewButtonColumn AddToCart;
        private DataGridViewTextBoxColumn productId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductQuantity;
        private DataGridViewButtonColumn IncreaseProduct;
        private DataGridViewButtonColumn DecreaseProduct;
        private DataGridViewButtonColumn RemoveProduct;
        private BindingSource dataSetOrdersBindingSource;
        private DataSetOrders dataSetOrders;
        private BindingSource eATFASTORDERBindingSource;
        private DataSetOrdersTableAdapters.EATFAST_ORDERTableAdapter eATFAST_ORDERTableAdapter;
        private DataGridViewTextBoxColumn oRDDATEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oRDSTATUSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oRDDELIVERYADDRESSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oRDTOTALDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn oRDPAYMENTSTATUSDataGridViewTextBoxColumn;
        private Button btnChangePassword;
    }
}

