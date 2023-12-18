using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProductAccountingInStockView.Windows
{
    public partial class AddShipmentForm : Form
    {
        public int CurrentId { get; set; }
        private Dictionary<int, (string, int)> shipmentProducts;
        private decimal Sum;

        private readonly IShipmentLogic _shipmentLogic;
        private readonly IDirectionLogic _directionLogic;
        private readonly IProviderLogic _providerLogic;
        private readonly IProductLogic _productLogic;
        public AddShipmentForm(IProviderLogic providerLogic, IProductLogic productLogic,
            IDirectionLogic directionLogic, IShipmentLogic shipmentLogic)
        {
            InitializeComponent();
            _providerLogic = providerLogic;
            _productLogic = productLogic;
            _directionLogic = directionLogic;
            shipmentProducts = new Dictionary<int, (string, int)>();
            _shipmentLogic = shipmentLogic;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int count;
            if (comboBoxProvider.SelectedValue == null)
            {
                MessageBox.Show("Выберите поставщика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxProducts.SelectedValue == null)
            {
                MessageBox.Show("Выберите продукцию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(textBoxCount.Text, out count))
            {
                shipmentProducts.Add((int)comboBoxProducts.SelectedValue,
                    (comboBoxProducts.Text, Convert.ToInt32(textBoxCount.Text)));
                LoadDataProductsGrid();
                return;
            }
            else
            {
                MessageBox.Show("Укажите целое число единиц продукции", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxDirection.SelectedValue == null)
            {
                MessageBox.Show("Выберите направление поставки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxProvider.SelectedValue == null)
            {
                MessageBox.Show("Выберите поставщика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (shipmentProducts.Count == 0)
            {
                MessageBox.Show("Добавьте продукцию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _shipmentLogic.CreateShipment(new CreateShipmentBindingModel
                {
                    DirectionShipmentId = (int)comboBoxDirection.SelectedValue,
                    ProviderId = (int)comboBoxProvider.SelectedValue,
                    EmployeeId = CurrentId,
                    ShipmentProducts = shipmentProducts,
                    Sum = Sum
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddShipmentForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            comboBoxDirection.DataSource = _directionLogic.Read(null);
            comboBoxDirection.DisplayMember = "DirectionName";
            comboBoxDirection.ValueMember = "Id";

            comboBoxProvider.DataSource = _providerLogic.Read(null);
            comboBoxProvider.DisplayMember = "ProviderName";
            comboBoxProvider.ValueMember = "Id";

            LoadDataProductsGrid();
        }

        private void comboBoxProvider_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadDataProductsCombo()
        {
            int provid;
            try
            {
                ProviderViewModel k = (ProviderViewModel)comboBoxProvider.SelectedValue;
                provid = k.Id;
            }
            catch(Exception ex)
            {
                provid = (int)comboBoxProvider.SelectedValue;
            }
            if (comboBoxProvider.SelectedValue != null)
            {
                comboBoxProducts.DataSource = _productLogic.Read(
                    new ProductBindingModel { ProviderId = provid });
                comboBoxProducts.DisplayMember = "ProductName";
                comboBoxProducts.ValueMember = "Id";
            }
        }

        private void LoadDataProductsGrid()
        {
            try
            {
                if (shipmentProducts != null)
                {
                    dataGridViewProducts.Rows.Clear();
                    foreach (var pc in shipmentProducts)
                    {
                        dataGridViewProducts.Rows.Add(new object[] { pc.Key, pc.Value.Item1, pc.Value.Item2 });
                        dataGridViewProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dataGridViewProducts.Columns[0].Visible = false;
                        dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonDelProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить продукцию?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        shipmentProducts.Remove(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadDataProductsGrid();
                }
            }
        }

        private void comboBoxProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            shipmentProducts.Clear();
            if (comboBoxProvider.Items.Count == 0 || comboBoxDirection.Items.Count == 0) LoadData();
            LoadDataProductsCombo();
            LoadDataProductsGrid();
        }
    }
}
