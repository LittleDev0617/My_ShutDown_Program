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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ProcessGridView.ReadOnly = true;
            SetupGridView();
            ProcessRefresh.Start();
        }

        void SetupGridView()
        {
            foreach (Process pro in Process.GetProcesses())
            {
                try
                {
                    ProcessGridView.Rows.Add(pro.ProcessName, pro.Id, pro.HasExited.ToString());
                }
                catch { }
            }
        }

        void GetProcessList()
        {
            int i = 0;
            foreach (Process pro in Process.GetProcesses())
            {
                try
                {
                    ProcessGridView.Rows[i].SetValues(pro.ProcessName, pro.Id, pro.HasExited.ToString());
                }
                catch { }
            }
        }

        private void ProcessGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 form2;
            form2 = new Form2(ProcessGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
            form2.Show();
        }

        private void ProcessRefresh_Tick(object sender, EventArgs e)
        {
            GetProcessList();
        }
    }
}
