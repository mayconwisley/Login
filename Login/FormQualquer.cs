using System;
using System.Windows.Forms;

namespace Login
{
    public partial class FormQualquer : Form
    {
        public FormQualquer()
        {
            InitializeComponent();
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
