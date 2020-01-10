namespace EatFast_Project
{
    partial class Checkout
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
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCardName = new System.Windows.Forms.TextBox();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.textBoxCardCVV = new System.Windows.Forms.TextBox();
            this.btnSubmitPayment = new System.Windows.Forms.Button();
            this.labelCartTotal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(383, 47);
            this.label16.TabIndex = 44;
            this.label16.Text = "Payment information";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 47);
            this.label1.TabIndex = 45;
            this.label1.Text = "Cardholder\'s name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 47);
            this.label2.TabIndex = 46;
            this.label2.Text = "Card number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 47);
            this.label3.TabIndex = 47;
            this.label3.Text = "Valid thru";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 47);
            this.label4.TabIndex = 48;
            this.label4.Text = "CVV / CVC";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCardName
            // 
            this.textBoxCardName.Location = new System.Drawing.Point(95, 106);
            this.textBoxCardName.Name = "textBoxCardName";
            this.textBoxCardName.Size = new System.Drawing.Size(209, 20);
            this.textBoxCardName.TabIndex = 49;
            this.textBoxCardName.TextChanged += new System.EventHandler(this.CheckCardInformation);
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(95, 179);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(209, 20);
            this.textBoxCardNumber.TabIndex = 50;
            this.textBoxCardNumber.TextChanged += new System.EventHandler(this.CheckCardInformation);
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(157, 253);
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownMonth.TabIndex = 51;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.ValueChanged += new System.EventHandler(this.CheckCardInformation);
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(203, 253);
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownYear.TabIndex = 52;
            this.numericUpDownYear.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.numericUpDownYear.ValueChanged += new System.EventHandler(this.CheckCardInformation);
            // 
            // textBoxCardCVV
            // 
            this.textBoxCardCVV.Location = new System.Drawing.Point(172, 335);
            this.textBoxCardCVV.Name = "textBoxCardCVV";
            this.textBoxCardCVV.Size = new System.Drawing.Size(59, 20);
            this.textBoxCardCVV.TabIndex = 53;
            this.textBoxCardCVV.TextChanged += new System.EventHandler(this.CheckCardInformation);
            // 
            // btnSubmitPayment
            // 
            this.btnSubmitPayment.Enabled = false;
            this.btnSubmitPayment.Location = new System.Drawing.Point(130, 408);
            this.btnSubmitPayment.Name = "btnSubmitPayment";
            this.btnSubmitPayment.Size = new System.Drawing.Size(144, 23);
            this.btnSubmitPayment.TabIndex = 54;
            this.btnSubmitPayment.Text = "Submit payment";
            this.btnSubmitPayment.UseVisualStyleBackColor = true;
            this.btnSubmitPayment.Click += new System.EventHandler(this.BtnSubmitClicked);
            // 
            // labelCartTotal
            // 
            this.labelCartTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartTotal.Location = new System.Drawing.Point(12, 358);
            this.labelCartTotal.Name = "labelCartTotal";
            this.labelCartTotal.Size = new System.Drawing.Size(386, 47);
            this.labelCartTotal.TabIndex = 55;
            this.labelCartTotal.Text = "Total (CHF) : 0.0";
            this.labelCartTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "Back to cart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnBackClicked);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 475);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelCartTotal);
            this.Controls.Add(this.btnSubmitPayment);
            this.Controls.Add(this.textBoxCardCVV);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.textBoxCardName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCardName;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.TextBox textBoxCardCVV;
        private System.Windows.Forms.Button btnSubmitPayment;
        private System.Windows.Forms.Label labelCartTotal;
        private System.Windows.Forms.Button button2;
    }
}