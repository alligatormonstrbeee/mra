using System;
using System.Windows.Forms;

namespace FurnitureApp
{
    public partial class AdminForm : Form
    {
        private int userId;

        public AdminForm(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Сохраняем ID пользователя
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Логика для загрузки данных администратора
            MessageBox.Show($"Добро пожаловать, администратор с ID: {userId}!");

            // Здесь можно загрузить информацию о складах и предоставить функционал удаления пользователей
            LoadWarehouseInfo();
        }

        private void LoadWarehouseInfo()
        {
            // Пример отображения информации о складах (можно заменить на данные из БД)
            string warehouses = "Склад Москва: г. Москва, ул. Строителей, д. 1\n" +
                                "Склад СПб: г. Санкт-Петербург, ул. Заводская, д. 5\n" +
                                "Склад Казань: г. Казань, ул. Лесная, д. 12\n" +
                                "Склад Екатеринбург: г. Екатеринбург, ул. Карла Маркса, д. 8\n" +
                                "Склад Новосибирск: г. Новосибирск, ул. Лермонтова, д. 9";
            MessageBox.Show(warehouses, "Информация о складах", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
