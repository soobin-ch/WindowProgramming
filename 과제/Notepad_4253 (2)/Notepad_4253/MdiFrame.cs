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
    public partial class MdiFrame : Form
    {
        public MdiFrame()
        {
            InitializeComponent();
        }

        private void MdiFrame_Load(object sender, EventArgs e)
        {
            newChild();
        }

        private void newChild()
        {
            MdiChild myChild = new MdiChild();
            myChild.MdiParent = this;
            myChild.Show();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            newChild();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(openFileDialog1.FileName == null) return;
                newChild(openFileDialog1.FileName, openFileDialog1.FilterIndex);
            }
        }

        private void newChild(string filename, int filterIndex)
        {
            MdiChild myChild = new MdiChild(filename, filterIndex);
            myChild.MdiParent = this;
            myChild.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

            mnuCascade.Checked = true;
            mnuHorizontal.Checked = false;
            mnuVertical.Checked = false;
            mnuIcon.Checked = false;
        }

        private void mnuHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

            mnuCascade.Checked = false;
            mnuHorizontal.Checked = true;
            mnuVertical.Checked = false;
            mnuIcon.Checked = false;
        }

        private void mnuVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

            mnuCascade.Checked = false;
            mnuHorizontal.Checked = false;
            mnuVertical.Checked = true;
            mnuIcon.Checked = false;
        }

        private void mnuIcon_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);

            mnuCascade.Checked = false;
            mnuHorizontal.Checked = false;
            mnuVertical.Checked = false;
            mnuIcon.Checked = true;
        }

        private void mnuInformation_Click(object sender, EventArgs e)
        {
            Information myInfo = new Information();
            myInfo.ShowDialog();
        }

        private void tstNew_Click(object sender, EventArgs e)
        {
            newChild();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            MdiChild myChild = (MdiChild)this.ActiveMdiChild;
            myChild.saveFile();
        }

        private void tsbCut_Click(object sender, EventArgs e)
        {
            MdiChild myChild = (MdiChild)this.ActiveMdiChild;
            myChild.Cut();
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {

            MdiChild myChild = (MdiChild)this.ActiveMdiChild;
            myChild.Copy();
        }

        private void tsbPaste_Click(object sender, EventArgs e)
        {

            MdiChild myChild = (MdiChild)this.ActiveMdiChild;
            myChild.Paste();
        }

        private void tsbFind_Click(object sender, EventArgs e)
        {
            FindForm myFinder = new FindForm();
            myFinder.Owner = (MdiChild)this.ActiveMdiChild;
            myFinder.Show();
        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssClock.Text = System.DateTime.Now.ToLongDateString() + "" + System.DateTime.Now.ToLongDateString();
        }
    }
}
