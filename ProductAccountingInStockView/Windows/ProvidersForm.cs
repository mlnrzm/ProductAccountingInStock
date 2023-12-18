using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockModels.BindingModels;
using System;
using System.Windows.Forms;
using Unity;

namespace ProductAccountingInStockView.Windows
{
    public partial class ProvidersForm : Form
    {
        private readonly IProviderLogic _providerLogic;
        public ProvidersForm(IProviderLogic providerLogic)
        {
            InitializeComponent();
            _providerLogic = providerLogic;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<AddProviderForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                loadProviders();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewProviders.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<AddProviderForm>();
                form.Id = Convert.ToInt32(dataGridViewProviders.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    loadProviders();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProviders.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить поставщика?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewProviders.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _providerLogic.Delete(new ProviderBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    loadProviders();
                }
            }
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            if (dataGridViewProviders.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<ProviderProductsForm>();
                form.ProviderId = Convert.ToInt32(dataGridViewProviders.SelectedRows[0].Cells[0].Value);
                form.ProviderName = dataGridViewProviders.SelectedRows[0].Cells[1].Value.ToString();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    loadProviders();
                }
            }
        }

        private void ProvidersForm_Load(object sender, EventArgs e)
        {
            loadProviders();
        }
        private void loadProviders()
        {
            try
            {
                var list = _providerLogic.Read(null);
                if (list != null)
                {
                    dataGridViewProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewProviders.DataSource = list;
                    dataGridViewProviders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewProviders.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
