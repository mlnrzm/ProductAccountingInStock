using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccountingInStockBusinessLogic.BusinessLogicContracts
{
    public interface IReportLogic
    {
        /// <summary>
        /// Получение списка продукции определенной поставки
        /// </summary>
        /// <returns></returns>
        List<ReportShipmentProductsViewModel> GetProducts(List<ShipmentBindingModel> list);
        /// <summary>
        /// Получение списка поставок за определенный период
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<ReportShipmentsViewModel> GetShipments(ReportBindingModel model);
        /// <summary>
        /// Сохранение в файл-Excel
        /// </summary>
        /// <param name="model"></param>
        void SaveShipmentProductsToExcelFile(ReportBindingModel model);
    }
}
