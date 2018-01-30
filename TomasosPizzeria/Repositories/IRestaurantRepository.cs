﻿using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore.Http;
using TomasosPizzeria.Entities;
using TomasosPizzeria.Models.ViewModels;

namespace TomasosPizzeria.Repositories
{
    public interface IRestaurantRepository
    {
        IQueryable<Matratt> GetAllMatratter();
        IQueryable<Kund> GetAllCustomers();
        IQueryable<Bestallning> GetAllOrders();
        IQueryable<MatrattTyp> GetAllMatrattTyp();
        IQueryable<Produkt> GetAllProducts();


        Bestallning GetOrderById(int id);
        Kund GetCustomerById(int id);
        Matratt GetMatrattById(int id);
        Kund GetCustomerByUserName(string username);
        IQueryable<Produkt> GetProductsByMattrattId(int matrattId);
        Produkt GetProduktById(int id);
        int GetPoangByUserName(string username);

        void DeleteCustomer(string username);
        void AddCustomer(Kund user);
        void UpdateCustomer();
        void SaveOrder(string username, bool ispremium);
        bool ChangeOrderStatus(int id, bool status);
        void DeleteOrder(int id);
        void UpdateMatrattProdukter(EditDishViewModel model);
        void UpdateMatratt(EditDishViewModel model);
        bool AddMatratt(AddDishViewModel model);
        bool UpdateProduct(ProductViewModel model);
        bool AddProduct(ProductViewModel model);


    }
}
