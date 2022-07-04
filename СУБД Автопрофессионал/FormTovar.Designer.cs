namespace СУБД_Автопрофессионал
{
    partial class FormTovar
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTovar));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblRole = new System.Windows.Forms.Label();
			this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
			this.avtoprofFelDataSet1 = new СУБД_Автопрофессионал.AvtoprofFelDataSet();
			this.lblCountRec = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPanel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.userTableAdapter = new СУБД_Автопрофессионал.AvtoprofFelDataSetTableAdapters.UserTableAdapter();
			this.DgvProduct = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxName = new System.Windows.Forms.CheckBox();
			this.cbxDesc = new System.Windows.Forms.CheckBox();
			this.cbxManuf = new System.Windows.Forms.CheckBox();
			this.cbxCount = new System.Windows.Forms.CheckBox();
			this.cbxCost = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			this.bsP = new System.Windows.Forms.BindingSource(this.components);
			this.productTableAdapter = new СУБД_Автопрофессионал.AvtoprofFelDataSetTableAdapters.ProductTableAdapter();
			this.cmbManuf = new System.Windows.Forms.ComboBox();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tslMess = new System.Windows.Forms.ToolStripLabel();
			this.allManufNameTableAdapter = new СУБД_Автопрофессионал.AvtoprofFelDataSetTableAdapters.allManufNameTableAdapter();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbSort = new System.Windows.Forms.ComboBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.BsOrderProduct = new System.Windows.Forms.BindingSource(this.components);
			this.orderProductTableAdapter = new СУБД_Автопрофессионал.AvtoprofFelDataSetTableAdapters.OrderProductTableAdapter();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.avtoprofFelDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BsOrderProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.Controls.Add(this.lblRole);
			this.panel1.Controls.Add(this.lblCountRec);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lblPanel);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1349, 134);
			this.panel1.TabIndex = 1;
			// 
			// lblRole
			// 
			this.lblRole.AutoSize = true;
			this.lblRole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "UserRole", true));
			this.lblRole.Location = new System.Drawing.Point(194, 101);
			this.lblRole.Name = "lblRole";
			this.lblRole.Size = new System.Drawing.Size(56, 17);
			this.lblRole.TabIndex = 12;
			this.lblRole.Text = "label4";
			// 
			// bsUsers
			// 
			this.bsUsers.DataMember = "User";
			this.bsUsers.DataSource = this.avtoprofFelDataSet1;
			// 
			// avtoprofFelDataSet1
			// 
			this.avtoprofFelDataSet1.DataSetName = "AvtoprofFelDataSet";
			this.avtoprofFelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lblCountRec
			// 
			this.lblCountRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCountRec.AutoSize = true;
			this.lblCountRec.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblCountRec.Location = new System.Drawing.Point(980, 98);
			this.lblCountRec.Name = "lblCountRec";
			this.lblCountRec.Size = new System.Drawing.Size(0, 20);
			this.lblCountRec.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "UserPatronymic", true));
			this.label3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(1166, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "отчество";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "UserName", true));
			this.label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(1166, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "имя";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsers, "UserSurname", true));
			this.label1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(1166, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Фамилия";
			// 
			// lblPanel
			// 
			this.lblPanel.AutoSize = true;
			this.lblPanel.Font = new System.Drawing.Font("Courier New", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPanel.Location = new System.Drawing.Point(407, 25);
			this.lblPanel.Name = "lblPanel";
			this.lblPanel.Size = new System.Drawing.Size(196, 50);
			this.lblPanel.TabIndex = 1;
			this.lblPanel.Text = "Товары";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = global::СУБД_Автопрофессионал.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(153, 134);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// userTableAdapter
			// 
			this.userTableAdapter.ClearBeforeFill = true;
			// 
			// DgvProduct
			// 
			this.DgvProduct.AllowUserToAddRows = false;
			this.DgvProduct.AllowUserToDeleteRows = false;
			this.DgvProduct.AllowUserToResizeColumns = false;
			this.DgvProduct.AllowUserToResizeRows = false;
			this.DgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DgvProduct.BackgroundColor = System.Drawing.Color.White;
			this.DgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvProduct.ColumnHeadersVisible = false;
			this.DgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
			this.DgvProduct.GridColor = System.Drawing.Color.White;
			this.DgvProduct.Location = new System.Drawing.Point(12, 262);
			this.DgvProduct.MinimumSize = new System.Drawing.Size(1325, 433);
			this.DgvProduct.MultiSelect = false;
			this.DgvProduct.Name = "DgvProduct";
			this.DgvProduct.ReadOnly = true;
			this.DgvProduct.RowHeadersVisible = false;
			this.DgvProduct.RowHeadersWidth = 51;
			this.DgvProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
			this.DgvProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
			this.DgvProduct.RowTemplate.DividerHeight = 10;
			this.DgvProduct.RowTemplate.Height = 100;
			this.DgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgvProduct.Size = new System.Drawing.Size(1325, 433);
			this.DgvProduct.TabIndex = 2;
			this.DgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellDoubleClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Column1";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Column2";
			this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Column2.MinimumWidth = 100;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column3.HeaderText = "Column3";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column4.HeaderText = "Column4";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 200;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(9, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Поиск по:";
			// 
			// cbxName
			// 
			this.cbxName.AutoSize = true;
			this.cbxName.Location = new System.Drawing.Point(115, 153);
			this.cbxName.Name = "cbxName";
			this.cbxName.Size = new System.Drawing.Size(126, 21);
			this.cbxName.TabIndex = 4;
			this.cbxName.Text = "Наименованию";
			this.cbxName.UseVisualStyleBackColor = true;
			this.cbxName.CheckedChanged += new System.EventHandler(this.cbxName_CheckedChanged);
			// 
			// cbxDesc
			// 
			this.cbxDesc.AutoSize = true;
			this.cbxDesc.Location = new System.Drawing.Point(247, 154);
			this.cbxDesc.Name = "cbxDesc";
			this.cbxDesc.Size = new System.Drawing.Size(94, 21);
			this.cbxDesc.TabIndex = 5;
			this.cbxDesc.Text = "Описанию";
			this.cbxDesc.UseVisualStyleBackColor = true;
			this.cbxDesc.CheckedChanged += new System.EventHandler(this.cbxDesc_CheckedChanged);
			// 
			// cbxManuf
			// 
			this.cbxManuf.AutoSize = true;
			this.cbxManuf.Location = new System.Drawing.Point(362, 154);
			this.cbxManuf.Name = "cbxManuf";
			this.cbxManuf.Size = new System.Drawing.Size(134, 21);
			this.cbxManuf.TabIndex = 6;
			this.cbxManuf.Text = "Производителю";
			this.cbxManuf.UseVisualStyleBackColor = true;
			this.cbxManuf.CheckedChanged += new System.EventHandler(this.cbxManuf_CheckedChanged);
			// 
			// cbxCount
			// 
			this.cbxCount.AutoSize = true;
			this.cbxCount.Location = new System.Drawing.Point(115, 180);
			this.cbxCount.Name = "cbxCount";
			this.cbxCount.Size = new System.Drawing.Size(110, 21);
			this.cbxCount.TabIndex = 8;
			this.cbxCount.Text = "Количеству";
			this.cbxCount.UseVisualStyleBackColor = true;
			this.cbxCount.CheckedChanged += new System.EventHandler(this.cbxCount_CheckedChanged);
			// 
			// cbxCost
			// 
			this.cbxCost.AutoSize = true;
			this.cbxCost.Location = new System.Drawing.Point(247, 180);
			this.cbxCost.Name = "cbxCost";
			this.cbxCost.Size = new System.Drawing.Size(62, 21);
			this.cbxCost.TabIndex = 7;
			this.cbxCost.Text = "Цене";
			this.cbxCost.UseVisualStyleBackColor = true;
			this.cbxCost.CheckedChanged += new System.EventHandler(this.cbxCost_CheckedChanged);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(3, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(269, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Введите строку для поиска:\r\n";
			// 
			// tbxSearch
			// 
			this.tbxSearch.Location = new System.Drawing.Point(269, 224);
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(215, 23);
			this.tbxSearch.TabIndex = 10;
			this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
			// 
			// bsP
			// 
			this.bsP.DataMember = "Product";
			this.bsP.DataSource = this.avtoprofFelDataSet1;
			// 
			// productTableAdapter
			// 
			this.productTableAdapter.ClearBeforeFill = true;
			// 
			// cmbManuf
			// 
			this.cmbManuf.DataSource = this.bindingSource1;
			this.cmbManuf.DisplayMember = "ManufName";
			this.cmbManuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbManuf.FormattingEnabled = true;
			this.cmbManuf.Location = new System.Drawing.Point(599, 164);
			this.cmbManuf.Name = "cmbManuf";
			this.cmbManuf.Size = new System.Drawing.Size(245, 25);
			this.cmbManuf.TabIndex = 11;
			this.cmbManuf.SelectedIndexChanged += new System.EventHandler(this.cmbManuf_SelectedIndexChanged);
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataMember = "allManufName";
			this.bindingSource1.DataSource = this.avtoprofFelDataSet1;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(595, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(239, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Выберите производителя:";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslMess});
			this.toolStrip1.Location = new System.Drawing.Point(0, 699);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1349, 25);
			this.toolStrip1.TabIndex = 13;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tslMess
			// 
			this.tslMess.Name = "tslMess";
			this.tslMess.Size = new System.Drawing.Size(25, 22);
			this.tslMess.Text = "    ";
			// 
			// allManufNameTableAdapter
			// 
			this.allManufNameTableAdapter.ClearBeforeFill = true;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(909, 141);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(249, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "Сортировка по стоимости:\r\n";
			// 
			// cmbSort
			// 
			this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSort.FormattingEnabled = true;
			this.cmbSort.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
			this.cmbSort.Location = new System.Drawing.Point(913, 164);
			this.cmbSort.Name = "cmbSort";
			this.cmbSort.Size = new System.Drawing.Size(245, 25);
			this.cmbSort.TabIndex = 14;
			this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
			this.btnDel.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDel.ForeColor = System.Drawing.Color.White;
			this.btnDel.Location = new System.Drawing.Point(599, 209);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(245, 38);
			this.btnDel.TabIndex = 16;
			this.btnDel.Text = "Удалить товар";
			this.btnDel.UseVisualStyleBackColor = false;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
			this.btnAdd.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(913, 209);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(252, 38);
			this.btnAdd.TabIndex = 17;
			this.btnAdd.Text = "Добавить товар";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// BsOrderProduct
			// 
			this.BsOrderProduct.DataMember = "OrderProduct";
			this.BsOrderProduct.DataSource = this.avtoprofFelDataSet1;
			// 
			// orderProductTableAdapter
			// 
			this.orderProductTableAdapter.ClearBeforeFill = true;
			// 
			// FormTovar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1349, 724);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbSort);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbManuf);
			this.Controls.Add(this.tbxSearch);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbxCount);
			this.Controls.Add(this.cbxCost);
			this.Controls.Add(this.cbxManuf);
			this.Controls.Add(this.cbxDesc);
			this.Controls.Add(this.cbxName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.DgvProduct);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "FormTovar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "СУБД Автопрофессионал";
			this.Load += new System.EventHandler(this.FormTovar_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.avtoprofFelDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BsOrderProduct)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private AvtoprofFelDataSet avtoprofFelDataSet1;
		private AvtoprofFelDataSetTableAdapters.UserTableAdapter userTableAdapter;
		public System.Windows.Forms.BindingSource bsUsers;
		private System.Windows.Forms.DataGridView DgvProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewImageColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbxName;
		private System.Windows.Forms.CheckBox cbxDesc;
		private System.Windows.Forms.CheckBox cbxManuf;
		private System.Windows.Forms.CheckBox cbxCount;
		private System.Windows.Forms.CheckBox cbxCost;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbxSearch;
		private System.Windows.Forms.Label lblCountRec;
		private System.Windows.Forms.BindingSource bsP;
		private AvtoprofFelDataSetTableAdapters.ProductTableAdapter productTableAdapter;
		private System.Windows.Forms.ComboBox cmbManuf;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel tslMess;
		private System.Windows.Forms.BindingSource bindingSource1;
		private AvtoprofFelDataSetTableAdapters.allManufNameTableAdapter allManufNameTableAdapter;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbSort;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.BindingSource BsOrderProduct;
		private AvtoprofFelDataSetTableAdapters.OrderProductTableAdapter orderProductTableAdapter;
		private System.Windows.Forms.Label lblRole;
	}
}