namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblProductName2 = new System.Windows.Forms.Label();
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.tbxStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lblStockUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblCategoryIdUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(14, 258);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(948, 173);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(82, 41);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(276, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(28, 44);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Kategori";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(948, 100);
            this.gbxCategory.TabIndex = 3;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kateegoriye Göre Ara";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(12, 134);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(948, 100);
            this.gbxProductName.TabIndex = 4;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Ara";
            this.gbxProductName.Enter += new System.EventHandler(this.gbxProductName_Enter);
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(82, 47);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(276, 20);
            this.tbxProductName.TabIndex = 4;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(26, 50);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Ürün Adı";
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
            this.gbxProductAdd.Controls.Add(this.tbxStock);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblProductName2);
            this.gbxProductAdd.Location = new System.Drawing.Point(12, 480);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(948, 145);
            this.gbxProductAdd.TabIndex = 5;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            this.gbxProductAdd.Enter += new System.EventHandler(this.gbxProductUpdate_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(720, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(91, 76);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(267, 21);
            this.cbxCategoryId.TabIndex = 9;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(625, 45);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(268, 20);
            this.tbxStock.TabIndex = 8;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(625, 77);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(268, 20);
            this.tbxQuantityPerUnit.TabIndex = 7;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(91, 112);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(267, 20);
            this.tbxUnitPrice.TabIndex = 6;
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(91, 41);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(267, 20);
            this.tbxProductNameAdd.TabIndex = 5;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(560, 84);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(560, 48);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(59, 13);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok Adedi";
            this.lblStock.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(39, 115);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(39, 79);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Kategori";
            // 
            // lblProductName2
            // 
            this.lblProductName2.AutoSize = true;
            this.lblProductName2.Location = new System.Drawing.Point(39, 48);
            this.lblProductName2.Name = "lblProductName2";
            this.lblProductName2.Size = new System.Drawing.Size(48, 13);
            this.lblProductName2.TabIndex = 0;
            this.lblProductName2.Text = "Ürün Adı";
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Controls.Add(this.btnUpdate);
            this.gbxProductUpdate.Controls.Add(this.cbxCategoryIdUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxStockUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblStockUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblCategoryIdUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblProductNameUpdate);
            this.gbxProductUpdate.Location = new System.Drawing.Point(12, 644);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Size = new System.Drawing.Size(948, 145);
            this.gbxProductUpdate.TabIndex = 6;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Ürün Güncelle";
            this.gbxProductUpdate.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(720, 105);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(91, 76);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(267, 21);
            this.cbxCategoryIdUpdate.TabIndex = 9;
            // 
            // tbxStockUpdate
            // 
            this.tbxStockUpdate.Location = new System.Drawing.Point(625, 34);
            this.tbxStockUpdate.Name = "tbxStockUpdate";
            this.tbxStockUpdate.Size = new System.Drawing.Size(268, 20);
            this.tbxStockUpdate.TabIndex = 8;
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(625, 72);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(268, 20);
            this.tbxQuantityPerUnitUpdate.TabIndex = 7;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(91, 112);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(267, 20);
            this.tbxUnitPriceUpdate.TabIndex = 6;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(91, 41);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(267, 20);
            this.tbxProductNameUpdate.TabIndex = 5;
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(560, 75);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnitUpdate.TabIndex = 4;
            this.lblQuantityPerUnitUpdate.Text = "Birim Adedi";
            // 
            // lblStockUpdate
            // 
            this.lblStockUpdate.AutoSize = true;
            this.lblStockUpdate.Location = new System.Drawing.Point(560, 37);
            this.lblStockUpdate.Name = "lblStockUpdate";
            this.lblStockUpdate.Size = new System.Drawing.Size(59, 13);
            this.lblStockUpdate.TabIndex = 3;
            this.lblStockUpdate.Text = "Stok Adedi";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(39, 115);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "Fiyat";
            // 
            // lblCategoryIdUpdate
            // 
            this.lblCategoryIdUpdate.AutoSize = true;
            this.lblCategoryIdUpdate.Location = new System.Drawing.Point(39, 79);
            this.lblCategoryIdUpdate.Name = "lblCategoryIdUpdate";
            this.lblCategoryIdUpdate.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryIdUpdate.TabIndex = 1;
            this.lblCategoryIdUpdate.Text = "Kategori";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(39, 48);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(48, 13);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "Ürün Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(825, 450);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 25);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(974, 832);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblProductName2;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxProductUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.TextBox tbxStockUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblStockUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblCategoryIdUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

