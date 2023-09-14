using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "Category Name";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "Category Name";
            cbxCategoryId.ValueMember = "CategoryId";


            cbxCategoryIdUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryIdUpdate.DisplayMember = "Category Name";
            cbxCategoryIdUpdate.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {


            }
        }


        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void gbxProductName_Enter(object sender, EventArgs e)
        {

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductNameAdd.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStock.Text)

                });
                MessageBox.Show("Ürün Eklendi");
                LoadProducts();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
            
                

            
        }

        private void gbxProductUpdate_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxProductNameUpdate.Text,
                CategoryId = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                UnitsInStock = Convert.ToInt16(tbxStockUpdate.Text),
                QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
               

            });
            MessageBox.Show("Ürün Güncellendi");
            LoadProducts();

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductNameUpdate.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            cbxCategoryIdUpdate.SelectedValue = row.Cells[2].Value;
            tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            tbxQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
            tbxStockUpdate.Text = row.Cells[5].Value.ToString();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün Silindi");
                    LoadProducts();
                }

                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
            
        }
        private void lblCategory_Click(object sender, EventArgs e)
        {

        }
    }

}
