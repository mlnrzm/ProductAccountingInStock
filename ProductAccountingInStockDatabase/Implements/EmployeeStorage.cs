using Microsoft.EntityFrameworkCore;
using ProductAccountingInStockDatabase.DatabaseModels;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductAccountingInStockDatabase.Implements
{
    public class EmployeeStorage : IEmployeeStorage
    {
        public List<EmployeeViewModel> GetFullList()
        {
            using var context = new ProductAccountingInStockDatabase();
            return context.Employees
            .Select(CreateModel)
            .ToList();
        }
        public List<EmployeeViewModel> GetFilteredList(EmployeeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ProductAccountingInStockDatabase();
            return context.Employees
            .Where(rec => rec.PostId == model.PostId)
            .Select(CreateModel)
            .ToList();
        }
        public EmployeeViewModel GetElement(EmployeeAuthorizationBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ProductAccountingInStockDatabase();
            var component = context.Employees
            .FirstOrDefault(rec => rec.EmployeeLogin == model.EmployeeLogin || rec.Id == model.Id);
            return component != null ? CreateModel(component) : null;
        }
        public EmployeeViewModel GetElement(EmployeeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ProductAccountingInStockDatabase();
            var component = context.Employees
            .FirstOrDefault(rec => rec.EmployeeLogin == model.EmployeeLogin || rec.Id == model.Id);
            return component != null ? CreateModel(component) : null;
        }
        public void Insert(EmployeeBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            context.Employees.Add(CreateModel(model, new Employee()));
            context.SaveChanges();

            using var context2 = new ProductAccountingInStockDatabase();
            Employee emp_upd = context.Employees.FirstOrDefault(rec => rec.EmployeeLogin == model.EmployeeLogin);

            if (context2.Posts.FirstOrDefault(rec => rec.Id == emp_upd.PostId).PostName == "Руководитель") {
                Update(new EmployeeBindingModel
                {
                    Id = emp_upd.Id,
                    EmployeeLogin = emp_upd.EmployeeLogin,
                    EmployeePassword = emp_upd.EmployeePassword,
                    PostId = emp_upd.PostId,
                    EmployeeFIO = emp_upd.EmployeeFIO,
                    SupervisorId = emp_upd.Id
                });
            }
            context2.SaveChanges();

        }
        public void Update(EmployeeBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            var element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Сотрудник не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(EmployeeBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            Employee element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Employees.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Сотрудник не найден");
            }
        }
        private static Employee CreateModel(EmployeeBindingModel model, Employee employee)
        {
            employee.EmployeeFIO = model.EmployeeFIO;
            employee.PostId = (int)model.PostId;
            employee.SupervisorId = model.SupervisorId;
            employee.EmployeeLogin = model.EmployeeLogin;
            employee.EmployeePassword = model.EmployeePassword;
            return employee;
        }
        private static EmployeeViewModel CreateModel(Employee employee)
        {
            using var context = new ProductAccountingInStockDatabase();
            return new EmployeeViewModel
            {
                Id = employee.Id,
                EmployeeFIO = employee.EmployeeFIO ,
                SupervisorId = (int)employee.SupervisorId,
                PostId = employee.PostId,
                PostName = context.Posts.FirstOrDefault(rec => rec.Id == employee.PostId).PostName,
                EmployeeLogin = employee.EmployeeLogin,
                EmployeePassword = employee.EmployeePassword
            };
        }
    }
}
