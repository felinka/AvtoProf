namespace СУБД_Автопрофессионал
{
    partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblPanel = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tbxLog = new System.Windows.Forms.TextBox();
			this.tbxPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnGost = new System.Windows.Forms.Button();
			this.panelInputCapcha = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxCapcha = new System.Windows.Forms.TextBox();
			this.panelCapcha = new System.Windows.Forms.Panel();
			this.lbl4 = new System.Windows.Forms.Label();
			this.lbl3 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			this.avtoprofFelDataSet1 = new СУБД_Автопрофессионал.AvtoprofFelDataSet();
			this.bsUser = new System.Windows.Forms.BindingSource(this.components);
			this.userTableAdapter = new СУБД_Автопрофессионал.AvtoprofFelDataSetTableAdapters.UserTableAdapter();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelInputCapcha.SuspendLayout();
			this.panelCapcha.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.avtoprofFelDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.Controls.Add(this.lblPanel);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(931, 100);
			this.panel1.TabIndex = 0;
			// 
			// lblPanel
			// 
			this.lblPanel.AutoSize = true;
			this.lblPanel.Font = new System.Drawing.Font("Courier New", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPanel.Location = new System.Drawing.Point(298, 34);
			this.lblPanel.Name = "lblPanel";
			this.lblPanel.Size = new System.Drawing.Size(341, 50);
			this.lblPanel.TabIndex = 1;
			this.lblPanel.Text = "Авторизация";
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
			// tbxLog
			// 
			this.tbxLog.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbxLog.Location = new System.Drawing.Point(39, 170);
			this.tbxLog.Name = "tbxLog";
			this.tbxLog.Size = new System.Drawing.Size(295, 49);
			this.tbxLog.TabIndex = 1;
			// 
			// tbxPass
			// 
			this.tbxPass.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbxPass.Location = new System.Drawing.Point(39, 268);
			this.tbxPass.Name = "tbxPass";
			this.tbxPass.Size = new System.Drawing.Size(295, 49);
			this.tbxPass.TabIndex = 2;
			this.tbxPass.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(39, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 39);
			this.label1.TabIndex = 3;
			this.label1.Text = "Логин";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(39, 222);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 39);
			this.label2.TabIndex = 4;
			this.label2.Text = "Пароль";
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
			this.btnOk.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.Location = new System.Drawing.Point(39, 370);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(295, 50);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "Войти";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnGost
			// 
			this.btnGost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(99)))), ((int)(((byte)(245)))));
			this.btnGost.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnGost.ForeColor = System.Drawing.Color.White;
			this.btnGost.Location = new System.Drawing.Point(39, 437);
			this.btnGost.Name = "btnGost";
			this.btnGost.Size = new System.Drawing.Size(295, 50);
			this.btnGost.TabIndex = 7;
			this.btnGost.Text = "Войти как гость";
			this.btnGost.UseVisualStyleBackColor = false;
			this.btnGost.Click += new System.EventHandler(this.btnGost_Click);
			// 
			// panelInputCapcha
			// 
			this.panelInputCapcha.Controls.Add(this.label3);
			this.panelInputCapcha.Controls.Add(this.tbxCapcha);
			this.panelInputCapcha.Controls.Add(this.panelCapcha);
			this.panelInputCapcha.Location = new System.Drawing.Point(389, 138);
			this.panelInputCapcha.Name = "panelInputCapcha";
			this.panelInputCapcha.Size = new System.Drawing.Size(294, 215);
			this.panelInputCapcha.TabIndex = 9;
			this.panelInputCapcha.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(54, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(194, 27);
			this.label3.TabIndex = 4;
			this.label3.Text = "Введите капчу";
			// 
			// tbxCapcha
			// 
			this.tbxCapcha.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbxCapcha.Location = new System.Drawing.Point(27, 163);
			this.tbxCapcha.Name = "tbxCapcha";
			this.tbxCapcha.Size = new System.Drawing.Size(248, 37);
			this.tbxCapcha.TabIndex = 1;
			// 
			// panelCapcha
			// 
			this.panelCapcha.BackgroundImage = global::СУБД_Автопрофессионал.Properties.Resources.Безымянный;
			this.panelCapcha.Controls.Add(this.lbl4);
			this.panelCapcha.Controls.Add(this.lbl3);
			this.panelCapcha.Controls.Add(this.lbl2);
			this.panelCapcha.Controls.Add(this.lbl1);
			this.panelCapcha.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCapcha.Location = new System.Drawing.Point(0, 0);
			this.panelCapcha.Name = "panelCapcha";
			this.panelCapcha.Size = new System.Drawing.Size(294, 100);
			this.panelCapcha.TabIndex = 0;
			this.panelCapcha.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCapcha_Paint);
			// 
			// lbl4
			// 
			this.lbl4.AutoSize = true;
			this.lbl4.BackColor = System.Drawing.Color.Transparent;
			this.lbl4.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl4.Location = new System.Drawing.Point(231, 54);
			this.lbl4.Name = "lbl4";
			this.lbl4.Size = new System.Drawing.Size(44, 44);
			this.lbl4.TabIndex = 3;
			this.lbl4.Text = "R";
			// 
			// lbl3
			// 
			this.lbl3.AutoSize = true;
			this.lbl3.BackColor = System.Drawing.Color.Transparent;
			this.lbl3.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl3.Location = new System.Drawing.Point(167, 9);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(44, 44);
			this.lbl3.TabIndex = 2;
			this.lbl3.Text = "R";
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.BackColor = System.Drawing.Color.Transparent;
			this.lbl2.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl2.Location = new System.Drawing.Point(97, 32);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(44, 44);
			this.lbl2.TabIndex = 1;
			this.lbl2.Text = "R";
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.BackColor = System.Drawing.Color.Transparent;
			this.lbl1.Font = new System.Drawing.Font("MV Boli", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.Location = new System.Drawing.Point(19, 9);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(44, 44);
			this.lbl1.TabIndex = 0;
			this.lbl1.Text = "R";
			// 
			// avtoprofFelDataSet1
			// 
			this.avtoprofFelDataSet1.DataSetName = "AvtoprofFelDataSet";
			this.avtoprofFelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bsUser
			// 
			this.bsUser.DataMember = "User";
			this.bsUser.DataSource = this.avtoprofFelDataSet1;
			// 
			// userTableAdapter
			// 
			this.userTableAdapter.ClearBeforeFill = true;
			// 
			// timer1
			// 
			this.timer1.Interval = 10000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(931, 511);
			this.Controls.Add(this.panelInputCapcha);
			this.Controls.Add(this.btnGost);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxPass);
			this.Controls.Add(this.tbxLog);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(953, 562);
			this.MinimumSize = new System.Drawing.Size(953, 562);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "СУБД \"Автопрофессионал\"";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelInputCapcha.ResumeLayout(false);
			this.panelInputCapcha.PerformLayout();
			this.panelCapcha.ResumeLayout(false);
			this.panelCapcha.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.avtoprofFelDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPanel;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnGost;
        private System.Windows.Forms.Panel panelInputCapcha;
        private System.Windows.Forms.Panel panelCapcha;
        private System.Windows.Forms.TextBox tbxCapcha;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
		private AvtoprofFelDataSet avtoprofFelDataSet1;
		private System.Windows.Forms.BindingSource bsUser;
		private AvtoprofFelDataSetTableAdapters.UserTableAdapter userTableAdapter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer timer1;
	}
}

