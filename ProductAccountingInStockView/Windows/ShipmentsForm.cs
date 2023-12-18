using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ProductAccountingInStockView.Windows
{
    public partial class ShipmentsForm : Form
    {
        public int CurrentId { get; set; }
        public string CurrentLogin { get; set; }
        private readonly IShipmentLogic _shipmentLogic;
        private readonly IDirectionLogic _directionLogic;
        private readonly IReportLogic _reportLogic;
        private readonly IForecastingLogic _forecastingLogic;
        private List<ShipmentViewModel> shipments_fordates;
        private List<ShipmentViewModel> shipments;
        public ShipmentsForm(IShipmentLogic shipmentLogic, IDirectionLogic directionLogic, IReportLogic reportLogic, IForecastingLogic forecastingLogic)
        {
            InitializeComponent();
            _shipmentLogic = shipmentLogic;
            _directionLogic = directionLogic;
            _reportLogic = reportLogic;
            _forecastingLogic = forecastingLogic;
        }

        private void ShipmentsForm_Load(object sender, EventArgs e)
        {
            LoadData(true);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            LoadData(true);
            List<ShipmentViewModel> import_shipments = new List<ShipmentViewModel>();
            int import_id = _directionLogic.Read(new DirectionBindingModel { DirectionName = "Импорт" }).FirstOrDefault().Id;
            foreach (var ship in shipments)
            {
                if (ship.DirectionShipmentId == import_id)
                {
                    import_shipments.Add(ship);
                }
            }
            shipments = import_shipments;
            LoadData(false);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            LoadData(true);
            List<ShipmentViewModel> export_shipments = new List<ShipmentViewModel>();
            int export_id = _directionLogic.Read(new DirectionBindingModel { DirectionName = "Экспорт" }).FirstOrDefault().Id;
            foreach (var ship in shipments)
            {
                if (ship.DirectionShipmentId == export_id)
                {
                    export_shipments.Add(ship);
                }
            }
            shipments = export_shipments;
            LoadData(false);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<AddShipmentForm>();
            form.CurrentId = CurrentId;
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData(true);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (dataGridViewShipments.SelectedRows.Count == 1)
            {
                try
                {
                    _shipmentLogic.TakeShipmentInWork(new ChangeShipmentStatusBindingModel
                    { ShipmentId = Convert.ToInt32(dataGridViewShipments.SelectedRows[0].Cells[0].Value) });
                    _shipmentLogic.FinishShipment(new ChangeShipmentStatusBindingModel
                    { ShipmentId = Convert.ToInt32(dataGridViewShipments.SelectedRows[0].Cells[0].Value) });
                    LoadData(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (dataGridViewShipments.SelectedRows.Count == 1)
            {
                try
                {
                    _shipmentLogic.DeliveryShipment(new ChangeShipmentStatusBindingModel
                    { ShipmentId = Convert.ToInt32(dataGridViewShipments.SelectedRows[0].Cells[0].Value) });
                    LoadData(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date >= dateTimePickerTo.Value.Date)
            {
                MessageBox.Show("Дата начала должна быть меньше даты окончания",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                shipments_fordates = _shipmentLogic.Read(new ShipmentBindingModel
                {
                    DateFrom = dateTimePickerFrom.Value,
                    DateTo = dateTimePickerTo.Value
                });
                shipments = shipments_fordates;
                LoadData(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void LoadData(bool newlist)
        {
            try
            {
                if (newlist && shipments != null) shipments.Clear();
                if (newlist) shipments = _shipmentLogic.Read(null);
                if (shipments != null)
                {
                    dataGridViewShipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewShipments.DataSource = shipments;
                    dataGridViewShipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridViewShipments.Columns[0].Visible = false;
                    dataGridViewShipments.Columns[1].Visible = false;
                    dataGridViewShipments.Columns[3].Visible = false;
                    dataGridViewShipments.Columns[5].Visible = false;
                    dataGridViewShipments.Columns[11].Visible = false;
                }
                else { shipments = new List<ShipmentViewModel>(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value >= dateTimePickerTo.Value)
            {
                MessageBox.Show("Дата начала должна быть меньше даты окончания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var dialog = new SaveFileDialog();
            dialog.Filter = "xlsx|*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<ShipmentBindingModel> ship = new List<ShipmentBindingModel>();
                    foreach (var s in shipments)
                    {
                        ship.Add(new ShipmentBindingModel
                        {
                            Id = s.Id,
                            ShipmentStatus = s.ShipmentStatus,
                            DateCreate = s.DateCreate,
                            DateImplement = s.DateImplement,
                            DirectionShipmentId = s.DirectionShipmentId,
                            EmployeeId = s.EmployeeId,
                            ProviderId = s.ProviderId,
                            ShipmentProducts = s.ShipmentProducts,
                            Sum = s.Sum
                        });
                    }
                    _reportLogic.SaveShipmentProductsToExcelFile(new ReportBindingModel
                    {
                        FileName = dialog.FileName,
                        DateFrom = dateTimePickerFrom.Value,
                        DateTo = dateTimePickerTo.Value,
                        shipments = ship
                    });
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SendEmailAsync(dialog.FileName).GetAwaiter();
            Console.Read();
        }


        private async Task SendEmailAsync(string path)
        {
            MailAddress from = new MailAddress("arzamaskina.ma@mail.ru", "ProductStorage");
            MailAddress to = new MailAddress(CurrentLogin);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Отчёт";
            m.Body = "Письмо c Отчётом";
            m.Attachments.Add(new Attachment(path));
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 2525);
            smtp.Credentials = new NetworkCredential("arzamaskina.ma@mail.ru", "1PVGCqG4Q22Z79hK1MFc");
            smtp.EnableSsl = true;
            smtp.Send(m);

            await smtp.SendMailAsync(m);
        }

        private void buttonForecasting_Click(object sender, EventArgs e)
        {
            if (dataGridViewShipments.SelectedRows.Count == 1)
            {
                try
                {
                    DateTime dateStart = (DateTime)dataGridViewShipments.SelectedRows[0].Cells[9].Value;
                    int pred_days = _forecastingLogic.ForecastingData(Convert.ToInt32(dataGridViewShipments.SelectedRows[0].Cells[3].Value));
                    MessageBox.Show("Прибытие поставки на место назначения ожидается " + dateStart.AddDays(pred_days), "Предположительная дата",
                        MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void buttonDelFilter_Click(object sender, EventArgs e)
        {
            LoadData(true);
        }
    }
}
