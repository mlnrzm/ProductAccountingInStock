using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockModels.BindingModels;
using System;
using System.Windows.Forms;
using Unity;

namespace ProductAccountingInStockView.Windows
{
    public partial class ProviderProductsForm : Form
    {
        public int ProviderId { set { id = value; } }
        private int? id;
        public string ProviderName { set { providerName = value; } }
        private string providerName;
        private readonly IProductLogic _productLogic;
        public ProviderProductsForm(IProductLogic productLogic)
        {
            InitializeComponent();
            _productLogic = productLogic;
        }

        private void ProviderProductsForm_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    labelProviderName.Text = providerName;
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void LoadData()
        {
            try
            {
                var list = _productLogic.Read(new ProductBindingModel { ProviderId = id.Value });
                if (list != null)
                {
                    dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewProducts.DataSource = list;
                    dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewProducts.Columns[0].Visible = false;
                    dataGridViewProducts.Columns[1].Visible = false;
                    dataGridViewProducts.Columns[2].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<AddProductForm>();
            form.ProviderId = id.Value;
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<AddProductForm>();
            form.ProviderId = id.Value;
            form.Id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить продукцию поставщика?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _productLogic.Delete(new ProductBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }
    }
}
