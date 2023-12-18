using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockDatabase.StoragesContracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Accord.Statistics.Models.Regression.Linear;

namespace ProductAccountingInStockBusinessLogic.BusinessLogics
{
    public class ForecastingBusinessLogic : IForecastingLogic
    {
        private readonly IShipmentStorage _shipmentStorage;
        private static DataTable mscTable = new DataTable();
        public ForecastingBusinessLogic(IShipmentStorage shipmentStorage) 
        {
            _shipmentStorage = shipmentStorage;
        }
        public int ForecastingData(int ProviderID)
        {
            CodingData();
            checkCountShipments(ProviderID);
            SimpleLinearRegression regression = StudyModel();

            double[] features = new double[] { ProviderID };
            //make a prediction
            double[] predicted = regression.Transform(features);

            return (int)predicted[0];
        }

        public SimpleLinearRegression StudyModel()
        {
            // Целевая функция
            double[] task = new double[mscTable.Rows.Count]; 
            List<int> OutRes = mscTable.AsEnumerable().Select(x => Convert.ToInt32(x["TimeDays"])).ToList();
            int counter = 0;
            foreach (var r in OutRes)
            {
                task[counter] = r;
                counter++;
            }

            // Удаление целевой функции
            mscTable.Columns.Remove("TimeDays");

            // Признаки регрессии
            double[] features = new double[mscTable.Rows.Count];
            List<int> OutFeat = mscTable.AsEnumerable().Select(x => Convert.ToInt32(x["ProviderID"])).ToList();
            int counter2 = 0;
            foreach (var r in OutFeat)
            {
                features[counter2] = r;
                counter2++;
            }

            var ols = new OrdinaryLeastSquares()
            {
                UseIntercept = true
            };

            //linear regression model for several features
            SimpleLinearRegression regression = ols.Learn(features, task);

            return regression;
        }

        private void CodingData() 
        {
            var shipments = _shipmentStorage.GetFullList();

            if (shipments.Where(rec => rec.DateImplement != null).ToList().Count == 0) 
            {
                throw new Exception("Невозможно предсказать дату, так как нет завершенных поставок");
            }

            DataColumn newColID = new DataColumn("ProviderID", typeof(int));
            newColID.AllowDBNull = true;
            DataColumn newColDays = new DataColumn("TimeDays", typeof(int));
            newColID.AllowDBNull = true;
            mscTable.Columns.Add(newColID);
            mscTable.Columns.Add(newColDays);

            foreach (var shipment in shipments)
            {
                if (shipment.DateImplement != null) {
                    DataRow new_row = mscTable.NewRow();
                    new_row["ProviderID"] = shipment.ProviderId;
                    new_row["TimeDays"] = ((DateTime)shipment.DateImplement).Subtract(shipment.DateCreate).TotalDays;
                    mscTable.Rows.Add(new_row);
                }
            }
        }

        private void checkCountShipments(int ProviderID) 
        {
            var shipments = _shipmentStorage.GetFullList();

            if (shipments.Where(rec => rec.ProviderId == ProviderID && rec.DateImplement != null).ToList().Count < 5)
            {
                throw new Exception("Невозможно предсказать дату, для предсказания даты недостаточно завершенных поставок с данным поставщиком");
            }
        }
    }
}
