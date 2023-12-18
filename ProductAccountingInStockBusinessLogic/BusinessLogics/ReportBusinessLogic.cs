using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockModels.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using ProductAccountingInStockBusinessLogic.OfficePackage.HelperModels;
using ProductAccountingInStockBusinessLogic.OfficePackage;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels.ViewModels;

namespace ProductAccountingInStockBusinessLogic.BusinessLogics
{
    public class ReportBusinessLogic : IReportLogic
    {
        private readonly IShipmentStorage _shipmentStorage;
        private readonly IProductStorage _productStorage;

        private readonly IProviderStorage _providerStorage;
        private readonly IDirectionStorage _directionStorage;

        private readonly AbstractSaveToExcel _saveToExcel;
        public ReportBusinessLogic(IShipmentStorage shipmentStorage, IProductStorage productStorage,
            AbstractSaveToExcel saveToExcel, IProviderStorage providerStorage, IDirectionStorage directionStorage)
        {
            _shipmentStorage = shipmentStorage;
            _productStorage = productStorage;
            _saveToExcel = saveToExcel;
            _providerStorage = providerStorage;
            _directionStorage = directionStorage;
        }

        public List<ReportShipmentProductsViewModel> GetProducts(List<ShipmentBindingModel> listShipments)
        {
            var providers = _providerStorage.GetFullList();
            var directions = _directionStorage.GetFullList();
            var products = _productStorage.GetFullList();
            var list = new List<ReportShipmentProductsViewModel>();

            foreach (var shipment in listShipments)
            {
                var record = new ReportShipmentProductsViewModel
                {
                    ShipmentAddress = providers.FirstOrDefault(x => x.Id == shipment.ProviderId).ProviderAddress,
                    ShipmentDirectionName = directions.FirstOrDefault(x => x.Id == shipment.DirectionShipmentId).DirectionName,
                    ShipmentProviderName = providers.FirstOrDefault(x => x.Id == shipment.ProviderId).ProviderName,
                    ShipmentProducts = new List<Tuple<string, int>>(),
                    TotalCount = 0
                };

                foreach (var product in _shipmentStorage.GetProducts((int)shipment.Id))
                {
                    record.ShipmentProducts.Add(new Tuple<string, int>(product.Key, product.Value));
                    record.TotalCount += product.Value;
                }
                list.Add(record);
            }
            return list;
        }

        public List<ReportShipmentsViewModel> GetShipments(ReportBindingModel model)
        {
            return _shipmentStorage.GetFilteredList(new ShipmentBindingModel
            {
                DateCreate = (DateTime)model.DateFrom,
                DateImplement = (DateTime)model.DateTo
            })
            .Select(x => new ReportShipmentsViewModel
            {
                DateCreate = x.DateCreate,
                ShipmentDirectionName = x.DirectionShipmentName,
                Sum = x.Sum,
                Status = x.ShipmentStatus.ToString()
            })
            .ToList();
        }

        public void SaveShipmentProductsToExcelFile(ReportBindingModel model)
        {
            _saveToExcel.CreateReport(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список поставляемой продукции",
                Shipments = GetProducts(model.shipments)
            });
        }
    }
}
