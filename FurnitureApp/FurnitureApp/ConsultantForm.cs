using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FurnitureApp
{
    public partial class ConsultantForm : Form
    {
        public ConsultantForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT o.OrderID, c.FirstName + ' ' + c.LastName AS ClientName, 
                               o.OrderDate, o.TotalPrice, o.Status
                        FROM Orders o
                        JOIN Users c ON o.ClientID = c.UserID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable ordersTable = new DataTable();
                    adapter.Fill(ordersTable);
                    dgvOrders.DataSource = ordersTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заказов: {ex.Message}");
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = (int)dgvOrders.SelectedRows[0].Cells["OrderID"].Value;
                EditOrderForm editOrderForm = new EditOrderForm(orderId);
                editOrderForm.ShowDialog();
                LoadOrders(); // Обновить список заказов после редактирования
            }
            else
            {
                MessageBox.Show("Выберите заказ для редактирования.");
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = (int)dgvOrders.SelectedRows[0].Cells["OrderID"].Value;

                DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот заказ?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = Database.GetConnection())
                        {
                            conn.Open();
                            string query = "DELETE FROM Orders WHERE OrderID = @OrderID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@OrderID", orderId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Заказ успешно удалён.");
                            LoadOrders();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка удаления заказа: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ для удаления.");
            }
        }
    }
}
