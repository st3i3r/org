namespace WindowsFormsApplication2
{
    partial class Sale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProduct = new System.Windows.Forms.Label();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.columnCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btBuy = new System.Windows.Forms.Button();
            this.txtOpenProduct = new System.Windows.Forms.TextBox();
            this.btOpenProduct = new System.Windows.Forms.Button();
            this.cmbSheetProduct = new System.Windows.Forms.ComboBox();
            this.btLoadProduct = new System.Windows.Forms.Button();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btAddToCart = new System.Windows.Forms.Button();
            this.listViewCart = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(3, 77);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product";
            // 
            // listViewProduct
            // 
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCode,
            this.columnProduct,
            this.columnQuantity});
            this.listViewProduct.FullRowSelect = true;
            this.listViewProduct.GridLines = true;
            this.listViewProduct.Location = new System.Drawing.Point(2, 100);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(434, 157);
            this.listViewProduct.TabIndex = 1;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            // 
            // columnCode
            // 
            this.columnCode.Text = "Code";
            // 
            // columnProduct
            // 
            this.columnProduct.Text = "Product";
            this.columnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnProduct.Width = 293;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Quantity";
            this.columnQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnQuantity.Width = 76;
            // 
            // btBuy
            // 
            this.btBuy.Location = new System.Drawing.Point(359, 464);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(75, 23);
            this.btBuy.TabIndex = 2;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // txtOpenProduct
            // 
            this.txtOpenProduct.Location = new System.Drawing.Point(6, 15);
            this.txtOpenProduct.Name = "txtOpenProduct";
            this.txtOpenProduct.Size = new System.Drawing.Size(350, 20);
            this.txtOpenProduct.TabIndex = 3;
            // 
            // btOpenProduct
            // 
            this.btOpenProduct.Location = new System.Drawing.Point(361, 13);
            this.btOpenProduct.Name = "btOpenProduct";
            this.btOpenProduct.Size = new System.Drawing.Size(75, 23);
            this.btOpenProduct.TabIndex = 4;
            this.btOpenProduct.Text = "Open File";
            this.btOpenProduct.UseVisualStyleBackColor = true;
            this.btOpenProduct.Click += new System.EventHandler(this.btOpenProduct_Click);
            // 
            // cmbSheetProduct
            // 
            this.cmbSheetProduct.FormattingEnabled = true;
            this.cmbSheetProduct.Location = new System.Drawing.Point(234, 42);
            this.cmbSheetProduct.Name = "cmbSheetProduct";
            this.cmbSheetProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbSheetProduct.TabIndex = 5;
            // 
            // btLoadProduct
            // 
            this.btLoadProduct.Location = new System.Drawing.Point(361, 40);
            this.btLoadProduct.Name = "btLoadProduct";
            this.btLoadProduct.Size = new System.Drawing.Size(75, 23);
            this.btLoadProduct.TabIndex = 6;
            this.btLoadProduct.Text = "Load";
            this.btLoadProduct.UseVisualStyleBackColor = true;
            this.btLoadProduct.Click += new System.EventHandler(this.btLoadProduct_Click);
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(3, 292);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(26, 13);
            this.lblCart.TabIndex = 7;
            this.lblCart.Text = "Cart";
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Location = new System.Drawing.Point(376, 77);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(41, 13);
            this.lblSearchProduct.TabIndex = 8;
            this.lblSearchProduct.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(88, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(268, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btAddToCart
            // 
            this.btAddToCart.Location = new System.Drawing.Point(329, 263);
            this.btAddToCart.Name = "btAddToCart";
            this.btAddToCart.Size = new System.Drawing.Size(107, 26);
            this.btAddToCart.TabIndex = 10;
            this.btAddToCart.Text = "Add To Cart";
            this.btAddToCart.UseVisualStyleBackColor = true;
            this.btAddToCart.Click += new System.EventHandler(this.btAddToCart_Click);
            // 
            // listViewCart
            // 
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCart.FullRowSelect = true;
            this.listViewCart.GridLines = true;
            this.listViewCart.Location = new System.Drawing.Point(0, 308);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(434, 150);
            this.listViewCart.TabIndex = 11;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 293;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 76;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewCart);
            this.Controls.Add(this.btAddToCart);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearchProduct);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.btLoadProduct);
            this.Controls.Add(this.cmbSheetProduct);
            this.Controls.Add(this.btOpenProduct);
            this.Controls.Add(this.txtOpenProduct);
            this.Controls.Add(this.btBuy);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.lblProduct);
            this.Name = "Sale";
            this.Size = new System.Drawing.Size(440, 490);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.TextBox txtOpenProduct;
        private System.Windows.Forms.Button btOpenProduct;
        private System.Windows.Forms.ColumnHeader columnProduct;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ComboBox cmbSheetProduct;
        private System.Windows.Forms.Button btLoadProduct;
        private System.Windows.Forms.ColumnHeader columnCode;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btAddToCart;
        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
