using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Inventaire : Form
    {
        public Inventaire()
        {
            InitializeComponent();
            
        }

        private void Inventaire_Load(object sender, EventArgs e)
        {
            try
            {
                if (ProductsDatasetUtil.DesignerUtil.IsRunTime())
                {
                    //TODO: Delete this line of code to remove the default AutoFill for 'productsDataset.PRODUCTS'.
                    this.pRODUCTSTableAdapter.Fill(this.productsDataset.PRODUCTS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pRODUCTSDataGrid_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var formpopup = new Form();
                formpopup.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}