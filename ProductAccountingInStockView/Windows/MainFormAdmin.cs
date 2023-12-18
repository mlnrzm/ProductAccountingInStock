using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ProductAccountingInStockView.Windows
{
    public partial class MainFormAdmin : Form
    {
        public int CurrentAdminId { get; set; }
        public string CurrentAdminLogin { get; set; }
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        private void MainFormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<EmployeesForm>();
            form.CurrentAdminId = CurrentAdminId;
            form.Show();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<ProvidersForm>();
            form.Show();
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<ShipmentsForm>();
            form.CurrentId = CurrentAdminId;
            form.CurrentLogin = CurrentAdminLogin;
            form.Show();
        }
    }
}
