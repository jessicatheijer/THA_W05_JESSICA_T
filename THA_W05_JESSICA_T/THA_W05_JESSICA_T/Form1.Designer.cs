namespace THA_W05_JESSICA_T
{
    partial class Form1
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
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.dataGridView_Category = new System.Windows.Forms.DataGridView();
            this.label_Product = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_Details = new System.Windows.Forms.Label();
            this.label_Nama1 = new System.Windows.Forms.Label();
            this.label_Category2 = new System.Windows.Forms.Label();
            this.label_harga = new System.Windows.Forms.Label();
            this.label_stock = new System.Windows.Forms.Label();
            this.label_Nama2 = new System.Windows.Forms.Label();
            this.button_All = new System.Windows.Forms.Button();
            this.button_filter = new System.Windows.Forms.Button();
            this.textBox_NamaProduct = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.textBox_NamaCategory = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.button_AddProduct = new System.Windows.Forms.Button();
            this.button_EditProduct = new System.Windows.Forms.Button();
            this.button_RemoveProduct = new System.Windows.Forms.Button();
            this.button_AddCategory = new System.Windows.Forms.Button();
            this.button_RemoveCategory = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.AllowUserToAddRows = false;
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product.Location = new System.Drawing.Point(18, 84);
            this.dataGridView_Product.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.ReadOnly = true;
            this.dataGridView_Product.RowHeadersVisible = false;
            this.dataGridView_Product.RowHeadersWidth = 62;
            this.dataGridView_Product.RowTemplate.Height = 28;
            this.dataGridView_Product.Size = new System.Drawing.Size(352, 212);
            this.dataGridView_Product.TabIndex = 0;
            this.dataGridView_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Product_CellClick);
            // 
            // dataGridView_Category
            // 
            this.dataGridView_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Category.Location = new System.Drawing.Point(385, 84);
            this.dataGridView_Category.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Category.Name = "dataGridView_Category";
            this.dataGridView_Category.ReadOnly = true;
            this.dataGridView_Category.RowHeadersVisible = false;
            this.dataGridView_Category.RowHeadersWidth = 62;
            this.dataGridView_Category.RowTemplate.Height = 28;
            this.dataGridView_Category.Size = new System.Drawing.Size(205, 145);
            this.dataGridView_Category.TabIndex = 1;
            this.dataGridView_Category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Category_CellClick);
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Font = new System.Drawing.Font("Chaparral Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Product.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_Product.Location = new System.Drawing.Point(14, 63);
            this.label_Product.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(67, 20);
            this.label_Product.TabIndex = 2;
            this.label_Product.Text = "Product";
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Font = new System.Drawing.Font("Chaparral Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label_Category.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_Category.Location = new System.Drawing.Point(381, 62);
            this.label_Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(75, 20);
            this.label_Category.TabIndex = 3;
            this.label_Category.Text = "Category";
            // 
            // label_Details
            // 
            this.label_Details.AutoSize = true;
            this.label_Details.Font = new System.Drawing.Font("Chaparral Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label_Details.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_Details.Location = new System.Drawing.Point(19, 314);
            this.label_Details.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Details.Name = "label_Details";
            this.label_Details.Size = new System.Drawing.Size(60, 20);
            this.label_Details.TabIndex = 4;
            this.label_Details.Text = "Details";
            // 
            // label_Nama1
            // 
            this.label_Nama1.AutoSize = true;
            this.label_Nama1.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nama1.Location = new System.Drawing.Point(21, 338);
            this.label_Nama1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Nama1.Name = "label_Nama1";
            this.label_Nama1.Size = new System.Drawing.Size(39, 14);
            this.label_Nama1.TabIndex = 5;
            this.label_Nama1.Text = "Name:";
            // 
            // label_Category2
            // 
            this.label_Category2.AutoSize = true;
            this.label_Category2.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Italic);
            this.label_Category2.Location = new System.Drawing.Point(20, 366);
            this.label_Category2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Category2.Name = "label_Category2";
            this.label_Category2.Size = new System.Drawing.Size(56, 14);
            this.label_Category2.TabIndex = 6;
            this.label_Category2.Text = "Category:";
            // 
            // label_harga
            // 
            this.label_harga.AutoSize = true;
            this.label_harga.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Italic);
            this.label_harga.Location = new System.Drawing.Point(21, 393);
            this.label_harga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_harga.Name = "label_harga";
            this.label_harga.Size = new System.Drawing.Size(35, 14);
            this.label_harga.TabIndex = 7;
            this.label_harga.Text = "Price:";
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Italic);
            this.label_stock.Location = new System.Drawing.Point(20, 421);
            this.label_stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(37, 14);
            this.label_stock.TabIndex = 8;
            this.label_stock.Text = "Stock:";
            // 
            // label_Nama2
            // 
            this.label_Nama2.AutoSize = true;
            this.label_Nama2.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Italic);
            this.label_Nama2.Location = new System.Drawing.Point(384, 250);
            this.label_Nama2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Nama2.Name = "label_Nama2";
            this.label_Nama2.Size = new System.Drawing.Size(39, 14);
            this.label_Nama2.TabIndex = 9;
            this.label_Nama2.Text = "Name:";
            // 
            // button_All
            // 
            this.button_All.Font = new System.Drawing.Font("Chaparral Pro", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_All.Location = new System.Drawing.Point(182, 60);
            this.button_All.Margin = new System.Windows.Forms.Padding(2);
            this.button_All.Name = "button_All";
            this.button_All.Size = new System.Drawing.Size(33, 20);
            this.button_All.TabIndex = 10;
            this.button_All.Text = "All";
            this.button_All.UseVisualStyleBackColor = true;
            this.button_All.Click += new System.EventHandler(this.button_All_Click);
            // 
            // button_filter
            // 
            this.button_filter.Font = new System.Drawing.Font("Chaparral Pro", 7.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_filter.ForeColor = System.Drawing.Color.Black;
            this.button_filter.Location = new System.Drawing.Point(219, 60);
            this.button_filter.Margin = new System.Windows.Forms.Padding(2);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(49, 20);
            this.button_filter.TabIndex = 11;
            this.button_filter.Text = "Filter:";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // textBox_NamaProduct
            // 
            this.textBox_NamaProduct.Location = new System.Drawing.Point(83, 335);
            this.textBox_NamaProduct.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NamaProduct.Name = "textBox_NamaProduct";
            this.textBox_NamaProduct.Size = new System.Drawing.Size(221, 20);
            this.textBox_NamaProduct.TabIndex = 12;
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(83, 391);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(113, 20);
            this.textBox_price.TabIndex = 13;
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_price_KeyPress);
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(83, 419);
            this.textBox_stock.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(113, 20);
            this.textBox_stock.TabIndex = 14;
            this.textBox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_stock_KeyPress);
            // 
            // textBox_NamaCategory
            // 
            this.textBox_NamaCategory.Location = new System.Drawing.Point(425, 246);
            this.textBox_NamaCategory.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NamaCategory.Name = "textBox_NamaCategory";
            this.textBox_NamaCategory.Size = new System.Drawing.Size(165, 20);
            this.textBox_NamaCategory.TabIndex = 15;
            // 
            // comboBox_category
            // 
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(83, 362);
            this.comboBox_category.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(113, 21);
            this.comboBox_category.TabIndex = 16;
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.Enabled = false;
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Location = new System.Drawing.Point(272, 59);
            this.comboBox_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(88, 21);
            this.comboBox_Filter.TabIndex = 17;
            this.comboBox_Filter.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_SelectedIndexChanged);
            // 
            // button_AddProduct
            // 
            this.button_AddProduct.BackColor = System.Drawing.Color.Chartreuse;
            this.button_AddProduct.Font = new System.Drawing.Font("Rockwell", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_AddProduct.Location = new System.Drawing.Point(209, 362);
            this.button_AddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddProduct.Name = "button_AddProduct";
            this.button_AddProduct.Size = new System.Drawing.Size(95, 38);
            this.button_AddProduct.TabIndex = 18;
            this.button_AddProduct.Text = "Add Product";
            this.button_AddProduct.UseVisualStyleBackColor = false;
            this.button_AddProduct.Click += new System.EventHandler(this.button_AddProduct_Click);
            // 
            // button_EditProduct
            // 
            this.button_EditProduct.BackColor = System.Drawing.Color.Yellow;
            this.button_EditProduct.Font = new System.Drawing.Font("Rockwell", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_EditProduct.Location = new System.Drawing.Point(210, 402);
            this.button_EditProduct.Margin = new System.Windows.Forms.Padding(2);
            this.button_EditProduct.Name = "button_EditProduct";
            this.button_EditProduct.Size = new System.Drawing.Size(45, 38);
            this.button_EditProduct.TabIndex = 19;
            this.button_EditProduct.Text = "Edit";
            this.button_EditProduct.UseVisualStyleBackColor = false;
            this.button_EditProduct.Click += new System.EventHandler(this.button_EditProduct_Click);
            // 
            // button_RemoveProduct
            // 
            this.button_RemoveProduct.BackColor = System.Drawing.Color.Tomato;
            this.button_RemoveProduct.Font = new System.Drawing.Font("Rockwell", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveProduct.Location = new System.Drawing.Point(259, 402);
            this.button_RemoveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.button_RemoveProduct.Name = "button_RemoveProduct";
            this.button_RemoveProduct.Size = new System.Drawing.Size(45, 38);
            this.button_RemoveProduct.TabIndex = 21;
            this.button_RemoveProduct.Text = "Remove";
            this.button_RemoveProduct.UseVisualStyleBackColor = false;
            this.button_RemoveProduct.Click += new System.EventHandler(this.button_RemoveProduct_Click);
            // 
            // button_AddCategory
            // 
            this.button_AddCategory.BackColor = System.Drawing.Color.Chartreuse;
            this.button_AddCategory.Font = new System.Drawing.Font("Rockwell", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_AddCategory.Location = new System.Drawing.Point(457, 274);
            this.button_AddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddCategory.Name = "button_AddCategory";
            this.button_AddCategory.Size = new System.Drawing.Size(66, 41);
            this.button_AddCategory.TabIndex = 22;
            this.button_AddCategory.Text = "Add Category";
            this.button_AddCategory.UseVisualStyleBackColor = false;
            this.button_AddCategory.Click += new System.EventHandler(this.button_AddCategory_Click);
            // 
            // button_RemoveCategory
            // 
            this.button_RemoveCategory.BackColor = System.Drawing.Color.Tomato;
            this.button_RemoveCategory.Font = new System.Drawing.Font("Rockwell", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_RemoveCategory.Location = new System.Drawing.Point(524, 274);
            this.button_RemoveCategory.Margin = new System.Windows.Forms.Padding(2);
            this.button_RemoveCategory.Name = "button_RemoveCategory";
            this.button_RemoveCategory.Size = new System.Drawing.Size(66, 41);
            this.button_RemoveCategory.TabIndex = 23;
            this.button_RemoveCategory.Text = "Remove Category";
            this.button_RemoveCategory.UseVisualStyleBackColor = false;
            this.button_RemoveCategory.Click += new System.EventHandler(this.button_RemoveCategory_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.GreenYellow;
            this.label_Title.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.DarkGreen;
            this.label_Title.Location = new System.Drawing.Point(214, 15);
            this.label_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(204, 27);
            this.label_Title.TabIndex = 24;
            this.label_Title.Text = "DREAMIES SHOP";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::THA_W05_JESSICA_T.Properties.Resources.imgonline_com_ua_resize_2HJ9zXA54J;
            this.pictureBox4.Location = new System.Drawing.Point(42, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::THA_W05_JESSICA_T.Properties.Resources.imgonline_com_ua_resize_QsC2un0yZPYrty;
            this.pictureBox3.Location = new System.Drawing.Point(459, 328);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 136);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::THA_W05_JESSICA_T.Properties.Resources.imgonline_com_ua_resize_rCHUE3I9ZXJiCc;
            this.pictureBox1.Location = new System.Drawing.Point(185, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::THA_W05_JESSICA_T.Properties.Resources.imgonline_com_ua_resize_rCHUE3I9ZXJiCc;
            this.pictureBox2.Location = new System.Drawing.Point(422, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::THA_W05_JESSICA_T.Properties.Resources.imgonline_com_ua_resize_YQ5XwCrukBQBD;
            this.pictureBox6.Location = new System.Drawing.Point(522, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(76, 73);
            this.pictureBox6.TabIndex = 32;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::THA_W05_JESSICA_T.Properties.Resources.imgonline_com_ua_resize_WXrOK0vjhy5x2Z;
            this.pictureBox5.Location = new System.Drawing.Point(348, 352);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(115, 112);
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::THA_W05_JESSICA_T.Properties.Resources.imgonline_com_ua_resize_oOzXKzeg3ovltg;
            this.pictureBox7.Location = new System.Drawing.Point(318, 310);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 77);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 33;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(607, 462);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_RemoveCategory);
            this.Controls.Add(this.button_AddCategory);
            this.Controls.Add(this.button_RemoveProduct);
            this.Controls.Add(this.button_EditProduct);
            this.Controls.Add(this.button_AddProduct);
            this.Controls.Add(this.comboBox_Filter);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.textBox_NamaCategory);
            this.Controls.Add(this.textBox_stock);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_NamaProduct);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.button_All);
            this.Controls.Add(this.label_Nama2);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.label_harga);
            this.Controls.Add(this.label_Category2);
            this.Controls.Add(this.label_Nama1);
            this.Controls.Add(this.label_Details);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_Product);
            this.Controls.Add(this.dataGridView_Category);
            this.Controls.Add(this.dataGridView_Product);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Product;
        private System.Windows.Forms.DataGridView dataGridView_Category;
        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_Details;
        private System.Windows.Forms.Label label_Nama1;
        private System.Windows.Forms.Label label_Category2;
        private System.Windows.Forms.Label label_harga;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.Label label_Nama2;
        private System.Windows.Forms.Button button_All;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.TextBox textBox_NamaProduct;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.TextBox textBox_NamaCategory;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.ComboBox comboBox_Filter;
        private System.Windows.Forms.Button button_AddProduct;
        private System.Windows.Forms.Button button_EditProduct;
        private System.Windows.Forms.Button button_RemoveProduct;
        private System.Windows.Forms.Button button_AddCategory;
        private System.Windows.Forms.Button button_RemoveCategory;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

