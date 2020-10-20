using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();
            cmbIzbor.SelectedIndex = 0;


        }

        private void cmbIzbor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIspis.Text = cmbIzbor.SelectedItem.ToString();
        }

        private void txtIspis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
