using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W05_JESSICA_T
{
    public partial class Form1 : Form
    {
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();

        List<Category> listCategory = new List<Category>();
        List<Product>  listProduct = new List<Product>();

        string kodenya;
        string kodenyaproduk;

        public class Category
        {
            public string namaCategory;
            public string idCategory;
        }
        public class Product
        {
            public string idProduct;
            public string namaProduct;
            public long hargaProduct;
            public int stokk;
            public string namaCategory2;
        }

        public void ambilKodeCategory(string namanya)
        {
            foreach(var huhu in listCategory)
            {
                if (huhu.namaCategory == namanya)
                {
                    kodenya = huhu.idCategory;
                }
            }
        }
        public void buatKodeProduct(string baaa)
        {
            int nomernya = 1;
            string hurufnya = baaa.Substring(0, 1).ToUpper();
            foreach (var hehe in listProduct)
            {
                if (hurufnya == hehe.namaProduct.Substring(0, 1).ToUpper())
                {
                    nomernya += 1;
                }
            }
            kodenyaproduk = hurufnya + nomernya.ToString("D3");
        }

        public void updateCategoryBox()
        {
            dtCategory.Clear();
            comboBox_category.Items.Clear();
            comboBox_Filter.Items.Clear();
            int nomernya = 0;
            foreach(var huee in listCategory)
            {
                nomernya += 1;
                huee.idCategory = "C" + nomernya.ToString();
                dtCategory.Rows.Add(huee.idCategory, huee.namaCategory);
                comboBox_category.Items.Add(huee.namaCategory);
                comboBox_Filter.Items.Add(huee.namaCategory);
            }
        }

        public void updateProductsBox()
        {
            dtProdukSimpan.Clear();
            dataGridView_Product.DataSource = dtProdukSimpan;

            foreach (var haiz in listProduct)
            {
                if (haiz.stokk != 0)
                {
                    ambilKodeCategory(haiz.namaCategory2);
                    dtProdukSimpan.Rows.Add(haiz.idProduct, haiz.namaProduct, haiz.hargaProduct, haiz.stokk, kodenya);
                }
            }
        }

        public void updateProductsBoxFilter(string category)
        {
            dtProdukTampil.Clear();
            dataGridView_Product.DataSource = dtProdukTampil;

            foreach (var hoho in listProduct)
            {
                if (hoho.namaCategory2 == category)
                {
                    if (hoho.stokk != 0)
                    {
                        ambilKodeCategory(hoho.namaCategory2);
                        dtProdukTampil.Rows.Add(hoho.idProduct, hoho.namaProduct, hoho.hargaProduct, hoho.stokk, kodenya);
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            dataGridView_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Category.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtProdukTampil.Columns.Add("Product ID");
            dtProdukTampil.Columns.Add("Product Name");
            dtProdukTampil.Columns.Add("Price");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("Category ID");


            dtProdukSimpan.Columns.Add("Product ID");
            dtProdukSimpan.Columns.Add("Product Name");
            dtProdukSimpan.Columns.Add("Price");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("Category ID");

            dtCategory.Columns.Add("Category ID");
            dtCategory.Columns.Add("Category Name");
            dataGridView_Category.DataSource = dtCategory;

            dataGridView_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // yok masukin category dlu beb
            Category category1 = new Category();
            category1.namaCategory = "Jas";
            listCategory.Add(category1);

            Category category2 = new Category();
            category2.namaCategory = "T-shirt";
            listCategory.Add(category2);

            Category category3 = new Category();
            category3.namaCategory = "Rok";
            listCategory.Add(category3);

            Category category4 = new Category();
            category4.namaCategory = "Celana";
            listCategory.Add(category4);

            Category category5 = new Category();
            category5.namaCategory = "Cawat";
            listCategory.Add(category5);

            updateCategoryBox();

            // nah sekarang masukin produkk juseyooo
            Product product1 = new Product();
            product1.namaCategory2 = "Jas";
            product1.namaProduct = "Jas Hitam";
            buatKodeProduct(product1.namaProduct);
            product1.idProduct = kodenyaproduk;
            product1.hargaProduct = 100000;
            product1.stokk = 10;
            listProduct.Add(product1);

            Product product2 = new Product();
            product2.namaCategory2 = "T-shirt";
            product2.namaProduct = "T-shirt Black Pink";
            buatKodeProduct(product2.namaProduct);
            product2.idProduct = kodenyaproduk;
            product2.hargaProduct = 70000;
            product2.stokk = 20;
            listProduct.Add(product2);


            Product product3 = new Product();
            product3.namaCategory2 = "T-shirt";
            product3.namaProduct = "T-shirt Obsessive";
            buatKodeProduct(product3.namaProduct);
            product3.idProduct = kodenyaproduk;
            product3.hargaProduct = 75000;
            product3.stokk = 16;
            listProduct.Add(product3);

            Product product4 = new Product();
            product4.namaCategory2 = "Rok";
            product4.namaProduct = "Rok mini";
            buatKodeProduct(product4.namaProduct);
            product4.idProduct = kodenyaproduk;
            product4.hargaProduct = 82000;
            product4.stokk = 26;
            listProduct.Add(product4);

            Product product5 = new Product();
            product5.namaCategory2 = "Celana";
            product5.namaProduct = "Jeans Biru";
            buatKodeProduct(product5.namaProduct);
            product5.idProduct = kodenyaproduk;
            product5.hargaProduct = 90000;
            product5.stokk = 5;
            listProduct.Add(product5);

            Product product6 = new Product();
            product6.namaCategory2 = "Celana";
            product6.namaProduct = "Celana Pendek Coklat";
            buatKodeProduct(product6.namaProduct);
            product6.idProduct = kodenyaproduk;
            product6.hargaProduct = 60000;
            product6.stokk = 11;
            listProduct.Add(product6);

            Product product7 = new Product();
            product7.namaCategory2 = "Cawat";
            product7.namaProduct = "Cawat Blink -blink";
            buatKodeProduct(product7.namaProduct);
            product7.idProduct = kodenyaproduk;
            product7.hargaProduct = 1000000;
            product7.stokk = 1;
            listProduct.Add(product7);

            Product product8 = new Product();
            product8.namaCategory2 = "T-shirt";
            product8.namaProduct = "Rocca Shirt";
            buatKodeProduct(product8.namaProduct);
            product8.idProduct = kodenyaproduk;
            product8.hargaProduct = 50000;
            product8.stokk = 8;
            listProduct.Add(product8);

            updateProductsBox();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column = dataGridView_Product.Columns[1];
            column.Width = 100;
        }
        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            int cek = 0;
            if (!string.IsNullOrEmpty(textBox_NamaProduct.Text) && 
                !string.IsNullOrEmpty(textBox_price.Text) && !string.IsNullOrEmpty(textBox_stock.Text))
            {
                if (string.IsNullOrEmpty(comboBox_category.Text))
                {   
                    MessageBox.Show("Please select category", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (var hehe in listProduct)
                {
                    if (hehe.namaProduct == textBox_NamaProduct.Text)
                    {
                        cek = 1;
                    }
                }
                if (cek == 0)
                {
                    if (textBox_stock.Text == "0")
                    {
                        MessageBox.Show("Stock must be more than 0", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Product product = new Product();
                        product.namaCategory2 = comboBox_category.Text;
                        product.namaProduct = textBox_NamaProduct.Text;
                        buatKodeProduct(product.namaProduct);
                        product.idProduct = kodenyaproduk;
                        product.hargaProduct = Convert.ToInt64(textBox_price.Text);
                        product.stokk = Convert.ToInt32(textBox_stock.Text);
                        listProduct.Add(product);
                        updateProductsBox();

                        textBox_NamaProduct.Clear();
                        comboBox_category.SelectedItem = null;
                        textBox_price.Clear();
                        textBox_stock.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Product is already in the list!", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            else
            {
                MessageBox.Show("Please enter all details", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_RemoveProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_NamaProduct.Text) &&
                !string.IsNullOrEmpty(textBox_price.Text) && !string.IsNullOrEmpty(textBox_stock.Text))
            {
                if (string.IsNullOrEmpty(comboBox_category.Text))
                {
                    MessageBox.Show("Please select category", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                int nomernya = 0;

                foreach(var hihi in listProduct.ToList())
                {
                    nomernya += 1;
                    if (hihi.namaProduct == textBox_NamaProduct.Text)
                    {
                        listProduct.RemoveAt(nomernya - 1);
                    }
                }

                updateProductsBox();
                textBox_NamaProduct.Clear();
                comboBox_category.SelectedItem = null;
                textBox_price.Clear();
                textBox_stock.Clear();
            }
            else
            {
                MessageBox.Show("Please select product to remove", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_EditProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_NamaProduct.Text) &&
                !string.IsNullOrEmpty(textBox_price.Text) && !string.IsNullOrEmpty(textBox_stock.Text))
            {
                if (string.IsNullOrEmpty(comboBox_category.Text))
                {
                    MessageBox.Show("Please select category", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var blaa in listProduct)
                    {
                        if (textBox_NamaProduct.Text == blaa.namaProduct)
                        {
                            blaa.namaProduct = textBox_NamaProduct.Text;
                            blaa.hargaProduct = Convert.ToInt32(textBox_price.Text);
                            blaa.stokk = Convert.ToInt32(textBox_stock.Text);
                        }
                    }
                    updateProductsBox();
                    textBox_NamaProduct.Clear();
                    comboBox_category.SelectedItem = null;
                    textBox_price.Clear();
                    textBox_stock.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter all details", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_filter_Click(object sender, EventArgs e)
        {
            comboBox_Filter.Enabled = true;
        }

        private void button_All_Click(object sender, EventArgs e)
        {
            comboBox_Filter.Text = "";
            comboBox_Filter.Enabled = false;
            updateProductsBox();
        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button_AddCategory_Click(object sender, EventArgs e)
        {
            int cek = 0;
            if (!string.IsNullOrEmpty(textBox_NamaCategory.Text))
            {
                foreach (var hehe in listCategory)
                {
                    if (hehe.namaCategory == textBox_NamaCategory.Text)
                    {
                        cek = 1;
                    }
                }
                if (cek == 0)
                {
                    Category category = new Category();
                    category.namaCategory = textBox_NamaCategory.Text;
                    listCategory.Add(category);
                    updateCategoryBox();
                    textBox_NamaCategory.Clear();
                }
                else
                {
                    MessageBox.Show("Category is already there..", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter category name", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_RemoveCategory_Click(object sender, EventArgs e)
        {
            int ihh = 0;
            if (!string.IsNullOrEmpty(textBox_NamaCategory.Text))
            {
                foreach(var hehe in listCategory)
                {
                    if (hehe.namaCategory == textBox_NamaCategory.Text)
                    {
                        ihh += 1;
                    }
                }
                if (ihh > 0)
                {
                    listCategory.RemoveAt(dataGridView_Category.CurrentCell.RowIndex);
                    for (int j = 0; j < listCategory.Count; j++)
                    {
                        for (int i = 0; i < listProduct.Count; i++)
                        {
                            if (listProduct[i].namaCategory2 == textBox_NamaCategory.Text)
                            {
                                listProduct.RemoveAt(i);
                            }
                        }
                    }
                    updateCategoryBox();
                    updateProductsBox();
                    textBox_NamaCategory.Clear();
                }
                else
                {
                    MessageBox.Show("Please choose category remove", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter category name to remove", "ndakbisa kak", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView_Product.Rows[index];
            textBox_NamaProduct.Text = selectedrow.Cells[1].Value.ToString();
            textBox_price.Text = selectedrow.Cells[2].Value.ToString();
            textBox_stock.Text = selectedrow.Cells[3].Value.ToString();

            foreach (var hihi in listCategory)
            {
                if (selectedrow.Cells[4].Value.ToString() == hihi.idCategory)
                {
                    comboBox_category.SelectedItem = hihi.namaCategory;
                }
            }
        }

        private void dataGridView_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView_Category.Rows[index];
            textBox_NamaCategory.Text = selectedrow.Cells[1].Value.ToString();
        }

        private void comboBox_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateProductsBoxFilter(comboBox_Filter.SelectedItem.ToString());

            textBox_NamaProduct.Clear();
            comboBox_category.SelectedItem = null;
            textBox_price.Clear();
            textBox_stock.Clear();
        }
    }
}
