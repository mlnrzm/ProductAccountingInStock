using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using ProductAccountingInStockModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccountingInStockBusinessLogic.BusinessLogicContracts
{
    public interface IShipmentLogic
    {
        public List<ShipmentViewModel> Read(ShipmentBindingModel model);
        public void CreateShipment(CreateShipmentBindingModel model);
        public void FinishShipment(ChangeShipmentStatusBindingModel model);
        public void DeliveryShipment(ChangeShipmentStatusBindingModel model);
        public void TakeShipmentInWork(ChangeShipmentStatusBindingModel model);
    }
}
