using System;
using System.Windows.Forms;
using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockBusinessLogic.BusinessLogics;
using ProductAccountingInStockDatabase.Implements;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockView.Windows;
using Unity;
using Unity.Lifetime;

namespace ProductAccountingInStockView
{
    static class Program
    {
        private static IUnityContainer container = null;
        public static IUnityContainer Container
        {
            get
            {
                if (container == null)
                {
                    container = BuildUnityContainer();
                }
                return container;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<AuthorizationForm>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<IDirectionStorage, DirectionStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IEmployeeStorage, EmployeeStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IPostStorage, PostStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IProductStorage, ProductStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IProviderStorage, ProviderStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IShipmentStorage, ShipmentStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IDirectionLogic, DirectionBusinessLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IEmployeeLogic, EmployeeBusinessLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IPostLogic, PostBusinessLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IProductLogic, ProductBusinessLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IProviderLogic, ProviderBusinessLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IShipmentLogic, ShipmentBusinessLogic>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
