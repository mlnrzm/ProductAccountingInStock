using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockModels.BindingModels;
using System;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace ProductAccountingInStockView.Windows
{
    public partial class EmployeesForm : Form
    {
        public int CurrentAdminId { get; set; }
        private readonly IEmployeeLogic _employeeLogic;
        private readonly IPostLogic _postLogic;
        public EmployeesForm(IEmployeeLogic employeeLogic, IPostLogic postLogic)
        {
            InitializeComponent();
            _employeeLogic = employeeLogic;
            _postLogic = postLogic;
        }
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            loadEmployees();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<AddEmployeeForm>();
            form.CurrentAdminId = CurrentAdminId;
            if (form.ShowDialog() == DialogResult.OK)
            {
                loadEmployees();
            }
        }

        private void loadEmployees()
        {
            try
            {
                var list = _employeeLogic.Read(new EmployeeBindingModel
                {
                    PostId = _postLogic.Read(null).FirstOrDefault(rec => rec.PostName.Contains("Сотрудник")).Id
                });
                if (list != null)
                {
                    dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewEmployees.DataSource = list;
                    dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewEmployees.Columns[0].Visible = false;
                    dataGridViewEmployees.Columns[1].Visible = false;
                    dataGridViewEmployees.Columns[2].Visible = false;
                    dataGridViewEmployees.Columns[6].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить сотрудника?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _employeeLogic.Delete(new EmployeeBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    loadEmployees();
                }
            }
        }
    }
}
