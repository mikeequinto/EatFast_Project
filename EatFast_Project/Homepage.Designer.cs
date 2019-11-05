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
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.tabControlHomepage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSaveAccount = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IncreaseProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DecreaseProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RemoveProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControlHomepage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.tabControlHomepage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlHomepage.Name = "tabControlHomepage";
            this.tabControlHomepage.SelectedIndex = 0;
            this.tabControlHomepage.Size = new System.Drawing.Size(1148, 591);
            this.tabControlHomepage.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1140, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Location = new System.Drawing.Point(745, 279);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(267, 167);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "product_3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(80, 130);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Add to cart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnAddCartClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "25.00 CHF";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(431, 279);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 167);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "product_2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 130);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add to cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnAddCartClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "25.00 CHF";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddToCart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(120, 279);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 167);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "product_1";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(80, 130);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(100, 28);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.BtnAddCartClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "25.00 CHF";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1120, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Our top products";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1120, 97);
            this.label2.TabIndex = 15;
            this.label2.Text = "restaurant_info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1121, 94);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome to restaurant_name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1140, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All products";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(107, 107);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(936, 430);
            this.tabControl2.TabIndex = 22;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Size = new System.Drawing.Size(928, 401);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Starters";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInfo);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.Location = new System.Drawing.Point(27, 20);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(267, 167);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(32, 126);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(100, 28);
            this.btnInfo.TabIndex = 14;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfoClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "product_1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(140, 126);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 6;
            this.button6.Text = "Add to cart";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BtnAddCartClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 106);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "25.00 CHF";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage6.Size = new System.Drawing.Size(928, 401);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Main Dishes";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(928, 401);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Desserts";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(928, 401);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Drinks";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1140, 562);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Your cart";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Total :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(219, 111);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderDate,
            this.OrderAddress,
            this.OrderTotal,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(105, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(919, 278);
            this.dataGridView1.TabIndex = 3;
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
            this.tabPage9.Controls.Add(this.textBoxEmail);
            this.tabPage9.Controls.Add(this.lblEmail);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1140, 562);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Your account";
            this.tabPage9.UseVisualStyleBackColor = true;
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
            this.textBoxAddress.Location = new System.Drawing.Point(448, 266);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(399, 20);
            this.textBoxAddress.TabIndex = 21;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.CheckAccountInfo);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(297, 269);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(122, 17);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Delivery address :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(448, 197);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(216, 22);
            this.textBoxEmail.TabIndex = 19;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.CheckAccountInfo);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(297, 200);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email :";
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
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(300, 340);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(143, 28);
            this.btnChangePassword.TabIndex = 35;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePasswordClicked);
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.Enabled = false;
            this.btnSaveAccount.Location = new System.Drawing.Point(507, 434);
            this.btnSaveAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(116, 28);
            this.btnSaveAccount.TabIndex = 36;
            this.btnSaveAccount.Text = "Save";
            this.btnSaveAccount.UseVisualStyleBackColor = true;
            this.btnSaveAccount.Click += new System.EventHandler(this.BtnSaveAccountClicked);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductPrice,
            this.ProductQuantity,
            this.IncreaseProduct,
            this.DecreaseProduct,
            this.RemoveProduct});
            this.dataGridView2.Location = new System.Drawing.Point(80, 146);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(980, 230);
            this.dataGridView2.TabIndex = 44;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(71, 46);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 62);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(71, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 62);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(71, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(75, 41);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(133, 62);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(133, 413);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 17);
            this.label14.TabIndex = 46;
            this.label14.Text = "29.50";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(190, 414);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 17);
            this.label20.TabIndex = 47;
            this.label20.Text = "CHF";
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Date";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 125;
            // 
            // OrderAddress
            // 
            this.OrderAddress.HeaderText = "Address";
            this.OrderAddress.MinimumWidth = 6;
            this.OrderAddress.Name = "OrderAddress";
            this.OrderAddress.ReadOnly = true;
            this.OrderAddress.Width = 250;
            // 
            // OrderTotal
            // 
            this.OrderTotal.HeaderText = "Total";
            this.OrderTotal.MinimumWidth = 6;
            this.OrderTotal.Name = "OrderTotal";
            this.OrderTotal.ReadOnly = true;
            this.OrderTotal.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Delivery status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
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
            this.IncreaseProduct.Text = "+";
            this.IncreaseProduct.UseColumnTextForButtonValue = true;
            this.IncreaseProduct.Width = 75;
            // 
            // DecreaseProduct
            // 
            this.DecreaseProduct.HeaderText = "Decrease";
            this.DecreaseProduct.MinimumWidth = 6;
            this.DecreaseProduct.Name = "DecreaseProduct";
            this.DecreaseProduct.Text = "-";
            this.DecreaseProduct.UseColumnTextForButtonValue = true;
            this.DecreaseProduct.Width = 75;
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.HeaderText = "Remove";
            this.RemoveProduct.MinimumWidth = 6;
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Text = "Remove";
            this.RemoveProduct.Width = 125;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 705);
            this.Controls.Add(this.tabControlHomepage);
            this.Controls.Add(this.linkLabelLogout);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Homepage_FormClosing);
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.tabControlHomepage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private GroupBox groupBox3;
        private Label label8;
        private Button button3;
        private Label label9;
        private PictureBox pictureBox3;
        private GroupBox groupBox2;
        private Label label5;
        private Button button2;
        private Label label7;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label3;
        private Button btnAddToCart;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabControl tabControl2;
        private TabPage tabPage5;
        private GroupBox groupBox4;
        private Label label11;
        private Button button6;
        private Label label12;
        private PictureBox pictureBox4;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Button button7;
        private Label label10;
        private Label label15;
        private DataGridView dataGridView1;
        private Button btnInfo;
        private Label label18;
        private Label label16;
        private Label label17;
        private TabPage tabPage9;
        private Label label19;
        private TextBox textBoxName;
        private Label lblUsername;
        private TextBox textBoxAddress;
        private Label lblAddress;
        private TextBox textBoxEmail;
        private Label lblEmail;
        private Button btnSaveAccount;
        private Button btnChangePassword;
        private DataGridView dataGridView2;
        private Label label20;
        private Label label14;
        private Label label13;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderAddress;
        private DataGridViewTextBoxColumn OrderTotal;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProductQuantity;
        private DataGridViewButtonColumn IncreaseProduct;
        private DataGridViewButtonColumn DecreaseProduct;
        private DataGridViewButtonColumn RemoveProduct;
    }
}

