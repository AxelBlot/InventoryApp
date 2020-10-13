namespace InventoryApp
{
    partial class AddReference
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label rEFERENCELabel;
            System.Windows.Forms.Label eXPIRING_DATELabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.ReferenceTextBox = new System.Windows.Forms.TextBox();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataset = new InventoryApp.ProductsDataset();
            this.ExpiringDateTextBox = new System.Windows.Forms.TextBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.pRODUCTSTableAdapter = new InventoryApp.ProductsDatasetTableAdapters.PRODUCTSTableAdapter();
            rEFERENCELabel = new System.Windows.Forms.Label();
            eXPIRING_DATELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // rEFERENCELabel
            // 
            rEFERENCELabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            rEFERENCELabel.Location = new System.Drawing.Point(3, 29);
            rEFERENCELabel.Name = "rEFERENCELabel";
            rEFERENCELabel.Size = new System.Drawing.Size(122, 20);
            rEFERENCELabel.Text = "REFERENCE:";
            // 
            // eXPIRING_DATELabel
            // 
            eXPIRING_DATELabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            eXPIRING_DATELabel.Location = new System.Drawing.Point(3, 59);
            eXPIRING_DATELabel.Name = "eXPIRING_DATELabel";
            eXPIRING_DATELabel.Size = new System.Drawing.Size(157, 20);
            eXPIRING_DATELabel.Text = "DATE D\'EXPIRATION:";
            // 
            // ReferenceTextBox
            // 
            this.ReferenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTSBindingSource, "REFERENCE", true));
            this.ReferenceTextBox.Location = new System.Drawing.Point(162, 26);
            this.ReferenceTextBox.Name = "ReferenceTextBox";
            this.ReferenceTextBox.Size = new System.Drawing.Size(100, 23);
            this.ReferenceTextBox.TabIndex = 3;
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.productsDataset;
            // 
            // productsDataset
            // 
            this.productsDataset.DataSetName = "ProductsDataset";
            this.productsDataset.Prefix = "";
            this.productsDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExpiringDateTextBox
            // 
            this.ExpiringDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pRODUCTSBindingSource, "EXPIRING_DATE", true));
            this.ExpiringDateTextBox.Location = new System.Drawing.Point(162, 55);
            this.ExpiringDateTextBox.Name = "ExpiringDateTextBox";
            this.ExpiringDateTextBox.Size = new System.Drawing.Size(100, 23);
            this.ExpiringDateTextBox.TabIndex = 5;
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(162, 104);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(100, 24);
            this.buttonValidate.TabIndex = 6;
            this.buttonValidate.Text = "Valider";
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // AddReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(349, 243);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(rEFERENCELabel);
            this.Controls.Add(this.ReferenceTextBox);
            this.Controls.Add(eXPIRING_DATELabel);
            this.Controls.Add(this.ExpiringDateTextBox);
            this.Menu = this.mainMenu1;
            this.Name = "AddReference";
            this.Text = "AddReference";
            this.ResumeLayout(false);

        }

        #endregion

        private ProductsDataset productsDataset;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private InventoryApp.ProductsDatasetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.TextBox ReferenceTextBox;
        private System.Windows.Forms.TextBox ExpiringDateTextBox;
        private System.Windows.Forms.Button buttonValidate;
    }
}