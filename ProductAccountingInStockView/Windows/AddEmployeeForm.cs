using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockModels.BindingModels;
using System;
using System.Windows.Forms;

namespace ProductAccountingInStockView.Windows
{
    public partial class AddEmployeeForm : Form
    {
        public int CurrentAdminId { get; set; }
        private readonly IEmployeeLogic _employeeLogic;
        private readonly IPostLogic _postLogic;
        public AddEmployeeForm(IEmployeeLogic employeeLogic, IPostLogic postLogic)
        {
            InitializeComponent();
            _employeeLogic = employeeLogic;
            _postLogic = postLogic;
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            comboBoxPosts.DataSource = _postLogic.Read(null);
            comboBoxPosts.DisplayMember = "PostName";
            comboBoxPosts.ValueMember = "Id";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text) ||
                string.IsNullOrEmpty(textBoxLogin.Text) ||
                string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _employeeLogic.Create(new EmployeeBindingModel
                {
                    PostId = (int)comboBoxPosts.SelectedValue,
                    EmployeeFIO = textBoxFIO.Text,
                    EmployeeLogin = textBoxLogin.Text,
                    EmployeePassword = textBoxPassword.Text,
                    SupervisorId = CurrentAdminId
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
