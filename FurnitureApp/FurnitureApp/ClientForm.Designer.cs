namespace FurnitureApp
{
    partial class ClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnCreateOrder;

        private void InitializeComponent()
        {
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnCreateOrder = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // dgvOrders
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(20, 20);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(560, 200);
            this.dgvOrders.TabIndex = 0;

            // dgvProducts
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(20, 240);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(560, 200);
            this.dgvProducts.TabIndex = 1;

            // btnCreateOrder
            this.btnCreateOrder.Location = new System.Drawing.Point(20, 460);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(160, 40);
            this.btnCreateOrder.TabIndex = 2;
            this.btnCreateOrder.Text = "Создать заказ";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);

            // ClientForm
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnCreateOrder);
            this.Name = "ClientForm";
            this.Text = "Клиентская панель";
            this.ResumeLayout(false);
        }
    }
}
