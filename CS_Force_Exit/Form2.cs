using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CS_Force_Exit
{
    public partial class Form2 : Form
    {
        Process SelectedProcess;
        public Form2(string strPid)
        {
            InitializeComponent();
            int pid;
            int.TryParse(strPid, out pid);
            SelectedProcess = Process.GetProcessById(pid);
            label1.Text = SelectedProcess.ProcessName + " PID : " + SelectedProcess.Id + " 상태 : " + SelectedProcess.HasExited;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로세스를 정말로 중지 시키겠습니까?", "프로세스 중지 프로그램", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SelectedProcess.Kill();
                this.Close();   //Form2
            }
        }
    }
}
