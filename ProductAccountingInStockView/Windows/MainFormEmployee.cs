using System;
using System.Windows.Forms;
using Unity;

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

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<ProvidersForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<ShipmentsForm>();
            form.CurrentId = CurrentEmployeeId;
            form.CurrentLogin = CurrentEmployeeLogin;
            if (form.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
