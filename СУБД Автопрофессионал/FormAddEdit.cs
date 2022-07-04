using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Автопрофессионал
{
	
	public partial class FormAddEdit : Form
	{
		public FormAddEdit()
		{
			InitializeComponent();
		}

		public bool Adding = true;

		private void FormAddEdit_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "avtoprofFelDataSet1.Manufacturer". При необходимости она может быть перемещена или удалена.
			this.manufacturerTableAdapter.Fill(this.avtoprofFelDataSet1.Manufacturer);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "avtoprofFelDataSet1.Provider". При необходимости она может быть перемещена или удалена.
			this.providerTableAdapter.Fill(this.avtoprofFelDataSet1.Provider);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "avtoprofFelDataSet1.Role". При необходимости она может быть перемещена или удалена.
			// TODO: данная строка кода позволяет загрузить данные в таблицу "avtoprofFelDataSet1.Category". При необходимости она может быть перемещена или удалена.
			this.categoryTableAdapter.Fill(this.avtoprofFelDataSet1.Category);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "avtoprofFelDataSet1.Product". При необходимости она может быть перемещена или удалена.
			this.productTableAdapter.Fill(this.avtoprofFelDataSet1.Product);

			if(Adding)
			{
				bsProduct.AddNew();
				cmbKat.SelectedIndex = 0;
				cmbManuf.SelectedIndex = 0;
				cmbProvider.SelectedIndex = 0;

			}
			else
			{
				tbxArticle.ReadOnly = true;
				try
				{
					pbxPhoto.Image = Image.FromFile(Application.StartupPath + "\\photo\\"+lblP.Text);
				}
				catch
				{
					pbxPhoto.Image = Image.FromFile(Application.StartupPath + "\\photo\\picture.png");
				}
			}

			lblP.Hide();

		}

		private void btnDel_Click(object sender, EventArgs e)
		{

			if(tbxArticle.Text.Trim() == "")
			{
				MessageBox.Show("Артикул не может быть пустым");
				return;
			}
			if (tbxName.Text.Trim() == "")
			{
				MessageBox.Show("Название не может быть пустым");
				return;
			}
			bsProductCheckArticle.Filter = $"ProductArticleNumber = '{tbxArticle.Text}'";
			if(Adding && bsProductCheckArticle.Count>0)
			{
				MessageBox.Show("Такой артикул уже используется в базе данных");
				return;
			}

			if(openPhoto.FileName !="")
			{
				string NewFileName = Guid.NewGuid() + Path.GetExtension(openPhoto.FileName);
				lblP.Text = NewFileName;
				try
				{
					File.Copy(openPhoto.FileName, Application.StartupPath + "\\photo\\" + NewFileName);
				}
				catch
				{
					lblP.Text = "";
				}
				
			}
		

			bsProduct.EndEdit();
			this.productTableAdapter.Update(this.avtoprofFelDataSet1.Product);
			this.Close();
		}

		private void btnLoadP_Click(object sender, EventArgs e)
		{
			if(openPhoto.ShowDialog() == DialogResult.OK)
			{

				Image Im;
				try
				{
					Im = Image.FromFile(openPhoto.FileName);
				}
				catch
				{
					MessageBox.Show("Невозможно загрузить изображение из файла");
					openPhoto.FileName = "";
					return;

				}
				if (!((Im.Width <= 300 && Im.Height <=200) || (Im.Width <=200 && Im.Height<=300 ) ))
				{
					MessageBox.Show("Размеры изображения слишком большие");
					openPhoto.FileName = "";
					return;
				}
			}
		}

		private void tbxCOunt_Validating(object sender, CancelEventArgs e)
		{
			try
			{
				int Count = int.Parse(tbxCOunt.Text);
				if(Count<0)
				{
					MessageBox.Show("Количество не может быть отрицательным ");
					tbxCOunt.Clear();
					return;
				}
			}
			catch
			{
				MessageBox.Show("Количество должно быть целым числом ");
				tbxCOunt.Clear();
				return;
			}
		}

		private void tbxCost_Validating(object sender, CancelEventArgs e)
		{
			try
			{
				double Count = double.Parse(tbxCost.Text);
				if (Count < 0)
				{
					MessageBox.Show("Цена не может быть отрицательной ");
					tbxCost.Clear();
					return;
				}
			}
			catch
			{
				MessageBox.Show("Цена должна быть вещественным числом ");
				tbxCOunt.Clear();
				return;
			}
		}

	}
}
