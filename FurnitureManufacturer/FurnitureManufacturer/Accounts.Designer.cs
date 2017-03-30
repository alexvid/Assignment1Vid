namespace FurnitureManufacturer
{
    partial class Accounts
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
            this.lblUser = new System.Windows.Forms.Label();
            this.panProduct = new System.Windows.Forms.Panel();
            this.txtIdProduct = new System.Windows.Forms.TextBox();
            this.lblIdProduct = new System.Windows.Forms.Label();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtDescriptionProduct = new System.Windows.Forms.TextBox();
            this.txtStockProduct = new System.Windows.Forms.TextBox();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.lblDescriptionProduct = new System.Windows.Forms.Label();
            this.lblStockProduct = new System.Windows.Forms.Label();
            this.lblPriceProduct = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.gridProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIDProduct2 = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnDeleteFromOrder = new System.Windows.Forms.Button();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblIDProduct2 = new System.Windows.Forms.Label();
            this.lblIDOrder2 = new System.Windows.Forms.Label();
            this.txtIDOrder2 = new System.Windows.Forms.TextBox();
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Label();
            this.gridProducts2 = new System.Windows.Forms.DataGridView();
            this.lblProd = new System.Windows.Forms.Label();
            this.txtIDOrder = new System.Windows.Forms.TextBox();
            this.lblIDOrder = new System.Windows.Forms.Label();
            this.dateDelivery = new System.Windows.Forms.DateTimePicker();
            this.panProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(21, 21);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 0;
            // 
            // panProduct
            // 
            this.panProduct.Controls.Add(this.txtIdProduct);
            this.panProduct.Controls.Add(this.lblIdProduct);
            this.panProduct.Controls.Add(this.btnViewProduct);
            this.panProduct.Controls.Add(this.btnDeleteProduct);
            this.panProduct.Controls.Add(this.btnUpdateProduct);
            this.panProduct.Controls.Add(this.btnAddProduct);
            this.panProduct.Controls.Add(this.txtDescriptionProduct);
            this.panProduct.Controls.Add(this.txtStockProduct);
            this.panProduct.Controls.Add(this.txtPriceProduct);
            this.panProduct.Controls.Add(this.txtNameProduct);
            this.panProduct.Controls.Add(this.lblDescriptionProduct);
            this.panProduct.Controls.Add(this.lblStockProduct);
            this.panProduct.Controls.Add(this.lblPriceProduct);
            this.panProduct.Controls.Add(this.lblNameProduct);
            this.panProduct.Controls.Add(this.gridProduct);
            this.panProduct.Location = new System.Drawing.Point(12, 37);
            this.panProduct.Name = "panProduct";
            this.panProduct.Size = new System.Drawing.Size(548, 429);
            this.panProduct.TabIndex = 1;
            // 
            // txtIdProduct
            // 
            this.txtIdProduct.Location = new System.Drawing.Point(85, 24);
            this.txtIdProduct.Name = "txtIdProduct";
            this.txtIdProduct.Size = new System.Drawing.Size(100, 20);
            this.txtIdProduct.TabIndex = 31;
            // 
            // lblIdProduct
            // 
            this.lblIdProduct.AutoSize = true;
            this.lblIdProduct.Location = new System.Drawing.Point(25, 27);
            this.lblIdProduct.Name = "lblIdProduct";
            this.lblIdProduct.Size = new System.Drawing.Size(19, 13);
            this.lblIdProduct.TabIndex = 30;
            this.lblIdProduct.Text = "Id:";
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Location = new System.Drawing.Point(378, 85);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(75, 23);
            this.btnViewProduct.TabIndex = 29;
            this.btnViewProduct.Text = "View";
            this.btnViewProduct.UseVisualStyleBackColor = true;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(249, 85);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 28;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(378, 24);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProduct.TabIndex = 27;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(249, 24);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 26;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtDescriptionProduct
            // 
            this.txtDescriptionProduct.Location = new System.Drawing.Point(85, 167);
            this.txtDescriptionProduct.Name = "txtDescriptionProduct";
            this.txtDescriptionProduct.Size = new System.Drawing.Size(449, 20);
            this.txtDescriptionProduct.TabIndex = 25;
            // 
            // txtStockProduct
            // 
            this.txtStockProduct.Location = new System.Drawing.Point(85, 127);
            this.txtStockProduct.Name = "txtStockProduct";
            this.txtStockProduct.Size = new System.Drawing.Size(100, 20);
            this.txtStockProduct.TabIndex = 24;
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Location = new System.Drawing.Point(85, 88);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(100, 20);
            this.txtPriceProduct.TabIndex = 23;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(85, 56);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(100, 20);
            this.txtNameProduct.TabIndex = 22;
            // 
            // lblDescriptionProduct
            // 
            this.lblDescriptionProduct.AutoSize = true;
            this.lblDescriptionProduct.Location = new System.Drawing.Point(16, 170);
            this.lblDescriptionProduct.Name = "lblDescriptionProduct";
            this.lblDescriptionProduct.Size = new System.Drawing.Size(63, 13);
            this.lblDescriptionProduct.TabIndex = 21;
            this.lblDescriptionProduct.Text = "Description:";
            // 
            // lblStockProduct
            // 
            this.lblStockProduct.AutoSize = true;
            this.lblStockProduct.Location = new System.Drawing.Point(28, 130);
            this.lblStockProduct.Name = "lblStockProduct";
            this.lblStockProduct.Size = new System.Drawing.Size(38, 13);
            this.lblStockProduct.TabIndex = 20;
            this.lblStockProduct.Text = "Stock:";
            // 
            // lblPriceProduct
            // 
            this.lblPriceProduct.AutoSize = true;
            this.lblPriceProduct.Location = new System.Drawing.Point(29, 91);
            this.lblPriceProduct.Name = "lblPriceProduct";
            this.lblPriceProduct.Size = new System.Drawing.Size(34, 13);
            this.lblPriceProduct.TabIndex = 19;
            this.lblPriceProduct.Text = "Price:";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Location = new System.Drawing.Point(25, 59);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(38, 13);
            this.lblNameProduct.TabIndex = 18;
            this.lblNameProduct.Text = "Name:";
            // 
            // gridProduct
            // 
            this.gridProduct.AllowUserToAddRows = false;
            this.gridProduct.AllowUserToDeleteRows = false;
            this.gridProduct.AllowUserToResizeColumns = false;
            this.gridProduct.AllowUserToResizeRows = false;
            this.gridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduct.Location = new System.Drawing.Point(3, 228);
            this.gridProduct.MultiSelect = false;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ReadOnly = true;
            this.gridProduct.RowHeadersVisible = false;
            this.gridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduct.Size = new System.Drawing.Size(542, 198);
            this.gridProduct.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateDelivery);
            this.panel1.Controls.Add(this.txtIDOrder);
            this.panel1.Controls.Add(this.lblIDOrder);
            this.panel1.Controls.Add(this.lblProd);
            this.panel1.Controls.Add(this.gridProducts2);
            this.panel1.Controls.Add(this.txtIDProduct2);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.btnDeleteFromOrder);
            this.panel1.Controls.Add(this.btnAddToOrder);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.lblIDProduct2);
            this.panel1.Controls.Add(this.lblIDOrder2);
            this.panel1.Controls.Add(this.txtIDOrder2);
            this.panel1.Controls.Add(this.gridOrder);
            this.panel1.Controls.Add(this.lblDelivery);
            this.panel1.Controls.Add(this.btnViewOrder);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.btnUpdateOrder);
            this.panel1.Controls.Add(this.btnAddOrder);
            this.panel1.Controls.Add(this.txtCustomer);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Location = new System.Drawing.Point(566, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 429);
            this.panel1.TabIndex = 2;
            // 
            // txtIDProduct2
            // 
            this.txtIDProduct2.Location = new System.Drawing.Point(438, 21);
            this.txtIDProduct2.Name = "txtIDProduct2";
            this.txtIDProduct2.Size = new System.Drawing.Size(57, 20);
            this.txtIDProduct2.TabIndex = 59;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(438, 93);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(57, 20);
            this.txtQuantity.TabIndex = 58;
            // 
            // btnDeleteFromOrder
            // 
            this.btnDeleteFromOrder.Location = new System.Drawing.Point(439, 143);
            this.btnDeleteFromOrder.Name = "btnDeleteFromOrder";
            this.btnDeleteFromOrder.Size = new System.Drawing.Size(58, 23);
            this.btnDeleteFromOrder.TabIndex = 57;
            this.btnDeleteFromOrder.Text = "Delete";
            this.btnDeleteFromOrder.UseVisualStyleBackColor = true;
            this.btnDeleteFromOrder.Click += new System.EventHandler(this.btnDeleteFromOrder_Click);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(341, 143);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(58, 23);
            this.btnAddToOrder.TabIndex = 56;
            this.btnAddToOrder.Text = "Add";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(378, 93);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 55;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblIDProduct2
            // 
            this.lblIDProduct2.AutoSize = true;
            this.lblIDProduct2.Location = new System.Drawing.Point(378, 25);
            this.lblIDProduct2.Name = "lblIDProduct2";
            this.lblIDProduct2.Size = new System.Drawing.Size(58, 13);
            this.lblIDProduct2.TabIndex = 47;
            this.lblIDProduct2.Text = "IDProduct:";
            // 
            // lblIDOrder2
            // 
            this.lblIDOrder2.AutoSize = true;
            this.lblIDOrder2.Location = new System.Drawing.Point(382, 57);
            this.lblIDOrder2.Name = "lblIDOrder2";
            this.lblIDOrder2.Size = new System.Drawing.Size(47, 13);
            this.lblIDOrder2.TabIndex = 48;
            this.lblIDOrder2.Text = "IDOrder:";
            // 
            // txtIDOrder2
            // 
            this.txtIDOrder2.Location = new System.Drawing.Point(438, 54);
            this.txtIDOrder2.Name = "txtIDOrder2";
            this.txtIDOrder2.Size = new System.Drawing.Size(57, 20);
            this.txtIDOrder2.TabIndex = 50;
            // 
            // gridOrder
            // 
            this.gridOrder.AllowUserToAddRows = false;
            this.gridOrder.AllowUserToDeleteRows = false;
            this.gridOrder.AllowUserToResizeColumns = false;
            this.gridOrder.AllowUserToResizeRows = false;
            this.gridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrder.Location = new System.Drawing.Point(14, 228);
            this.gridOrder.MultiSelect = false;
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.ReadOnly = true;
            this.gridOrder.RowHeadersVisible = false;
            this.gridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrder.Size = new System.Drawing.Size(333, 198);
            this.gridOrder.TabIndex = 32;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(11, 124);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(48, 13);
            this.lblDelivery.TabIndex = 46;
            this.lblDelivery.Text = "Delivery:";
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(251, 104);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(58, 23);
            this.btnViewOrder.TabIndex = 43;
            this.btnViewOrder.Text = "View";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(11, 56);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(54, 13);
            this.lblCustomer.TabIndex = 32;
            this.lblCustomer.Text = "Customer:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 88);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 33;
            this.lblAddress.Text = "Address:";
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(251, 59);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(58, 23);
            this.btnUpdateOrder.TabIndex = 41;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(251, 17);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(58, 23);
            this.btnAddOrder.TabIndex = 40;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(71, 53);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(83, 20);
            this.txtCustomer.TabIndex = 36;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(71, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(138, 20);
            this.txtAddress.TabIndex = 37;
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.Location = new System.Drawing.Point(12, 17);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(77, 17);
            this.Product.TabIndex = 18;
            this.Product.Text = "Products:";
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.Location = new System.Drawing.Point(563, 17);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(55, 17);
            this.Order.TabIndex = 19;
            this.Order.Text = "Order:";
            // 
            // gridProducts2
            // 
            this.gridProducts2.AllowUserToAddRows = false;
            this.gridProducts2.AllowUserToDeleteRows = false;
            this.gridProducts2.AllowUserToResizeColumns = false;
            this.gridProducts2.AllowUserToResizeRows = false;
            this.gridProducts2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts2.Location = new System.Drawing.Point(363, 228);
            this.gridProducts2.MultiSelect = false;
            this.gridProducts2.Name = "gridProducts2";
            this.gridProducts2.ReadOnly = true;
            this.gridProducts2.RowHeadersVisible = false;
            this.gridProducts2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts2.Size = new System.Drawing.Size(202, 198);
            this.gridProducts2.TabIndex = 60;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(360, 208);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(61, 13);
            this.lblProd.TabIndex = 20;
            this.lblProd.Text = "Products:";
            // 
            // txtIDOrder
            // 
            this.txtIDOrder.Location = new System.Drawing.Point(71, 17);
            this.txtIDOrder.Name = "txtIDOrder";
            this.txtIDOrder.Size = new System.Drawing.Size(100, 20);
            this.txtIDOrder.TabIndex = 33;
            // 
            // lblIDOrder
            // 
            this.lblIDOrder.AutoSize = true;
            this.lblIDOrder.Location = new System.Drawing.Point(11, 20);
            this.lblIDOrder.Name = "lblIDOrder";
            this.lblIDOrder.Size = new System.Drawing.Size(19, 13);
            this.lblIDOrder.TabIndex = 32;
            this.lblIDOrder.Text = "Id:";
            // 
            // dateDelivery
            // 
            this.dateDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDelivery.Location = new System.Drawing.Point(71, 123);
            this.dateDelivery.Name = "dateDelivery";
            this.dateDelivery.Size = new System.Drawing.Size(136, 20);
            this.dateDelivery.TabIndex = 20;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 478);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panProduct);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.panProduct.ResumeLayout(false);
            this.panProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridProduct;
        private System.Windows.Forms.Label lblDescriptionProduct;
        private System.Windows.Forms.Label lblStockProduct;
        private System.Windows.Forms.Label lblPriceProduct;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtDescriptionProduct;
        private System.Windows.Forms.TextBox txtStockProduct;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtIdProduct;
        private System.Windows.Forms.Label lblIdProduct;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblIDProduct2;
        private System.Windows.Forms.Label lblIDOrder2;
        private System.Windows.Forms.TextBox txtIDOrder2;
        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.TextBox txtIDProduct2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnDeleteFromOrder;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.DataGridView gridProducts2;
        private System.Windows.Forms.TextBox txtIDOrder;
        private System.Windows.Forms.Label lblIDOrder;
        private System.Windows.Forms.DateTimePicker dateDelivery;
    }
}