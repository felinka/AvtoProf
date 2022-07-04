using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Автопрофессионал
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static string TxtCon = $@"Data Source=213.155.192.79,3002;Initial Catalog=AvtoprofFel;Persist Security Info=True;User ID=u20voloho;Password=mfw5";

        string capcha;

        /// <summary>
        /// Создание капчи
        /// </summary>
        void GetCapcha()
        {
            capcha = Guid.NewGuid().ToString();
            lbl1.Text = capcha[0].ToString().ToUpper();
            lbl2.Text = capcha[1].ToString().ToUpper();
            lbl3.Text = capcha[2].ToString().ToUpper();
            lbl4.Text = capcha[3].ToString().ToUpper();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
			// TODO: данная строка кода позволяет загрузить данные в таблицу "avtoprofFelDataSet1.User". При необходимости она может быть перемещена или удалена.
			this.userTableAdapter.Fill(this.avtoprofFelDataSet1.User);
            GetCapcha();
        }


        /// <summary>
        /// Авторизация пользователя
        /// </summary>

        private void btnOk_Click(object sender, EventArgs e)
        {
            bsUser.Filter = $"UserLogin='{tbxLog.Text}' and UserPassword='{tbxPass.Text}'";
            if (bsUser.Count == 0 || (tbxLog.Text == "-" && tbxPass.Text == "-"))
            {
                MessageBox.Show("Нет пользователя с указанным логином и паролем.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (panelInputCapcha.Visible == false)
				{
                    panelInputCapcha.Visible = true;
                    GetCapcha();
                }
                else
				{
                    GetCapcha();
                    btnOk.Enabled = false;
                    timer1.Start() ;
                    
				}
             
                return;
            }

            if(panelInputCapcha.Visible && tbxCapcha.Text.ToUpper()!= capcha)
			{
                MessageBox.Show("Неверная капча.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                GetCapcha();
                btnOk.Enabled = false;
                timer1.Start();
                return;
            }

            FormTovar form = new FormTovar();
            Hide();
            form.bsUsers.Filter = bsUser.Filter;
            form.ShowDialog();
            Show();
            tbxLog.Text = null;
            tbxPass.Text = null;
            tbxLog.Focus();
            tbxCapcha.Clear();
            
            panelInputCapcha.Visible = false;
        }


        private void btnGost_Click(object sender, EventArgs e)
        {
            bsUser.Filter = $"UserLogin='-' and UserPassword='-'";
            var form = new FormTovar();
            form.bsUsers.Filter = bsUser.Filter;
            Hide();
            form.ShowDialog();
            Show();
            tbxLog.Focus();
        }

		private void panelCapcha_Paint(object sender, PaintEventArgs e)
		{
            e.Graphics.DrawLine(new Pen(Color.Black, 3),10, 20, 200, 90 );
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 10, 50, 220, 10);

            Random rnd = new Random();
			for (int i = 1; i <= 7; i++)
			{
                e.Graphics.DrawLine(new Pen(Color.Black, 2), rnd.Next(100), rnd.Next(100), rnd.Next(panelCapcha.Width), rnd.Next(panelCapcha.Height));
			}
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
            btnOk.Enabled = true;
            timer1.Stop(); 
		}
	}
}
