using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDataApp
{
    public partial class Navigation : Form
    {
        //gerekli yerlere gönder
        public Navigation()
        {
            InitializeComponent();
        }

        private void Navigation_Load(object sender, EventArgs e)
        {

        }

        // new customera gönder
        //butonun adı değişmemiş?
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new NewCustomer();
            frm.Show();
        }
        //diğerine gönder
        //buton adı gene değişmemiş
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form frm = new FillOrCancel();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
