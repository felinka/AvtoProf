
namespace СУБД_Автопрофессионал
{
	partial class FormAddEdit
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label productArticleNumberLabel;
			System.Windows.Forms.Label productNameLabel;
			System.Windows.Forms.Label productQuantityInStockLabel;
			System.Windows.Forms.Label unitLabel;
			System.Windows.Forms.Label productCostLabel;
			System.Windows.Forms.Label productDescriptionLabel;
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblPanel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.avtoprofFelDataSet1 = new СУБД_Автопрофессионал.AvtoprofFelDataSet();
			this.bsProduct = new System.Windows.Forms.BindingSource(this.components);
			this.productTableAdapter = new СУБД_Автопрофессионал.AvtoprofFelDataSetTableAdapters.ProductTableAdapter();
			this.tableAdapterManager = new СУБД_Автопрофессионал.AvtoprofFelDataSetTableAdapters.TableAdapterManager();
			this.categoryTableAdapter = new СУБД_Автопрофессионал.AvtoprofFelDataSetTableAdapters.CategoryTableAdapter();
			this.manufacturerTableAdapter = new СУБД_Автопрофессионал.AvtoprofFelDataSetTableAdapters.ManufacturerTableAdapter();
			this.providerTableAdapter = new СУБД_Автопрофессионал.AvtoprofFelDataSetTableAdapters.ProviderTableAdapter();
			this.tbxArticle = new System.Windows.Forms.TextBox();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.tbxCOunt = new System.Windows.Forms.TextBox();
			this.tbxUnit = new System.Windows.Forms.TextBox();
			this.tbxCost = new System.Windows.Forms.TextBox();
			this.tbxDescr = new System.Windows.Forms.TextBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pbxPhoto = new System.Windows.Forms.PictureBox();
			this.btnLoadP = new System.Windows.Forms.Button();
			this.lblP = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbKat = new System.Windows.Forms.ComboBox();
			this.bsKat = new System.Windows.Forms.BindingSource(this.components);
			this.cmbManuf = new System.Windows.Forms.ComboBox();
			this.bsManuf = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.cmbProvider = new System.Windows.Forms.ComboBox();
			this.bsProvider = new System.Windows.Forms.BindingSource(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.openPhoto = new System.Windows.Forms.OpenFileDialog();
			this.bsProductCheckArticle = new System.Windows.Forms.BindingSource(this.components);
			productArticleNumberLabel = new System.Windows.Forms.Label();
			productNameLabel = new System.Windows.Forms.Label();
			productQuantityInStockLabel = new System.Windows.Forms.Label();
			unitLabel = new System.Windows.Forms.Label();
			productCostLabel = new System.Windows.Forms.Label();
			productDescriptionLabel = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.avtoprofFelDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsKat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsManuf)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsProductCheckArticle)).BeginInit();
			this.SuspendLayout();
			// 
			// productArticleNumberLabel
			// 
			productArticleNumberLabel.AutoSize = true;
			productArticleNumberLabel.Location = new System.Drawing.Point(471, 124);
			productArticleNumberLabel.Name = "productArticleNumberLabel";
			productArticleNumberLabel.Size = new System.Drawing.Size(99, 20);
			productArticleNumberLabel.TabIndex = 1;
			productArticleNumberLabel.Text = "Артикуль:";
			// 
			// productNameLabel
			// 
			productNameLabel.AutoSize = true;
			productNameLabel.Location = new System.Drawing.Point(462, 195);
			productNameLabel.Name = "productNameLabel";
			productNameLabel.Size = new System.Drawing.Size(99, 20);
			productNameLabel.TabIndex = 3;
			productNameLabel.Text = "Название:";
			// 
			// productQuantityInStockLabel
			// 
			productQuantityInStockLabel.AutoSize = true;
			productQuantityInStockLabel.Location = new System.Drawing.Point(290, 280);
			productQuantityInStockLabel.Name = "productQuantityInStockLabel";
			productQuantityInStockLabel.Size = new System.Drawing.Size(219, 20);
			productQuantityInStockLabel.TabIndex = 5;
			productQuantityInStockLabel.Text = "Количество на складе:";
			// 
			// unitLabel
			// 
			unitLabel.AutoSize = true;
			unitLabel.Location = new System.Drawing.Point(541, 280);
			unitLabel.Name = "unitLabel";
			unitLabel.Size = new System.Drawing.Size(189, 20);
			unitLabel.TabIndex = 7;
			unitLabel.Text = "Единица измерения:";
			// 
			// productCostLabel
			// 
			productCostLabel.AutoSize = true;
			productCostLabel.Location = new System.Drawing.Point(492, 370);
			productCostLabel.Name = "productCostLabel";
			productCostLabel.Size = new System.Drawing.Size(59, 20);
			productCostLabel.TabIndex = 9;
			productCostLabel.Text = "Цена:";
			// 
			// productDescriptionLabel
			// 
			productDescriptionLabel.AutoSize = true;
			productDescriptionLabel.Location = new System.Drawing.Point(256, 475);
			productDescriptionLabel.Name = "productDescriptionLabel";
			productDescriptionLabel.Size = new System.Drawing.Size(99, 20);
			productDescriptionLabel.TabIndex = 11;
			productDescriptionLabel.Text = "Описание:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.Controls.Add(this.lblPanel);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1270, 100);
			this.panel1.TabIndex = 1;
			// 
			// lblPanel
			// 
			this.lblPanel.AutoSize = true;
			this.lblPanel.Font = new System.Drawing.Font("Courier New", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPanel.Location = new System.Drawing.Point(298, 34);
			this.lblPanel.Name = "lblPanel";
			this.lblPanel.Size = new System.Drawing.Size(486, 50);
			this.lblPanel.TabIndex = 1;
			this.lblPanel.Text = "Добавить продукт";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::СУБД_Автопрофессионал.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// avtoprofFelDataSet1
			// 
			this.avtoprofFelDataSet1.DataSetName = "AvtoprofFelDataSet";
			this.avtoprofFelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bsProduct
			// 
			this.bsProduct.DataMember = "Product";
			this.bsProduct.DataSource = this.avtoprofFelDataSet1;
			// 
			// productTableAdapter
			// 
			this.productTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
			this.tableAdapterManager.ManufacturerTableAdapter = this.manufacturerTableAdapter;
			this.tableAdapterManager.OrderProductTableAdapter = null;
			this.tableAdapterManager.OrderTableAdapter = null;
			this.tableAdapterManager.PickupPointTableAdapter = null;
			this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
			this.tableAdapterManager.ProviderTableAdapter = this.providerTableAdapter;
			this.tableAdapterManager.RoleTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = СУБД_Автопрофессионал.AvtoprofFelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UserTableAdapter = null;
			// 
			// categoryTableAdapter
			// 
			this.categoryTableAdapter.ClearBeforeFill = true;
			// 
			// manufacturerTableAdapter
			// 
			this.manufacturerTableAdapter.ClearBeforeFill = true;
			// 
			// providerTableAdapter
			// 
			this.providerTableAdapter.ClearBeforeFill = true;
			// 
			// tbxArticle
			// 
			this.tbxArticle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductArticleNumber", true));
			this.tbxArticle.Location = new System.Drawing.Point(457, 147);
			this.tbxArticle.Name = "tbxArticle";
			this.tbxArticle.Size = new System.Drawing.Size(117, 27);
			this.tbxArticle.TabIndex = 2;
			// 
			// tbxName
			// 
			this.tbxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductName", true));
			this.tbxName.Location = new System.Drawing.Point(384, 218);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(265, 27);
			this.tbxName.TabIndex = 4;
			// 
			// tbxCOunt
			// 
			this.tbxCOunt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductQuantityInStock", true));
			this.tbxCOunt.Location = new System.Drawing.Point(307, 320);
			this.tbxCOunt.Name = "tbxCOunt";
			this.tbxCOunt.Size = new System.Drawing.Size(182, 27);
			this.tbxCOunt.TabIndex = 6;
			this.tbxCOunt.Validating += new System.ComponentModel.CancelEventHandler(this.tbxCOunt_Validating);
			// 
			// tbxUnit
			// 
			this.tbxUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "Unit", true));
			this.tbxUnit.Location = new System.Drawing.Point(545, 320);
			this.tbxUnit.Name = "tbxUnit";
			this.tbxUnit.Size = new System.Drawing.Size(185, 27);
			this.tbxUnit.TabIndex = 8;
			// 
			// tbxCost
			// 
			this.tbxCost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductCost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
			this.tbxCost.Location = new System.Drawing.Point(403, 393);
			this.tbxCost.Name = "tbxCost";
			this.tbxCost.Size = new System.Drawing.Size(246, 27);
			this.tbxCost.TabIndex = 10;
			this.tbxCost.Validating += new System.ComponentModel.CancelEventHandler(this.tbxCost_Validating);
			// 
			// tbxDescr
			// 
			this.tbxDescr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductDescription", true));
			this.tbxDescr.Location = new System.Drawing.Point(361, 475);
			this.tbxDescr.Multiline = true;
			this.tbxDescr.Name = "tbxDescr";
			this.tbxDescr.Size = new System.Drawing.Size(369, 139);
			this.tbxDescr.TabIndex = 12;
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
			this.btnDel.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDel.ForeColor = System.Drawing.Color.White;
			this.btnDel.Location = new System.Drawing.Point(154, 676);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(245, 38);
			this.btnDel.TabIndex = 17;
			this.btnDel.Text = "Сохранить";
			this.btnDel.UseVisualStyleBackColor = false;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(609, 676);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(245, 38);
			this.button1.TabIndex = 18;
			this.button1.Text = "Отменить";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// pbxPhoto
			// 
			this.pbxPhoto.Location = new System.Drawing.Point(27, 124);
			this.pbxPhoto.Name = "pbxPhoto";
			this.pbxPhoto.Size = new System.Drawing.Size(181, 181);
			this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxPhoto.TabIndex = 19;
			this.pbxPhoto.TabStop = false;
			// 
			// btnLoadP
			// 
			this.btnLoadP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
			this.btnLoadP.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLoadP.ForeColor = System.Drawing.Color.White;
			this.btnLoadP.Location = new System.Drawing.Point(47, 308);
			this.btnLoadP.Name = "btnLoadP";
			this.btnLoadP.Size = new System.Drawing.Size(133, 50);
			this.btnLoadP.TabIndex = 20;
			this.btnLoadP.Text = "Загрузить фото";
			this.btnLoadP.UseVisualStyleBackColor = false;
			this.btnLoadP.Click += new System.EventHandler(this.btnLoadP_Click);
			// 
			// lblP
			// 
			this.lblP.AutoSize = true;
			this.lblP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProduct, "ProductPhoto", true));
			this.lblP.Location = new System.Drawing.Point(77, 413);
			this.lblP.Name = "lblP";
			this.lblP.Size = new System.Drawing.Size(69, 20);
			this.lblP.TabIndex = 21;
			this.lblP.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(940, 225);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 20);
			this.label1.TabIndex = 22;
			this.label1.Text = "Категория";
			// 
			// cmbKat
			// 
			this.cmbKat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduct, "idCategory", true));
			this.cmbKat.DataSource = this.bsKat;
			this.cmbKat.DisplayMember = "GategoryName";
			this.cmbKat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKat.FormattingEnabled = true;
			this.cmbKat.Location = new System.Drawing.Point(930, 248);
			this.cmbKat.Name = "cmbKat";
			this.cmbKat.Size = new System.Drawing.Size(215, 28);
			this.cmbKat.TabIndex = 23;
			this.cmbKat.ValueMember = "IdCategory";
			// 
			// bsKat
			// 
			this.bsKat.DataMember = "Category";
			this.bsKat.DataSource = this.avtoprofFelDataSet1;
			// 
			// cmbManuf
			// 
			this.cmbManuf.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduct, "idManufacturer", true));
			this.cmbManuf.DataSource = this.bsManuf;
			this.cmbManuf.DisplayMember = "ManufacturerName";
			this.cmbManuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbManuf.FormattingEnabled = true;
			this.cmbManuf.Location = new System.Drawing.Point(930, 320);
			this.cmbManuf.Name = "cmbManuf";
			this.cmbManuf.Size = new System.Drawing.Size(215, 28);
			this.cmbManuf.TabIndex = 25;
			this.cmbManuf.ValueMember = "idManufacturer";
			// 
			// bsManuf
			// 
			this.bsManuf.DataMember = "Manufacturer";
			this.bsManuf.DataSource = this.avtoprofFelDataSet1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(940, 297);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 20);
			this.label2.TabIndex = 24;
			this.label2.Text = "Производитель";
			// 
			// cmbProvider
			// 
			this.cmbProvider.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProduct, "idProvider", true));
			this.cmbProvider.DataSource = this.bsProvider;
			this.cmbProvider.DisplayMember = "ProviderName";
			this.cmbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbProvider.FormattingEnabled = true;
			this.cmbProvider.Location = new System.Drawing.Point(930, 393);
			this.cmbProvider.Name = "cmbProvider";
			this.cmbProvider.Size = new System.Drawing.Size(215, 28);
			this.cmbProvider.TabIndex = 27;
			this.cmbProvider.ValueMember = "idProvider";
			// 
			// bsProvider
			// 
			this.bsProvider.DataMember = "Provider";
			this.bsProvider.DataSource = this.avtoprofFelDataSet1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(940, 370);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 20);
			this.label3.TabIndex = 26;
			this.label3.Text = "Поставщик";
			// 
			// openPhoto
			// 
			this.openPhoto.FileName = "openFileDialog1";
			// 
			// bsProductCheckArticle
			// 
			this.bsProductCheckArticle.DataMember = "Product";
			this.bsProductCheckArticle.DataSource = this.avtoprofFelDataSet1;
			// 
			// FormAddEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1270, 726);
			this.Controls.Add(this.cmbProvider);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbManuf);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbKat);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblP);
			this.Controls.Add(this.btnLoadP);
			this.Controls.Add(this.pbxPhoto);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(productDescriptionLabel);
			this.Controls.Add(this.tbxDescr);
			this.Controls.Add(productCostLabel);
			this.Controls.Add(this.tbxCost);
			this.Controls.Add(unitLabel);
			this.Controls.Add(this.tbxUnit);
			this.Controls.Add(productQuantityInStockLabel);
			this.Controls.Add(this.tbxCOunt);
			this.Controls.Add(productNameLabel);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(productArticleNumberLabel);
			this.Controls.Add(this.tbxArticle);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormAddEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавление";
			this.Load += new System.EventHandler(this.FormAddEdit_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.avtoprofFelDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsKat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsManuf)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsProductCheckArticle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label lblPanel;
		private AvtoprofFelDataSet avtoprofFelDataSet1;
		private AvtoprofFelDataSetTableAdapters.ProductTableAdapter productTableAdapter;
		private AvtoprofFelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox tbxArticle;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.TextBox tbxCOunt;
		private System.Windows.Forms.TextBox tbxUnit;
		private System.Windows.Forms.TextBox tbxCost;
		private System.Windows.Forms.TextBox tbxDescr;
		public System.Windows.Forms.BindingSource bsProduct;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pbxPhoto;
		private System.Windows.Forms.Button btnLoadP;
		private System.Windows.Forms.Label lblP;
		private AvtoprofFelDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbKat;
		private System.Windows.Forms.ComboBox cmbManuf;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbProvider;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.BindingSource bsKat;
		private System.Windows.Forms.BindingSource bsManuf;
		private System.Windows.Forms.BindingSource bsProvider;
		private AvtoprofFelDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
		private AvtoprofFelDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
		private System.Windows.Forms.OpenFileDialog openPhoto;
		private System.Windows.Forms.BindingSource bsProductCheckArticle;
	}
}