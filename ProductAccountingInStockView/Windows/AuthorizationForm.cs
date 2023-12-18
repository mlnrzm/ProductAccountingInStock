using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockModels.BindingModels;
using System;
using System.Linq;
using System.Windows.Forms;
using Unity;

namespace ProductAccountingInStockView.Windows
{
    public partial class AuthorizationForm : Form
    {
        private readonly IEmployeeLogic _employeeLogic;
        private readonly IPostLogic _postLogic;
        private readonly IDirectionLogic _redirectLogic;
        public AuthorizationForm(IEmployeeLogic employeeLogic, IPostLogic postLogic, IDirectionLogic redirectLogic)
        {
            InitializeComponent();
            _employeeLogic = employeeLogic;
            _postLogic = postLogic;
            _redirectLogic = redirectLogic;
            firstRun();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Заполните поле Логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните поле Пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var employee = _employeeLogic.Enter(new EmployeeBindingModel
                    {
                        EmployeeLogin = textBoxLogin.Text,
                        EmployeePassword = textBoxPassword.Text
                    });
                    if (employee.SupervisorId == employee.Id)
                    {
                        var form = Program.Container.Resolve<MainFormAdmin>();
                        form.CurrentAdminId = employee.Id;
                        form.CurrentAdminLogin = employee.EmployeeLogin;
                        Hide();
                        form.Show();
                    }
                    else
                    {
                        var form = Program.Container.Resolve<MainFormEmployee>();
                        form.CurrentEmployeeId = employee.Id;
                        form.CurrentEmployeeLogin = employee.EmployeeLogin;
                        Hide();
                        form.Show();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void firstRun() 
        {
            try
            {
                if (_postLogic.Read(null).Count == 0)
                {
                    _postLogic.Create(new PostBindingModel
                    {
                        PostName = "Руководитель"
                    });
                    _postLogic.Create(new PostBindingModel
                    {
                        PostName = "Сотрудник"
                    });
                }
                int postId = _postLogic.Read(null).FirstOrDefault(rec => rec.PostName == "Руководитель").Id;

                if (_redirectLogic.Read(null).Count == 0)
                {
                    _redirectLogic.Create(new DirectionBindingModel
                    {
                        DirectionName = "Импорт"
                    });
                    _redirectLogic.Create(new DirectionBindingModel
                    {
                        DirectionName = "Экспорт"
                    });
                }

                if (_employeeLogic.Read(null).Count == 0)
                {
                    _employeeLogic.Create(new EmployeeBindingModel
                    {
                        PostId = postId,
                        EmployeeLogin = "arzamaskina.ma@mail.ru",
                        EmployeePassword = "Mlnrzm.123",
                        EmployeeFIO = "Арзамаскина М.А."
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
