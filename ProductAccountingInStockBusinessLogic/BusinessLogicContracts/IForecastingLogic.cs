using Accord.Statistics.Models.Regression.Linear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccountingInStockBusinessLogic.BusinessLogicContracts
{
    public interface IForecastingLogic
    {
        SimpleLinearRegression StudyModel();
        int ForecastingData(int ProviderID);
    }
}
