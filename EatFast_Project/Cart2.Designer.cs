namespace EatFast_Project
{
    partial class Cart2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelCart = new System.Windows.Forms.Label();
            this.linkLabelHome = new System.Windows.Forms.LinkLabel();
            this.linkLabelMenu = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelCart
            // 
            this.labelCart.AutoSize = true;
            this.labelCart.Location = new System.Drawing.Point(367, 81);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(50, 13);
            this.labelCart.TabIndex = 1;
            this.labelCart.Text = "Your cart";
            // 
            // linkLabelHome
            // 
            this.linkLabelHome.AutoSize = true;
            this.linkLabelHome.Location = new System.Drawing.Point(713, 33);
            this.linkLabelHome.Name = "linkLabelHome";
            this.linkLabelHome.Size = new System.Drawing.Size(35, 13);
            this.linkLabelHome.TabIndex = 2;
            this.linkLabelHome.TabStop = true;
            this.linkLabelHome.Text = "Home";
            this.linkLabelHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkHomeClicked);
            // 
            // linkLabelMenu
            // 
            this.linkLabelMenu.AutoSize = true;
            this.linkLabelMenu.Location = new System.Drawing.Point(658, 33);
            this.linkLabelMenu.Name = "linkLabelMenu";
            this.linkLabelMenu.Size = new System.Drawing.Size(34, 13);
            this.linkLabelMenu.TabIndex = 3;
            this.linkLabelMenu.TabStop = true;
            this.linkLabelMenu.Text = "Menu";
            this.linkLabelMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkMenuClicked);
            // 
            // Cart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelMenu);
            this.Controls.Add(this.linkLabelHome);
            this.Controls.Add(this.labelCart);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cart2";
            this.Text = "Cart2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCart;
        private System.Windows.Forms.LinkLabel linkLabelHome;
        private System.Windows.Forms.LinkLabel linkLabelMenu;
    }
}