using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Автопрофессионал
{
    public partial class FormTovar : Form
    {
        public FormTovar()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Вывод списка товаров
		/// </summary>
		void OutputProduct()
		{

			string TxtFind = "";

			if(cbxName.Checked && tbxSearch.Text !="")
			{
				TxtFind += $"  and ProductName like '{tbxSearch.Text}%'";
			}
			if (cbxDesc.Checked && tbxSearch.Text != "")
			{
				TxtFind += $"  and ProductDescription like '{tbxSearch.Text}%'";
			}
			if (cbxManuf.Checked && tbxSearch.Text != "")
			{
				TxtFind += $"  and ManufacturerName like '{tbxSearch.Text}%'";
			}
			if (cbxCost.Checked && tbxSearch.Text != "")
			{
				TxtFind += $"  and ProductCost = {tbxSearch.Text}";
			}

			if (cbxCount.Checked && tbxSearch.Text != "")
			{
				TxtFind += $"  and ProductQuantityInStock = {tbxSearch.Text}";
			}
			if(cmbManuf.SelectedIndex !=0)
			{
				TxtFind += $" and ManufacturerName = '{cmbManuf.Text}'";
			}
			if(cmbSort.SelectedIndex == 0)
			{
				TxtFind += $"  order by ProductCost asc";
			}
			else
			{
				TxtFind += $"  order by ProductCost desc";
			}

			SqlConnection Con = new SqlConnection(FormMain.TxtCon);
			Con.Open();

			try
			{



				
				SqlCommand Q = new SqlCommand($@"SELECT    Product.ProductArticleNumber, Product.ProductPhoto, Product.ProductName, Product.ProductDescription, Product.ProductCost, Product.ProductQuantityInStock, Manufacturer.ManufacturerName
FROM         Product INNER JOIN
                      Manufacturer ON Product.idManufacturer = Manufacturer.idManufacturer Where 1>0" + TxtFind, Con);
				SqlDataReader res = Q.ExecuteReader();
				DgvProduct.Rows.Clear();
				while (res.Read())
				{
					string TxtProduct = res["ProductName"] + "\r\n" + res["ProductDescription"] + "\r\nПроизводитель: " + res["ManufacturerName"] + "\r\nЦена: " + res["ProductCost"];
					try
					{
						DgvProduct.Rows.Add(res["ProductArticleNumber"], Image.FromFile(Application.StartupPath + "\\photo\\" + res["ProductPhoto"]), TxtProduct, "На складе: " + res["ProductQuantityInStock"]);
					}
					catch
					{
						DgvProduct.Rows.Add(res["ProductArticleNumber"], Image.FromFile(Application.StartupPath + "\\photo\\picture.png"), TxtProduct, "На складе: " + res["ProductQuantityInStock"]);
					}
					if (int.Parse(res["ProductQuantityInStock"].ToString()) == 0)
					{
						DgvProduct.Rows[DgvProduct.RowCount - 1].DefaultCellStyle.BackColor = Color.Gray;
					}

				}
			}
			catch
			{
				DgvProduct.Rows.Clear();
			}
				Con.Close();
			lblCountRec.Text = $"ОТображается {DgvProduct.RowCount} из {bsP.Count}";
			if (DgvProduct.RowCount == 0 && tbxSearch.Text != "")
			{
				tslMess.Text = "Товары, соответствующие условию поиска, отсутствуют.";
			}
			else
				tslMess.Text = "";
			
		}


		private void FormTovar_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "avtoprofFelDataSet1.OrderProduct". При необходимости она может быть перемещена или удалена.
			this.orderProductTableAdapter.Fill(this.avtoprofFelDataSet1.OrderProduct);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "avtoprofFelDataSet1.allManufName". При необходимости она может быть перемещена или удалена.
			this.allManufNameTableAdapter.Fill(this.avtoprofFelDataSet1.allManufName);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "avtoprofFelDataSet1.Product". При необходимости она может быть перемещена или удалена.
			this.productTableAdapter.Fill(this.avtoprofFelDataSet1.Product);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "avtoprofFelDataSet1.User". При необходимости она может быть перемещена или удалена.
			this.userTableAdapter.Fill(this.avtoprofFelDataSet1.User);

			cmbSort.SelectedIndex = 0;
			OutputProduct();

			if(lblRole.Text !="1")
			{
				btnAdd.Enabled = false;
				btnDel.Enabled = false;
			}
			lblRole.Hide();
		}

		private void tbxSearch_TextChanged(object sender, EventArgs e)
		{
			OutputProduct();
		}

		private void cbxName_CheckedChanged(object sender, EventArgs e)
		{
			OutputProduct();
		}

		private void cbxDesc_CheckedChanged(object sender, EventArgs e)
		{
			OutputProduct();
		}

		private void cbxManuf_CheckedChanged(object sender, EventArgs e)
		{
			OutputProduct();
		}

		private void cbxCount_CheckedChanged(object sender, EventArgs e)
		{
			OutputProduct();
		}

		private void cbxCost_CheckedChanged(object sender, EventArgs e)
		{
			OutputProduct();
		}

		private void cmbManuf_SelectedIndexChanged(object sender, EventArgs e)
		{
			OutputProduct();
		}

		private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			OutputProduct();
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			BsOrderProduct.Filter = $"ProductArticleNumber = '{DgvProduct.SelectedRows[0].Cells[0].Value}'";
			if(BsOrderProduct.Count > 0)
			{
				MessageBox.Show("Невозможно удалить товар, т.к. уже содержатся заказы с ним.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DialogResult res = MessageBox.Show("Вы уверены, что хотите удалить выделенный товар?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(res == DialogResult.No)
			{
				return;
			}

			string TxtQ = $"Delete from Product where ProductArticleNumber = '{DgvProduct.SelectedRows[0].Cells[0].Value}'";
			SqlConnection Con = new SqlConnection(FormMain.TxtCon);
			Con.Open();
			SqlCommand Q = new SqlCommand(TxtQ, Con);
			Q.ExecuteNonQuery();
			Con.Close();
			MessageBox.Show("Товар успешно удалён", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			OutputProduct();

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormAddEdit frm = new FormAddEdit();
			frm.ShowDialog();
			this.productTableAdapter.Fill(this.avtoprofFelDataSet1.Product);
			OutputProduct();
		}

		private void DgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(lblRole.Text!="1")
			{
				return;
			}
			FormAddEdit frm = new FormAddEdit();
			frm.lblPanel.Text = "Редактировние продукта";
			frm.Adding = false;
			frm.bsProduct.Filter = $"ProductArticleNumber = '{DgvProduct.CurrentRow.Cells[0].Value}'";
			frm.ShowDialog();
			this.productTableAdapter.Fill(this.avtoprofFelDataSet1.Product);
			OutputProduct();

		}
	}
}
