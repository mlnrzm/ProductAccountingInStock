using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Windows.Forms;

namespace ProductAccountingInStockView.Windows
{
    public partial class AddProviderForm : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private readonly IProviderLogic _providerLogic;
        public AddProviderForm(IProviderLogic providerLogic)
        {
            InitializeComponent();
            _providerLogic = providerLogic;
        }

        private void AddProviderForm_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    ProviderViewModel view = _providerLogic.Read(new ProviderBindingModel
                    {
                        Id = id.Value
                    })?[0];

                    if (view != null)
                    {
                        textBoxFIO.Text = view.ProviderName;
                        textBoxAddress.Text = view.ProviderAddress;
                        textBoxPhone.Text = view.ProviderPhone;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните наименование организации", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Заполните адрес", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Заполните телефон", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                _providerLogic.CreateOrUpdate(new ProviderBindingModel
                {
                    Id = id,
                    ProviderName = textBoxFIO.Text,
                    ProviderAddress = textBoxAddress.Text,
                    ProviderPhone = textBoxPhone.Text
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