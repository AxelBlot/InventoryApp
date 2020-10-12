using System.Windows.Forms;
namespace InventoryApp
{
    partial class Inventaire
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
            System.Windows.Forms.DataGrid ProductsDataGrid;
            System.Windows.Forms.DataGridTextBoxColumn rEFERENCEDataGridColumnStyleDataGridTextBoxColumn;
            System.Windows.Forms.DataGridTextBoxColumn eXPIRING_DATEDataGridColumnStyleDataGridTextBoxColumn;
            this.ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataset = new InventoryApp.ProductsDataset();
            this.pRODUCTSTableStyleDataGridTableStyle = new System.Windows.Forms.DataGridTableStyle();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pRODUCTSTableAdapter = new InventoryApp.ProductsDatasetTableAdapters.PRODUCTSTableAdapter();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            ProductsDataGrid = new System.Windows.Forms.DataGrid();
            rEFERENCEDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            eXPIRING_DATEDataGridColumnStyleDataGridTextBoxColumn = new System.Windows.Forms.DataGridTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsBindingSource
            // 
            this.ProductsBindingSource.DataMember = "PRODUCTS";
            this.ProductsBindingSource.DataSource = this.productsDataset;
            // 
            // ProductsDataGrid
            // 
            ProductsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            ProductsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            ProductsDataGrid.DataSource = this.ProductsBindingSource;
            ProductsDataGrid.Location = new System.Drawing.Point(0, 90);
            ProductsDataGrid.Name = "ProductsDataGrid";
            ProductsDataGrid.Size = new System.Drawing.Size(545, 255);
            ProductsDataGrid.TabIndex = 0;
            ProductsDataGrid.TableStyles.Add(this.pRODUCTSTableStyleDataGridTableStyle);
            // 
            // productsDataset
            // 
            this.productsDataset.DataSetName = "ProductsDataset";
            this.productsDataset.Prefix = "";
            this.productsDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTSTableStyleDataGridTableStyle
            // 
            this.pRODUCTSTableStyleDataGridTableStyle.GridColumnStyles.Add(rEFERENCEDataGridColumnStyleDataGridTextBoxColumn);
            this.pRODUCTSTableStyleDataGridTableStyle.GridColumnStyles.Add(eXPIRING_DATEDataGridColumnStyleDataGridTextBoxColumn);
            this.pRODUCTSTableStyleDataGridTableStyle.MappingName = "PRODUCTS";
            // 
            // rEFERENCEDataGridColumnStyleDataGridTextBoxColumn
            // 
            rEFERENCEDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            rEFERENCEDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            rEFERENCEDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "REFERENCE";
            rEFERENCEDataGridColumnStyleDataGridTextBoxColumn.MappingName = "REFERENCE";
            rEFERENCEDataGridColumnStyleDataGridTextBoxColumn.Width = 100;
            // 
            // eXPIRING_DATEDataGridColumnStyleDataGridTextBoxColumn
            // 
            eXPIRING_DATEDataGridColumnStyleDataGridTextBoxColumn.Format = "";
            eXPIRING_DATEDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = null;
            eXPIRING_DATEDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "EXPIRING_DATE";
            eXPIRING_DATEDataGridColumnStyleDataGridTextBoxColumn.MappingName = "EXPIRING_DATE";
            eXPIRING_DATEDataGridColumnStyleDataGridTextBoxColumn.Width = 125;
            
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.ButtonRefresh.Location = new System.Drawing.Point(13, 24);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(84, 35);
            this.ButtonRefresh.TabIndex = 1;
            this.ButtonRefresh.TabStop = false;
            this.ButtonRefresh.Text = "Actualiser";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.ButtonAdd.Location = new System.Drawing.Point(393, 24);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(139, 35);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Ajouter Référence";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(545, 345);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(ProductsDataGrid);
            this.Menu = this.mainMenu1;
            this.Name = "Inventaire";
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.Inventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProductsDataset productsDataset;
        private System.Windows.Forms.BindingSource ProductsBindingSource;
        private InventoryApp.ProductsDatasetTableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private System.Windows.Forms.DataGridTableStyle pRODUCTSTableStyleDataGridTableStyle;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ButtonAdd;

    }
}

