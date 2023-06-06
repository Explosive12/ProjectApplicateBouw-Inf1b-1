﻿using Project1._4.Model;
using Project1._4.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1._4
{
    public partial class ManagerView : Form
    {
        private int _manager;
        private int _products;



 

        public ManagerView()
        {
            InitializeComponent();
        }

        public void AddEmployee()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> LoadProducts()
        {
            ProductService service = new ProductService();
            List<Product> products = service.GetAllProducts();
            return products;
        }

        public List<Employee> LoadEmployees()
        {
            EmployeeService service = new EmployeeService();
            List<Employee> orders = service.GetAllEmployees();
            return orders;
        }

        public List<OrderItem> RemoveMenuItem()
        {
            OrderItemService service = new OrderItemService();
            List<OrderItem> orderItems = service.GetAllOrderItems();
            return orderItems;
        }

        public void ModifyEmployee(Product product) { }

        public void RemoveProductFromOrder(OrderItem orderItem) { }

        public void AddEmployee(OrderItem orderItem) { }

        public void AddMenuItem() { }

        public void RemoveEmployee() { }

        public void AddStockToMenu(OrderItem orderItem) { }

        public void RemoveStockToMenu(OrderItem orderItem) { }

        public void RevertStock()
        {
            throw new System.NotImplementedException();
        }
    }
}
