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
    public partial class AddReference : Form
    {
        public AddReference()
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

        //Ajouter une nouvelle référence dans la base de données
        private void buttonValidate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCeConnection connection = new SqlCeConnection(@"Data Source=C:\Users\Axel\Documents\Visual Studio 2008\Projects\InventoryApp\InventoryApp\Database.sdf");
                connection.Open();
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [PRODUCTS] (REFERENCE, EXPIRING_DATE, DT_CRE, USER_CRE) values ('"+ ReferenceTextBox.Text + "', '" + Convert.ToDateTime(ExpiringDateTextBox.Text) + "', '" + DateTime.Now + "', 'Axel')";
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                connection.Close();
                ReferenceTextBox.Text = string.Empty;
                ExpiringDateTextBox.Text = string.Empty;
                MessageBox.Show("Reference ajoutée !");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}