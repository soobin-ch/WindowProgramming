using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_4253
{
    public partial class FindForm: Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            txtKeyword.Focus();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            if (txtKeyword.Text.Length != 0) btnFind.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            MdiChild workForm = (MdiChild)this.Owner;

            workForm.Search(txtKeyword.Text, chkCase.Checked, rdoDown.Checked);
            workForm.Focus();
        }
    }
}
