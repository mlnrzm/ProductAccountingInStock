using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System.Collections.Generic;

namespace ProductAccountingInStockDatabase.StoragesContracts
{
    public interface IShipmentStorage
    {
        List<ShipmentViewModel> GetFullList();
        List<ShipmentViewModel> GetFilteredList(ShipmentBindingModel model);
        ShipmentViewModel GetElement(ShipmentBindingModel model);
        void Insert(ShipmentBindingModel model);
        void Update(ShipmentBindingModel model);
        void Delete(ShipmentBindingModel model);
        Dictionary<string, int> GetProducts(int shipmentId);
    }
}
