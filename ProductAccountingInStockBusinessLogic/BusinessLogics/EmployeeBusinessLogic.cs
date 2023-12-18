using ProductAccountingInStockBusinessLogic.BusinessLogicContracts;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProductAccountingInStockBusinessLogic.BusinessLogics
{
    public class EmployeeBusinessLogic : IEmployeeLogic
    {
        private readonly IEmployeeStorage _employeeStorage;
        private readonly int _passwordMaxLength = 50;
        private readonly int _passwordMinLength = 10;
        public EmployeeBusinessLogic(IEmployeeStorage employeeStorage)
        {
            _employeeStorage = employeeStorage;
        }
        public List<EmployeeViewModel> Read(EmployeeBindingModel model)
        {
            if (model == null)
            {
                return _employeeStorage.GetFullList();
            }
            if (model.Id.HasValue || model.EmployeeLogin != null || model.EmployeeLogin != null)
            {
                return new List<EmployeeViewModel> { _employeeStorage.GetElement(model) };
            }
            return _employeeStorage.GetFilteredList(model);
        }
        public void Create(EmployeeBindingModel model)
        {
            var element = _employeeStorage.GetElement(new EmployeeBindingModel
            {
                EmployeeLogin = model.EmployeeLogin
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть сотрудник с таким логином");
            }
            if (!Regex.IsMatch(model.EmployeeLogin, 
                @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$"))
            {
                throw new Exception("В качестве логина должна быть указана почта");
            }
            if (model.EmployeePassword.Length > _passwordMaxLength || model.EmployeePassword.Length < _passwordMinLength
                || !Regex.IsMatch(model.EmployeePassword, @"^((\w+\d+\W+)|(\w+\W+\d+)|(\d+\w+\W+)|(\d+\W+\w+)|(\W+\w+\d+)|(\W+\d+\w+))[\w\d\W]*$"))
            {
                throw new Exception($"Пароль длиной от {_passwordMinLength} до {_passwordMaxLength} должен состоять и из цифр, букв и небуквенных символов");
            }
            _employeeStorage.Insert(model);
        }
        public void Delete(EmployeeBindingModel model)
        {
            var element = _employeeStorage.GetElement(new EmployeeBindingModel
            {
                Id = model.Id
            });

            if (element == null)
            {
                throw new Exception("Сотрудник не найден");
            }
            _employeeStorage.Delete(model);
        }
        public EmployeeViewModel Enter(EmployeeBindingModel model)
        {
            var element = _employeeStorage.GetElement(new EmployeeBindingModel
            {
                EmployeeLogin = model.EmployeeLogin,
                EmployeePassword = model.EmployeePassword
            });
            if (element == null)
            {
                throw new Exception("Сотрудник не найден");
            }
            if (element != null && element.EmployeePassword != model.EmployeePassword) 
            {
                throw new Exception("Пароль введён не верно");
            }
            return element;
        }
    }
}