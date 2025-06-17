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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            txtInfo.Text = "메모장 - 두원공과대학교 컴퓨터공학과"
                + (char)13 + (char)10 + (char)13 + (char)10
                + "Copyright(c) 2016 Doowon Technical University"
                + "\r\n\r\n\r\n"
                + "이 프로그램은 두원공과대학교 컴퓨터공학과의 \r\n"
                + "윈도우프로그래밍 수업의 프로젝트로 활용하기 위해 \r\n"
                + "기획된 것입니다.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
