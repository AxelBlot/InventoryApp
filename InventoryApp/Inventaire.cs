using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace InventoryApp
{
    public partial class Inventaire : Form
    {
        SqlCeConnection connection = new SqlCeConnection(@"Data Source=C:\Users\Axel\Documents\Visual Studio 2008\Projects\InventoryApp\InventoryApp\Database.sdf");

        public Inventaire()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Inventaire_Load(object sender, EventArgs e)
        {
            try
            {
                if (ProductsDatasetUtil.DesignerUtil.IsRunTime())
                {
                    this.pRODUCTSTableAdapter.FillByExistingDate(this.productsDataset.PRODUCTS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pRODUCTSDataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var add = new AddReference();
                add.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [PRODUCTS] order by [EXPIRING_DATE] asc";
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.pRODUCTSTableAdapter.FillByExistingDate(this.productsDataset.PRODUCTS);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}