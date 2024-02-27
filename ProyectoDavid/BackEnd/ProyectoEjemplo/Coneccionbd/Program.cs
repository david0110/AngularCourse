// See https://aka.ms/new-console-template for more information
using Coneccionbd.Services;

var customerService = new CustomerService();
customerService.ShowAll();
customerService.CreateCustomer();
customerService.UpdateCustomer();
customerService.DeleteCustomer();
customerService.ShowAll();
