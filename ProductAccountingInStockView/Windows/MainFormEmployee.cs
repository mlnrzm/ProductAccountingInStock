using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductAccountingInStockView.Windows
{
    public partial class MainFormEmployee : Form
    {
        public int CurrentEmployeeId { get; set; }
        public string CurrentEmployeeLogin { get; set; }
        public MainFormEmployee()
        {
            InitializeComponent();
        }

        private void MainFormEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
