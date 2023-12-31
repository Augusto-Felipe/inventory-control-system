﻿using InventoryControlSystem.Entities;
using InventoryControlSystem.Repositories;

namespace InventoryControlSystem
{
    public partial class EditProduct : Form
    {
        public EventHandler DataEdited;

        public EditProduct()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            List<Product> list = ProductRepository.Instance.ListProducts();

            string newProductName = txt_newName.Text;
            int productID = int.Parse(txt_id.Text);

            foreach (Product product in list)
            {
                if (product.Id == productID)
                {
                    product.Name = newProductName;
                    DataEdited.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Produto Alterado com sucesso!");
                }
            }

            this.Close();
        }
    }
}
