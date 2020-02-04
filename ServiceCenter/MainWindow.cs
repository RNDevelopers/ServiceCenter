using ServiceCenter.Common;
using ServiceCenter.Setup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter
{
    public partial class MainWindow : BaseUI
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SetFormName();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddCompany obj = new frmAddCompany();
            obj.Show();
        }
    }
}
